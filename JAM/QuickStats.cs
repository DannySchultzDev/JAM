using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JAM
{
	public partial class QuickStats : Form
	{
		public static QuickStats? instance = null;

		public bool statusChanged = false;

		public QuickStats()
		{
			InitializeComponent();
		}

		private void QuickStats_Load(object sender, EventArgs e)
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

			DataGridViewColumn statNameColumn = new DataGridViewColumn();
			statNameColumn.HeaderText = "Name";
			statNameColumn.CellTemplate = new DataGridViewTextBoxCell();
			mainDataGridView.Columns.Add(statNameColumn);

			DataGridViewColumn statValueColumn = new DataGridViewColumn();
			statValueColumn.HeaderText = "Value";
			statValueColumn.CellTemplate = new DataGridViewTextBoxCell();
			mainDataGridView.Columns.Add(statValueColumn);

			DataGridViewButtonColumn copyButtonColumn = new DataGridViewButtonColumn();
			copyButtonColumn.HeaderText = "Copy";
			copyButtonColumn.CellTemplate = new DataGridViewButtonCell();
			copyButtonColumn.ReadOnly = true;
			mainDataGridView.Columns.Add(copyButtonColumn);
			copyButtonColumn.Width = 100;

			Stats stats = Home.stats;
			foreach (var stat in stats.stats)
			{
				mainDataGridView.Rows.Add(stat.name, stat.value);
			}

			StringBuilder sb = new StringBuilder();
			foreach (string skill in Home.skills.skills)
			{
				if (sb.Length > 0)
					sb.Append(", ");
				sb.Append(skill);
			}
			skillsTextBox.Text = sb.ToString();

			statusChanged = false;
		}

		private void mainDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
					return;

				switch (e.ColumnIndex)
				{
					case 2:
						e.Paint(e.CellBounds, DataGridViewPaintParts.All);

						int w = Properties.Resources.Copy.Width;
						int h = Properties.Resources.Copy.Height;
						int x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
						int y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

						e.Graphics!.DrawImage(Properties.Resources.Copy, new Rectangle(x, y, w, h));
						e.Handled = true;
						break;
				}
			}
			catch { }
		}

		private void QuickStats_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (statusChanged &&
				MessageBox.Show("You have made changes. Discard changes and close quick stats?",
				"Close?", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				e.Cancel = true;
				return;
			}

			if (instance == this)
				instance = null;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				StringBuilder errors = new StringBuilder();

				Stats stats = new Stats(new List<(string name, string value)>());

				foreach (DataGridViewRow row in mainDataGridView.Rows)
				{
					try
					{
						int index = row.Index;
						string name = (string)row.Cells[0].Value;
						string value = (string)row.Cells[1].Value;

						if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(value))
							continue;

						stats.stats.Add((name, value));
					}
					catch (Exception ex)
					{
						errors.Append("\nRow " + row.Index + 1 + " of skills has the error: " + ex.Message);
					}
				}

				Skills skills = new Skills(new List<string>());
				List<string> skillsUpperCase = new List<string>();
				string[] skillsArray = skillsTextBox.Text.Split(',');
				foreach (string skill in skillsArray)
				{
					if (skillsUpperCase.Contains(skill.Trim().ToUpper()))
						continue;
					skills.skills.Add(skill.Trim());
					skillsUpperCase.Add(skill.Trim().ToUpper());
				}

				if (errors.Length > 0)
					throw new Exception(errors.ToString());

				Home.stats = stats;
				FileManager.SaveXml(stats.ConvertToXml(), FileType.QUICK_STAT, FileManager.quickStatsFileName);
				Home.skills = skills;
				FileManager.SaveXml(skills.ConvertToXml(), FileType.QUICK_STAT, FileManager.skillsFileName);

				statusChanged = false;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not save due to the following errors:" + ex.Message);
			}
		}

		private void mainDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			statusChanged = true;
		}

		private void mainDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			statusChanged = true;
		}

		private void mainDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			statusChanged = true;
		}

		private void skillsButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(skillsTextBox.Text);
		}

		private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 2 &&
				e.RowIndex > -1 &&
				!string.IsNullOrEmpty((string)mainDataGridView[1, e.RowIndex].Value))
				Clipboard.SetText((string)mainDataGridView[1, e.RowIndex].Value);
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			statusChanged = false;
			Close();
		}
	}
}
