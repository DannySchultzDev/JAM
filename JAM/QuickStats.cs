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

using System.Text;

namespace JAM
{
	public partial class QuickStats : Form
	{
		#region Variables
		/// <summary>
		/// The current instance of the QuickStats Form.<br/>
		/// Used to insure only one copy is opened at a time.
		/// </summary>
		public static QuickStats? instance = null;

		/// <summary>
		/// Is the data in the form dirty.<br/>
		/// Determines whether the user should be prompted when closing.
		/// </summary>
		public bool statusChanged = false;
		#endregion Variables

		#region Lifecycle
		/// <summary>
		/// Base construction
		/// </summary>
		public QuickStats()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Ensure this is the only instance of the form.<br/>
		/// Load data into the DataGridView and TextBox.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
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

		/// <summary>
		/// Prompt the user if there is dirty data.<br/>
		/// If this is not a duplicate form, free the instance.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">If the user wants to save their data cancel the close.</param>
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

		/// <summary>
		/// User is done with the form, so close it.<br/>
		/// Save the user's data before closing.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				StringBuilder errors = new StringBuilder();

				//Get Stats organized.
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

				//Get skills orginized.
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

				//Ensure nothing went wrong.
				if (errors.Length > 0)
					throw new Exception(errors.ToString());

				//Update and save data.
				Home.stats = stats;
				FileManager.SaveXml(stats.ConvertToXml(), FileType.QUICK_STAT, FileManager.quickStatsFileName);
				Home.skills = skills;
				FileManager.SaveXml(skills.ConvertToXml(), FileType.QUICK_STAT, FileManager.skillsFileName);

				//Close the form.
				statusChanged = false;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not save due to the following errors:" + ex.Message);
			}
		}

		/// <summary>
		/// User is done with the form, so close it.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void cancelButton_Click(object sender, EventArgs e)
		{
			statusChanged = false;
			Close();
		}
		#endregion Lifecycle

		#region Stats
		/// <summary>
		/// Paint the copy symbol on the stats' buttons.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">The cell being painted</param>
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

		/// <summary>
		/// If the copy button of a cell is clicked, copy the value of the stat of the row.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">The cell being clicked</param>
		private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 2 &&
				e.RowIndex > -1 &&
				!string.IsNullOrEmpty((string)mainDataGridView[1, e.RowIndex].Value))
				Clipboard.SetText((string)mainDataGridView[1, e.RowIndex].Value);
		}

		/// <summary>
		/// A cell has been changed so mark the form as dirty.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void mainDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			statusChanged = true;
		}

		/// <summary>
		/// A row has been added so mark the form as dirty.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void mainDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			statusChanged = true;
		}

		/// <summary>
		/// A row has been removed so mark the form as dirty.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void mainDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			statusChanged = true;
		}
		#endregion Stats

		#region Skills
		/// <summary>
		/// The user clicked the copy skills button, so copy them.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void skillsButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(skillsTextBox.Text);
		}

		/// <summary>
		/// The skills have changed, so mark the form as dirty.
		/// </summary>
		/// <param name="sender">Unused</param>
		/// <param name="e">Unused</param>
		private void skillsTextBox_TextChanged(object sender, EventArgs e)
		{
			statusChanged = true;
		}
		#endregion Skills
	}
}
