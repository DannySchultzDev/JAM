using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace JAM
{
	public partial class Home : Form
	{
		public static PasswordProtectionType? loggedIn = null;
		public static string password = "";

		public static List<ApplicationEditor> applicationEditors = new List<ApplicationEditor>();

		//Company Name - Company
		public static Dictionary<string, Company> companiesN = new Dictionary<string, Company>();
		//Company Guid - Company
		public static Dictionary<string, Company> companiesG = new Dictionary<string, Company>();
		//Application guid - Application
		public static Dictionary<string, Application> applications = new Dictionary<string, Application>();
		//Resume file name - Resume
		public static Dictionary<string, Resume> resumes = new Dictionary<string, Resume>();

		public Home()
		{
			InitializeComponent();
		}

		private void Home_Load(object sender, System.EventArgs e)
		{
			try
			{
				byte[] key;
				if (FileManager.TryGetFile(FileType.SETTINGS, FileManager.keyFileName, out string keyFilepath))
				{
					key = ProtectedData.Unprotect(File.ReadAllBytes(keyFilepath), null, DataProtectionScope.CurrentUser);
					if (key.Length != 32)
					{
						throw new Exception("Key is invalid. Keys are encrypted and decrypted using the current machine and user and are not transferable.");
					}

					XmlDocument? settings = FileManager.TryGetXml(FileType.SETTINGS, FileManager.settingsFileName);
					if (settings == null)
					{
						throw new Exception("Password file is missing.");
					}

					XmlNode passwordProtectionTypeNode = settings.DocumentElement!.GetElementsByTagName(
						XmlNodeName.PASSWORD_PROTECTION_TYPE.ToString())[0]!;
					switch (Enum.Parse(typeof(PasswordProtectionType),
						EncryptionManager.Decrypt(passwordProtectionTypeNode.InnerText,
						passwordProtectionTypeNode.Attributes![XmlNodeName.IV.ToString()]!.Value)))
					{
						case PasswordProtectionType.NONE:
							loggedIn = PasswordProtectionType.NONE;
							break;
						case PasswordProtectionType.LIMITED:
							loggedIn = PasswordProtectionType.LIMITED;
							break;
						case PasswordProtectionType.FULL:
							Login login = new Login();
							login.ShowDialog();
							if (login.loggedIn)
							{
								loggedIn = PasswordProtectionType.FULL;
							}
							else
							{
								Close();
							}
							break;
						default:
							throw new Exception("Password type is invald.");
					}

					FileManager.EnsureAllFoldersExist();
					foreach (string companyFilepath in Directory.GetFiles(FileManager.companiesFolder))
					{
						XmlDocument? companyXml = FileManager.TryGetXml(FileType.COMPANY, Path.GetFileName(companyFilepath));
						if (companyXml == null)
						{
							throw new Exception("Company xml exists but is null.");
						}
						Company company = new Company(companyXml);
						companiesN.Add(company.name, company);
						companiesG.Add(company.guid, company);
					}
					foreach (string applicationFilepath in Directory.GetFiles(FileManager.applicationsFolder))
					{
						XmlDocument? applicationXml = FileManager.TryGetXml(FileType.APPLICATION, Path.GetFileName(applicationFilepath));
						if (applicationXml == null)
						{
							throw new Exception("Application xml exists but is null.");
						}
						Application application = new Application(applicationXml);
						applications.Add(application.guid, application);
					}
					foreach (string resumeFilepath in Directory.GetFiles(FileManager.resumesFolder))
					{
						XmlDocument? resumeXml = FileManager.TryGetXml(FileType.RESUMES, Path.GetFileName(resumeFilepath));
						if (resumeXml == null)
						{
							throw new Exception("Resume xml exists but is null.");
						}
						Resume resume = new Resume(resumeXml);
						resumes.Add(resume.name, resume);
					}
				}
				else
				{
					FileManager.EnsureAllFoldersExist();
					if (FileManager.TryGetFile(FileType.SETTINGS, FileManager.settingsFileName, out _) ||
							Directory.GetFiles(FileManager.companiesFolder).Length > 0 ||
							Directory.GetFiles(FileManager.applicationsFolder).Length > 0 ||
							Directory.GetFiles(FileManager.quickStatsFolder).Length > 0 ||
							Directory.GetFiles(FileManager.resumesFolder).Length > 0)
					{
						throw new Exception("Key file is missing.");
					}
					else
					{
						loggedIn = PasswordProtectionType.NONE;
						XmlDocument xmlDocument = new XmlDocument();
						XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
						xmlDocument.AppendChild(root);

						FileManager.AddDataToXml(xmlDocument, root, PasswordProtectionType.NONE.ToString(), XmlNodeName.PASSWORD_PROTECTION_TYPE);
						FileManager.AddDataToXml(xmlDocument, root, "", XmlNodeName.PASSWORD);

						FileManager.SaveXml(xmlDocument, FileType.SETTINGS, FileManager.settingsFileName);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not complete authentication: " + ex.Message);
				Close();
				return;
			}
		}

		private void createApplicationButton_Click(object sender, EventArgs e)
		{
			ApplicationEditor createApplication = new ApplicationEditor(EditorType.CREATE_APPLICATION, null, null);
			createApplication.Show();
		}

		private void viewApplicationsButton_Click(object sender, EventArgs e)
		{
			ApplicationSelector viewer = new ApplicationSelector();
			viewer.Show();
		}

		private void Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (applicationEditors.Count > 0)
			{
				if (MessageBox.Show("Application editors are open. Continue closing?",
					"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					e.Cancel = true;
				}
				else
				{
					foreach (ApplicationEditor editor in applicationEditors)
					{
						editor.TryDestroyCurrTempImage();
					}
				}
			}
			if (!e.Cancel)
			{
				foreach (ApplicationViewer viewer in ApplicationViewer.activeApplications.Values)
				{
					viewer.TryDestroyCurrTempImage();
				}
			}
		}

		private void creditsButton_Click(object sender, EventArgs e)
		{
			Credits credits = new Credits();
			credits.Show();
		}

		private void quickStatsButton_Click(object sender, EventArgs e)
		{
			QuickStats quickStats = new QuickStats();
			quickStats.Show();
		}
	}
}
