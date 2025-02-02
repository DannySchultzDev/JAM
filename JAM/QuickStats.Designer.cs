namespace JAM
{
	partial class QuickStats
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
			mainTableLayout = new TableLayoutPanel();
			mainSplitContainer = new SplitContainer();
			mainDataGridView = new DataGridView();
			skillsTableLayoutPanel = new TableLayoutPanel();
			skillsLabel = new Label();
			skillsButton = new Button();
			skillsTextBox = new TextBox();
			saveButton = new Button();
			cancelButton = new Button();
			mainTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
			mainSplitContainer.Panel1.SuspendLayout();
			mainSplitContainer.Panel2.SuspendLayout();
			mainSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
			skillsTableLayoutPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayout
			// 
			mainTableLayout.ColumnCount = 2;
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayout.Controls.Add(mainSplitContainer, 0, 0);
			mainTableLayout.Controls.Add(saveButton, 0, 1);
			mainTableLayout.Controls.Add(cancelButton, 1, 1);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 2;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainTableLayout.Size = new Size(518, 714);
			mainTableLayout.TabIndex = 0;
			// 
			// mainSplitContainer
			// 
			mainSplitContainer.BorderStyle = BorderStyle.FixedSingle;
			mainTableLayout.SetColumnSpan(mainSplitContainer, 2);
			mainSplitContainer.Dock = DockStyle.Fill;
			mainSplitContainer.Location = new Point(3, 3);
			mainSplitContainer.Name = "mainSplitContainer";
			mainSplitContainer.Orientation = Orientation.Horizontal;
			// 
			// mainSplitContainer.Panel1
			// 
			mainSplitContainer.Panel1.Controls.Add(mainDataGridView);
			// 
			// mainSplitContainer.Panel2
			// 
			mainSplitContainer.Panel2.Controls.Add(skillsTableLayoutPanel);
			mainSplitContainer.Size = new Size(512, 658);
			mainSplitContainer.SplitterDistance = 329;
			mainSplitContainer.TabIndex = 0;
			// 
			// mainDataGridView
			// 
			mainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			mainDataGridView.BackgroundColor = SystemColors.Control;
			mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			mainDataGridView.Dock = DockStyle.Fill;
			mainDataGridView.Location = new Point(0, 0);
			mainDataGridView.Name = "mainDataGridView";
			mainDataGridView.RowHeadersWidth = 62;
			mainDataGridView.Size = new Size(510, 327);
			mainDataGridView.TabIndex = 0;
			mainDataGridView.CellContentClick += mainDataGridView_CellContentClick;
			mainDataGridView.CellPainting += mainDataGridView_CellPainting;
			mainDataGridView.CellValueChanged += mainDataGridView_CellValueChanged;
			mainDataGridView.RowsAdded += mainDataGridView_RowsAdded;
			mainDataGridView.RowsRemoved += mainDataGridView_RowsRemoved;
			// 
			// skillsTableLayoutPanel
			// 
			skillsTableLayoutPanel.ColumnCount = 2;
			skillsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			skillsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			skillsTableLayoutPanel.Controls.Add(skillsLabel, 0, 0);
			skillsTableLayoutPanel.Controls.Add(skillsButton, 1, 0);
			skillsTableLayoutPanel.Controls.Add(skillsTextBox, 0, 1);
			skillsTableLayoutPanel.Dock = DockStyle.Fill;
			skillsTableLayoutPanel.Location = new Point(0, 0);
			skillsTableLayoutPanel.Name = "skillsTableLayoutPanel";
			skillsTableLayoutPanel.RowCount = 2;
			skillsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			skillsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			skillsTableLayoutPanel.Size = new Size(510, 323);
			skillsTableLayoutPanel.TabIndex = 0;
			// 
			// skillsLabel
			// 
			skillsLabel.AutoSize = true;
			skillsLabel.Dock = DockStyle.Fill;
			skillsLabel.Location = new Point(3, 0);
			skillsLabel.Name = "skillsLabel";
			skillsLabel.Size = new Size(454, 40);
			skillsLabel.TabIndex = 0;
			skillsLabel.Text = "Skills:";
			// 
			// skillsButton
			// 
			skillsButton.Image = Properties.Resources.Copy;
			skillsButton.Location = new Point(463, 3);
			skillsButton.Name = "skillsButton";
			skillsButton.Size = new Size(44, 34);
			skillsButton.TabIndex = 1;
			skillsButton.UseVisualStyleBackColor = true;
			skillsButton.Click += skillsButton_Click;
			// 
			// skillsTextBox
			// 
			skillsTableLayoutPanel.SetColumnSpan(skillsTextBox, 2);
			skillsTextBox.Dock = DockStyle.Fill;
			skillsTextBox.Location = new Point(3, 43);
			skillsTextBox.Multiline = true;
			skillsTextBox.Name = "skillsTextBox";
			skillsTextBox.ScrollBars = ScrollBars.Vertical;
			skillsTextBox.Size = new Size(504, 277);
			skillsTextBox.TabIndex = 2;
			// 
			// saveButton
			// 
			saveButton.Dock = DockStyle.Fill;
			saveButton.Location = new Point(3, 667);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(253, 44);
			saveButton.TabIndex = 1;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Dock = DockStyle.Fill;
			cancelButton.Location = new Point(262, 667);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(253, 44);
			cancelButton.TabIndex = 2;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			// 
			// QuickStats
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(518, 714);
			Controls.Add(mainTableLayout);
			Name = "QuickStats";
			ShowIcon = false;
			Text = "Quick Stats";
			FormClosing += QuickStats_FormClosing;
			Load += QuickStats_Load;
			mainTableLayout.ResumeLayout(false);
			mainSplitContainer.Panel1.ResumeLayout(false);
			mainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
			mainSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
			skillsTableLayoutPanel.ResumeLayout(false);
			skillsTableLayoutPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayout;
		private SplitContainer mainSplitContainer;
		private DataGridView mainDataGridView;
		private TableLayoutPanel skillsTableLayoutPanel;
		private Label skillsLabel;
		private Button skillsButton;
		private TextBox skillsTextBox;
		private Button saveButton;
		private Button cancelButton;
	}
}