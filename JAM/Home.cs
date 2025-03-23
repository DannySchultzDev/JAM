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

using System.Security.Cryptography;
using System.Xml;

namespace JAM
{
	public partial class Home : Form
	{
		#region Variables
		/// <summary>
		/// The user's password. Used during sign in.
		/// </summary>
		public static string password = "";
		/// <summary>
		/// The user's email address. Used during password recovery.
		/// </summary>
		public static string email = "";

		/// <summary>
		/// List of open ApplicationEditors. Used for ensuring no dirty work is left unsaved.
		/// </summary>
		public static List<ApplicationEditor> applicationEditors = new List<ApplicationEditor>();

		#region User Data
		/// <summary>
		/// Company Name - Company
		/// </summary>
		public static Dictionary<string, Company> companiesN = new Dictionary<string, Company>();
		/// <summary>
		/// Company Guid - Company
		/// </summary>
		public static Dictionary<string, Company> companiesG = new Dictionary<string, Company>();
		/// <summary>
		/// Application guid - Application
		/// </summary>
		public static Dictionary<string, Application> applications = new Dictionary<string, Application>();
		/// <summary>
		/// Resume file name - Resume
		/// </summary>
		public static Dictionary<string, Resume> resumes = new Dictionary<string, Resume>();
		/// <summary>
		/// Stats
		/// </summary>
		public static Stats stats = new Stats(new List<(string, string)>
		{
			("Email", ""),
			("Phone Number", ""),
			("Address", ""),
			("Address Line 2", ""),
			("LinkedIn", "")
		});
		/// <summary>
		/// Skills
		/// </summary>
		public static Skills skills = new Skills(new List<string>());
		#endregion User Data
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base Constructor
		/// </summary>
		public Home()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Get all user data.<br/>
		/// If the user has a password, force them to sign in before showing the home window.<br/>
		/// If there is any corruption or data missing, don't show the home window.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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
						//The key is invalid. This could be 1 of 4 things:
						//1. The user copied all of their data to another computer instead of using the export/import buttons.
						//If the key is invalid due to user error, hopefully they can go back and correctly export their data.
						//2. The user's key got corrupted. This should hopefully never happen.
						//If the key is invalid due to corruption, the only solution is to create a new key and use a backup export the user made of their data.
						//3. A malicious actor stole a user's data and key and has tried to decrypt the key on a different machiene.
						//4. A malicious actor stole a user's data and created/used a fake garbage key.
						//No data for the malicious actor.
						throw new Exception("Key is invalid. Keys are encrypted and decrypted using the current machine and user and are not transferable. To properly transfer data, use the export and inport options in settings.");
					}

					XmlDocument? settings = FileManager.TryGetXml(FileType.SETTINGS, FileManager.settingsFileName);
					if (settings == null)
					{
						//There is no password file. This could be 1 of 2 things:
						//The user deleted the password file, this should hopefully never happen.
						//A malicious actor deleted the users password file, hoping it would be recreated.
						//If the password file is missing, the only solution is to create a new key and password file and use a backup export the user made of their data.
						//The user could technically download the source code and get past this exception in debug mode.
						//Due to this, the purpose of this is to be a deterrent to an a attack where a malicious actor gains control over the users PC which only has the JAM exe installed.
						throw new Exception("Password file is missing. This should never happen under most cicumstances. Data recovery is possible, please reach out to the developer for more information.");
					}

					{
						string? password = null;
						string? email = null;
						foreach (XmlElement element in settings.DocumentElement!.ChildNodes)
						{
							string decryptedElement = EncryptionManager.Decrypt(element.InnerText,
								element.Attributes[XmlNodeName.IV.ToString()]!.Value);
							switch (Enum.Parse(typeof(XmlNodeName), element.Name))
							{
								case XmlNodeName.PASSWORD:
									password = decryptedElement;
									break;
								case XmlNodeName.EMAIL:
									email = decryptedElement;
									break;
								default:
									//The password file is corrupted. This could be 1 of 2 things:
									//The password file got corrupted, this should hopefully never happen.
									//A malicious actor replaced the users password file with garbage data, hoping it would be ignored.
									//If the password file is corrupted, the only solution is to create a new key and password file and use a backup export the user made of their data.
									//The user could technically download the source code and get past this exception in debug mode.
									//Due to this, the purpose of this is to be a deterrent to an a attack where a malicious actor gains control over the users PC which only has the JAM exe installed.
									throw new Exception("Settings file has been tampered with. This should never happen under most circumstances. Data recovery is possible, please reach out to the developer for more information.");
							}
						}
						if (password == null || email == null)
						{
							//The password file is corrupted. This could be 1 of 2 things:
							//The password file got corrupted, this should hopefully never happen.
							//A malicious actor replaced the users password file with garbage data, hoping it would be ignored.
							//If the password file is corrupted, the only solution is to create a new key and password file and use a backup export the user made of their data.
							//The user could technically download the source code and get past this exception in debug mode.
							//Due to this, the purpose of this is to be a deterrent to an a attack where a malicious actor gains control over the users PC which only has the JAM exe installed.
							throw new Exception("Settings file has been tampered with. This should never happen under most circumstances. Data recovery is possible, please reach out to the developer for more information.");
						}
						Home.password = password;
						Home.email = email;
					}

					if (password.Length > 0)
					{
						Login login = new Login();
						login.ShowDialog();
						if (!login.loggedIn)
						{
							Close();
						}
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
					//Stats
					{
						XmlDocument? statsXml = FileManager.TryGetXml(FileType.QUICK_STAT, FileManager.quickStatsFileName);
						if (statsXml != null)
							stats = new Stats(statsXml);
					}
					//Skills
					{
						XmlDocument? skillsXml = FileManager.TryGetXml(FileType.QUICK_STAT, FileManager.skillsFileName);
						if (skillsXml != null)
							skills = new Skills(skillsXml);
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
						//User has data, but no key file. This could be 1 of 2 things:
						//The user deleted their key file by mistake, this should never happen.
						//A malicious actor deleted the users key file to try to get the program to regenerate a new key and decrypt the users data.
						throw new Exception("Key file is missing.");
					}
					else
					{
						//Fresh boot.
						//Create the password file.
						//A new key file will also be generated implicitly.
						password = "";
						email = "";
						XmlDocument xmlDocument = new XmlDocument();
						XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
						xmlDocument.AppendChild(root);

						FileManager.AddDataToXml(xmlDocument, root, "", XmlNodeName.PASSWORD);
						FileManager.AddDataToXml(xmlDocument, root, "", XmlNodeName.EMAIL);

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

		/// <summary>
		/// Prompt user if dirty data exists.<br/>
		/// Also destroy temp images if they exist.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Event args to use if the user cancels the close.</param>
		private void Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (QuickStats.instance != null && QuickStats.instance.statusChanged)
			{
				if (MessageBox.Show("Quick Stats are open with unsaved changes. Continue closing?",
					"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					e.Cancel = true;
					return;
				}
			}
			if (Settings.instance != null && Settings.instance.statusChanged)
			{
				if (MessageBox.Show("Settings are open with unsaved changes. Continue closing?",
					"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					e.Cancel = true;
					return;
				}
			}
			if (applicationEditors.Count > 0)
			{
				if (MessageBox.Show("Application editors are open. Continue closing?",
					"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
				{
					e.Cancel = true;
					return;
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
		#endregion Lifecycle

		#region Open Window
		/// <summary>
		/// Opens an application creator.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void createApplicationButton_Click(object sender, EventArgs e)
		{
			ApplicationEditor createApplication = new ApplicationEditor(EditorType.CREATE_APPLICATION, null, null);
			createApplication.Show();
		}

		/// <summary>
		/// Opens the application selector.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void viewApplicationsButton_Click(object sender, EventArgs e)
		{
			ApplicationSelector viewer = new ApplicationSelector();
			viewer.Show();
		}

		/// <summary>
		/// Opens the quick stats window.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void quickStatsButton_Click(object sender, EventArgs e)
		{
			QuickStats quickStats = new QuickStats();
			quickStats.Show();
		}

		/// <summary>
		/// Opens the settings window.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void settingsButton_Click(object sender, EventArgs e)
		{
			Settings options = new Settings();
			options.Show();
		}

		/// <summary>
		/// Opens the credits window.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void creditsButton_Click(object sender, EventArgs e)
		{
			Credits credits = new Credits();
			credits.Show();
		}
		#endregion Open Window
	}
}
