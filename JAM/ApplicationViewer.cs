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
	public partial class ApplicationViewer : Form
	{
		private Dictionary<Company, List<Application>> companyApplicationDictionary = new Dictionary<Company, List<Application>>();
		private Image viewImage = Properties.Resources.Open;
		private Image editImage = Properties.Resources.Edit;

		public ApplicationViewer()
		{
			InitializeComponent();
		}

		private void ApplicationViewer_Load(object sender, EventArgs e)
		{
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

			foreach (KeyValuePair<Company, List<Application>> companyApplications in companyApplicationDictionary)
			{
				int index = companiesGrid.Rows.Add(companyApplications.Key.name, companyApplications.Value.Count);
				Button button = (Button)companiesGrid[2, index].Value;
			}
		}

		private void companiesGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			switch (e.ColumnIndex)
			{
				case 2:
					{
						e.Paint(e.CellBounds, DataGridViewPaintParts.All);

						int w = viewImage.Width;
						int h = viewImage.Height;
						int x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
						int y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

						e.Graphics!.DrawImage(viewImage, x, y, w, h);

						e.Handled = true;
						break;
					}
				case 3:
					{
						e.Paint(e.CellBounds, DataGridViewPaintParts.All);

						int w = editImage.Width;
						int h = editImage.Height;
						int x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
						int y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

						e.Graphics!.DrawImage(editImage, x, y, w, h);

						e.Handled = true;
						break;
					}
			}
		}
	}
}
