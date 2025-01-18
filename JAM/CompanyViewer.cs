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
	public partial class CompanyViewer : Form
	{
		private string guid;

		public static Dictionary<string, CompanyViewer> activeCompanies = new Dictionary<string, CompanyViewer>();
		private bool removeFromDictionary = true;

		public CompanyViewer(string guid)
		{
			this.guid = guid;

			InitializeComponent();
		}

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

		private void CompanyViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (removeFromDictionary)
				activeCompanies.Remove(guid);
		}

		private void doneButton_Click(object sender, EventArgs e)
		{
			Close();
		}

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
	}
}
