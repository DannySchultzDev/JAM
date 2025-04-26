/*
Copyright 2025 Wah Infinite

This file is part of JAM.

JAM is free software: you can redistribute it and/or modify it under the terms of the GNU General
Public License as published by the Free Software Foundation, either version 3 of the License, or (at your 
option) any later version.

JAM is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even 
the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with JAM. If not, see 
<https://www.gnu.org/licenses/>.
*/

using System.Xml;

namespace JAM
{
	public partial class Settings : Form
	{
		#region Variables
		/// <summary>
		/// The current instance of the Settings Form.<br/>
		/// Used to insure only one copy is opened at a time.
		/// </summary>
		public static Settings? instance = null;

		/// <summary>
		/// Is the data in the form dirty.<br/>
		/// Determines whether the user should be prompted when closing.
		/// </summary>
		public bool statusChanged = false;
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base constructor
		/// </summary>
		public Settings()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Ensure this is the only instance of the form.<br/>
		/// Load data into the textboxes.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void Settings_Load(object sender, EventArgs e)
		{
			if (instance != null)
			{
				instance.Focus();
				if (instance.WindowState == FormWindowState.Minimized)
					instance.WindowState = FormWindowState.Normal;
				Close();
				return;
			}
			else
			{
				instance = this;
			}

			passwordTextBox.Text = Home.password;
			emailTextBox.Text = Home.email;

			statusChanged = false;
		}

		/// <summary>
		/// Prompt the user if there is dirty data.<br/>
		/// If this is not a duplicate form, free the instance.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">If the user wants to save their data cancel the close.</param>
		private void Settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (statusChanged &&
				MessageBox.Show("You have made changes. Discard changes and close settings?",
				"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				e.Cancel = true;
				return;
			}

			if (instance == this)
				instance = null;
		}

		/// <summary>
		/// User is done with the form, so close it.<br/>
		/// Save the user's data before closing.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void doneButton_Click(object sender, EventArgs e)
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
				xmlDocument.AppendChild(root);

				FileManager.AddDataToXml(xmlDocument, root, passwordTextBox.Text, XmlNodeName.PASSWORD);
				FileManager.AddDataToXml(xmlDocument, root, emailTextBox.Text, XmlNodeName.EMAIL);

				Home.password = passwordTextBox.Text;
				Home.email = emailTextBox.Text;
				FileManager.SaveXml(xmlDocument, FileType.SETTINGS, FileManager.settingsFileName);

				statusChanged = false;
				Close();
			}
			catch
			{
				MessageBox.Show("Error saving new settings");
			}
		}
		#endregion Lifecycle

		#region Data Management
		/// <summary>
		/// Attempt to export all of the users data to a single file.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void exportButton_Click(object sender, EventArgs e)
		{
			try
			{
				//Salt to use for password encryption.
				string? salt = null;

				//Set encryption type.
				if (usePasswordCheckBox.Checked)
				{
					byte[] saltBytes = new byte[16];
					Random random = new();
					for (int i = 0; i < saltBytes.Length; ++i)
						saltBytes[i] = (byte)random.Next(256);

					salt = EncryptionManager.GetString(saltBytes);

					EncryptionManager.encryptionType = EncryptionType.TEMP;
					EncryptionManager.SetTempKey(passwordTextBox.Text, salt);
				}
				else
					EncryptionManager.encryptionType = EncryptionType.NONE;

				XmlDocument xmlDocument = new XmlDocument();
				XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
				root.SetAttribute(XmlNodeName.IV.ToString(), salt);
				xmlDocument.AppendChild(root);

				//Append every file of every data type.
				foreach (Company company in Home.companiesG.Values)
				{
					XmlDocument companyXml = company.ConvertToXml();

					XmlElement companyElement = xmlDocument.CreateElement(XmlNodeName.COMPANY.ToString());
					companyElement.AppendChild(xmlDocument.ImportNode(companyXml.DocumentElement!, true));
					root.AppendChild(companyElement);
				}
				foreach (Application application in Home.applications.Values)
				{
					XmlDocument applicationXml = application.ConvertToXml();

					XmlElement applicationElement = xmlDocument.CreateElement(XmlNodeName.APPLICATION.ToString());
					applicationElement.AppendChild(xmlDocument.ImportNode(applicationXml.DocumentElement!, true));
					root.AppendChild(applicationElement);
				}
				foreach (Resume resume in Home.resumes.Values)
				{
					XmlDocument resumeXml = resume.ConvertToXml();

					XmlElement resumeElement = xmlDocument.CreateElement(XmlNodeName.RESUME.ToString());
					resumeElement.AppendChild(xmlDocument.ImportNode(resumeXml.DocumentElement!, true));
					root.AppendChild(resumeElement);
				}
				{
					XmlDocument statsXml = Home.stats.ConvertToXml();

					XmlElement statsElement = xmlDocument.CreateElement(XmlNodeName.STATS.ToString());
					statsElement.AppendChild(xmlDocument.ImportNode(statsXml.DocumentElement!, true));
					root.AppendChild(statsElement);
				}
				{
					XmlDocument skillsXml = Home.skills.ConvertToXml();

					XmlElement skillsElement = xmlDocument.CreateElement(XmlNodeName.SKILLS.ToString());
					skillsElement.AppendChild(xmlDocument.ImportNode(skillsXml.DocumentElement!, true));
					root.AppendChild(skillsElement);
				}

				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "XML files (*.xml)|*.xml";
					saveFileDialog.Title = "Export Data";
					saveFileDialog.DefaultExt = "xml";
					saveFileDialog.AddExtension = true;
					saveFileDialog.FileName = "JAM Data.xml";

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
						xmlDocument.Save(saveFileDialog.FileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting files: " + ex.Message);
			}
			finally
			{
				//Reset the encryption type.
				EncryptionManager.encryptionType = EncryptionType.KEY;
			}
		}

		/// <summary>
		/// Attempt to import all of the users data from a single file.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void importButton_Click(object sender, EventArgs e)
		{
			try
			{
				//Warn the user.
				if (MessageBox.Show("Importing data will clear all pre-existing data. Continue?", "Are you sure?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					return;
				}

				XmlDocument xmlDocument = new XmlDocument();

				//Get the file to import
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = "XML files (*.xml)|*.xml";
					openFileDialog.Title = "Import Data";

					if (openFileDialog.ShowDialog() != DialogResult.OK)
						return;

					xmlDocument.Load(openFileDialog.FileName);
				}

				XmlElement root = xmlDocument.DocumentElement!;

				//Set the encryption type.
				if (usePasswordCheckBox.Checked)
				{
					EncryptionManager.encryptionType = EncryptionType.TEMP;

					string salt = root.GetAttribute(XmlNodeName.IV.ToString());
					if (string.IsNullOrEmpty(salt))
					{
						//If this is an old file without salt use the original SHA hash.
						EncryptionManager.SetTempKey(passwordTextBox.Text);
					}
					else
					{
						//If this is a new file with salt use the new Pbkdf2 hash.
						EncryptionManager.SetTempKey(passwordTextBox.Text, salt);
					}
				}
				else
					EncryptionManager.encryptionType = EncryptionType.NONE;

				//Get the individual data objects out of the XML.
				List<Company> companies = new List<Company>();
				List<Application> applications = new List<Application>();
				List<Resume> resumes = new List<Resume>();
				Stats stats = new Stats(new List<(string, string)>());
				Skills skills = new Skills(new List<string>());

				foreach (XmlElement element in root.ChildNodes)
				{
					switch (Enum.Parse<XmlNodeName>(element.Name))
					{
						case XmlNodeName.COMPANY:
							XmlDocument companyXml = new XmlDocument();
							companyXml.AppendChild(companyXml.ImportNode(element.FirstChild!, true));
							companies.Add(new Company(companyXml));
							break;
						case XmlNodeName.APPLICATION:
							XmlDocument applicationXml = new XmlDocument();
							applicationXml.AppendChild(applicationXml.ImportNode(element.FirstChild!, true));
							applications.Add(new Application(applicationXml));
							break;
						case XmlNodeName.RESUME:
							XmlDocument resumeXml = new XmlDocument();
							resumeXml.AppendChild(resumeXml.ImportNode(element.FirstChild!, true));
							resumes.Add(new Resume(resumeXml));
							break;
						case XmlNodeName.STATS:
							XmlDocument statsXml = new XmlDocument();
							statsXml.AppendChild(statsXml.ImportNode(element.FirstChild!, true));
							stats = new Stats(statsXml);
							break;
						case XmlNodeName.SKILLS:
							XmlDocument skillsXml = new XmlDocument();
							skillsXml.AppendChild(skillsXml.ImportNode(element.FirstChild!, true));
							skills = new Skills(skillsXml);
							break;
						default:
							throw new NotImplementedException("Document type not recognized.");
					}
				}

				foreach (CompanyViewer companyViewer in CompanyViewer.activeCompanies.Values)
					companyViewer.Close();
				foreach (ApplicationViewer applicationViewer in ApplicationViewer.activeApplications.Values)
					applicationViewer.Close();

				//Set the current data to the imported data.
				Home.companiesG.Clear();
				Home.companiesN.Clear();
				foreach (Company company in companies)
				{
					Home.companiesG.Add(company.guid, company);
					Home.companiesN.Add(company.name, company);
				}
				Home.applications.Clear();
				foreach (Application application in applications)
					Home.applications.Add(application.guid, application);
				Home.resumes.Clear();
				foreach (Resume resume in resumes)
					Home.resumes.Add(resume.name, resume);
				Home.stats = stats;
				Home.skills = skills;

				//Reset the encryption type.
				EncryptionManager.encryptionType = EncryptionType.KEY;

				//Delete the original data's files.
				Directory.Delete(FileManager.companiesFolder, true);
				Directory.Delete(FileManager.applicationsFolder, true);
				Directory.Delete(FileManager.resumesFolder, true);
				Directory.Delete(FileManager.quickStatsFolder, true);

				//Regenerate the folders.
				FileManager.EnsureAllFoldersExist();

				//Save the imported files.
				foreach (Company company in companies)
					FileManager.SaveXml(company.ConvertToXml(), FileType.COMPANY, company.guid.ToString() + ".xml");
				foreach (Application application in applications)
					FileManager.SaveXml(application.ConvertToXml(), FileType.APPLICATION, application.guid.ToString() + ".xml");
				foreach (Resume resume in resumes)
					FileManager.SaveXml(resume.ConvertToXml(), FileType.RESUMES, resume.guid.ToString() + ".xml");
				FileManager.SaveXml(stats.ConvertToXml(), FileType.QUICK_STAT, FileManager.quickStatsFileName);
				FileManager.SaveXml(skills.ConvertToXml(), FileType.QUICK_STAT, FileManager.skillsFileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error importing files: " + ex.Message);
			}
			finally
			{
				//Reset the encryption type.
				EncryptionManager.encryptionType = EncryptionType.KEY;
			}
		}
		#endregion Data Management

		#region Miscelaneous
		/// <summary>
		/// Toggle the password's visability.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void passwordViewButton_Click(object sender, EventArgs e)
		{
			passwordTextBox.PasswordChar =
				passwordTextBox.PasswordChar == '\0' ?
				'•' : '\0';
			passwordViewButton.Image =
				passwordTextBox.PasswordChar == '\0' ?
				JAM.Properties.Resources.CloakOrHide :
				JAM.Properties.Resources.Visible;
		}

		/// <summary>
		/// Data has been changed, so mark the form as dirty.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void StatusChanged(object sender, EventArgs e)
		{
			statusChanged = true;
		}
		#endregion Miscelaneous
	}
}
