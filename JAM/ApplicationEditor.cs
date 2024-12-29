using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAM
{
	public partial class ApplicationEditor : Form
	{
		private PictureBox? lastClickedImage = null;
		private string? lastTempPath = null;

		private bool statusChanged = false;

		private EditorType editorType;
		private Company? companyToEdit;
		private Application? applicationToEdit;

		public ApplicationEditor(EditorType editorType, Company? companyToEdit, Application? applicationToEdit)
		{
			this.editorType = editorType;
			this.companyToEdit = companyToEdit;
			this.applicationToEdit = applicationToEdit;

			Home.applicationEditors.Add(this);

			InitializeComponent();
		}

		private void ApplicationEditor_Load(object sender, EventArgs e)
		{
			try
			{
				switch (editorType)
				{
					case EditorType.CREATE_APPLICATION:
						mainTabControl.TabPages.Remove(augmentationsTabPage);
						foreach (string companyName in Home.companiesN.Keys)
							reuseCompanyComboBox.Items.Add(companyName);
						break;
					default:
						throw new NotImplementedException();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading application editor: " + ex.Message);
			}
		}

		private void reuseCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			reuseCompanyComboBox.Enabled = reuseCompanyCheckBox.Checked;
			viewCompanyButton.Enabled = reuseCompanyCheckBox.Checked;
			newCompanyGroupBox.Enabled = !reuseCompanyCheckBox.Checked;

			statusChanged = true;
		}

		private void companyPasswordViewButton_Click(object sender, EventArgs e)
		{
			companyPasswordTextBox.PasswordChar =
				companyPasswordTextBox.PasswordChar == '\0' ?
				'•' : '\0';
			companyPasswordViewButton.Image =
				companyPasswordTextBox.PasswordChar == '\0' ?
				JAM.Properties.Resources.CloakOrHide :
				JAM.Properties.Resources.Visible;
		}

		private void addBackupImage(Image image)
		{
			PictureBox pictureBox = new PictureBox();
			pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox.Image = image;
			pictureBox.Parent = applicationImageFlowLayout;
			pictureBox.ContextMenuStrip = applicationImageContextMenu;
			pictureBox.MouseDown += pictureBox_Click;
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			if (sender is PictureBox)
			{
				lastClickedImage = (PictureBox)sender;
			}
		}

		private void applicationImagePasteButton_Click(object sender, EventArgs e)
		{
			Image? image = Clipboard.GetImage();
			if (image == null)
				return;
			addBackupImage(image);
		}

		private void applicationImageUploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;
			try
			{
				Image image = Image.FromFile(openFileDialog.FileName);
				addBackupImage(image);
			}
			catch
			{
				MessageBox.Show("Could not add image:\n" + openFileDialog.FileName);
			}
		}

		private void viewImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lastClickedImage == null)
				return;
			TryDestroyCurrTempImage();
			lastTempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".png");
			try
			{
				lastClickedImage.Image.Save(lastTempPath, System.Drawing.Imaging.ImageFormat.Png);
				Process.Start(new ProcessStartInfo
				{
					FileName = lastTempPath,
					UseShellExecute = true
				});
			}
			catch
			{
				MessageBox.Show("Could not view image.");
			}
		}

		private void TryDestroyCurrTempImage()
		{
			if (lastTempPath == null)
				return;
			try
			{
				File.Delete(lastTempPath);
			}
			catch
			{
				MessageBox.Show("Could not delete the temp image file.");
			}
		}

		private void removeImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lastClickedImage == null)
				return;
			applicationImageFlowLayout.Controls.Remove(lastClickedImage);
		}

		private void CreateApplication_FormClosing(object sender, FormClosingEventArgs e)
		{
			TryDestroyCurrTempImage();

			if (statusChanged == true)
			{
				if (MessageBox.Show("You have made changes. Discard changes and close editor?",
					"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					e.Cancel = true;
				}
			}
			if (!e.Cancel)
				Home.applicationEditors.Remove(this);
		}

		private void applicationImageDeleteButton_Click(object sender, EventArgs e)
		{
			if (applicationImageFlowLayout.Controls.Count == 0)
				return;
			applicationImageFlowLayout.Controls.RemoveAt(applicationImageFlowLayout.Controls.Count - 1);
		}

		private void applicationImageClearButton_Click(object sender, EventArgs e)
		{
			applicationImageFlowLayout.Controls.Clear();
		}

		private void applicationResumeUploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;
			applicationResumeComboBox.Text = openFileDialog.FileName;
		}

		private void applicationCoverLetterUploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;
			applicationCurrentCoverLetterLabel.Text = openFileDialog.FileName;
		}

		private void applicationCoverLetterDeleteButton_Click(object sender, EventArgs e)
		{
			applicationCurrentCoverLetterLabel.Text = "None";
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			statusChanged = false;
			Close();
		}

		private void StatusUpdated(object sender, EventArgs e)
		{
			statusChanged = true;
		}

		private void StatusUpdated(object sender, ControlEventArgs e)
		{
			statusChanged = true;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			List<string> errorList = new List<string>();

			try
			{
				switch (editorType)
				{
					case EditorType.CREATE_APPLICATION:
						if (reuseCompanyCheckBox.Checked && !Home.companiesN.ContainsKey(reuseCompanyComboBox.Text))
							errorList.Add("Company to reuse is not valid.");

						if ((!reuseCompanyCheckBox.Checked) && Home.companiesN.ContainsKey(companyNameTextBox.Text))
							errorList.Add("Company created has the same name as a pre-existing company.");

						if (errorList.Count > 0)
							break;

						string applicationType;
						if (applicationTypeComboBox.SelectedIndex == (int)ApplicationType.OTHER)
							applicationType = applicationTypeOtherTextBox.Text;
						else
							applicationType = ((ApplicationType)applicationTypeComboBox.SelectedIndex).ToString();

						string companyGuid = "";
						if (!reuseCompanyCheckBox.Checked)
						{
							Company company = new Company(
								companyNameTextBox.Text,
								companyWebsiteTextBox.Text,
								companyCareersWebsiteTextBox.Text,
								companyCareersHomeTextBox.Text,
								companyEmailTextBox.Text,
								companyPasswordTextBox.Text,
								companyInfoTextBox.Text);
							FileManager.SaveXml(company.ConvertToXml(), FileType.COMPANY, company.guid + ".xml");
							Home.companiesN.Add(company.name, company);
							Home.companiesG.Add(company.guid, company);
							companyGuid = company.guid;
						}
						else
						{
							if (Home.companiesN.TryGetValue(reuseCompanyComboBox.Text, out Company? company))
							{
								companyGuid = company.guid;
							}
							else
							{
								//This should be caught by error list's pre checks.
								throw new ArgumentException("Tried to reuse a non-existant company.");
							}
						}

						StringBuilder images = new StringBuilder();
						foreach (Control control in applicationImageFlowLayout.Controls)
						{
							if (!(control is PictureBox))
								continue;
							Image image = ((PictureBox)control).Image;
							byte[] imageBytes;
							using (var memoryStream = new MemoryStream())
							{
								image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
								imageBytes = memoryStream.ToArray();
							}
							string imageString = EncryptionManager.GetString(imageBytes);
							images.Append(imageString);
							images.Append("CONT");
						}

						string resume = "";
						if (Home.resumes.Keys.Contains(applicationResumeComboBox.Text))
						{
							resume = applicationResumeComboBox.Text;
						}
                        else if (File.Exists(applicationResumeComboBox.Text))
                        {
							resume = Path.GetFileName(applicationResumeComboBox.Text);
							string resumeBaseName = Path.GetFileNameWithoutExtension(resume);
							string resumeExtension = Path.GetExtension(resume);
							int counter = 0;
							while (Home.resumes.Keys.Contains(resume))
							{
								++counter;
								resume = resumeBaseName + "(" + counter + ")" + resumeExtension;
							}

							string resumeData = EncryptionManager.GetString(File.ReadAllBytes(applicationResumeComboBox.Text));
							Resume resumeObj = new Resume(resume, resumeData);
							FileManager.SaveXml(resumeObj.ConvertToXml(), FileType.RESUMES, resumeObj.guid + ".xml");
							Home.resumes.Add(resume, resumeObj);
						}

						string coverLetter = "";
						if (File.Exists(applicationCurrentCoverLetterLabel.Text))
						{
							coverLetter = EncryptionManager.GetString(File.ReadAllBytes(applicationCurrentCoverLetterLabel.Text));
						}

                        Application application = new Application(
							companyGuid,
							DateTime.Now.ToString(),
							ApplicationStatus.SENT.ToString(),
							DateTime.Now.ToString(),
							applicationPositionTextBox.Text,
							applicationLinkTextBox.Text,
							applicationType,
							applicationLocationTextBox.Text,
							applicationSalaryTextBox.Text,
							images.ToString(),
							resume,
							coverLetter,
							applicationInfoTextBox.Text);
						Home.applications.Add(application.guid, application);
						FileManager.SaveXml(application.ConvertToXml(), FileType.APPLICATION, application.guid + ".xml");
						break;
					default:
						throw new NotImplementedException();
				}
			}
			catch (Exception ex)
			{
				errorList.Add("Could not complete due to an error: " + ex.Message);
			}

			if (errorList.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("Could not save due to the following issues:");
				foreach (string error in errorList)
				{
					stringBuilder.AppendLine(error);
				}
				MessageBox.Show(stringBuilder.ToString());
				return;
			}
			statusChanged = false;
			Close();
		}

		private void applicationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (applicationTypeComboBox.SelectedIndex == (int)ApplicationType.OTHER)
				applicationTypeOtherTextBox.Enabled = true;
			else 
				applicationTypeOtherTextBox.Enabled = false;
		}
	}

	public enum EditorType
	{
		CREATE_APPLICATION,
		AUGMENT_APPLICATION,
		EDIT_APPLICATION,
		EDIT_COMPANY
	}
}
