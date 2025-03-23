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
	public partial class CompanyViewer : Form
	{
		#region Variables
		/// <summary>
		/// The GUID of the company being viewed.
		/// </summary>
		private string guid;

		/// <summary>
		/// Dictionary that ties GUIDs to Company Viewers.<br/>
		/// Used to ensure that each Company is only opened once.<br/>
		/// Also used to be signaled when an Company is edited.
		/// </summary>
		public static Dictionary<string, CompanyViewer> activeCompanies = new Dictionary<string, CompanyViewer>();
		/// <summary>
		/// Is this the Company Viewer currently using the GUID.<br/>
		/// Used on closing to determine whever the Company Viewer can free the GUID.
		/// </summary>
		private bool removeFromDictionary = true;
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base Constructor.
		/// </summary>
		/// <param name="guid">The GUID of the Company being viewed.</param>
		public CompanyViewer(string guid)
		{
			this.guid = guid;

			InitializeComponent();
		}

		/// <summary>
		/// Ensure this not a duplicate viewer of a single Company.<br/>
		/// Fill data with UpdateValues().
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void CompanyViewer_Load(object sender, EventArgs e)
		{
			if (activeCompanies.ContainsKey(guid) && activeCompanies[guid] != null)
			{
				CompanyViewer preExistingViewer = activeCompanies[guid];
				if (preExistingViewer.WindowState == FormWindowState.Minimized)
					preExistingViewer.WindowState = FormWindowState.Normal;
				preExistingViewer.Focus();
				removeFromDictionary = false;
				Close();
				return;
			}
			else
				activeCompanies.Add(guid, this);

			UpdateValues();
		}

		/// <summary>
		/// Fill the Company Viewer UI with data.
		/// </summary>
		public void UpdateValues()
		{
			Company? company;
			if (!Home.companiesG.TryGetValue(guid, out company) || company == null)
			{
				Close();
				return;
			}

			int numberOfApplications = 0;
			foreach (Application application in Home.applications.Values)
			{
				if (application.company.Equals(guid))
					++numberOfApplications;
			}

			nameValueLabel.Text = company.name;
			applicationAmountValueLabel.Text = numberOfApplications.ToString();
			websiteValueLabel.Text = company.website;
			careerWebsiteValueLabel.Text = company.careerWebsite;
			careerHomeValueLabel.Text = company.careerHome;
			emailValueTextBox.Text = company.email;
			passwordValueTextBox.Text = company.password;
			infoValueTextBox.Text = company.info;
		}

		/// <summary>
		/// User is done with the Company Viewer, so close it.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void doneButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// If the Company Viewer was not a duplicate, remove its GUID from the dictionary.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void CompanyViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (removeFromDictionary)
				activeCompanies.Remove(guid);
		}
		#endregion Lifecycle

		#region Openers
		/// <summary>
		/// Opens a link that was clicked in the users browser.
		/// </summary>
		/// <param name="sender">The Link Label that was clicked.</param>
		/// <param name="e">Unused</param>
		private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!(sender is LinkLabel))
				return;
			((LinkLabel)sender).LinkVisited = true;
			string link = ((LinkLabel)sender).Text;
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
		#endregion Openers

		/// <summary>
		/// Toggles the visibility of the password field.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void passwordViewButton_Click(object sender, EventArgs e)
		{
			passwordValueTextBox.PasswordChar =
				passwordValueTextBox.PasswordChar == '\0' ?
				'•' : '\0';
			passwordViewButton.Image =
				passwordValueTextBox.PasswordChar == '\0' ?
				JAM.Properties.Resources.CloakOrHide :
				JAM.Properties.Resources.Visible;
		}
	}
}
