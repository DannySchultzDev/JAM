using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.Mail;

namespace JAM
{
	public partial class Login : Form
	{
		public bool loggedIn = false;

		public string recoveryKey = Guid.NewGuid().ToString();

		public Login()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (passwordTextbox.Text.Equals(Home.password) ||
				passwordTextbox.Text.Equals(recoveryKey))
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
			if (string.IsNullOrEmpty(Home.email))
				emailButton.Enabled = false;
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

		private async void emailButton_Click(object sender, EventArgs e)
		{
			try
			{
				PasswordRecovery passwordRecovery = new PasswordRecovery();
				passwordRecovery.ShowDialog();
				string password = passwordRecovery.password;

				if (string.IsNullOrEmpty(password))
					return;

				password = password.Replace(" ","");

				MailMessage mail = new MailMessage();
				mail.From = new MailAddress(Home.email, "JAM Password Recovery");
				mail.To.Add(new MailAddress(Home.email));
				mail.Subject = "Temporary Password Created";
				mail.Body = "Your temporary password is:\n" +
					recoveryKey +
					"\nThis temporary password will only work for this login session.\n" +
					"Feel free to delete the app password now.";

				SmtpClient client = new SmtpClient("smtp.gmail.com");
				client.Port = 587;
				client.Credentials = new NetworkCredential(Home.email, password);
				client.EnableSsl = true;

				client.Send(mail);
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Could not send recovery email: " + ex);
			}
		}
	}
}
