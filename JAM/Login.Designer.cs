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
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			mainTableLayout = new TableLayoutPanel();
			passwordLabel = new Label();
			passwordTextbox = new TextBox();
			passwordViewButton = new Button();
			loginButton = new Button();
			cancelButton = new Button();
			emailButton = new Button();
			mainTableLayout.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayout
			// 
			mainTableLayout.ColumnCount = 5;
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			mainTableLayout.Controls.Add(passwordLabel, 0, 0);
			mainTableLayout.Controls.Add(passwordTextbox, 1, 0);
			mainTableLayout.Controls.Add(passwordViewButton, 3, 0);
			mainTableLayout.Controls.Add(loginButton, 0, 1);
			mainTableLayout.Controls.Add(cancelButton, 2, 1);
			mainTableLayout.Controls.Add(emailButton, 4, 0);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 2;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.Size = new Size(423, 91);
			mainTableLayout.TabIndex = 0;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Dock = DockStyle.Fill;
			passwordLabel.Location = new Point(3, 0);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(94, 40);
			passwordLabel.TabIndex = 2;
			passwordLabel.Text = "Password:";
			// 
			// passwordTextbox
			// 
			mainTableLayout.SetColumnSpan(passwordTextbox, 2);
			passwordTextbox.Dock = DockStyle.Fill;
			passwordTextbox.Location = new Point(103, 3);
			passwordTextbox.Name = "passwordTextbox";
			passwordTextbox.PasswordChar = '•';
			passwordTextbox.Size = new Size(216, 31);
			passwordTextbox.TabIndex = 0;
			// 
			// passwordViewButton
			// 
			passwordViewButton.Dock = DockStyle.Fill;
			passwordViewButton.Image = Properties.Resources.Visible;
			passwordViewButton.Location = new Point(325, 3);
			passwordViewButton.Name = "passwordViewButton";
			passwordViewButton.Size = new Size(44, 34);
			passwordViewButton.TabIndex = 1;
			passwordViewButton.UseVisualStyleBackColor = true;
			passwordViewButton.Click += passwordViewButton_Click;
			// 
			// loginButton
			// 
			mainTableLayout.SetColumnSpan(loginButton, 2);
			loginButton.Dock = DockStyle.Fill;
			loginButton.Location = new Point(3, 43);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(205, 45);
			loginButton.TabIndex = 3;
			loginButton.Text = "Login";
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += loginButton_Click;
			// 
			// cancelButton
			// 
			mainTableLayout.SetColumnSpan(cancelButton, 3);
			cancelButton.Dock = DockStyle.Fill;
			cancelButton.Location = new Point(214, 43);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(206, 45);
			cancelButton.TabIndex = 4;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// emailButton
			// 
			emailButton.Dock = DockStyle.Fill;
			emailButton.Image = Properties.Resources.Message;
			emailButton.Location = new Point(375, 3);
			emailButton.Name = "emailButton";
			emailButton.Size = new Size(45, 34);
			emailButton.TabIndex = 2;
			emailButton.UseVisualStyleBackColor = true;
			emailButton.Click += emailButton_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(423, 91);
			Controls.Add(mainTableLayout);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			mainTableLayout.ResumeLayout(false);
			mainTableLayout.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayout;
		private Button loginButton;
		private Button cancelButton;
		private Label passwordLabel;
		private TextBox passwordTextbox;
		private Button passwordViewButton;
		private Button emailButton;
	}
}