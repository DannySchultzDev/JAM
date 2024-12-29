using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JAM
{
	public partial class Login : Form
	{
		public bool loggedIn = false;

		private string realPassword = "";

		public Login()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (passwordTextbox.Text.Equals(realPassword))
			{
				loggedIn = true;
				Close();
			}
			else
			{
				MessageBox.Show("Password was incorrect.");
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			XmlDocument? settings = FileManager.TryGetXml(FileType.SETTINGS, FileManager.settingsFileName);
			if (settings == null)
			{
				MessageBox.Show("Settings file missing. Cannot log in.");
				Close();
				return;
			}
			try
			{
				XmlNode passwordNode = settings.DocumentElement!.GetElementsByTagName(
					XmlNodeName.PASSWORD.ToString())[0]!;
				realPassword = EncryptionManager.Decrypt(
					passwordNode.InnerText,
					passwordNode.Attributes![XmlNodeName.IV.ToString()]!.Value);
			}
			catch
			{
				MessageBox.Show("Error getting password. Cannot log in.");
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void passwordViewButton_Click(object sender, EventArgs e)
		{
			passwordTextbox.PasswordChar =
				passwordTextbox.PasswordChar == '\0' ?
				'•' : '\0';
			passwordViewButton.Image =
				passwordTextbox.PasswordChar == '\0' ?
				JAM.Properties.Resources.CloakOrHide :
				JAM.Properties.Resources.Visible;
		}
	}
}
