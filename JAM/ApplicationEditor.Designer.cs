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
	partial class ApplicationEditor
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationEditor));
			mainTableLayout = new TableLayoutPanel();
			mainTabControl = new TabControl();
			companyTabPage = new TabPage();
			companyTableLayout = new TableLayoutPanel();
			reuseCompanyCheckBox = new CheckBox();
			reuseCompanyComboBox = new ComboBox();
			viewCompanyButton = new Button();
			newCompanyGroupBox = new GroupBox();
			newCompanyTableLayout = new TableLayoutPanel();
			companyNameLabel = new Label();
			companyNameTextBox = new TextBox();
			companyWebsiteLabel = new Label();
			companyWebsiteTextBox = new TextBox();
			companyCareersWebsiteLabel = new Label();
			companyCareersWebsiteTextBox = new TextBox();
			companyCareersHomeLabel = new Label();
			companyCareersHomeTextBox = new TextBox();
			companyEmailLabel = new Label();
			companyEmailTextBox = new TextBox();
			companyPasswordLabel = new Label();
			companyPasswordTextBox = new TextBox();
			companyPasswordViewButton = new Button();
			companyInfoLabel = new Label();
			companyInfoTextBox = new TextBox();
			applicationTabPage = new TabPage();
			applicationTableLayout = new TableLayoutPanel();
			applicationPositionLabel = new Label();
			applicationPositionTextBox = new TextBox();
			applicationLinkLabel = new Label();
			applicationLinkTextBox = new TextBox();
			applicationTypeLabel = new Label();
			applicationTypeComboBox = new ComboBox();
			applicationTypeOtherLabel = new Label();
			applicationTypeOtherTextBox = new TextBox();
			applicationLocationLabel = new Label();
			applicationLocationTextBox = new TextBox();
			applicationSalaryLabel = new Label();
			applicationSalaryTextBox = new TextBox();
			applicationImageLabel = new Label();
			applicationImagePasteButton = new Button();
			applicationImageUploadButton = new Button();
			applicationImageDeleteButton = new Button();
			applicationImageClearButton = new Button();
			applicationImageFlowLayout = new FlowLayoutPanel();
			applicationResumeLabel = new Label();
			applicationResumeComboBox = new ComboBox();
			applicationResumeOpenButton = new Button();
			applicationResumeUploadButton = new Button();
			applicationCoverLetterLabel = new Label();
			applicationCoverLetterTextBox = new TextBox();
			applicationCoverLetterOpenButton = new Button();
			applicationCoverLetterUploadButton = new Button();
			applicationCoverLetterDeleteButton = new Button();
			applicationInfoLabel = new Label();
			applicationInfoTextBox = new TextBox();
			augmentationsTabPage = new TabPage();
			augmentationsTableLayout = new TableLayoutPanel();
			augmentCompanylabel = new Label();
			augmentCompanyComboBox = new ComboBox();
			augmentCreationTimeLabel = new Label();
			augmentCreationTimeDateTimePicker = new DateTimePicker();
			augmentStatusLabel = new Label();
			augmentStatusComboBox = new ComboBox();
			augmentStatusOtherLabel = new Label();
			augmentStatusOtherTextBox = new TextBox();
			augmentStatusTimeLabel = new Label();
			augmentStatusTimeDateTimePicker = new DateTimePicker();
			saveButton = new Button();
			cancelButton = new Button();
			applicationImageContextMenu = new ContextMenuStrip(components);
			viewImageToolStripMenuItem = new ToolStripMenuItem();
			removeImageToolStripMenuItem = new ToolStripMenuItem();
			mainTableLayout.SuspendLayout();
			mainTabControl.SuspendLayout();
			companyTabPage.SuspendLayout();
			companyTableLayout.SuspendLayout();
			newCompanyGroupBox.SuspendLayout();
			newCompanyTableLayout.SuspendLayout();
			applicationTabPage.SuspendLayout();
			applicationTableLayout.SuspendLayout();
			augmentationsTabPage.SuspendLayout();
			augmentationsTableLayout.SuspendLayout();
			applicationImageContextMenu.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayout
			// 
			mainTableLayout.ColumnCount = 2;
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			mainTableLayout.Controls.Add(mainTabControl, 0, 0);
			mainTableLayout.Controls.Add(saveButton, 0, 1);
			mainTableLayout.Controls.Add(cancelButton, 1, 1);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 2;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainTableLayout.Size = new Size(981, 737);
			mainTableLayout.TabIndex = 0;
			// 
			// mainTabControl
			// 
			mainTableLayout.SetColumnSpan(mainTabControl, 2);
			mainTabControl.Controls.Add(companyTabPage);
			mainTabControl.Controls.Add(applicationTabPage);
			mainTabControl.Controls.Add(augmentationsTabPage);
			mainTabControl.Dock = DockStyle.Fill;
			mainTabControl.Location = new Point(3, 3);
			mainTabControl.Name = "mainTabControl";
			mainTabControl.SelectedIndex = 0;
			mainTabControl.Size = new Size(975, 681);
			mainTabControl.TabIndex = 0;
			// 
			// companyTabPage
			// 
			companyTabPage.Controls.Add(companyTableLayout);
			companyTabPage.Location = new Point(4, 34);
			companyTabPage.Name = "companyTabPage";
			companyTabPage.Padding = new Padding(3);
			companyTabPage.Size = new Size(967, 643);
			companyTabPage.TabIndex = 0;
			companyTabPage.Text = "Company";
			companyTabPage.UseVisualStyleBackColor = true;
			// 
			// companyTableLayout
			// 
			companyTableLayout.ColumnCount = 3;
			companyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			companyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			companyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			companyTableLayout.Controls.Add(reuseCompanyCheckBox, 0, 0);
			companyTableLayout.Controls.Add(reuseCompanyComboBox, 1, 0);
			companyTableLayout.Controls.Add(viewCompanyButton, 2, 0);
			companyTableLayout.Controls.Add(newCompanyGroupBox, 0, 1);
			companyTableLayout.Dock = DockStyle.Fill;
			companyTableLayout.Location = new Point(3, 3);
			companyTableLayout.Name = "companyTableLayout";
			companyTableLayout.RowCount = 2;
			companyTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			companyTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			companyTableLayout.Size = new Size(961, 637);
			companyTableLayout.TabIndex = 0;
			// 
			// reuseCompanyCheckBox
			// 
			reuseCompanyCheckBox.AutoSize = true;
			reuseCompanyCheckBox.CheckAlign = ContentAlignment.TopLeft;
			reuseCompanyCheckBox.Dock = DockStyle.Fill;
			reuseCompanyCheckBox.Location = new Point(3, 3);
			reuseCompanyCheckBox.Name = "reuseCompanyCheckBox";
			reuseCompanyCheckBox.Size = new Size(194, 44);
			reuseCompanyCheckBox.TabIndex = 1;
			reuseCompanyCheckBox.Text = "Reuse Company:";
			reuseCompanyCheckBox.TextAlign = ContentAlignment.TopLeft;
			reuseCompanyCheckBox.UseVisualStyleBackColor = true;
			reuseCompanyCheckBox.CheckedChanged += reuseCompanyCheckBox_CheckedChanged;
			// 
			// reuseCompanyComboBox
			// 
			reuseCompanyComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			reuseCompanyComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			reuseCompanyComboBox.Dock = DockStyle.Fill;
			reuseCompanyComboBox.Enabled = false;
			reuseCompanyComboBox.FormattingEnabled = true;
			reuseCompanyComboBox.Location = new Point(203, 3);
			reuseCompanyComboBox.Name = "reuseCompanyComboBox";
			reuseCompanyComboBox.Size = new Size(705, 33);
			reuseCompanyComboBox.TabIndex = 2;
			reuseCompanyComboBox.TextUpdate += StatusUpdated;
			// 
			// viewCompanyButton
			// 
			viewCompanyButton.Dock = DockStyle.Fill;
			viewCompanyButton.Enabled = false;
			viewCompanyButton.Image = Properties.Resources.Open;
			viewCompanyButton.Location = new Point(914, 3);
			viewCompanyButton.Name = "viewCompanyButton";
			viewCompanyButton.Size = new Size(44, 44);
			viewCompanyButton.TabIndex = 3;
			viewCompanyButton.UseVisualStyleBackColor = true;
			viewCompanyButton.Click += viewCompanyButton_Click;
			// 
			// newCompanyGroupBox
			// 
			companyTableLayout.SetColumnSpan(newCompanyGroupBox, 3);
			newCompanyGroupBox.Controls.Add(newCompanyTableLayout);
			newCompanyGroupBox.Dock = DockStyle.Fill;
			newCompanyGroupBox.Location = new Point(3, 53);
			newCompanyGroupBox.Name = "newCompanyGroupBox";
			newCompanyGroupBox.Size = new Size(955, 581);
			newCompanyGroupBox.TabIndex = 2;
			newCompanyGroupBox.TabStop = false;
			newCompanyGroupBox.Text = "New Company";
			// 
			// newCompanyTableLayout
			// 
			newCompanyTableLayout.ColumnCount = 5;
			newCompanyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			newCompanyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			newCompanyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			newCompanyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			newCompanyTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			newCompanyTableLayout.Controls.Add(companyNameLabel, 0, 0);
			newCompanyTableLayout.Controls.Add(companyNameTextBox, 1, 0);
			newCompanyTableLayout.Controls.Add(companyWebsiteLabel, 2, 0);
			newCompanyTableLayout.Controls.Add(companyWebsiteTextBox, 3, 0);
			newCompanyTableLayout.Controls.Add(companyCareersWebsiteLabel, 0, 1);
			newCompanyTableLayout.Controls.Add(companyCareersWebsiteTextBox, 1, 1);
			newCompanyTableLayout.Controls.Add(companyCareersHomeLabel, 2, 1);
			newCompanyTableLayout.Controls.Add(companyCareersHomeTextBox, 3, 1);
			newCompanyTableLayout.Controls.Add(companyEmailLabel, 0, 2);
			newCompanyTableLayout.Controls.Add(companyEmailTextBox, 1, 2);
			newCompanyTableLayout.Controls.Add(companyPasswordLabel, 2, 2);
			newCompanyTableLayout.Controls.Add(companyPasswordTextBox, 3, 2);
			newCompanyTableLayout.Controls.Add(companyPasswordViewButton, 4, 2);
			newCompanyTableLayout.Controls.Add(companyInfoLabel, 0, 3);
			newCompanyTableLayout.Controls.Add(companyInfoTextBox, 1, 3);
			newCompanyTableLayout.Dock = DockStyle.Fill;
			newCompanyTableLayout.Location = new Point(3, 27);
			newCompanyTableLayout.Name = "newCompanyTableLayout";
			newCompanyTableLayout.RowCount = 4;
			newCompanyTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			newCompanyTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
			newCompanyTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			newCompanyTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			newCompanyTableLayout.Size = new Size(949, 551);
			newCompanyTableLayout.TabIndex = 0;
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Dock = DockStyle.Fill;
			companyNameLabel.Location = new Point(3, 0);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new Size(94, 50);
			companyNameLabel.TabIndex = 0;
			companyNameLabel.Text = "Name:";
			// 
			// companyNameTextBox
			// 
			companyNameTextBox.Dock = DockStyle.Fill;
			companyNameTextBox.Location = new Point(103, 3);
			companyNameTextBox.Name = "companyNameTextBox";
			companyNameTextBox.Size = new Size(343, 31);
			companyNameTextBox.TabIndex = 4;
			companyNameTextBox.TextChanged += StatusUpdated;
			// 
			// companyWebsiteLabel
			// 
			companyWebsiteLabel.AutoSize = true;
			companyWebsiteLabel.Dock = DockStyle.Fill;
			companyWebsiteLabel.Location = new Point(452, 0);
			companyWebsiteLabel.Name = "companyWebsiteLabel";
			companyWebsiteLabel.Size = new Size(94, 50);
			companyWebsiteLabel.TabIndex = 1;
			companyWebsiteLabel.Text = "Website:";
			// 
			// companyWebsiteTextBox
			// 
			newCompanyTableLayout.SetColumnSpan(companyWebsiteTextBox, 2);
			companyWebsiteTextBox.Dock = DockStyle.Fill;
			companyWebsiteTextBox.Location = new Point(552, 3);
			companyWebsiteTextBox.Name = "companyWebsiteTextBox";
			companyWebsiteTextBox.Size = new Size(394, 31);
			companyWebsiteTextBox.TabIndex = 5;
			companyWebsiteTextBox.TextChanged += StatusUpdated;
			// 
			// companyCareersWebsiteLabel
			// 
			companyCareersWebsiteLabel.AutoSize = true;
			companyCareersWebsiteLabel.Dock = DockStyle.Fill;
			companyCareersWebsiteLabel.Location = new Point(3, 50);
			companyCareersWebsiteLabel.Name = "companyCareersWebsiteLabel";
			companyCareersWebsiteLabel.Size = new Size(94, 70);
			companyCareersWebsiteLabel.TabIndex = 2;
			companyCareersWebsiteLabel.Text = "Career Website:";
			// 
			// companyCareersWebsiteTextBox
			// 
			companyCareersWebsiteTextBox.Dock = DockStyle.Fill;
			companyCareersWebsiteTextBox.Location = new Point(103, 53);
			companyCareersWebsiteTextBox.Name = "companyCareersWebsiteTextBox";
			companyCareersWebsiteTextBox.Size = new Size(343, 31);
			companyCareersWebsiteTextBox.TabIndex = 6;
			companyCareersWebsiteTextBox.TextChanged += StatusUpdated;
			// 
			// companyCareersHomeLabel
			// 
			companyCareersHomeLabel.AutoSize = true;
			companyCareersHomeLabel.Dock = DockStyle.Fill;
			companyCareersHomeLabel.Location = new Point(452, 50);
			companyCareersHomeLabel.Name = "companyCareersHomeLabel";
			companyCareersHomeLabel.Size = new Size(94, 70);
			companyCareersHomeLabel.TabIndex = 3;
			companyCareersHomeLabel.Text = "Career Home:";
			// 
			// companyCareersHomeTextBox
			// 
			newCompanyTableLayout.SetColumnSpan(companyCareersHomeTextBox, 2);
			companyCareersHomeTextBox.Dock = DockStyle.Fill;
			companyCareersHomeTextBox.Location = new Point(552, 53);
			companyCareersHomeTextBox.Name = "companyCareersHomeTextBox";
			companyCareersHomeTextBox.Size = new Size(394, 31);
			companyCareersHomeTextBox.TabIndex = 7;
			companyCareersHomeTextBox.TextChanged += StatusUpdated;
			// 
			// companyEmailLabel
			// 
			companyEmailLabel.AutoSize = true;
			companyEmailLabel.Dock = DockStyle.Fill;
			companyEmailLabel.Location = new Point(3, 120);
			companyEmailLabel.Name = "companyEmailLabel";
			companyEmailLabel.Size = new Size(94, 50);
			companyEmailLabel.TabIndex = 4;
			companyEmailLabel.Text = "Email:";
			// 
			// companyEmailTextBox
			// 
			companyEmailTextBox.Dock = DockStyle.Fill;
			companyEmailTextBox.Location = new Point(103, 123);
			companyEmailTextBox.Name = "companyEmailTextBox";
			companyEmailTextBox.Size = new Size(343, 31);
			companyEmailTextBox.TabIndex = 8;
			companyEmailTextBox.TextChanged += StatusUpdated;
			// 
			// companyPasswordLabel
			// 
			companyPasswordLabel.AutoSize = true;
			companyPasswordLabel.Dock = DockStyle.Fill;
			companyPasswordLabel.Location = new Point(452, 120);
			companyPasswordLabel.Name = "companyPasswordLabel";
			companyPasswordLabel.Size = new Size(94, 50);
			companyPasswordLabel.TabIndex = 5;
			companyPasswordLabel.Text = "Password:";
			// 
			// companyPasswordTextBox
			// 
			companyPasswordTextBox.Dock = DockStyle.Fill;
			companyPasswordTextBox.Location = new Point(552, 123);
			companyPasswordTextBox.Name = "companyPasswordTextBox";
			companyPasswordTextBox.PasswordChar = '•';
			companyPasswordTextBox.Size = new Size(343, 31);
			companyPasswordTextBox.TabIndex = 9;
			companyPasswordTextBox.TextChanged += StatusUpdated;
			// 
			// companyPasswordViewButton
			// 
			companyPasswordViewButton.Dock = DockStyle.Fill;
			companyPasswordViewButton.Image = Properties.Resources.Visible;
			companyPasswordViewButton.Location = new Point(901, 123);
			companyPasswordViewButton.Name = "companyPasswordViewButton";
			companyPasswordViewButton.Size = new Size(45, 44);
			companyPasswordViewButton.TabIndex = 10;
			companyPasswordViewButton.UseVisualStyleBackColor = true;
			companyPasswordViewButton.Click += companyPasswordViewButton_Click;
			// 
			// companyInfoLabel
			// 
			companyInfoLabel.AutoSize = true;
			companyInfoLabel.Dock = DockStyle.Fill;
			companyInfoLabel.Location = new Point(3, 170);
			companyInfoLabel.Name = "companyInfoLabel";
			companyInfoLabel.Size = new Size(94, 381);
			companyInfoLabel.TabIndex = 6;
			companyInfoLabel.Text = "Info:";
			// 
			// companyInfoTextBox
			// 
			newCompanyTableLayout.SetColumnSpan(companyInfoTextBox, 4);
			companyInfoTextBox.Dock = DockStyle.Fill;
			companyInfoTextBox.Location = new Point(103, 173);
			companyInfoTextBox.Multiline = true;
			companyInfoTextBox.Name = "companyInfoTextBox";
			companyInfoTextBox.ScrollBars = ScrollBars.Vertical;
			companyInfoTextBox.Size = new Size(843, 375);
			companyInfoTextBox.TabIndex = 11;
			companyInfoTextBox.TextChanged += StatusUpdated;
			// 
			// applicationTabPage
			// 
			applicationTabPage.Controls.Add(applicationTableLayout);
			applicationTabPage.Location = new Point(4, 34);
			applicationTabPage.Name = "applicationTabPage";
			applicationTabPage.Padding = new Padding(3);
			applicationTabPage.Size = new Size(967, 643);
			applicationTabPage.TabIndex = 1;
			applicationTabPage.Text = "Application";
			applicationTabPage.UseVisualStyleBackColor = true;
			// 
			// applicationTableLayout
			// 
			applicationTableLayout.ColumnCount = 16;
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.Controls.Add(applicationPositionLabel, 0, 0);
			applicationTableLayout.Controls.Add(applicationPositionTextBox, 3, 0);
			applicationTableLayout.Controls.Add(applicationLinkLabel, 0, 1);
			applicationTableLayout.Controls.Add(applicationLinkTextBox, 3, 1);
			applicationTableLayout.Controls.Add(applicationTypeLabel, 0, 2);
			applicationTableLayout.Controls.Add(applicationTypeComboBox, 3, 2);
			applicationTableLayout.Controls.Add(applicationTypeOtherLabel, 0, 3);
			applicationTableLayout.Controls.Add(applicationTypeOtherTextBox, 3, 3);
			applicationTableLayout.Controls.Add(applicationLocationLabel, 0, 4);
			applicationTableLayout.Controls.Add(applicationLocationTextBox, 3, 4);
			applicationTableLayout.Controls.Add(applicationSalaryLabel, 0, 5);
			applicationTableLayout.Controls.Add(applicationSalaryTextBox, 3, 5);
			applicationTableLayout.Controls.Add(applicationImageLabel, 7, 0);
			applicationTableLayout.Controls.Add(applicationImagePasteButton, 12, 0);
			applicationTableLayout.Controls.Add(applicationImageUploadButton, 13, 0);
			applicationTableLayout.Controls.Add(applicationImageDeleteButton, 14, 0);
			applicationTableLayout.Controls.Add(applicationImageClearButton, 15, 0);
			applicationTableLayout.Controls.Add(applicationImageFlowLayout, 11, 1);
			applicationTableLayout.Controls.Add(applicationResumeLabel, 0, 6);
			applicationTableLayout.Controls.Add(applicationResumeComboBox, 3, 6);
			applicationTableLayout.Controls.Add(applicationResumeOpenButton, 8, 6);
			applicationTableLayout.Controls.Add(applicationResumeUploadButton, 9, 6);
			applicationTableLayout.Controls.Add(applicationCoverLetterLabel, 0, 7);
			applicationTableLayout.Controls.Add(applicationCoverLetterTextBox, 3, 7);
			applicationTableLayout.Controls.Add(applicationCoverLetterOpenButton, 8, 7);
			applicationTableLayout.Controls.Add(applicationCoverLetterUploadButton, 9, 7);
			applicationTableLayout.Controls.Add(applicationCoverLetterDeleteButton, 10, 7);
			applicationTableLayout.Controls.Add(applicationInfoLabel, 0, 8);
			applicationTableLayout.Controls.Add(applicationInfoTextBox, 3, 8);
			applicationTableLayout.Dock = DockStyle.Fill;
			applicationTableLayout.Location = new Point(3, 3);
			applicationTableLayout.Name = "applicationTableLayout";
			applicationTableLayout.RowCount = 9;
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			applicationTableLayout.Size = new Size(961, 637);
			applicationTableLayout.TabIndex = 0;
			// 
			// applicationPositionLabel
			// 
			applicationPositionLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationPositionLabel, 3);
			applicationPositionLabel.Dock = DockStyle.Fill;
			applicationPositionLabel.Location = new Point(3, 0);
			applicationPositionLabel.Name = "applicationPositionLabel";
			applicationPositionLabel.Size = new Size(144, 50);
			applicationPositionLabel.TabIndex = 0;
			applicationPositionLabel.Text = "Position:";
			// 
			// applicationPositionTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationPositionTextBox, 5);
			applicationPositionTextBox.Dock = DockStyle.Fill;
			applicationPositionTextBox.Location = new Point(153, 3);
			applicationPositionTextBox.Name = "applicationPositionTextBox";
			applicationPositionTextBox.Size = new Size(246, 31);
			applicationPositionTextBox.TabIndex = 12;
			applicationPositionTextBox.TextChanged += StatusUpdated;
			// 
			// applicationLinkLabel
			// 
			applicationLinkLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationLinkLabel, 3);
			applicationLinkLabel.Dock = DockStyle.Fill;
			applicationLinkLabel.Location = new Point(3, 50);
			applicationLinkLabel.Name = "applicationLinkLabel";
			applicationLinkLabel.Size = new Size(144, 50);
			applicationLinkLabel.TabIndex = 1;
			applicationLinkLabel.Text = "Link:";
			// 
			// applicationLinkTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationLinkTextBox, 5);
			applicationLinkTextBox.Dock = DockStyle.Fill;
			applicationLinkTextBox.Location = new Point(153, 53);
			applicationLinkTextBox.Name = "applicationLinkTextBox";
			applicationLinkTextBox.Size = new Size(246, 31);
			applicationLinkTextBox.TabIndex = 17;
			applicationLinkTextBox.TextChanged += StatusUpdated;
			// 
			// applicationTypeLabel
			// 
			applicationTypeLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationTypeLabel, 3);
			applicationTypeLabel.Dock = DockStyle.Fill;
			applicationTypeLabel.Location = new Point(3, 100);
			applicationTypeLabel.Name = "applicationTypeLabel";
			applicationTypeLabel.Size = new Size(144, 50);
			applicationTypeLabel.TabIndex = 2;
			applicationTypeLabel.Text = "Application Type:";
			// 
			// applicationTypeComboBox
			// 
			applicationTypeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			applicationTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			applicationTableLayout.SetColumnSpan(applicationTypeComboBox, 5);
			applicationTypeComboBox.Dock = DockStyle.Fill;
			applicationTypeComboBox.FormattingEnabled = true;
			applicationTypeComboBox.Location = new Point(153, 103);
			applicationTypeComboBox.Name = "applicationTypeComboBox";
			applicationTypeComboBox.Size = new Size(246, 33);
			applicationTypeComboBox.TabIndex = 18;
			applicationTypeComboBox.SelectedIndexChanged += applicationTypeComboBox_SelectedIndexChanged;
			applicationTypeComboBox.TextUpdate += StatusUpdated;
			// 
			// applicationTypeOtherLabel
			// 
			applicationTypeOtherLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationTypeOtherLabel, 3);
			applicationTypeOtherLabel.Dock = DockStyle.Fill;
			applicationTypeOtherLabel.Location = new Point(3, 150);
			applicationTypeOtherLabel.Name = "applicationTypeOtherLabel";
			applicationTypeOtherLabel.Size = new Size(144, 50);
			applicationTypeOtherLabel.TabIndex = 31;
			applicationTypeOtherLabel.Text = "Other:";
			// 
			// applicationTypeOtherTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationTypeOtherTextBox, 5);
			applicationTypeOtherTextBox.Dock = DockStyle.Fill;
			applicationTypeOtherTextBox.Enabled = false;
			applicationTypeOtherTextBox.Location = new Point(153, 153);
			applicationTypeOtherTextBox.Name = "applicationTypeOtherTextBox";
			applicationTypeOtherTextBox.Size = new Size(246, 31);
			applicationTypeOtherTextBox.TabIndex = 19;
			applicationTypeOtherTextBox.TextChanged += StatusUpdated;
			// 
			// applicationLocationLabel
			// 
			applicationLocationLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationLocationLabel, 3);
			applicationLocationLabel.Dock = DockStyle.Fill;
			applicationLocationLabel.Location = new Point(3, 200);
			applicationLocationLabel.Name = "applicationLocationLabel";
			applicationLocationLabel.Size = new Size(144, 50);
			applicationLocationLabel.TabIndex = 24;
			applicationLocationLabel.Text = "Location:";
			// 
			// applicationLocationTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationLocationTextBox, 5);
			applicationLocationTextBox.Dock = DockStyle.Fill;
			applicationLocationTextBox.Location = new Point(153, 203);
			applicationLocationTextBox.Name = "applicationLocationTextBox";
			applicationLocationTextBox.Size = new Size(246, 31);
			applicationLocationTextBox.TabIndex = 20;
			applicationLocationTextBox.TextChanged += StatusUpdated;
			// 
			// applicationSalaryLabel
			// 
			applicationSalaryLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationSalaryLabel, 3);
			applicationSalaryLabel.Dock = DockStyle.Fill;
			applicationSalaryLabel.Location = new Point(3, 250);
			applicationSalaryLabel.Name = "applicationSalaryLabel";
			applicationSalaryLabel.Size = new Size(144, 50);
			applicationSalaryLabel.TabIndex = 25;
			applicationSalaryLabel.Text = "Salary:";
			// 
			// applicationSalaryTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationSalaryTextBox, 5);
			applicationSalaryTextBox.Dock = DockStyle.Fill;
			applicationSalaryTextBox.Location = new Point(153, 253);
			applicationSalaryTextBox.Name = "applicationSalaryTextBox";
			applicationSalaryTextBox.Size = new Size(246, 31);
			applicationSalaryTextBox.TabIndex = 21;
			applicationSalaryTextBox.TextChanged += StatusUpdated;
			// 
			// applicationImageLabel
			// 
			applicationImageLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationImageLabel, 4);
			applicationImageLabel.Dock = DockStyle.Fill;
			applicationImageLabel.Location = new Point(405, 0);
			applicationImageLabel.Name = "applicationImageLabel";
			applicationImageLabel.Size = new Size(352, 50);
			applicationImageLabel.TabIndex = 3;
			applicationImageLabel.Text = "Image Backup:";
			// 
			// applicationImagePasteButton
			// 
			applicationImagePasteButton.Dock = DockStyle.Fill;
			applicationImagePasteButton.Image = Properties.Resources.Paste;
			applicationImagePasteButton.Location = new Point(763, 3);
			applicationImagePasteButton.Name = "applicationImagePasteButton";
			applicationImagePasteButton.Size = new Size(44, 44);
			applicationImagePasteButton.TabIndex = 13;
			applicationImagePasteButton.UseVisualStyleBackColor = true;
			applicationImagePasteButton.Click += applicationImagePasteButton_Click;
			// 
			// applicationImageUploadButton
			// 
			applicationImageUploadButton.Dock = DockStyle.Fill;
			applicationImageUploadButton.Image = Properties.Resources.FolderOpened;
			applicationImageUploadButton.Location = new Point(813, 3);
			applicationImageUploadButton.Name = "applicationImageUploadButton";
			applicationImageUploadButton.Size = new Size(44, 44);
			applicationImageUploadButton.TabIndex = 14;
			applicationImageUploadButton.UseVisualStyleBackColor = true;
			applicationImageUploadButton.Click += applicationImageUploadButton_Click;
			// 
			// applicationImageDeleteButton
			// 
			applicationImageDeleteButton.Dock = DockStyle.Fill;
			applicationImageDeleteButton.Image = Properties.Resources.Close;
			applicationImageDeleteButton.Location = new Point(863, 3);
			applicationImageDeleteButton.Name = "applicationImageDeleteButton";
			applicationImageDeleteButton.Size = new Size(44, 44);
			applicationImageDeleteButton.TabIndex = 15;
			applicationImageDeleteButton.UseVisualStyleBackColor = true;
			applicationImageDeleteButton.Click += applicationImageDeleteButton_Click;
			// 
			// applicationImageClearButton
			// 
			applicationImageClearButton.Dock = DockStyle.Fill;
			applicationImageClearButton.Image = Properties.Resources.CloseAll;
			applicationImageClearButton.Location = new Point(913, 3);
			applicationImageClearButton.Name = "applicationImageClearButton";
			applicationImageClearButton.Size = new Size(45, 44);
			applicationImageClearButton.TabIndex = 16;
			applicationImageClearButton.UseVisualStyleBackColor = true;
			applicationImageClearButton.Click += applicationImageClearButton_Click;
			// 
			// applicationImageFlowLayout
			// 
			applicationImageFlowLayout.AutoScroll = true;
			applicationTableLayout.SetColumnSpan(applicationImageFlowLayout, 5);
			applicationImageFlowLayout.Dock = DockStyle.Fill;
			applicationImageFlowLayout.FlowDirection = FlowDirection.TopDown;
			applicationImageFlowLayout.Location = new Point(555, 53);
			applicationImageFlowLayout.Name = "applicationImageFlowLayout";
			applicationTableLayout.SetRowSpan(applicationImageFlowLayout, 8);
			applicationImageFlowLayout.Size = new Size(403, 581);
			applicationImageFlowLayout.TabIndex = 0;
			applicationImageFlowLayout.WrapContents = false;
			applicationImageFlowLayout.ControlAdded += StatusUpdated;
			applicationImageFlowLayout.ControlRemoved += StatusUpdated;
			// 
			// applicationResumeLabel
			// 
			applicationResumeLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationResumeLabel, 3);
			applicationResumeLabel.Dock = DockStyle.Fill;
			applicationResumeLabel.Location = new Point(3, 300);
			applicationResumeLabel.Name = "applicationResumeLabel";
			applicationResumeLabel.Size = new Size(144, 50);
			applicationResumeLabel.TabIndex = 4;
			applicationResumeLabel.Text = "Resume:";
			// 
			// applicationResumeComboBox
			// 
			applicationResumeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			applicationResumeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			applicationTableLayout.SetColumnSpan(applicationResumeComboBox, 5);
			applicationResumeComboBox.Dock = DockStyle.Fill;
			applicationResumeComboBox.FormattingEnabled = true;
			applicationResumeComboBox.Items.AddRange(new object[] { "None" });
			applicationResumeComboBox.Location = new Point(153, 303);
			applicationResumeComboBox.Name = "applicationResumeComboBox";
			applicationResumeComboBox.Size = new Size(246, 33);
			applicationResumeComboBox.TabIndex = 22;
			applicationResumeComboBox.TextUpdate += StatusUpdated;
			// 
			// applicationResumeOpenButton
			// 
			applicationResumeOpenButton.Dock = DockStyle.Fill;
			applicationResumeOpenButton.Image = Properties.Resources.Open;
			applicationResumeOpenButton.Location = new Point(405, 303);
			applicationResumeOpenButton.Name = "applicationResumeOpenButton";
			applicationResumeOpenButton.Size = new Size(44, 44);
			applicationResumeOpenButton.TabIndex = 23;
			applicationResumeOpenButton.UseVisualStyleBackColor = true;
			applicationResumeOpenButton.Click += applicationResumeOpenButton_Click;
			// 
			// applicationResumeUploadButton
			// 
			applicationResumeUploadButton.Dock = DockStyle.Fill;
			applicationResumeUploadButton.Image = Properties.Resources.FolderOpened;
			applicationResumeUploadButton.Location = new Point(455, 303);
			applicationResumeUploadButton.Name = "applicationResumeUploadButton";
			applicationResumeUploadButton.Size = new Size(44, 44);
			applicationResumeUploadButton.TabIndex = 24;
			applicationResumeUploadButton.UseVisualStyleBackColor = true;
			applicationResumeUploadButton.Click += applicationResumeUploadButton_Click;
			// 
			// applicationCoverLetterLabel
			// 
			applicationCoverLetterLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationCoverLetterLabel, 3);
			applicationCoverLetterLabel.Dock = DockStyle.Fill;
			applicationCoverLetterLabel.Location = new Point(3, 350);
			applicationCoverLetterLabel.Name = "applicationCoverLetterLabel";
			applicationCoverLetterLabel.Size = new Size(144, 50);
			applicationCoverLetterLabel.TabIndex = 5;
			applicationCoverLetterLabel.Text = "Cover Letter:";
			// 
			// applicationCoverLetterTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationCoverLetterTextBox, 5);
			applicationCoverLetterTextBox.Dock = DockStyle.Fill;
			applicationCoverLetterTextBox.Location = new Point(153, 353);
			applicationCoverLetterTextBox.Multiline = true;
			applicationCoverLetterTextBox.Name = "applicationCoverLetterTextBox";
			applicationCoverLetterTextBox.ReadOnly = true;
			applicationCoverLetterTextBox.ScrollBars = ScrollBars.Vertical;
			applicationCoverLetterTextBox.Size = new Size(246, 44);
			applicationCoverLetterTextBox.TabIndex = 0;
			applicationCoverLetterTextBox.TabStop = false;
			applicationCoverLetterTextBox.Text = "None";
			applicationCoverLetterTextBox.TextChanged += StatusUpdated;
			// 
			// applicationCoverLetterOpenButton
			// 
			applicationCoverLetterOpenButton.Dock = DockStyle.Fill;
			applicationCoverLetterOpenButton.Image = Properties.Resources.Open;
			applicationCoverLetterOpenButton.Location = new Point(405, 353);
			applicationCoverLetterOpenButton.Name = "applicationCoverLetterOpenButton";
			applicationCoverLetterOpenButton.Size = new Size(44, 44);
			applicationCoverLetterOpenButton.TabIndex = 25;
			applicationCoverLetterOpenButton.UseVisualStyleBackColor = true;
			applicationCoverLetterOpenButton.Click += applicationCoverLetterOpenButton_Click;
			// 
			// applicationCoverLetterUploadButton
			// 
			applicationCoverLetterUploadButton.Dock = DockStyle.Fill;
			applicationCoverLetterUploadButton.Image = Properties.Resources.FolderOpened;
			applicationCoverLetterUploadButton.Location = new Point(455, 353);
			applicationCoverLetterUploadButton.Name = "applicationCoverLetterUploadButton";
			applicationCoverLetterUploadButton.Size = new Size(44, 44);
			applicationCoverLetterUploadButton.TabIndex = 26;
			applicationCoverLetterUploadButton.UseVisualStyleBackColor = true;
			applicationCoverLetterUploadButton.Click += applicationCoverLetterUploadButton_Click;
			// 
			// applicationCoverLetterDeleteButton
			// 
			applicationCoverLetterDeleteButton.Dock = DockStyle.Fill;
			applicationCoverLetterDeleteButton.Image = Properties.Resources.Close;
			applicationCoverLetterDeleteButton.Location = new Point(505, 353);
			applicationCoverLetterDeleteButton.Name = "applicationCoverLetterDeleteButton";
			applicationCoverLetterDeleteButton.Size = new Size(44, 44);
			applicationCoverLetterDeleteButton.TabIndex = 27;
			applicationCoverLetterDeleteButton.UseVisualStyleBackColor = true;
			applicationCoverLetterDeleteButton.Click += applicationCoverLetterDeleteButton_Click;
			// 
			// applicationInfoLabel
			// 
			applicationInfoLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationInfoLabel, 3);
			applicationInfoLabel.Dock = DockStyle.Fill;
			applicationInfoLabel.Location = new Point(3, 400);
			applicationInfoLabel.Name = "applicationInfoLabel";
			applicationInfoLabel.Size = new Size(144, 237);
			applicationInfoLabel.TabIndex = 6;
			applicationInfoLabel.Text = "Info:";
			// 
			// applicationInfoTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationInfoTextBox, 8);
			applicationInfoTextBox.Dock = DockStyle.Fill;
			applicationInfoTextBox.Location = new Point(153, 403);
			applicationInfoTextBox.Multiline = true;
			applicationInfoTextBox.Name = "applicationInfoTextBox";
			applicationInfoTextBox.ScrollBars = ScrollBars.Vertical;
			applicationInfoTextBox.Size = new Size(396, 231);
			applicationInfoTextBox.TabIndex = 28;
			applicationInfoTextBox.TextChanged += StatusUpdated;
			// 
			// augmentationsTabPage
			// 
			augmentationsTabPage.Controls.Add(augmentationsTableLayout);
			augmentationsTabPage.Location = new Point(4, 34);
			augmentationsTabPage.Name = "augmentationsTabPage";
			augmentationsTabPage.Size = new Size(967, 643);
			augmentationsTabPage.TabIndex = 2;
			augmentationsTabPage.Text = "Augmentations";
			augmentationsTabPage.UseVisualStyleBackColor = true;
			// 
			// augmentationsTableLayout
			// 
			augmentationsTableLayout.ColumnCount = 2;
			augmentationsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			augmentationsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			augmentationsTableLayout.Controls.Add(augmentCompanylabel, 0, 0);
			augmentationsTableLayout.Controls.Add(augmentCompanyComboBox, 1, 0);
			augmentationsTableLayout.Controls.Add(augmentCreationTimeLabel, 0, 1);
			augmentationsTableLayout.Controls.Add(augmentCreationTimeDateTimePicker, 1, 1);
			augmentationsTableLayout.Controls.Add(augmentStatusLabel, 0, 2);
			augmentationsTableLayout.Controls.Add(augmentStatusComboBox, 1, 2);
			augmentationsTableLayout.Controls.Add(augmentStatusOtherLabel, 0, 3);
			augmentationsTableLayout.Controls.Add(augmentStatusOtherTextBox, 1, 3);
			augmentationsTableLayout.Controls.Add(augmentStatusTimeLabel, 0, 4);
			augmentationsTableLayout.Controls.Add(augmentStatusTimeDateTimePicker, 1, 4);
			augmentationsTableLayout.Dock = DockStyle.Fill;
			augmentationsTableLayout.Location = new Point(0, 0);
			augmentationsTableLayout.Name = "augmentationsTableLayout";
			augmentationsTableLayout.RowCount = 6;
			augmentationsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			augmentationsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			augmentationsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			augmentationsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			augmentationsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			augmentationsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			augmentationsTableLayout.Size = new Size(967, 643);
			augmentationsTableLayout.TabIndex = 0;
			// 
			// augmentCompanylabel
			// 
			augmentCompanylabel.AutoSize = true;
			augmentCompanylabel.Dock = DockStyle.Fill;
			augmentCompanylabel.Location = new Point(3, 0);
			augmentCompanylabel.Name = "augmentCompanylabel";
			augmentCompanylabel.Size = new Size(194, 50);
			augmentCompanylabel.TabIndex = 0;
			augmentCompanylabel.Text = "Company:";
			// 
			// augmentCompanyComboBox
			// 
			augmentCompanyComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			augmentCompanyComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			augmentCompanyComboBox.Dock = DockStyle.Fill;
			augmentCompanyComboBox.FormattingEnabled = true;
			augmentCompanyComboBox.Location = new Point(203, 3);
			augmentCompanyComboBox.Name = "augmentCompanyComboBox";
			augmentCompanyComboBox.Size = new Size(761, 33);
			augmentCompanyComboBox.TabIndex = 29;
			augmentCompanyComboBox.TextUpdate += StatusUpdated;
			// 
			// augmentCreationTimeLabel
			// 
			augmentCreationTimeLabel.AutoSize = true;
			augmentCreationTimeLabel.Dock = DockStyle.Fill;
			augmentCreationTimeLabel.Location = new Point(3, 50);
			augmentCreationTimeLabel.Name = "augmentCreationTimeLabel";
			augmentCreationTimeLabel.Size = new Size(194, 50);
			augmentCreationTimeLabel.TabIndex = 1;
			augmentCreationTimeLabel.Text = "Creation Time:";
			// 
			// augmentCreationTimeDateTimePicker
			// 
			augmentCreationTimeDateTimePicker.Dock = DockStyle.Fill;
			augmentCreationTimeDateTimePicker.Location = new Point(203, 53);
			augmentCreationTimeDateTimePicker.Name = "augmentCreationTimeDateTimePicker";
			augmentCreationTimeDateTimePicker.Size = new Size(761, 31);
			augmentCreationTimeDateTimePicker.TabIndex = 30;
			augmentCreationTimeDateTimePicker.ValueChanged += StatusUpdated;
			// 
			// augmentStatusLabel
			// 
			augmentStatusLabel.AutoSize = true;
			augmentStatusLabel.Dock = DockStyle.Fill;
			augmentStatusLabel.Location = new Point(3, 100);
			augmentStatusLabel.Name = "augmentStatusLabel";
			augmentStatusLabel.Size = new Size(194, 50);
			augmentStatusLabel.TabIndex = 2;
			augmentStatusLabel.Text = "Application Status:";
			// 
			// augmentStatusComboBox
			// 
			augmentStatusComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			augmentStatusComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			augmentStatusComboBox.Dock = DockStyle.Fill;
			augmentStatusComboBox.FormattingEnabled = true;
			augmentStatusComboBox.ItemHeight = 25;
			augmentStatusComboBox.Location = new Point(203, 103);
			augmentStatusComboBox.Name = "augmentStatusComboBox";
			augmentStatusComboBox.Size = new Size(761, 33);
			augmentStatusComboBox.TabIndex = 31;
			augmentStatusComboBox.SelectedIndexChanged += augmentStatusComboBox_SelectedIndexChanged;
			augmentStatusComboBox.TextUpdate += StatusUpdated;
			// 
			// augmentStatusOtherLabel
			// 
			augmentStatusOtherLabel.AutoSize = true;
			augmentStatusOtherLabel.Dock = DockStyle.Fill;
			augmentStatusOtherLabel.Enabled = false;
			augmentStatusOtherLabel.Location = new Point(3, 150);
			augmentStatusOtherLabel.Name = "augmentStatusOtherLabel";
			augmentStatusOtherLabel.Size = new Size(194, 50);
			augmentStatusOtherLabel.TabIndex = 3;
			augmentStatusOtherLabel.Text = "Other:";
			// 
			// augmentStatusOtherTextBox
			// 
			augmentStatusOtherTextBox.Dock = DockStyle.Fill;
			augmentStatusOtherTextBox.Enabled = false;
			augmentStatusOtherTextBox.Location = new Point(203, 153);
			augmentStatusOtherTextBox.Name = "augmentStatusOtherTextBox";
			augmentStatusOtherTextBox.Size = new Size(761, 31);
			augmentStatusOtherTextBox.TabIndex = 32;
			augmentStatusOtherTextBox.TextChanged += augmentStatusOtherTextBox_TextChanged;
			// 
			// augmentStatusTimeLabel
			// 
			augmentStatusTimeLabel.AutoSize = true;
			augmentStatusTimeLabel.Dock = DockStyle.Fill;
			augmentStatusTimeLabel.Location = new Point(3, 200);
			augmentStatusTimeLabel.Name = "augmentStatusTimeLabel";
			augmentStatusTimeLabel.Size = new Size(194, 50);
			augmentStatusTimeLabel.TabIndex = 8;
			augmentStatusTimeLabel.Text = "Last Update Time:";
			// 
			// augmentStatusTimeDateTimePicker
			// 
			augmentStatusTimeDateTimePicker.Dock = DockStyle.Fill;
			augmentStatusTimeDateTimePicker.Location = new Point(203, 203);
			augmentStatusTimeDateTimePicker.Name = "augmentStatusTimeDateTimePicker";
			augmentStatusTimeDateTimePicker.Size = new Size(761, 31);
			augmentStatusTimeDateTimePicker.TabIndex = 33;
			augmentStatusTimeDateTimePicker.ValueChanged += StatusUpdated;
			// 
			// saveButton
			// 
			saveButton.Dock = DockStyle.Fill;
			saveButton.Location = new Point(3, 690);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(484, 44);
			saveButton.TabIndex = 34;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Dock = DockStyle.Fill;
			cancelButton.Location = new Point(493, 690);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(485, 44);
			cancelButton.TabIndex = 35;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// applicationImageContextMenu
			// 
			applicationImageContextMenu.ImageScalingSize = new Size(24, 24);
			applicationImageContextMenu.Items.AddRange(new ToolStripItem[] { viewImageToolStripMenuItem, removeImageToolStripMenuItem });
			applicationImageContextMenu.Name = "applicationImageContextMenu";
			applicationImageContextMenu.Size = new Size(204, 68);
			// 
			// viewImageToolStripMenuItem
			// 
			viewImageToolStripMenuItem.Name = "viewImageToolStripMenuItem";
			viewImageToolStripMenuItem.Size = new Size(203, 32);
			viewImageToolStripMenuItem.Text = "Open Image";
			viewImageToolStripMenuItem.Click += viewImageToolStripMenuItem_Click;
			// 
			// removeImageToolStripMenuItem
			// 
			removeImageToolStripMenuItem.Name = "removeImageToolStripMenuItem";
			removeImageToolStripMenuItem.Size = new Size(203, 32);
			removeImageToolStripMenuItem.Text = "Remove Image";
			removeImageToolStripMenuItem.Click += removeImageToolStripMenuItem_Click;
			// 
			// ApplicationEditor
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(981, 737);
			Controls.Add(mainTableLayout);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ApplicationEditor";
			ShowIcon = false;
			Text = "Application Editor";
			FormClosing += CloseApplicationEditor;
			Load += LoadApplicationEditor;
			mainTableLayout.ResumeLayout(false);
			mainTabControl.ResumeLayout(false);
			companyTabPage.ResumeLayout(false);
			companyTableLayout.ResumeLayout(false);
			companyTableLayout.PerformLayout();
			newCompanyGroupBox.ResumeLayout(false);
			newCompanyTableLayout.ResumeLayout(false);
			newCompanyTableLayout.PerformLayout();
			applicationTabPage.ResumeLayout(false);
			applicationTableLayout.ResumeLayout(false);
			applicationTableLayout.PerformLayout();
			augmentationsTabPage.ResumeLayout(false);
			augmentationsTableLayout.ResumeLayout(false);
			augmentationsTableLayout.PerformLayout();
			applicationImageContextMenu.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayout;
		private TabControl mainTabControl;
		private TabPage companyTabPage;
		private TabPage applicationTabPage;
		private Button saveButton;
		private Button cancelButton;
		private TableLayoutPanel companyTableLayout;
		private CheckBox reuseCompanyCheckBox;
		private ComboBox reuseCompanyComboBox;
		private GroupBox newCompanyGroupBox;
		private TableLayoutPanel newCompanyTableLayout;
		private Label companyNameLabel;
		private TextBox companyNameTextBox;
		private Label companyWebsiteLabel;
		private TextBox companyWebsiteTextBox;
		private Label companyCareersWebsiteLabel;
		private TextBox companyCareersWebsiteTextBox;
		private Label companyCareersHomeLabel;
		private TextBox companyCareersHomeTextBox;
		private Label companyEmailLabel;
		private TextBox companyEmailTextBox;
		private Label companyPasswordLabel;
		private TextBox companyPasswordTextBox;
		private Label companyInfoLabel;
		private Button companyPasswordViewButton;
		private Button viewCompanyButton;
		private TableLayoutPanel applicationTableLayout;
		private Label applicationPositionLabel;
		private Label applicationLinkLabel;
		private Label applicationTypeLabel;
		private Label applicationImageLabel;
		private Label applicationResumeLabel;
		private Label applicationCoverLetterLabel;
		private Label applicationInfoLabel;
		private TextBox applicationPositionTextBox;
		private ComboBox applicationTypeComboBox;
		private Button applicationImageUploadButton;
		private TextBox applicationTypeOtherTextBox;
		private Button applicationResumeUploadButton;
		private Button applicationCoverLetterUploadButton;
		private TextBox applicationLinkTextBox;
		private Button applicationImagePasteButton;
		private FlowLayoutPanel applicationImageFlowLayout;
		private TextBox companyInfoTextBox;
		private TextBox applicationInfoTextBox;
		private ContextMenuStrip applicationImageContextMenu;
		private ToolStripMenuItem viewImageToolStripMenuItem;
		private ToolStripMenuItem removeImageToolStripMenuItem;
		private Button applicationImageDeleteButton;
		private Button applicationImageClearButton;
		private Button applicationCoverLetterDeleteButton;
		private Label applicationLocationLabel;
		private Label applicationSalaryLabel;
		private TextBox applicationLocationTextBox;
		private TextBox applicationSalaryTextBox;
		private ComboBox applicationResumeComboBox;
		private TabPage augmentationsTabPage;
		private TableLayoutPanel augmentationsTableLayout;
		private Label augmentCompanylabel;
		private ComboBox augmentCompanyComboBox;
		private Label augmentCreationTimeLabel;
		private Label augmentStatusLabel;
		private Label augmentStatusOtherLabel;
		private DateTimePicker augmentCreationTimeDateTimePicker;
		private DateTimePicker augmentStatusTimeDateTimePicker;
		private ComboBox augmentStatusComboBox;
		private Label augmentStatusTimeLabel;
		private TextBox augmentStatusOtherTextBox;
		private Button applicationCoverLetterOpenButton;
		private TextBox applicationCoverLetterTextBox;
		private Label applicationTypeOtherLabel;
		private Button applicationResumeOpenButton;
	}
}