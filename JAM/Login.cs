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

using System.Net;
using System.Net.Mail;

namespace JAM
{
	public partial class Login : Form
	{
		#region Variables
		/// <summary>
		/// Whether the user successfuly logged in.<br/>
		/// Used by parent form.
		/// </summary>
		public bool loggedIn { get; private set; } = false;

		/// <summary>
		/// Recovery key that can be sent to the user in the event they forgot their password.<br/>
		/// Recovery keys are session dependent and will allow for a single sign in.
		/// </summary>
		public string recoveryKey = Guid.NewGuid().ToString();
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base constructor
		/// </summary>
		public Login()
		{
			InitializeComponent();
		}

		/// <summary>
		/// If the user did not set a recovery email, disable the recovery email button.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void Login_Load(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Home.email))
				emailButton.Enabled = false;
		}

		/// <summary>
		/// Ensure the user input their password (or the recovery password).
		/// If the user entered a valid password, close the dialog.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// User has decided to not enter a password, and instead wishes to close the application.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion Lifecycle

		#region Miscellaneous
		/// <summary>
		/// Toggle the password's visibility.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// Attempt to email the user the recovery email.<br/>
		/// User must have a Gmail account set up as their recovery email for this to work.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void emailButton_Click(object sender, EventArgs e)
		{
			try
			{
				PasswordRecovery passwordRecovery = new PasswordRecovery();
				passwordRecovery.ShowDialog();
				string password = passwordRecovery.password;

				if (string.IsNullOrEmpty(password))
					return;

				password = password.Replace(" ", "");

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
		#endregion Miscellaneous
	}
}
