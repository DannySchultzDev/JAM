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

using System.Diagnostics;

namespace JAM
{
	public partial class ApplicationViewer : Form
	{
		#region Variables
		/// <summary>
		/// The GUID of the application being viewed.
		/// </summary>
		private string guid;

		/// <summary>
		/// Dictionary that ties GUIDs to Application Viewers.<br/>
		/// Used to ensure that each Application is only opened once.<br/>
		/// Also used to be signaled when an Application is edited.
		/// </summary>
		public static Dictionary<string, ApplicationViewer> activeApplications = new Dictionary<string, ApplicationViewer>();
		/// <summary>
		/// Is this the Application Viewer currently using the GUID.<br/>
		/// Used on closing to determine whever the Application Viewer can free the GUID.
		/// </summary>
		private bool removeFromDictionary = true;

		/// <summary>
		/// The GUID of the Company that the Application is for.
		/// </summary>
		public string? companyGuid = null;

		/// <summary>
		/// The Application's cover letter's internal data.
		/// </summary>
		private byte[]? coverLetter = null;

		/// <summary>
		/// The last path used when generating a temp file.<br/>
		/// Destroy the temp file when creating a new one, or when closing.
		/// </summary>
		private string? lastTempPath = null;
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base constructor.
		/// </summary>
		/// <param name="guid">The GUID of the Application being viewed.</param>
		public ApplicationViewer(string guid)
		{
			this.guid = guid;
			InitializeComponent();
		}

		/// <summary>
		/// Ensure this not a duplicate viewer of a single Application.<br/>
		/// Fill data with UpdateValues().
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// Fill the Application Viewer UI with data.
		/// </summary>
		public void UpdateValues()
		{
			//Ensure the application still exists
			if (!Home.applications.TryGetValue(guid, out Application? application) || application == null)
			{
				Close();
				return;
			}

			positionValueLabel.Text = application.position;

			//Try to get the Application's Company's name.
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

			//Convert the image string to images and display.
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

		/// <summary>
		/// User is done with the Application Viewer, so close it.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void doneButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// If the Application Viewer was not a duplicate, remove its GUID from the dictionary.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void ApplicationViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			TryDestroyCurrTempImage();

			if (removeFromDictionary)
				activeApplications.Remove(guid);
		}
		#endregion Lifecycle

		#region Openers
		/// <summary>
		/// Opens a Company Viewer for the Application's Company.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void companyOpenButton_Click(object sender, EventArgs e)
		{
			if (companyGuid == null)
				return;

			CompanyViewer viewer = new CompanyViewer(companyGuid);
			viewer.Show();
		}

		/// <summary>
		/// Opens a link label's link.
		/// </summary>
		/// <param name="sender">The link label being clicked.</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// Opens the Application's resume if it contains one.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// Opens the Application's cover letter if it contains one.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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
		#endregion Openers

		#region Images
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
		#endregion Images
	}
}
