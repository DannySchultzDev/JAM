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
	public partial class ApplicationSelector : Form
	{
		#region Variables
		private static ApplicationSelector? instance = null;

		/// <summary>
		/// Dictionary connecting each Company to each of their Applications.
		/// </summary>
		private Dictionary<Company, List<Application>> companyApplicationDictionary = new Dictionary<Company, List<Application>>();
		
		private Image viewImage = Properties.Resources.Open;
		private Image editImage = Properties.Resources.Edit;
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base constructor.
		/// </summary>
		public ApplicationSelector()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Prepares data grid views for data.<br/>
		/// Then calls UpdateData() to fill data grid views.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void ApplicationSelector_Load(object sender, EventArgs e)
		{
			//Ensure this is the only instance.
			if (instance != null)
			{
				instance.Focus();
				if (instance.WindowState == FormWindowState.Minimized)
					instance.WindowState = FormWindowState.Normal;
				Close();
				return;
			}
			else
			{
				instance = this;
			}

			//Load the columns of the Companies data grid view.
			DataGridViewColumn companyNameColumn = new DataGridViewColumn();
			companyNameColumn.Name = "Name";
			companyNameColumn.HeaderText = "Name";
			companyNameColumn.CellTemplate = new DataGridViewTextBoxCell();
			companiesGrid.Columns.Add(companyNameColumn);
			DataGridViewColumn companyApplicationsColumn = new DataGridViewColumn();
			companyApplicationsColumn.Name = "Applications";
			companyApplicationsColumn.HeaderText = "Applications";
			companyApplicationsColumn.CellTemplate = new DataGridViewTextBoxCell();
			companiesGrid.Columns.Add(companyApplicationsColumn);
			DataGridViewButtonColumn companyViewColumn = new DataGridViewButtonColumn();
			companyViewColumn.Name = "View";
			companyViewColumn.HeaderText = "View";
			companyViewColumn.CellTemplate = new DataGridViewButtonCell();
			companiesGrid.Columns.Add(companyViewColumn);
			DataGridViewButtonColumn companyEditColumn = new DataGridViewButtonColumn();
			companyEditColumn.Name = "Edit";
			companyEditColumn.HeaderText = "Edit";
			companyViewColumn.CellTemplate = new DataGridViewButtonCell();
			companiesGrid.Columns.Add(companyEditColumn);

			//Load the columns of the Applications data grid view.
			DataGridViewColumn applicationPositionColumn = new DataGridViewColumn();
			applicationPositionColumn.Name = "Position";
			applicationPositionColumn.HeaderText = "Position";
			applicationPositionColumn.CellTemplate = new DataGridViewTextBoxCell();
			applicationsGrid.Columns.Add(applicationPositionColumn);
			DataGridViewColumn applicationStatusColumn = new DataGridViewColumn();
			applicationStatusColumn.Name = "Status";
			applicationStatusColumn.HeaderText = "Status";
			applicationStatusColumn.CellTemplate = new DataGridViewTextBoxCell();
			applicationsGrid.Columns.Add(applicationStatusColumn);
			DataGridViewColumn applicationStatusTimeColumn = new DataGridViewColumn();
			applicationStatusTimeColumn.Name = "Status Time";
			applicationStatusTimeColumn.HeaderText = "Last Update";
			applicationStatusTimeColumn.CellTemplate = new DataGridViewTextBoxCell();
			applicationsGrid.Columns.Add(applicationStatusTimeColumn);
			DataGridViewButtonColumn applicationViewColumn = new DataGridViewButtonColumn();
			applicationViewColumn.Name = "View";
			applicationViewColumn.HeaderText = "View";
			applicationViewColumn.CellTemplate = new DataGridViewButtonCell();
			applicationsGrid.Columns.Add(applicationViewColumn);
			DataGridViewButtonColumn applicationEditColumn = new DataGridViewButtonColumn();
			applicationEditColumn.Name = "Edit";
			applicationEditColumn.HeaderText = "Edit";
			applicationEditColumn.CellTemplate = new DataGridViewButtonCell();
			applicationsGrid.Columns.Add(applicationEditColumn);

			UpdateData();
		}

		/// <summary>
		/// Remove instance reference.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void ApplicationSelector_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this == instance)
				instance = null;
		}
		#endregion Lifecycle

		#region Update Data
		/// <summary>
		/// User has clicked refresh, so update data.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void refreshButton_Click(object sender, EventArgs e)
		{
			UpdateData();
		}

		/// <summary>
		/// Warn the user that the data they are viewing is out of date if an application selector is open.
		/// </summary>
		public static void WarnDataUpdate()
		{
			if (instance == null)
				return;
			instance.refreshButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
		}

		/// <summary>
		/// Fill the data grid views with updated data.
		/// </summary>
		private void UpdateData()
		{
			//Update the dictionary to have newest data.
			companyApplicationDictionary.Clear();

			foreach (Company company in Home.companiesN.Values)
			{
				companyApplicationDictionary.Add(company, new List<Application>());
			}

			foreach (Application application in Home.applications.Values)
			{
				try
				{
					Company? company;
					if (!Home.companiesG.TryGetValue(application.company, out company))
						continue;
					companyApplicationDictionary[company].Add(application);
				}
				catch { }
			}

			//Update data grid views.
			UpdateCompanyRows();
			UpdateApplicationsRows();

			//Update warning UI.
			lastUpdateLabel.Text = "Last update: " + DateTime.Now.ToString();
			refreshButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
		}

		/// <summary>
		/// Add each company in the dictionary to the data grid view.
		/// </summary>
		private void UpdateCompanyRows()
		{
			companiesGrid.Rows.Clear();

			foreach (KeyValuePair<Company, List<Application>> companyApplications in companyApplicationDictionary)
			{
				int index = companiesGrid.Rows.Add(companyApplications.Key.name, companyApplications.Value.Count);
				companiesGrid.Rows[index].Tag = companyApplications.Key;
			}
		}

		/// <summary>
		/// Add each application in the the currently selected company to the data grid view.
		/// </summary>
		private void UpdateApplicationsRows()
		{
			applicationsGrid.Rows.Clear();

			if (companyApplicationDictionary.Count == 0)
				return;

			Company selectedCompany;
			try
			{
				DataGridViewCell selectedCell = companiesGrid.SelectedCells[0];
				selectedCompany = (Company)selectedCell.OwningRow.Tag!;
				foreach (Application application in companyApplicationDictionary[selectedCompany])
				{
					int index = applicationsGrid.Rows.Add(application.position, application.status, application.statusTime);
					applicationsGrid.Rows[index].Tag = application;
				}
			}
			catch
			{
				return;
			}
		}
		#endregion Update Data

		#region Input
		/// <summary>
		/// If the selected Company changed, show the Applications for the new Company.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void companiesGrid_SelectionChanged(object sender, EventArgs e)
		{
			UpdateApplicationsRows();
		}

		/// <summary>
		/// Open a Company editor or viewer if the user clicked the coresponding cell.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Event with the cell cliked info.</param>
		private void companiesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				switch (e.ColumnIndex)
				{
					case 2:
						CompanyViewer viewer = new CompanyViewer(((Company)companiesGrid.Rows[e.RowIndex].Tag!).guid);
						viewer.Show();
						break;
					case 3:
						ApplicationEditor editor = new ApplicationEditor(EditorType.EDIT_COMPANY, (Company)companiesGrid.Rows[e.RowIndex].Tag!, null);
						editor.Show();
						break;
				}
			}
			catch { }
		}

		/// <summary>
		/// Open a Application editor or viewer if the user clicked the coresponding cell.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Event with the cell cliked info.</param>
		private void applicationsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				switch (e.ColumnIndex)
				{
					case 3:
						ApplicationViewer viewer = new ApplicationViewer(((Application)applicationsGrid.Rows[e.RowIndex].Tag!).guid);
						viewer.Show();
						break;
					case 4:
						ApplicationEditor editor = new ApplicationEditor(EditorType.EDIT_APPLICATION, null, (Application)applicationsGrid.Rows[e.RowIndex].Tag!);
						editor.Show();
						break;
				}
			}
			catch { }
		}
		#endregion Input

		#region Cell Painting
		/// <summary>
		/// Paints images on the Companies' data grid view buttons.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Event for cell info.</param>
		private void companiesGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			switch (e.ColumnIndex)
			{
				case 2:
					PaintCell(e, viewImage);
					break;
				case 3:
					PaintCell(e, editImage);
					break;
			}
		}

		/// <summary>
		/// Paints images on the Applications' data grid view buttons.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Event for cell info.</param>
		private void applicationsGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			switch (e.ColumnIndex)
			{
				case 3:
					PaintCell(e, viewImage);
					break;
				case 4:
					PaintCell(e, editImage);
					break;
			}
		}

		/// <summary>
		/// Helper method that paints a cell of a data grid view.
		/// </summary>
		/// <param name="e">Event that contains cell info.</param>
		/// <param name="image">The image to paint.</param>
		private void PaintCell(DataGridViewCellPaintingEventArgs e, Image image)
		{
			e.Paint(e.CellBounds, DataGridViewPaintParts.All);

			int w = image.Width;
			int h = image.Height;
			int x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
			int y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

			e.Graphics!.DrawImage(image, x, y, w, h);

			e.Handled = true;
		}
		#endregion Cell Painting
	}
}
