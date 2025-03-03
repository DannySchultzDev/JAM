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
	partial class PasswordRecovery
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecovery));
			tableLayoutPanel1 = new TableLayoutPanel();
			disclamerLabel = new Label();
			linkLabel = new LinkLabel();
			passwordTextBox = new TextBox();
			doneButton = new Button();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(disclamerLabel, 0, 0);
			tableLayoutPanel1.Controls.Add(linkLabel, 0, 1);
			tableLayoutPanel1.Controls.Add(passwordTextBox, 0, 2);
			tableLayoutPanel1.Controls.Add(doneButton, 0, 3);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(583, 340);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// disclamerLabel
			// 
			disclamerLabel.AutoSize = true;
			disclamerLabel.Dock = DockStyle.Fill;
			disclamerLabel.Location = new Point(3, 0);
			disclamerLabel.Name = "disclamerLabel";
			disclamerLabel.Size = new Size(577, 210);
			disclamerLabel.TabIndex = 0;
			disclamerLabel.Text = resources.GetString("disclamerLabel.Text");
			// 
			// linkLabel
			// 
			linkLabel.AutoSize = true;
			linkLabel.Dock = DockStyle.Fill;
			linkLabel.Location = new Point(3, 210);
			linkLabel.Name = "linkLabel";
			linkLabel.Size = new Size(577, 40);
			linkLabel.TabIndex = 1;
			linkLabel.TabStop = true;
			linkLabel.Text = "Gmail App Password Creator";
			linkLabel.LinkClicked += LinkClicked;
			// 
			// passwordTextBox
			// 
			passwordTextBox.Dock = DockStyle.Fill;
			passwordTextBox.Location = new Point(3, 253);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(577, 31);
			passwordTextBox.TabIndex = 2;
			// 
			// doneButton
			// 
			doneButton.Dock = DockStyle.Fill;
			doneButton.Location = new Point(3, 293);
			doneButton.Name = "doneButton";
			doneButton.Size = new Size(577, 44);
			doneButton.TabIndex = 3;
			doneButton.Text = "Done";
			doneButton.UseVisualStyleBackColor = true;
			doneButton.Click += doneButton_Click;
			// 
			// PasswordRecovery
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(583, 340);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "PasswordRecovery";
			ShowIcon = false;
			Text = "Enter Email Password";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label disclamerLabel;
		private LinkLabel linkLabel;
		private TextBox passwordTextBox;
		private Button doneButton;
	}
}