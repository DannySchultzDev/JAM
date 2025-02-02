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

			DataGridViewColumn indexColumn = new DataGridViewColumn();
			indexColumn.CellTemplate = new DataGridViewTextBoxCell();
			indexColumn.Visible = false;
			mainDataGridView.Columns.Add(indexColumn);

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

			Dictionary<int, (string name, string value)> stats = new Dictionary<int, (string name, string value)>();
			XmlDocument? statsXmlDocument = FileManager.TryGetXml(FileType.QUICK_STAT, FileManager.quickStatsFileName);
			if (statsXmlDocument != null)
			{
				try
				{
					XmlElement root = statsXmlDocument.DocumentElement!;
					foreach (XmlNode node in root.ChildNodes)
					{
						try
						{
							int index;
							string name;
							string value;

							index = int.Parse(node.Attributes![XmlNodeName.INDEX.ToString()]!.Value);
							XmlNode nameNode = node.SelectSingleNode(XmlNodeName.NAME.ToString())!;
							name = EncryptionManager.Decrypt(nameNode.InnerText,
								nameNode.Attributes![XmlNodeName.IV.ToString()]!.Value);
							XmlNode valueNode = node.SelectSingleNode(XmlNodeName.VALUE.ToString())!;
							value = EncryptionManager.Decrypt(valueNode.InnerText,
								valueNode.Attributes![XmlNodeName.IV.ToString()]!.Value);

							stats.Add(index, (name, value));
						}
						catch { }
					}
				}
				catch { }
			}
			else
			{
				stats.Add(0, ("Email", ""));
				stats.Add(1, ("Phone Number", ""));
				stats.Add(2, ("Address", ""));
				stats.Add(3, ("Address Line 2", ""));
				stats.Add(4, ("LinkedIn", ""));
			}

			for (int i = 0; stats.Count > 0; ++i)
			{
				if (!stats.TryGetValue(i, out (string name, string value) stat))
					continue;

				mainDataGridView.Rows.Add(i, stat.name, stat.value);
				stats.Remove(i);
			}

			PriorityQueue<string, int> skills = new PriorityQueue<string, int>();
			XmlDocument? skillsXmlDocument = FileManager.TryGetXml(FileType.QUICK_STAT, FileManager.skillsFileName);
			if (skillsXmlDocument != null)
			{
				try
				{
					XmlElement root = skillsXmlDocument.DocumentElement!;
					foreach (XmlNode node in root.ChildNodes)
					{
						try
						{
							int index;
							string skill;

							index = int.Parse(node.Attributes![XmlNodeName.INDEX.ToString()]!.Value);
							skill = EncryptionManager.Decrypt(node.InnerText,
								node.Attributes![XmlNodeName.IV.ToString()]!.Value);

							skills.Enqueue(skill, index);
						}
						catch { }
					}
				}
				catch { }
			}

			StringBuilder sb = new StringBuilder();
			while (skills.Count > 1)
			{
				sb.Append(skills.Dequeue());
				sb.Append(", ");
			}
			if (skills.Count > 0)
			{
				sb.Append(skills.Dequeue());
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
					case 3:
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
				StringBuilder sb = new StringBuilder();

				XmlDocument statsXmlDocument = new XmlDocument();

				XmlElement statsRoot = statsXmlDocument.CreateElement("Root");
				statsXmlDocument.AppendChild(statsRoot);

				foreach (DataGridViewRow row in mainDataGridView.Rows)
				{
					try
					{
						int index = row.Index;
						string name = (string)row.Cells[1].Value;
						string value = (string)row.Cells[2].Value;

						if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(value))
							continue;

						XmlElement skillElement = statsXmlDocument.CreateElement("Stat");
						skillElement.SetAttribute(XmlNodeName.INDEX.ToString(), index.ToString());

						XmlElement nameElement = statsXmlDocument.CreateElement(XmlNodeName.NAME.ToString());
						nameElement.InnerText = EncryptionManager.Encrypt(name, out string nameIV);
						nameElement.SetAttribute(XmlNodeName.IV.ToString(), nameIV);
						skillElement.AppendChild(nameElement);

						XmlElement valueElement = statsXmlDocument.CreateElement(XmlNodeName.VALUE.ToString());
						valueElement.InnerText = EncryptionManager.Encrypt(value, out string valueIV);
						valueElement.SetAttribute(XmlNodeName.IV.ToString(), valueIV);
						skillElement.AppendChild(valueElement);

						statsRoot.AppendChild(skillElement);
					}
					catch (Exception ex)
					{
						sb.Append("\nRow " + row.Index + 1 + " of skills has the error: " + ex.Message);
					}
				}

				Queue<string> skills = new Queue<string>();
				Queue<string> skillsUpperCase = new Queue<string>();
				string[] skillsArray = skillsTextBox.Text.Split(',');
				foreach (string skill in skillsArray)
				{
					if (skillsUpperCase.Contains(skill.Trim().ToUpper()))
						continue;
					skills.Enqueue(skill.Trim());
					skillsUpperCase.Enqueue(skill.Trim().ToUpper());
				}

				XmlDocument skillsXmlDocutment = new XmlDocument();
				XmlElement skillsRoot = skillsXmlDocutment.CreateElement("Root");
				skillsXmlDocutment.AppendChild(skillsRoot);

				for (int i = 0; skills.Count > 0; ++i)
				{
					XmlElement skill = skillsXmlDocutment.CreateElement("Skill");
					skill.InnerText = EncryptionManager.Encrypt(skills.Dequeue(), out string IV);
					skill.SetAttribute(XmlNodeName.IV.ToString(), IV);
					skill.SetAttribute(XmlNodeName.INDEX.ToString(), i.ToString());
					skillsRoot.AppendChild(skill);
				}

				if (sb.Length > 0)
					throw new Exception(sb.ToString());

				FileManager.SaveXml(statsXmlDocument, FileType.QUICK_STAT, FileManager.quickStatsFileName);
				FileManager.SaveXml(skillsXmlDocutment, FileType.QUICK_STAT, FileManager.skillsFileName);

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
			if (e.ColumnIndex == 3 &&
				e.RowIndex > -1 &&
				!string.IsNullOrEmpty((string)mainDataGridView[2, e.RowIndex].Value))
				Clipboard.SetText((string)mainDataGridView[2, e.RowIndex].Value);
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			statusChanged = false;
			Close();
		}
	}
}
