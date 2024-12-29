namespace JAM
{
	partial class ApplicationViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			mainSplitContainer = new SplitContainer();
			companiesTableLayoutPanel = new TableLayoutPanel();
			companiesLabel = new Label();
			companiesGrid = new DataGridView();
			applicationsTableLayoutPanel = new TableLayoutPanel();
			applicationsLayout = new Label();
			applicationsGrid = new DataGridView();
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
			mainSplitContainer.Panel1.SuspendLayout();
			mainSplitContainer.Panel2.SuspendLayout();
			mainSplitContainer.SuspendLayout();
			companiesTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)companiesGrid).BeginInit();
			applicationsTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)applicationsGrid).BeginInit();
			SuspendLayout();
			// 
			// mainSplitContainer
			// 
			mainSplitContainer.Dock = DockStyle.Fill;
			mainSplitContainer.Location = new Point(0, 0);
			mainSplitContainer.Name = "mainSplitContainer";
			mainSplitContainer.Orientation = Orientation.Horizontal;
			// 
			// mainSplitContainer.Panel1
			// 
			mainSplitContainer.Panel1.Controls.Add(companiesTableLayoutPanel);
			// 
			// mainSplitContainer.Panel2
			// 
			mainSplitContainer.Panel2.Controls.Add(applicationsTableLayoutPanel);
			mainSplitContainer.Size = new Size(778, 744);
			mainSplitContainer.SplitterDistance = 372;
			mainSplitContainer.TabIndex = 0;
			// 
			// companiesTableLayoutPanel
			// 
			companiesTableLayoutPanel.ColumnCount = 1;
			companiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			companiesTableLayoutPanel.Controls.Add(companiesLabel, 0, 0);
			companiesTableLayoutPanel.Controls.Add(companiesGrid, 0, 1);
			companiesTableLayoutPanel.Dock = DockStyle.Fill;
			companiesTableLayoutPanel.Location = new Point(0, 0);
			companiesTableLayoutPanel.Name = "companiesTableLayoutPanel";
			companiesTableLayoutPanel.RowCount = 2;
			companiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			companiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			companiesTableLayoutPanel.Size = new Size(778, 372);
			companiesTableLayoutPanel.TabIndex = 0;
			// 
			// companiesLabel
			// 
			companiesLabel.AutoSize = true;
			companiesLabel.Dock = DockStyle.Fill;
			companiesLabel.Location = new Point(3, 0);
			companiesLabel.Name = "companiesLabel";
			companiesLabel.Size = new Size(772, 40);
			companiesLabel.TabIndex = 0;
			companiesLabel.Text = "Companies:";
			// 
			// companiesGrid
			// 
			companiesGrid.AllowUserToAddRows = false;
			companiesGrid.AllowUserToDeleteRows = false;
			companiesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			companiesGrid.BackgroundColor = SystemColors.Control;
			companiesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			companiesGrid.Dock = DockStyle.Fill;
			companiesGrid.Location = new Point(3, 43);
			companiesGrid.Name = "companiesGrid";
			companiesGrid.ReadOnly = true;
			companiesGrid.RowHeadersWidth = 62;
			companiesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			companiesGrid.Size = new Size(772, 326);
			companiesGrid.TabIndex = 1;
			companiesGrid.CellPainting += companiesGrid_CellPainting;
			// 
			// applicationsTableLayoutPanel
			// 
			applicationsTableLayoutPanel.ColumnCount = 1;
			applicationsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			applicationsTableLayoutPanel.Controls.Add(applicationsLayout, 0, 0);
			applicationsTableLayoutPanel.Controls.Add(applicationsGrid, 0, 1);
			applicationsTableLayoutPanel.Dock = DockStyle.Fill;
			applicationsTableLayoutPanel.Location = new Point(0, 0);
			applicationsTableLayoutPanel.Name = "applicationsTableLayoutPanel";
			applicationsTableLayoutPanel.RowCount = 2;
			applicationsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			applicationsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			applicationsTableLayoutPanel.Size = new Size(778, 368);
			applicationsTableLayoutPanel.TabIndex = 1;
			// 
			// applicationsLayout
			// 
			applicationsLayout.AutoSize = true;
			applicationsLayout.Dock = DockStyle.Fill;
			applicationsLayout.Location = new Point(3, 0);
			applicationsLayout.Name = "applicationsLayout";
			applicationsLayout.Size = new Size(772, 40);
			applicationsLayout.TabIndex = 0;
			applicationsLayout.Text = "Applications:";
			// 
			// applicationsGrid
			// 
			applicationsGrid.AllowUserToAddRows = false;
			applicationsGrid.AllowUserToDeleteRows = false;
			applicationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			applicationsGrid.BackgroundColor = SystemColors.Control;
			applicationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			applicationsGrid.Dock = DockStyle.Fill;
			applicationsGrid.Location = new Point(3, 43);
			applicationsGrid.Name = "applicationsGrid";
			applicationsGrid.ReadOnly = true;
			applicationsGrid.RowHeadersWidth = 62;
			applicationsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			applicationsGrid.Size = new Size(772, 322);
			applicationsGrid.TabIndex = 1;
			// 
			// ApplicationViewer
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(778, 744);
			Controls.Add(mainSplitContainer);
			Name = "ApplicationViewer";
			ShowIcon = false;
			Text = "Application Viewer";
			Load += ApplicationViewer_Load;
			mainSplitContainer.Panel1.ResumeLayout(false);
			mainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
			mainSplitContainer.ResumeLayout(false);
			companiesTableLayoutPanel.ResumeLayout(false);
			companiesTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)companiesGrid).EndInit();
			applicationsTableLayoutPanel.ResumeLayout(false);
			applicationsTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)applicationsGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer mainSplitContainer;
		private TableLayoutPanel companiesTableLayoutPanel;
		private Label companiesLabel;
		private DataGridView companiesGrid;
		private TableLayoutPanel applicationsTableLayoutPanel;
		private Label applicationsLayout;
		private DataGridView applicationsGrid;
	}
}