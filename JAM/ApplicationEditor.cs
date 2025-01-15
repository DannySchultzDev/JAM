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
using System.Web;
using System.Windows.Forms;

namespace JAM
{
	public partial class ApplicationEditor : Form
	{
		#region Variables
		/// <summary>
		/// Used by the context menu to know the image to affect.
		/// </summary>
		private PictureBox? lastClickedImage = null;
		/// <summary>
		/// The path of the last image viewed. The image at this path is destroyed when the next image is loaded.
		/// </summary>
		private string? lastTempPath = null;

		/// <summary>
		/// Used to warn user if there is unsaved progress.
		/// </summary>
		private bool statusChanged = false;

		/// <summary>
		/// Used for determening how to load and how to save.
		/// </summary>
		private EditorType editorType;
		/// <summary>
		/// Used to load defaults, and to augment on save.
		/// </summary>
		private Company? companyToEdit;
		/// <summary>
		/// Used to load defaults, and to augment on save.
		/// </summary>
		private Application? applicationToEdit;

		/// <summary>
		/// Used on load to determine if an editor already exists for this company.
		/// </summary>
		private static Dictionary<Company, ApplicationEditor> activeCompanies = new Dictionary<Company, ApplicationEditor>();
		/// <summary>
		/// Used on load to determine if an editor already exists for this application.
		/// </summary>
		private static Dictionary<Application, ApplicationEditor> activeApplications = new Dictionary<Application, ApplicationEditor>();
		/// <summary>
		/// Prevent a duplicate that is being closed from removing the original form from the active dictionary.
		/// </summary>
		private bool removeFromDictionary = true;
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Standard constructor.
		/// </summary>
		/// <param name="editorType">Type of editor being loaded.</param>
		/// <param name="companyToEdit">When editing a company, which company to load.</param>
		/// <param name="applicationToEdit">When editing an application, which application to load.</param>
		public ApplicationEditor(EditorType editorType, Company? companyToEdit, Application? applicationToEdit)
		{
			this.editorType = editorType;
			this.companyToEdit = companyToEdit;
			this.applicationToEdit = applicationToEdit;

			Home.applicationEditors.Add(this);

			InitializeComponent();
		}

		/// <summary>
		/// Load event for the application editor. <br/>
		/// Will load differently depending on editor type.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void LoadApplicationEditor(object sender, EventArgs e)
		{
			if (companyToEdit != null)
			{
				if (activeCompanies.ContainsKey(companyToEdit))
				{
					if (activeCompanies[companyToEdit].WindowState == FormWindowState.Minimized)
						activeCompanies[companyToEdit].WindowState = FormWindowState.Normal;
					activeCompanies[companyToEdit].Focus();
					removeFromDictionary = false;
					Close();
					return;
				}
				activeCompanies.Add(companyToEdit, this);
			}

			if (applicationToEdit != null)
			{
				if (activeApplications.ContainsKey(applicationToEdit))
				{
					if (activeApplications[applicationToEdit].WindowState == FormWindowState.Minimized)
						activeApplications[applicationToEdit].WindowState = FormWindowState.Normal;
					activeApplications[applicationToEdit].Focus();
					removeFromDictionary = false;
					Close();
					return;
				}
				activeApplications.Add(applicationToEdit, this);
			}

			try
			{
				switch (editorType)
				{
					case EditorType.CREATE_APPLICATION:
						mainTabControl.TabPages.Remove(augmentationsTabPage);
						Text = "Application Creator";
						foreach (ApplicationType applicationType in Enum.GetValues(typeof(ApplicationType)))
							applicationTypeComboBox.Items.Add(Application.ApplicationTypes.GetValueOrDefault(applicationType, "Invalid Application Type"));
						applicationTypeComboBox.SelectedIndex = (int)ApplicationType.CAREERS_WEBSITE;
						foreach (string resume in Home.resumes.Keys)
							applicationResumeComboBox.Items.Add(resume);
						applicationResumeComboBox.SelectedIndex = 0;
						foreach (string companyName in Home.companiesN.Keys)
							reuseCompanyComboBox.Items.Add(companyName);
						break;
					case EditorType.EDIT_COMPANY:
						mainTabControl.TabPages.Remove(applicationTabPage);
						mainTabControl.TabPages.Remove(augmentationsTabPage);
						reuseCompanyCheckBox.Enabled = false;
						reuseCompanyCheckBox.Visible = false;
						reuseCompanyComboBox.Enabled = false;
						reuseCompanyComboBox.Visible = false;
						viewCompanyButton.Enabled = false;
						viewCompanyButton.Visible = false;
						companyTableLayout.RowStyles[0].Height = 0;
						Text = "Company Editor";
						try
						{
							newCompanyGroupBox.Text = "Edit " + companyToEdit!.name;
							companyNameTextBox.Text = companyToEdit.name;
							companyWebsiteTextBox.Text = companyToEdit.website;
							companyCareersWebsiteTextBox.Text = companyToEdit.careerWebsite;
							companyCareersHomeTextBox.Text = companyToEdit.careerHome;
							companyEmailTextBox.Text = companyToEdit.email;
							companyPasswordTextBox.Text = companyToEdit.password;
							companyInfoTextBox.Text = companyToEdit.info;
						}
						catch { }
						break;
					case EditorType.EDIT_APPLICATION:
						mainTabControl.TabPages.Remove(companyTabPage);
						mainTabControl.SelectedTab = augmentationsTabPage;
						foreach (string resume in Home.resumes.Keys)
							applicationResumeComboBox.Items.Add(resume);
						try
						{
							applicationPositionTextBox.Text = applicationToEdit!.position;
							applicationLinkTextBox.Text = applicationToEdit.link;

							foreach(ApplicationType applicationType in Enum.GetValues(typeof(ApplicationType)))
								applicationTypeComboBox.Items.Add(Application.ApplicationTypes.GetValueOrDefault(applicationType, "Invalid Application Type"));
							if (Enum.IsDefined(typeof(ApplicationType), applicationToEdit.applicationType))
								applicationTypeComboBox.SelectedIndex = (int)Enum.Parse<ApplicationType>(applicationToEdit.applicationType);
							else
							{
								applicationTypeComboBox.SelectedIndex = (int)ApplicationType.OTHER;
								applicationTypeOtherTextBox.Text = applicationToEdit.applicationType;
							}

							applicationLocationTextBox.Text = applicationToEdit.location;
							applicationSalaryTextBox.Text = applicationToEdit.salary;
							string[] imageStrings = applicationToEdit.images.Split("CONT");
							foreach (string imageString in imageStrings)
							{
								if (string.IsNullOrEmpty(imageString))
									continue;
								byte[] imageBytes = EncryptionManager.GetBytes(imageString);
								using (var memoryStream = new MemoryStream(imageBytes))
								{
									Image image = Image.FromStream(memoryStream);

									PictureBox pictureBox = new PictureBox();
									pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
									pictureBox.Image = image;
									applicationImageFlowLayout.Controls.Add(pictureBox);
								}
							}
							applicationResumeComboBox.Text = applicationToEdit.resume;
							applicationCoverLetterTextBox.Text = applicationToEdit.coverLetterFileName;
							if (!string.IsNullOrEmpty(applicationToEdit.coverLetter))
								applicationCoverLetterTextBox.Tag = EncryptionManager.GetBytes(applicationToEdit.coverLetter);
							applicationInfoTextBox.Text = applicationToEdit.info;
							foreach (string companyName in Home.companiesN.Keys)
								augmentCompanyComboBox.Items.Add(companyName);
							Company? company = Home.companiesG.GetValueOrDefault(applicationToEdit.company);
							if (company != null)
								augmentCompanyComboBox.Text = company.name;
							augmentCreationTimeDateTimePicker.Value = DateTime.Parse(applicationToEdit.creationTime);
							foreach (ApplicationStatus status in Enum.GetValues(typeof(ApplicationStatus)))
								augmentStatusComboBox.Items.Add(Application.ApplicationStatuses.GetValueOrDefault(status, "Invalid Application Status"));
							if (Enum.IsDefined(typeof(ApplicationStatus), applicationToEdit.status))
								augmentStatusComboBox.SelectedIndex = (int)Enum.Parse<ApplicationStatus>(applicationToEdit.status);
							else
							{
								augmentStatusComboBox.SelectedIndex = (int)ApplicationStatus.OTHER;
								augmentStatusOtherTextBox.Text = applicationToEdit.status;
							}
							augmentStatusTimeDateTimePicker.Value = DateTime.Parse(applicationToEdit.statusTime);
						}
						catch { }
						break;
					default:
						throw new NotImplementedException();
				}
				statusChanged = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading application editor: " + ex.Message);
			}
		}

		/// <summary>
		/// Close event for the application editor.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void CloseApplicationEditor(object sender, FormClosingEventArgs e)
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
			{
				Home.applicationEditors.Remove(this);
				if (removeFromDictionary && companyToEdit != null)
					activeCompanies.Remove(companyToEdit);
				if (removeFromDictionary && applicationToEdit != null)
					activeApplications.Remove(applicationToEdit);
			}
		}
		#endregion Lifecycle

		#region Company
		/// <summary>
		/// Uses the check state to determine whether to enable the new company section, or the reuse company section.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void reuseCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			reuseCompanyComboBox.Enabled = reuseCompanyCheckBox.Checked;
			viewCompanyButton.Enabled = reuseCompanyCheckBox.Checked;
			newCompanyGroupBox.Enabled = !reuseCompanyCheckBox.Checked;

			statusChanged = true;
		}

		/// <summary>
		/// Either reveals or hides the companies passward.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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
		#endregion Company

		#region Application Image
		/// <summary>
		/// Pastes an image from the user's clipboard into the images flow view.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void applicationImagePasteButton_Click(object sender, EventArgs e)
		{
			Image? image = Clipboard.GetImage();
			if (image == null)
				return;
			AddBackupImage(image);
		}

		/// <summary>
		/// Lets the user select an image from their files to upload to the images flow view.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationImageUploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;
			try
			{
				Image image = Image.FromFile(openFileDialog.FileName);
				AddBackupImage(image);
			}
			catch
			{
				MessageBox.Show("Could not add image:\n" + openFileDialog.FileName);
			}
		}

		/// <summary>
		/// Helper function that adds an image to the images flow view.
		/// </summary>
		/// <param name="image">The image to add to the images flow view</param>
		private void AddBackupImage(Image image)
		{
			PictureBox pictureBox = new PictureBox();
			pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox.Image = image;
			pictureBox.Parent = applicationImageFlowLayout;
			pictureBox.ContextMenuStrip = applicationImageContextMenu;
			pictureBox.MouseDown += pictureBox_Click!;
		}

		/// <summary>
		/// Removes the last image added to the images flow view.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationImageDeleteButton_Click(object sender, EventArgs e)
		{
			if (applicationImageFlowLayout.Controls.Count == 0)
				return;
			applicationImageFlowLayout.Controls.RemoveAt(applicationImageFlowLayout.Controls.Count - 1);
		}

		/// <summary>
		/// Removes all images from the images flow view.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationImageClearButton_Click(object sender, EventArgs e)
		{
			applicationImageFlowLayout.Controls.Clear();
		}

		/// <summary>
		/// Creates a temp file of the image, then opens it externaly.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// Removes the image the user right clicked on.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void removeImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lastClickedImage == null)
				return;
			applicationImageFlowLayout.Controls.Remove(lastClickedImage);
		}

		/// <summary>
		/// Sets the last clicked image so the context menu options can access it.
		/// </summary>
		/// <param name="sender">The PictureBox that was clicked</param>
		/// <param name="e">Unused</param>
		private void pictureBox_Click(object sender, EventArgs e)
		{
			if (sender is PictureBox)
			{
				lastClickedImage = (PictureBox)sender;
			}
		}

		/// <summary>
		/// Helper function that destroys the last opened image. <br/>
		/// Used to prevent temp images from being left on the user's machine.
		/// </summary>
		public void TryDestroyCurrTempImage()
		{
			if (lastTempPath == null)
				return;
			try
			{
				File.Delete(lastTempPath);
			}
			catch
			{
				MessageBox.Show("Could not delete the file: " + lastTempPath);
			}
		}
		#endregion Application Image

		#region Application
		/// <summary>
		/// Determines if the other type TextBox should be enabled.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (applicationTypeComboBox.SelectedIndex == (int)ApplicationType.OTHER)
			{
				applicationTypeOtherLabel.Enabled = true;
				applicationTypeOtherTextBox.Enabled = true;
			}
			else
			{
				applicationTypeOtherLabel.Enabled = false;
				applicationTypeOtherTextBox.Enabled = false;
			}
		}

		/// <summary>
		/// Lets the user select a filepath of a new resume to add. <br/>
		/// Resume data is not saved to a file until the application is saved.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationResumeUploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;
			applicationResumeComboBox.Text = openFileDialog.FileName;
		}

		/// <summary>
		/// Lets the user open the cover letter they have uploaded.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationCoverLetterOpenButton_Click(object sender, EventArgs e)
		{
			if (applicationCoverLetterTextBox.Tag == null)
				return;

			TryDestroyCurrTempImage();
			lastTempPath = Path.Combine(Path.GetTempPath(), applicationCoverLetterTextBox.Text);
			try
			{
				File.WriteAllBytes(lastTempPath, (byte[])applicationCoverLetterTextBox.Tag);
				Process.Start(new ProcessStartInfo
				{
					FileName = lastTempPath,
					UseShellExecute = true
				});
			}
			catch
			{
				MessageBox.Show("Could not open cover letter.");
			}
		}

		/// <summary>
		/// Lets the user upload a cover letter. <br/>
		/// Cover letter data is stored in a variable imeadiatly since they are unique to each application.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationCoverLetterUploadButton_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
				if (openFileDialog.ShowDialog() != DialogResult.OK)
					return;
				applicationCoverLetterTextBox.Text = openFileDialog.SafeFileName;
				applicationCoverLetterTextBox.Tag = File.ReadAllBytes(openFileDialog.FileName);
			}
			catch (Exception ex)
			{
				applicationCoverLetterTextBox.Text = "None";
				applicationCoverLetterTextBox.Tag = null;
				MessageBox.Show("Issue uploading cover letter: " + ex.Message);
			}
		}

		/// <summary>
		/// Deletes the current cover letter's name and data.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void applicationCoverLetterDeleteButton_Click(object sender, EventArgs e)
		{
			applicationCoverLetterTextBox.Text = "None";
			applicationCoverLetterTextBox.Tag = null;
		}
		#endregion Application

		#region Augmentations
		/// <summary>
		/// Determines whether the other status TextBox needs to be enabled.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void augmentStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (augmentStatusComboBox.SelectedIndex == (int)ApplicationStatus.OTHER)
			{
				augmentStatusOtherLabel.Enabled = true;
				augmentStatusOtherTextBox.Enabled = true;
			}
			else
			{
				augmentStatusOtherLabel.Enabled = false;
				augmentStatusOtherTextBox.Enabled = false;
			}
			augmentStatusTimeDateTimePicker.Value = DateTime.Now;
		}

		/// <summary>
		/// Auto update last update time to now since status changed.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void augmentStatusOtherTextBox_TextChanged(object sender, EventArgs e)
		{
			augmentStatusTimeDateTimePicker.Value = DateTime.Now;
			StatusUpdated(sender, e);
		}
		#endregion Augmentations

		#region Generic
		/// <summary>
		/// Used when something on the form changed so user can be informed when closing the form.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void StatusUpdated(object sender, EventArgs e)
		{
			statusChanged = true;
		}

		/// <summary>
		/// Used when an image is added to or removed from the images flow view so user can be informed when closing the form.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void StatusUpdated(object sender, ControlEventArgs e)
		{
			statusChanged = true;
		}

		/// <summary>
		/// Saves the application, resume, or both depending on the editor type. <br/>
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void saveButton_Click(object sender, EventArgs e)
		{
			List<string> errorList = new List<string>();

			try
			{
				switch (editorType)
				{
					case EditorType.CREATE_APPLICATION:
						{
							if (reuseCompanyCheckBox.Checked && !Home.companiesN.ContainsKey(reuseCompanyComboBox.Text))
								errorList.Add("Company to reuse is not valid.");

							if ((!reuseCompanyCheckBox.Checked) && Home.companiesN.ContainsKey(companyNameTextBox.Text))
								errorList.Add("Company created has the same name as a pre-existing company.");

							if (errorList.Count > 0)
								break;

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

							ScrapeApplicationTab(
								out string position,
								out string link,
								out string applicationType,
								out string location,
								out string salary,
								out string resume,
								out string coverLetterFileName,
								out string coverLetter,
								out string info,
								out string images);

							Application application = new Application(
								companyGuid,
								DateTime.Now.ToString("MM/dd/yyyy"),
								ApplicationStatus.SENT.ToString(),
								DateTime.Now.ToString("MM/dd/yyyy"),
								position,
								link,
								applicationType,
								location,
								salary,
								images,
								resume,
								coverLetterFileName,
								coverLetter,
								info);
							Home.applications.Add(application.guid, application);
							FileManager.SaveXml(application.ConvertToXml(), FileType.APPLICATION, application.guid + ".xml");

							ApplicationSelector.WarnDataUpdate();

							break;
						}
					case EditorType.EDIT_COMPANY:
						if (!companyNameTextBox.Text.Equals(companyToEdit!.name) && Home.companiesN.ContainsKey(companyNameTextBox.Text))
							errorList.Add("Company created has the same name as a pre-existing company.");

						if (errorList.Count > 0)
							break;

						string originalName = companyToEdit.name;

						companyToEdit.name = companyNameTextBox.Text;
						companyToEdit.website = companyWebsiteTextBox.Text;
						companyToEdit.careerWebsite = companyCareersWebsiteTextBox.Text;
						companyToEdit.careerHome = companyCareersHomeTextBox.Text;
						companyToEdit.email = companyEmailTextBox.Text;
						companyToEdit.password = companyPasswordTextBox.Text;
						companyToEdit.info = companyInfoTextBox.Text;

						FileManager.SaveXml(companyToEdit.ConvertToXml(), FileType.COMPANY, companyToEdit.guid + ".xml");
						Home.companiesG[companyToEdit.guid] = companyToEdit;
						Home.companiesN.Remove(originalName);
						Home.companiesN.Add(companyToEdit.name, companyToEdit);

						ApplicationSelector.WarnDataUpdate();

						break;
					case EditorType.EDIT_APPLICATION:
						{
							if (augmentCompanyComboBox.SelectedIndex == -1)
								errorList.Add("Invalid company selected in augmentations");
							if (applicationToEdit == null)
								errorList.Add("Application to edit is null");

							if (errorList.Count > 0)
								break;

							ScrapeApplicationTab(
								out string position,
								out string link,
								out string applicationType,
								out string location,
								out string salary,
								out string resume,
								out string coverLetterFileName,
								out string coverLetter,
								out string info,
								out string images);

							applicationToEdit!.position = position;
							applicationToEdit.link = link;
							applicationToEdit.applicationType = applicationType;
							applicationToEdit.location = location;
							applicationToEdit.salary = salary;
							applicationToEdit.resume = resume;
							applicationToEdit.coverLetterFileName = coverLetterFileName;
							applicationToEdit.coverLetter = coverLetter;
							applicationToEdit.info = info;
							applicationToEdit.images = images;

							Company? company = null;
							Home.companiesN.TryGetValue(augmentCompanyComboBox.Text, out company);
							if (company == null)
								throw new Exception("Company was null");
							applicationToEdit.company = company.guid;

							applicationToEdit.creationTime = augmentCreationTimeDateTimePicker.Value.ToString("MM/dd/yyyy");

							if (augmentStatusComboBox.SelectedIndex == (int)ApplicationStatus.OTHER)
								applicationToEdit.status = augmentStatusOtherTextBox.Text;
							else
								applicationToEdit.status = ((ApplicationStatus)augmentStatusComboBox.SelectedIndex).ToString();

							applicationToEdit.statusTime = augmentStatusTimeDateTimePicker.Value.ToString("MM/dd/yyyy");

							FileManager.SaveXml(applicationToEdit.ConvertToXml(), FileType.APPLICATION, applicationToEdit.guid + ".xml");
							Home.applications[applicationToEdit.guid] = applicationToEdit;

							ApplicationSelector.WarnDataUpdate();

							break;
						}
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

		/// <summary>
		/// Helper function for getting all of the information off of the application tab. <br/>
		/// Used when creating new applications, or editing pre-existing ones.
		/// </summary>
		/// <param name="position">The position the application is for</param>
		/// <param name="link">A link to the application page</param>
		/// <param name="applicationType">The type of application being submitted</param>
		/// <param name="location">Where position is located</param>
		/// <param name="salary">What salary the position is offering</param>
		/// <param name="resume">The resume submitted to the application</param>
		/// <param name="coverLetterFileName">The file name of the cover letter submitted to the application</param>
		/// <param name="coverLetter">The cover letter submitted to the application</param>
		/// <param name="info">Additional information abbout the position</param>
		/// <param name="images">A string representing images of the position in case the link to the position dies</param>
		private void ScrapeApplicationTab(
			out string position,
			out string link,
			out string applicationType,
			out string location,
			out string salary,
			out string resume,
			out string coverLetterFileName,
			out string coverLetter,
			out string info,
			out string images)
		{
			position = applicationPositionTextBox.Text;

			link = applicationLinkTextBox.Text;

			if (applicationTypeComboBox.SelectedIndex == (int)ApplicationType.OTHER)
				applicationType = applicationTypeOtherTextBox.Text;
			else
				applicationType = ((ApplicationType)applicationTypeComboBox.SelectedIndex).ToString();

			location = applicationLocationTextBox.Text;

			salary = applicationSalaryTextBox.Text;

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
			else
			{
				resume = "None";
			}

			if (applicationCoverLetterTextBox.Tag != null)
			{
				coverLetterFileName = applicationCoverLetterTextBox.Text;
				coverLetter = EncryptionManager.GetString((byte[])applicationCoverLetterTextBox.Tag);
			}
			else
			{
				coverLetterFileName = "None";
				coverLetter = "";
			}

			info = applicationInfoTextBox.Text;

			StringBuilder imagesSB = new StringBuilder();
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
				imagesSB.Append(imageString);
				imagesSB.Append("CONT");
			}
			images = imagesSB.ToString();
		}

		/// <summary>
		/// Closes out of the application editor without prompting the user of changes made.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void cancelButton_Click(object sender, EventArgs e)
		{
			statusChanged = false;
			Close();
		}
		#endregion Generic
	}

	public enum EditorType
	{
		CREATE_APPLICATION,
		EDIT_APPLICATION,
		EDIT_COMPANY
	}
}
