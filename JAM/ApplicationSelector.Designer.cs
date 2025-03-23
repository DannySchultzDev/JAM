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
	partial class ApplicationSelector
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSelector));
			mainSplitContainer = new SplitContainer();
			companiesTableLayoutPanel = new TableLayoutPanel();
			companiesLabel = new Label();
			companiesGrid = new DataGridView();
			applicationsTableLayoutPanel = new TableLayoutPanel();
			applicationsLayout = new Label();
			applicationsGrid = new DataGridView();
			statusStrip = new StatusStrip();
			lastUpdateLabel = new ToolStripStatusLabel();
			statusStripSpacer = new ToolStripStatusLabel();
			refreshButton = new ToolStripDropDownButton();
			mainToolStripContainer = new ToolStripContainer();
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
			mainSplitContainer.Panel1.SuspendLayout();
			mainSplitContainer.Panel2.SuspendLayout();
			mainSplitContainer.SuspendLayout();
			companiesTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)companiesGrid).BeginInit();
			applicationsTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)applicationsGrid).BeginInit();
			statusStrip.SuspendLayout();
			mainToolStripContainer.BottomToolStripPanel.SuspendLayout();
			mainToolStripContainer.ContentPanel.SuspendLayout();
			mainToolStripContainer.SuspendLayout();
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
			mainSplitContainer.Size = new Size(778, 687);
			mainSplitContainer.SplitterDistance = 343;
			mainSplitContainer.TabIndex = 0;
			mainSplitContainer.TabStop = false;
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
			companiesTableLayoutPanel.Size = new Size(778, 343);
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
			companiesGrid.MultiSelect = false;
			companiesGrid.Name = "companiesGrid";
			companiesGrid.ReadOnly = true;
			companiesGrid.RowHeadersWidth = 62;
			companiesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			companiesGrid.Size = new Size(772, 297);
			companiesGrid.TabIndex = 1;
			companiesGrid.CellContentClick += companiesGrid_CellContentClick;
			companiesGrid.CellPainting += companiesGrid_CellPainting;
			companiesGrid.SelectionChanged += companiesGrid_SelectionChanged;
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
			applicationsTableLayoutPanel.Size = new Size(778, 340);
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
			applicationsGrid.Size = new Size(772, 294);
			applicationsGrid.TabIndex = 2;
			applicationsGrid.CellContentClick += applicationsGrid_CellContentClick;
			applicationsGrid.CellPainting += applicationsGrid_CellPainting;
			// 
			// statusStrip
			// 
			statusStrip.Dock = DockStyle.None;
			statusStrip.ImageScalingSize = new Size(24, 24);
			statusStrip.Items.AddRange(new ToolStripItem[] { lastUpdateLabel, statusStripSpacer, refreshButton });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(778, 32);
			statusStrip.TabIndex = 3;
			statusStrip.Text = "statusStrip1";
			// 
			// lastUpdateLabel
			// 
			lastUpdateLabel.Name = "lastUpdateLabel";
			lastUpdateLabel.Size = new Size(110, 25);
			lastUpdateLabel.Text = "Last Update:";
			// 
			// statusStripSpacer
			// 
			statusStripSpacer.Name = "statusStripSpacer";
			statusStripSpacer.Size = new Size(555, 25);
			statusStripSpacer.Spring = true;
			// 
			// refreshButton
			// 
			refreshButton.BackColor = SystemColors.ButtonHighlight;
			refreshButton.Image = Properties.Resources.IntellisenseWarning;
			refreshButton.ImageTransparentColor = Color.Magenta;
			refreshButton.Name = "refreshButton";
			refreshButton.ShowDropDownArrow = false;
			refreshButton.Size = new Size(98, 29);
			refreshButton.Text = "Refresh";
			refreshButton.TextImageRelation = TextImageRelation.TextBeforeImage;
			refreshButton.Click += refreshButton_Click;
			// 
			// mainToolStripContainer
			// 
			// 
			// mainToolStripContainer.BottomToolStripPanel
			// 
			mainToolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// mainToolStripContainer.ContentPanel
			// 
			mainToolStripContainer.ContentPanel.Controls.Add(mainSplitContainer);
			mainToolStripContainer.ContentPanel.Size = new Size(778, 687);
			mainToolStripContainer.Dock = DockStyle.Fill;
			mainToolStripContainer.Location = new Point(0, 0);
			mainToolStripContainer.Name = "mainToolStripContainer";
			mainToolStripContainer.Size = new Size(778, 744);
			mainToolStripContainer.TabIndex = 2;
			mainToolStripContainer.Text = "toolStripContainer1";
			// 
			// ApplicationSelector
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(778, 744);
			Controls.Add(mainToolStripContainer);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ApplicationSelector";
			ShowIcon = false;
			Text = "Application Selector";
			FormClosing += ApplicationSelector_FormClosing;
			Load += ApplicationSelector_Load;
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
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			mainToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			mainToolStripContainer.BottomToolStripPanel.PerformLayout();
			mainToolStripContainer.ContentPanel.ResumeLayout(false);
			mainToolStripContainer.ResumeLayout(false);
			mainToolStripContainer.PerformLayout();
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
		private StatusStrip statusStrip;
		private ToolStripContainer mainToolStripContainer;
		private ToolStripStatusLabel lastUpdateLabel;
		private ToolStripDropDownButton refreshButton;
		private ToolStripStatusLabel statusStripSpacer;
	}
}