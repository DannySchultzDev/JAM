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
	partial class Credits
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
			mainTableLayoutPanel = new TableLayoutPanel();
			creditsGroupBox = new GroupBox();
			creditsTextBox = new TextBox();
			toolsGroupBox = new GroupBox();
			toolsTextBox = new TextBox();
			licenseGroupBox = new GroupBox();
			licenseTextBox = new TextBox();
			doneButton = new Button();
			mainTableLayoutPanel.SuspendLayout();
			creditsGroupBox.SuspendLayout();
			toolsGroupBox.SuspendLayout();
			licenseGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			mainTableLayoutPanel.ColumnCount = 1;
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainTableLayoutPanel.Controls.Add(creditsGroupBox, 0, 0);
			mainTableLayoutPanel.Controls.Add(toolsGroupBox, 0, 1);
			mainTableLayoutPanel.Controls.Add(licenseGroupBox, 0, 2);
			mainTableLayoutPanel.Controls.Add(doneButton, 0, 3);
			mainTableLayoutPanel.Dock = DockStyle.Fill;
			mainTableLayoutPanel.Location = new Point(0, 0);
			mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			mainTableLayoutPanel.RowCount = 4;
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainTableLayoutPanel.Size = new Size(735, 602);
			mainTableLayoutPanel.TabIndex = 0;
			// 
			// creditsGroupBox
			// 
			creditsGroupBox.Controls.Add(creditsTextBox);
			creditsGroupBox.Dock = DockStyle.Fill;
			creditsGroupBox.Location = new Point(3, 3);
			creditsGroupBox.Name = "creditsGroupBox";
			creditsGroupBox.Size = new Size(729, 104);
			creditsGroupBox.TabIndex = 0;
			creditsGroupBox.TabStop = false;
			creditsGroupBox.Text = "Credits";
			// 
			// creditsTextBox
			// 
			creditsTextBox.Dock = DockStyle.Fill;
			creditsTextBox.Location = new Point(3, 27);
			creditsTextBox.Multiline = true;
			creditsTextBox.Name = "creditsTextBox";
			creditsTextBox.ReadOnly = true;
			creditsTextBox.ScrollBars = ScrollBars.Vertical;
			creditsTextBox.Size = new Size(723, 74);
			creditsTextBox.TabIndex = 0;
			creditsTextBox.Text = "Copyright © 2025 Wah Infinite: \r\nContribution: Development of JAM application.";
			// 
			// toolsGroupBox
			// 
			toolsGroupBox.Controls.Add(toolsTextBox);
			toolsGroupBox.Dock = DockStyle.Fill;
			toolsGroupBox.Location = new Point(3, 113);
			toolsGroupBox.Name = "toolsGroupBox";
			toolsGroupBox.Size = new Size(729, 159);
			toolsGroupBox.TabIndex = 1;
			toolsGroupBox.TabStop = false;
			toolsGroupBox.Text = "Tools Used";
			// 
			// toolsTextBox
			// 
			toolsTextBox.Dock = DockStyle.Fill;
			toolsTextBox.Location = new Point(3, 27);
			toolsTextBox.Multiline = true;
			toolsTextBox.Name = "toolsTextBox";
			toolsTextBox.ReadOnly = true;
			toolsTextBox.ScrollBars = ScrollBars.Vertical;
			toolsTextBox.Size = new Size(723, 129);
			toolsTextBox.TabIndex = 0;
			toolsTextBox.Text = "Windows Forms: A part of the .Net Framework. Winforms was used to create the GUI of this application.\r\nVisual Studio 2022 Image Library: Used to provide icons and imagery throughout the application.";
			// 
			// licenseGroupBox
			// 
			licenseGroupBox.Controls.Add(licenseTextBox);
			licenseGroupBox.Dock = DockStyle.Fill;
			licenseGroupBox.Location = new Point(3, 278);
			licenseGroupBox.Name = "licenseGroupBox";
			licenseGroupBox.Size = new Size(729, 270);
			licenseGroupBox.TabIndex = 2;
			licenseGroupBox.TabStop = false;
			licenseGroupBox.Text = "GPL V3 License:";
			// 
			// licenseTextBox
			// 
			licenseTextBox.Dock = DockStyle.Fill;
			licenseTextBox.Location = new Point(3, 27);
			licenseTextBox.Multiline = true;
			licenseTextBox.Name = "licenseTextBox";
			licenseTextBox.ReadOnly = true;
			licenseTextBox.ScrollBars = ScrollBars.Vertical;
			licenseTextBox.Size = new Size(723, 240);
			licenseTextBox.TabIndex = 0;
			licenseTextBox.Text = resources.GetString("licenseTextBox.Text");
			// 
			// doneButton
			// 
			doneButton.Dock = DockStyle.Fill;
			doneButton.Location = new Point(3, 554);
			doneButton.Name = "doneButton";
			doneButton.Size = new Size(729, 45);
			doneButton.TabIndex = 3;
			doneButton.Text = "Done";
			doneButton.UseVisualStyleBackColor = true;
			doneButton.Click += doneButton_Click;
			// 
			// Credits
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(735, 602);
			Controls.Add(mainTableLayoutPanel);
			Name = "Credits";
			ShowIcon = false;
			Text = "Credits";
			mainTableLayoutPanel.ResumeLayout(false);
			creditsGroupBox.ResumeLayout(false);
			creditsGroupBox.PerformLayout();
			toolsGroupBox.ResumeLayout(false);
			toolsGroupBox.PerformLayout();
			licenseGroupBox.ResumeLayout(false);
			licenseGroupBox.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayoutPanel;
		private GroupBox creditsGroupBox;
		private GroupBox toolsGroupBox;
		private GroupBox licenseGroupBox;
		private Button doneButton;
		private TextBox creditsTextBox;
		private TextBox toolsTextBox;
		private TextBox licenseTextBox;
	}
}