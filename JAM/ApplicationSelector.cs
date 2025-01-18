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
	public partial class ApplicationSelector : Form
	{
		private static ApplicationSelector? instance = null;

		private Dictionary<Company, List<Application>> companyApplicationDictionary = new Dictionary<Company, List<Application>>();
		private Image viewImage = Properties.Resources.Open;
		private Image editImage = Properties.Resources.Edit;

		public ApplicationSelector()
		{
			InitializeComponent();
		}

		private void ApplicationViewer_Load(object sender, EventArgs e)
		{
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

		private void refreshButton_Click(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void UpdateData()
		{
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

			UpdateCompanyRows();
			UpdateApplicationsRows();
			lastUpdateLabel.Text = "Last update: " + DateTime.Now.ToString();
			refreshButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
		}

		private void UpdateCompanyRows()
		{
			companiesGrid.Rows.Clear();

			foreach (KeyValuePair<Company, List<Application>> companyApplications in companyApplicationDictionary)
			{
				int index = companiesGrid.Rows.Add(companyApplications.Key.name, companyApplications.Value.Count);
				companiesGrid.Rows[index].Tag = companyApplications.Key;
			}
		}

		private void companiesGrid_SelectionChanged(object sender, EventArgs e)
		{
			UpdateApplicationsRows();
		}

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

		private void ApplicationSelector_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this == instance)
				instance = null;
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
	}
}
