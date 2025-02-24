using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml;

namespace JAM
{
	public partial class Settings : Form
	{
		public static Settings? instance = null;

		public bool statusChanged = false;

		public Settings()
		{
			InitializeComponent();
		}

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

		private void StatusChanged(object sender, EventArgs e)
		{
			statusChanged = true;
		}

		private void exportButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (usePasswordCheckBox.Checked)
				{
					EncryptionManager.encryptionType = EncryptionType.TEMP;
					EncryptionManager.SetTempKey(passwordTextBox.Text);
				}
				else
					EncryptionManager.encryptionType = EncryptionType.NONE;

				XmlDocument xmlDocument = new XmlDocument();
				XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
				xmlDocument.AppendChild(root);

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
				EncryptionManager.encryptionType = EncryptionType.KEY;
			}
		}

		private void importButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Importing data will clear all pre-existing data. Continue?", "Are you sure?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					return;
				}

				XmlDocument xmlDocument = new XmlDocument();

				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = "XML files (*.xml)|*.xml";
					openFileDialog.Title = "Import Data";

					if (openFileDialog.ShowDialog() != DialogResult.OK)
						return;

					xmlDocument.Load(openFileDialog.FileName);
				}

				if (usePasswordCheckBox.Checked)
				{
					EncryptionManager.encryptionType = EncryptionType.TEMP;
					EncryptionManager.SetTempKey(passwordTextBox.Text);
				}
				else
					EncryptionManager.encryptionType = EncryptionType.NONE;

				XmlElement root = xmlDocument.DocumentElement!;

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

				Directory.Delete(FileManager.companiesFolder, true);
				Directory.Delete(FileManager.applicationsFolder, true);
				Directory.Delete(FileManager.resumesFolder, true);
				Directory.Delete(FileManager.quickStatsFolder, true);

				FileManager.EnsureAllFoldersExist();

				foreach(Company company in companies)
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
				EncryptionManager.encryptionType = EncryptionType.KEY;
			}
		}
	}
}
