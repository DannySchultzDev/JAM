using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAM
{
	public partial class PasswordRecovery : Form
	{
		public string password;
		public PasswordRecovery()
		{
			InitializeComponent();
		}

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

		private void doneButton_Click(object sender, EventArgs e)
		{
			password = passwordTextBox.Text;
			Close();
		}
	}
}
