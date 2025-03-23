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

namespace JAM
{
	public partial class PasswordRecovery : Form
	{
		#region Variables
		/// <summary>
		/// The app password of the user's Gmail account.<br/>
		/// Used by the parent form.
		/// </summary>
		public string password;
		#endregion Variables

		#region Methods
		/// <summary>
		/// Base constructor
		/// </summary>
		public PasswordRecovery()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Opens the link in the user's browser.
		/// </summary>
		/// <param name="sender">The LinkLabel clicked</param>
		/// <param name="e">Unused</param>
		private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!(sender is LinkLabel))
				return;
			((LinkLabel)sender).LinkVisited = true;
			string link = "https://myaccount.google.com/apppasswords";
			try
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = link,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not open the website: " + ex.Message, "Invalid link", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// User has set their app password, so close the dialog.<br/>
		/// If their is an issue with the app password the parent form will need to handle it.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void doneButton_Click(object sender, EventArgs e)
		{
			password = passwordTextBox.Text;
			Close();
		}
		#endregion Methods
	}
}
