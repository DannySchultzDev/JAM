﻿/*
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
	partial class Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			mainTableLayout = new TableLayoutPanel();
			passwordLabel = new Label();
			passwordTextBox = new TextBox();
			passwordViewButton = new Button();
			emailLabel = new Label();
			emailTextBox = new TextBox();
			transferDataGroupBox = new GroupBox();
			transferDataTableLayout = new TableLayoutPanel();
			usePasswordCheckBox = new CheckBox();
			exportButton = new Button();
			importButton = new Button();
			doneButton = new Button();
			mainTableLayout.SuspendLayout();
			transferDataGroupBox.SuspendLayout();
			transferDataTableLayout.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayout
			// 
			mainTableLayout.ColumnCount = 3;
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			mainTableLayout.Controls.Add(passwordLabel, 0, 0);
			mainTableLayout.Controls.Add(passwordTextBox, 1, 0);
			mainTableLayout.Controls.Add(passwordViewButton, 2, 0);
			mainTableLayout.Controls.Add(emailLabel, 0, 1);
			mainTableLayout.Controls.Add(emailTextBox, 1, 1);
			mainTableLayout.Controls.Add(transferDataGroupBox, 0, 2);
			mainTableLayout.Controls.Add(doneButton, 0, 3);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 5;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainTableLayout.Size = new Size(471, 252);
			mainTableLayout.TabIndex = 0;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Dock = DockStyle.Fill;
			passwordLabel.Location = new Point(3, 0);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(144, 40);
			passwordLabel.TabIndex = 0;
			passwordLabel.Text = "Password:";
			// 
			// passwordTextBox
			// 
			passwordTextBox.Dock = DockStyle.Fill;
			passwordTextBox.Location = new Point(153, 3);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '•';
			passwordTextBox.Size = new Size(265, 31);
			passwordTextBox.TabIndex = 0;
			passwordTextBox.TextChanged += StatusChanged;
			// 
			// passwordViewButton
			// 
			passwordViewButton.Dock = DockStyle.Fill;
			passwordViewButton.Image = Properties.Resources.Visible;
			passwordViewButton.Location = new Point(424, 3);
			passwordViewButton.Name = "passwordViewButton";
			passwordViewButton.Size = new Size(44, 34);
			passwordViewButton.TabIndex = 1;
			passwordViewButton.UseVisualStyleBackColor = true;
			passwordViewButton.Click += passwordViewButton_Click;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Dock = DockStyle.Fill;
			emailLabel.Location = new Point(3, 40);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(144, 40);
			emailLabel.TabIndex = 3;
			emailLabel.Text = "Recovery Email:";
			// 
			// emailTextBox
			// 
			mainTableLayout.SetColumnSpan(emailTextBox, 2);
			emailTextBox.Dock = DockStyle.Fill;
			emailTextBox.Location = new Point(153, 43);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(315, 31);
			emailTextBox.TabIndex = 2;
			// 
			// transferDataGroupBox
			// 
			mainTableLayout.SetColumnSpan(transferDataGroupBox, 3);
			transferDataGroupBox.Controls.Add(transferDataTableLayout);
			transferDataGroupBox.Dock = DockStyle.Fill;
			transferDataGroupBox.Location = new Point(3, 83);
			transferDataGroupBox.Name = "transferDataGroupBox";
			transferDataGroupBox.Size = new Size(465, 114);
			transferDataGroupBox.TabIndex = 5;
			transferDataGroupBox.TabStop = false;
			transferDataGroupBox.Text = "Transfer Data";
			// 
			// transferDataTableLayout
			// 
			transferDataTableLayout.ColumnCount = 2;
			transferDataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			transferDataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			transferDataTableLayout.Controls.Add(usePasswordCheckBox, 0, 0);
			transferDataTableLayout.Controls.Add(exportButton, 0, 1);
			transferDataTableLayout.Controls.Add(importButton, 1, 1);
			transferDataTableLayout.Dock = DockStyle.Fill;
			transferDataTableLayout.Location = new Point(3, 27);
			transferDataTableLayout.Name = "transferDataTableLayout";
			transferDataTableLayout.RowCount = 2;
			transferDataTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			transferDataTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			transferDataTableLayout.Size = new Size(459, 84);
			transferDataTableLayout.TabIndex = 0;
			// 
			// usePasswordCheckBox
			// 
			usePasswordCheckBox.AutoSize = true;
			transferDataTableLayout.SetColumnSpan(usePasswordCheckBox, 2);
			usePasswordCheckBox.Dock = DockStyle.Fill;
			usePasswordCheckBox.Location = new Point(3, 3);
			usePasswordCheckBox.Name = "usePasswordCheckBox";
			usePasswordCheckBox.Size = new Size(453, 36);
			usePasswordCheckBox.TabIndex = 3;
			usePasswordCheckBox.Text = "Use password to encrypt data?";
			usePasswordCheckBox.UseVisualStyleBackColor = true;
			// 
			// exportButton
			// 
			exportButton.Dock = DockStyle.Fill;
			exportButton.Location = new Point(3, 45);
			exportButton.Name = "exportButton";
			exportButton.Size = new Size(223, 36);
			exportButton.TabIndex = 4;
			exportButton.Text = "Export Data";
			exportButton.UseVisualStyleBackColor = true;
			exportButton.Click += exportButton_Click;
			// 
			// importButton
			// 
			importButton.Dock = DockStyle.Fill;
			importButton.Location = new Point(232, 45);
			importButton.Name = "importButton";
			importButton.Size = new Size(224, 36);
			importButton.TabIndex = 5;
			importButton.Text = "Import Data";
			importButton.UseVisualStyleBackColor = true;
			importButton.Click += importButton_Click;
			// 
			// doneButton
			// 
			mainTableLayout.SetColumnSpan(doneButton, 3);
			doneButton.Dock = DockStyle.Fill;
			doneButton.Location = new Point(3, 203);
			doneButton.Name = "doneButton";
			doneButton.Size = new Size(465, 44);
			doneButton.TabIndex = 6;
			doneButton.Text = "Done";
			doneButton.UseVisualStyleBackColor = true;
			doneButton.Click += doneButton_Click;
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(471, 252);
			Controls.Add(mainTableLayout);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Settings";
			ShowIcon = false;
			Text = "Settings";
			FormClosing += Settings_FormClosing;
			Load += Settings_Load;
			mainTableLayout.ResumeLayout(false);
			mainTableLayout.PerformLayout();
			transferDataGroupBox.ResumeLayout(false);
			transferDataTableLayout.ResumeLayout(false);
			transferDataTableLayout.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayout;
		private Label passwordLabel;
		private TextBox passwordTextBox;
		private Button passwordViewButton;
		private Label emailLabel;
		private TextBox emailTextBox;
		private GroupBox transferDataGroupBox;
		private TableLayoutPanel transferDataTableLayout;
		private CheckBox usePasswordCheckBox;
		private Button exportButton;
		private Button importButton;
		private Button doneButton;
	}
}