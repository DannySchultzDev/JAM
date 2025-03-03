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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAM
{
	public partial class ApplicationViewer : Form
	{
		private string guid;

		public static Dictionary<string, ApplicationViewer> activeApplications = new Dictionary<string, ApplicationViewer>();
		private bool removeFromDictionary = true;

		public string? companyGuid = null;
		private byte[]? coverLetter = null;

		private string? lastTempPath = null;

		public ApplicationViewer(string guid)
		{
			this.guid = guid;
			InitializeComponent();
		}

		private void ApplicationViewer_Load(object sender, EventArgs e)
		{
			if (activeApplications.ContainsKey(guid) && activeApplications[guid] != null)
			{
				ApplicationViewer preExistingViewer = activeApplications[guid];
				if (preExistingViewer.WindowState == FormWindowState.Minimized)
					preExistingViewer.WindowState = FormWindowState.Normal;
				preExistingViewer.Focus();
				removeFromDictionary = false;
				Close();
				return;
			}
			else
				activeApplications.Add(guid, this);

			UpdateValues();
		}

		public void UpdateValues()
		{
			if (!Home.applications.TryGetValue(guid, out Application? application) || application == null)
			{
				Close();
				return;
			}

			positionValueLabel.Text = application.position;

			if (!Home.companiesG.TryGetValue(application.company, out Company? company) || company == null)
			{
				companyValueLabel.Text = "Unknown Company";
				companyGuid = null;
				companyOpenButton.Enabled = false;
			}
			else
			{
				companyValueLabel.Text = company.name;
				companyGuid = company.guid;
				companyOpenButton.Enabled = true;
			}

			if (Enum.TryParse(application.status, out ApplicationStatus status) &&
				Application.ApplicationStatuses.TryGetValue(status, out string? statusString) &&
				!string.IsNullOrEmpty(statusString))
				statusValueLabel.Text = statusString;
			else
				statusValueLabel.Text = application.status;

			lastUpdateTimeValueLabel.Text = application.statusTime;
			linkValueLabel.Text = application.link;

			if (Enum.TryParse(application.applicationType, out ApplicationType type) &&
				Application.ApplicationTypes.TryGetValue(type, out string? typeString) &&
				!string.IsNullOrEmpty(typeString))
				applicationTypeValueLabel.Text = typeString;
			else
				applicationTypeValueLabel.Text = application.applicationType;

			locationValueLabel.Text = application.location;
			salaryValueLabel.Text = application.salary;
			resumeValueLabel.Text = application.resume;
			coverLetterValueLabel.Text = application.coverLetterFileName;
			coverLetter = EncryptionManager.GetBytes(application.coverLetter);
			creationTimeValueLabel.Text = application.creationTime;
			infoValueTextBox.Text = application.info;

			imageFlowLayout.Controls.Clear();
			string[] images = application.images.Split("CONT");
			foreach (string imageString in images)
			{
				if (string.IsNullOrEmpty(imageString))
					continue;
				byte[] imageBytes = EncryptionManager.GetBytes(imageString);
				using (var memoryStream = new MemoryStream(imageBytes))
				{
					Image image = Image.FromStream(memoryStream);

					AddBackupImage(image);
				}
			}
		}

		private void ApplicationViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			TryDestroyCurrTempImage();

			if (removeFromDictionary)
				activeApplications.Remove(guid);
		}

		private void doneButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void companyOpenButton_Click(object sender, EventArgs e)
		{
			if (companyGuid == null)
				return;

			CompanyViewer viewer = new CompanyViewer(companyGuid);
			viewer.Show();
		}

		private void linkValueLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

		private void resumeOpenButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(resumeValueLabel.Text) ||
				!Home.resumes.TryGetValue(resumeValueLabel.Text, out Resume? resume) ||
				resume == null)
				return;

			TryDestroyCurrTempImage();
			lastTempPath = Path.Combine(Path.GetTempPath(), resume.guid + ".pdf");
			try
			{
				File.WriteAllBytes(lastTempPath, EncryptionManager.GetBytes(resume.data));
				Process.Start(new ProcessStartInfo
				{
					FileName = lastTempPath,
					UseShellExecute = true
				});
			}
			catch
			{
				MessageBox.Show("Could not open resume.");
			}
		}

		private void coverLetterOpenButton_Click(object sender, EventArgs e)
		{
			if (coverLetter == null)
				return;

			TryDestroyCurrTempImage();
			lastTempPath = Path.Combine(Path.GetTempPath(), coverLetterValueLabel.Text);
			try
			{
				File.WriteAllBytes(lastTempPath, coverLetter);
				Process.Start(new ProcessStartInfo
				{
					FileName = lastTempPath,
					UseShellExecute = true
				});
			}
			catch
			{
				MessageBox.Show("Could not open cover letter.");
			}
		}

		/// <summary>
		/// Helper function that adds an image to the images flow view.
		/// </summary>
		/// <param name="image">The image to add to the images flow view</param>
		private void AddBackupImage(Image image)
		{
			PictureBox pictureBox = new PictureBox();
			pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox.Image = image;
			pictureBox.Parent = imageFlowLayout;
			pictureBox.Click += PictureBoxClicked!;
		}

		/// <summary>
		/// Creates a temp file of the image, then opens it externaly.
		/// </summary>
		/// <param name="sender">The image clicked</param>
		/// <param name="e">Unused</param>
		private void PictureBoxClicked(object sender, EventArgs e)
		{
			if (sender == null ||
				!(sender is PictureBox))
				return;

			Image image = (sender as PictureBox)!.Image;

			TryDestroyCurrTempImage();
			lastTempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".png");
			try
			{
				image.Save(lastTempPath, System.Drawing.Imaging.ImageFormat.Png);
				Process.Start(new ProcessStartInfo
				{
					FileName = lastTempPath,
					UseShellExecute = true
				});
			}
			catch
			{
				MessageBox.Show("Could not view image.");
			}
		}

		/// <summary>
		/// Helper function that destroys the last opened image. <br/>
		/// Used to prevent temp images from being left on the user's machine.
		/// </summary>
		public void TryDestroyCurrTempImage()
		{
			if (lastTempPath == null)
				return;
			try
			{
				File.Delete(lastTempPath);
			}
			catch
			{
				MessageBox.Show("Could not delete the file: " + lastTempPath);
			}
		}
	}
}
