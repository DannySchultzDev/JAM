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
			applicationResumeUploadButton = new Button();
			applicationCoverLetterLabel = new Label();
			applicationCurrentCoverLetterLabel = new Label();
			applicationCoverLetterUploadButton = new Button();
			applicationCoverLetterDeleteButton = new Button();
			applicationInfoLabel = new Label();
			applicationInfoTextBox = new TextBox();
			augmentationsTabPage = new TabPage();
			tableLayoutPanel1 = new TableLayoutPanel();
			companylabel = new Label();
			companyComboBox = new ComboBox();
			creationTimeLabel = new Label();
			creationTimeDateTimePicker = new DateTimePicker();
			statusLabel = new Label();
			statusComboBox = new ComboBox();
			statusOtherLabel = new Label();
			statusOtherTextBox = new TextBox();
			statusTimeLabel = new Label();
			stausTimeDateTimePicker = new DateTimePicker();
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
			tableLayoutPanel1.SuspendLayout();
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
			mainTableLayout.Size = new Size(806, 737);
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
			mainTabControl.Size = new Size(800, 681);
			mainTabControl.TabIndex = 0;
			// 
			// companyTabPage
			// 
			companyTabPage.Controls.Add(companyTableLayout);
			companyTabPage.Location = new Point(4, 34);
			companyTabPage.Name = "companyTabPage";
			companyTabPage.Padding = new Padding(3);
			companyTabPage.Size = new Size(792, 643);
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
			companyTableLayout.Size = new Size(786, 637);
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
			reuseCompanyCheckBox.TabIndex = 0;
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
			reuseCompanyComboBox.Size = new Size(530, 33);
			reuseCompanyComboBox.TabIndex = 1;
			reuseCompanyComboBox.TextUpdate += StatusUpdated;
			// 
			// viewCompanyButton
			// 
			viewCompanyButton.Dock = DockStyle.Fill;
			viewCompanyButton.Enabled = false;
			viewCompanyButton.Image = Properties.Resources.Open;
			viewCompanyButton.Location = new Point(739, 3);
			viewCompanyButton.Name = "viewCompanyButton";
			viewCompanyButton.Size = new Size(44, 44);
			viewCompanyButton.TabIndex = 3;
			viewCompanyButton.UseVisualStyleBackColor = true;
			// 
			// newCompanyGroupBox
			// 
			companyTableLayout.SetColumnSpan(newCompanyGroupBox, 3);
			newCompanyGroupBox.Controls.Add(newCompanyTableLayout);
			newCompanyGroupBox.Dock = DockStyle.Fill;
			newCompanyGroupBox.Location = new Point(3, 53);
			newCompanyGroupBox.Name = "newCompanyGroupBox";
			newCompanyGroupBox.Size = new Size(780, 581);
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
			newCompanyTableLayout.Size = new Size(774, 551);
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
			companyNameTextBox.Size = new Size(256, 31);
			companyNameTextBox.TabIndex = 7;
			companyNameTextBox.TextChanged += StatusUpdated;
			// 
			// companyWebsiteLabel
			// 
			companyWebsiteLabel.AutoSize = true;
			companyWebsiteLabel.Dock = DockStyle.Fill;
			companyWebsiteLabel.Location = new Point(365, 0);
			companyWebsiteLabel.Name = "companyWebsiteLabel";
			companyWebsiteLabel.Size = new Size(94, 50);
			companyWebsiteLabel.TabIndex = 1;
			companyWebsiteLabel.Text = "Website:";
			// 
			// companyWebsiteTextBox
			// 
			newCompanyTableLayout.SetColumnSpan(companyWebsiteTextBox, 2);
			companyWebsiteTextBox.Dock = DockStyle.Fill;
			companyWebsiteTextBox.Location = new Point(465, 3);
			companyWebsiteTextBox.Name = "companyWebsiteTextBox";
			companyWebsiteTextBox.Size = new Size(306, 31);
			companyWebsiteTextBox.TabIndex = 8;
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
			companyCareersWebsiteTextBox.Size = new Size(256, 31);
			companyCareersWebsiteTextBox.TabIndex = 9;
			companyCareersWebsiteTextBox.TextChanged += StatusUpdated;
			// 
			// companyCareersHomeLabel
			// 
			companyCareersHomeLabel.AutoSize = true;
			companyCareersHomeLabel.Dock = DockStyle.Fill;
			companyCareersHomeLabel.Location = new Point(365, 50);
			companyCareersHomeLabel.Name = "companyCareersHomeLabel";
			companyCareersHomeLabel.Size = new Size(94, 70);
			companyCareersHomeLabel.TabIndex = 3;
			companyCareersHomeLabel.Text = "Career Home:";
			// 
			// companyCareersHomeTextBox
			// 
			newCompanyTableLayout.SetColumnSpan(companyCareersHomeTextBox, 2);
			companyCareersHomeTextBox.Dock = DockStyle.Fill;
			companyCareersHomeTextBox.Location = new Point(465, 53);
			companyCareersHomeTextBox.Name = "companyCareersHomeTextBox";
			companyCareersHomeTextBox.Size = new Size(306, 31);
			companyCareersHomeTextBox.TabIndex = 10;
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
			companyEmailTextBox.Size = new Size(256, 31);
			companyEmailTextBox.TabIndex = 11;
			companyEmailTextBox.TextChanged += StatusUpdated;
			// 
			// companyPasswordLabel
			// 
			companyPasswordLabel.AutoSize = true;
			companyPasswordLabel.Dock = DockStyle.Fill;
			companyPasswordLabel.Location = new Point(365, 120);
			companyPasswordLabel.Name = "companyPasswordLabel";
			companyPasswordLabel.Size = new Size(94, 50);
			companyPasswordLabel.TabIndex = 5;
			companyPasswordLabel.Text = "Password:";
			// 
			// companyPasswordTextBox
			// 
			companyPasswordTextBox.Dock = DockStyle.Fill;
			companyPasswordTextBox.Location = new Point(465, 123);
			companyPasswordTextBox.Name = "companyPasswordTextBox";
			companyPasswordTextBox.PasswordChar = '•';
			companyPasswordTextBox.Size = new Size(256, 31);
			companyPasswordTextBox.TabIndex = 12;
			companyPasswordTextBox.TextChanged += StatusUpdated;
			// 
			// companyPasswordViewButton
			// 
			companyPasswordViewButton.Dock = DockStyle.Fill;
			companyPasswordViewButton.Image = Properties.Resources.Visible;
			companyPasswordViewButton.Location = new Point(727, 123);
			companyPasswordViewButton.Name = "companyPasswordViewButton";
			companyPasswordViewButton.Size = new Size(44, 44);
			companyPasswordViewButton.TabIndex = 14;
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
			companyInfoTextBox.Size = new Size(668, 375);
			companyInfoTextBox.TabIndex = 15;
			companyInfoTextBox.TextChanged += StatusUpdated;
			// 
			// applicationTabPage
			// 
			applicationTabPage.Controls.Add(applicationTableLayout);
			applicationTabPage.Location = new Point(4, 34);
			applicationTabPage.Name = "applicationTabPage";
			applicationTabPage.Padding = new Padding(3);
			applicationTabPage.Size = new Size(792, 643);
			applicationTabPage.TabIndex = 1;
			applicationTabPage.Text = "Application";
			applicationTabPage.UseVisualStyleBackColor = true;
			// 
			// applicationTableLayout
			// 
			applicationTableLayout.ColumnCount = 12;
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			applicationTableLayout.Controls.Add(applicationPositionLabel, 0, 0);
			applicationTableLayout.Controls.Add(applicationPositionTextBox, 1, 0);
			applicationTableLayout.Controls.Add(applicationLinkLabel, 6, 0);
			applicationTableLayout.Controls.Add(applicationLinkTextBox, 7, 0);
			applicationTableLayout.Controls.Add(applicationTypeLabel, 0, 1);
			applicationTableLayout.Controls.Add(applicationTypeComboBox, 1, 1);
			applicationTableLayout.Controls.Add(applicationTypeOtherTextBox, 1, 2);
			applicationTableLayout.Controls.Add(applicationLocationLabel, 0, 3);
			applicationTableLayout.Controls.Add(applicationLocationTextBox, 1, 3);
			applicationTableLayout.Controls.Add(applicationSalaryLabel, 0, 4);
			applicationTableLayout.Controls.Add(applicationSalaryTextBox, 1, 4);
			applicationTableLayout.Controls.Add(applicationImageLabel, 6, 1);
			applicationTableLayout.Controls.Add(applicationImagePasteButton, 8, 1);
			applicationTableLayout.Controls.Add(applicationImageUploadButton, 9, 1);
			applicationTableLayout.Controls.Add(applicationImageDeleteButton, 10, 1);
			applicationTableLayout.Controls.Add(applicationImageClearButton, 11, 1);
			applicationTableLayout.Controls.Add(applicationImageFlowLayout, 7, 2);
			applicationTableLayout.Controls.Add(applicationResumeLabel, 0, 6);
			applicationTableLayout.Controls.Add(applicationResumeComboBox, 1, 6);
			applicationTableLayout.Controls.Add(applicationResumeUploadButton, 5, 6);
			applicationTableLayout.Controls.Add(applicationCoverLetterLabel, 6, 6);
			applicationTableLayout.Controls.Add(applicationCurrentCoverLetterLabel, 7, 6);
			applicationTableLayout.Controls.Add(applicationCoverLetterUploadButton, 10, 6);
			applicationTableLayout.Controls.Add(applicationCoverLetterDeleteButton, 11, 6);
			applicationTableLayout.Controls.Add(applicationInfoLabel, 0, 7);
			applicationTableLayout.Controls.Add(applicationInfoTextBox, 1, 7);
			applicationTableLayout.Dock = DockStyle.Fill;
			applicationTableLayout.Location = new Point(3, 3);
			applicationTableLayout.Name = "applicationTableLayout";
			applicationTableLayout.RowCount = 8;
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			applicationTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			applicationTableLayout.Size = new Size(786, 637);
			applicationTableLayout.TabIndex = 0;
			// 
			// applicationPositionLabel
			// 
			applicationPositionLabel.AutoSize = true;
			applicationPositionLabel.Dock = DockStyle.Fill;
			applicationPositionLabel.Location = new Point(3, 0);
			applicationPositionLabel.Name = "applicationPositionLabel";
			applicationPositionLabel.Size = new Size(114, 50);
			applicationPositionLabel.TabIndex = 0;
			applicationPositionLabel.Text = "Position:";
			// 
			// applicationPositionTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationPositionTextBox, 5);
			applicationPositionTextBox.Dock = DockStyle.Fill;
			applicationPositionTextBox.Location = new Point(123, 3);
			applicationPositionTextBox.Name = "applicationPositionTextBox";
			applicationPositionTextBox.Size = new Size(267, 31);
			applicationPositionTextBox.TabIndex = 7;
			applicationPositionTextBox.TextChanged += StatusUpdated;
			// 
			// applicationLinkLabel
			// 
			applicationLinkLabel.AutoSize = true;
			applicationLinkLabel.Dock = DockStyle.Fill;
			applicationLinkLabel.Location = new Point(396, 0);
			applicationLinkLabel.Name = "applicationLinkLabel";
			applicationLinkLabel.Size = new Size(114, 50);
			applicationLinkLabel.TabIndex = 1;
			applicationLinkLabel.Text = "Link:";
			// 
			// applicationLinkTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationLinkTextBox, 5);
			applicationLinkTextBox.Dock = DockStyle.Fill;
			applicationLinkTextBox.Location = new Point(516, 3);
			applicationLinkTextBox.Name = "applicationLinkTextBox";
			applicationLinkTextBox.Size = new Size(267, 31);
			applicationLinkTextBox.TabIndex = 8;
			applicationLinkTextBox.TextChanged += StatusUpdated;
			// 
			// applicationTypeLabel
			// 
			applicationTypeLabel.AutoSize = true;
			applicationTypeLabel.Dock = DockStyle.Fill;
			applicationTypeLabel.Location = new Point(3, 50);
			applicationTypeLabel.Name = "applicationTypeLabel";
			applicationTypeLabel.Size = new Size(114, 50);
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
			applicationTypeComboBox.Items.AddRange(new object[] { "Careers Website", "LinkedIn", "Other" });
			applicationTypeComboBox.Location = new Point(123, 53);
			applicationTypeComboBox.Name = "applicationTypeComboBox";
			applicationTypeComboBox.Size = new Size(267, 33);
			applicationTypeComboBox.TabIndex = 9;
			applicationTypeComboBox.SelectedIndexChanged += applicationTypeComboBox_SelectedIndexChanged;
			applicationTypeComboBox.TextUpdate += StatusUpdated;
			// 
			// applicationTypeOtherTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationTypeOtherTextBox, 5);
			applicationTypeOtherTextBox.Dock = DockStyle.Fill;
			applicationTypeOtherTextBox.Enabled = false;
			applicationTypeOtherTextBox.Location = new Point(123, 103);
			applicationTypeOtherTextBox.Name = "applicationTypeOtherTextBox";
			applicationTypeOtherTextBox.Size = new Size(267, 31);
			applicationTypeOtherTextBox.TabIndex = 12;
			applicationTypeOtherTextBox.TextChanged += StatusUpdated;
			// 
			// applicationLocationLabel
			// 
			applicationLocationLabel.AutoSize = true;
			applicationLocationLabel.Dock = DockStyle.Fill;
			applicationLocationLabel.Location = new Point(3, 150);
			applicationLocationLabel.Name = "applicationLocationLabel";
			applicationLocationLabel.Size = new Size(114, 50);
			applicationLocationLabel.TabIndex = 24;
			applicationLocationLabel.Text = "Location:";
			// 
			// applicationLocationTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationLocationTextBox, 5);
			applicationLocationTextBox.Dock = DockStyle.Fill;
			applicationLocationTextBox.Location = new Point(123, 153);
			applicationLocationTextBox.Name = "applicationLocationTextBox";
			applicationLocationTextBox.Size = new Size(267, 31);
			applicationLocationTextBox.TabIndex = 26;
			applicationLocationTextBox.TextChanged += StatusUpdated;
			// 
			// applicationSalaryLabel
			// 
			applicationSalaryLabel.AutoSize = true;
			applicationSalaryLabel.Dock = DockStyle.Fill;
			applicationSalaryLabel.Location = new Point(3, 200);
			applicationSalaryLabel.Name = "applicationSalaryLabel";
			applicationSalaryLabel.Size = new Size(114, 50);
			applicationSalaryLabel.TabIndex = 25;
			applicationSalaryLabel.Text = "Salary:";
			// 
			// applicationSalaryTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationSalaryTextBox, 5);
			applicationSalaryTextBox.Dock = DockStyle.Fill;
			applicationSalaryTextBox.Location = new Point(123, 203);
			applicationSalaryTextBox.Name = "applicationSalaryTextBox";
			applicationSalaryTextBox.Size = new Size(267, 31);
			applicationSalaryTextBox.TabIndex = 27;
			applicationSalaryTextBox.TextChanged += StatusUpdated;
			// 
			// applicationImageLabel
			// 
			applicationImageLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationImageLabel, 2);
			applicationImageLabel.Dock = DockStyle.Fill;
			applicationImageLabel.Location = new Point(396, 50);
			applicationImageLabel.Name = "applicationImageLabel";
			applicationImageLabel.Size = new Size(187, 50);
			applicationImageLabel.TabIndex = 3;
			applicationImageLabel.Text = "Image Backup:";
			// 
			// applicationImagePasteButton
			// 
			applicationImagePasteButton.Dock = DockStyle.Fill;
			applicationImagePasteButton.Image = Properties.Resources.Paste;
			applicationImagePasteButton.Location = new Point(589, 53);
			applicationImagePasteButton.Name = "applicationImagePasteButton";
			applicationImagePasteButton.Size = new Size(44, 44);
			applicationImagePasteButton.TabIndex = 10;
			applicationImagePasteButton.UseVisualStyleBackColor = true;
			applicationImagePasteButton.Click += applicationImagePasteButton_Click;
			// 
			// applicationImageUploadButton
			// 
			applicationImageUploadButton.Dock = DockStyle.Fill;
			applicationImageUploadButton.Image = Properties.Resources.FolderOpened;
			applicationImageUploadButton.Location = new Point(639, 53);
			applicationImageUploadButton.Name = "applicationImageUploadButton";
			applicationImageUploadButton.Size = new Size(44, 44);
			applicationImageUploadButton.TabIndex = 11;
			applicationImageUploadButton.UseVisualStyleBackColor = true;
			applicationImageUploadButton.Click += applicationImageUploadButton_Click;
			// 
			// applicationImageDeleteButton
			// 
			applicationImageDeleteButton.Dock = DockStyle.Fill;
			applicationImageDeleteButton.Image = Properties.Resources.Close;
			applicationImageDeleteButton.Location = new Point(689, 53);
			applicationImageDeleteButton.Name = "applicationImageDeleteButton";
			applicationImageDeleteButton.Size = new Size(44, 44);
			applicationImageDeleteButton.TabIndex = 20;
			applicationImageDeleteButton.UseVisualStyleBackColor = true;
			applicationImageDeleteButton.Click += applicationImageDeleteButton_Click;
			// 
			// applicationImageClearButton
			// 
			applicationImageClearButton.Dock = DockStyle.Fill;
			applicationImageClearButton.Image = Properties.Resources.CloseAll;
			applicationImageClearButton.Location = new Point(739, 53);
			applicationImageClearButton.Name = "applicationImageClearButton";
			applicationImageClearButton.Size = new Size(44, 44);
			applicationImageClearButton.TabIndex = 21;
			applicationImageClearButton.UseVisualStyleBackColor = true;
			applicationImageClearButton.Click += applicationImageClearButton_Click;
			// 
			// applicationImageFlowLayout
			// 
			applicationImageFlowLayout.AutoScroll = true;
			applicationTableLayout.SetColumnSpan(applicationImageFlowLayout, 5);
			applicationImageFlowLayout.Dock = DockStyle.Fill;
			applicationImageFlowLayout.Location = new Point(516, 103);
			applicationImageFlowLayout.Name = "applicationImageFlowLayout";
			applicationTableLayout.SetRowSpan(applicationImageFlowLayout, 4);
			applicationImageFlowLayout.Size = new Size(267, 312);
			applicationImageFlowLayout.TabIndex = 13;
			applicationImageFlowLayout.WrapContents = false;
			applicationImageFlowLayout.ControlAdded += StatusUpdated;
			// 
			// applicationResumeLabel
			// 
			applicationResumeLabel.AutoSize = true;
			applicationResumeLabel.Dock = DockStyle.Fill;
			applicationResumeLabel.Location = new Point(3, 418);
			applicationResumeLabel.Name = "applicationResumeLabel";
			applicationResumeLabel.Size = new Size(114, 50);
			applicationResumeLabel.TabIndex = 4;
			applicationResumeLabel.Text = "Resume:";
			// 
			// applicationResumeComboBox
			// 
			applicationResumeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			applicationResumeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			applicationTableLayout.SetColumnSpan(applicationResumeComboBox, 4);
			applicationResumeComboBox.Dock = DockStyle.Fill;
			applicationResumeComboBox.FormattingEnabled = true;
			applicationResumeComboBox.Items.AddRange(new object[] { "None" });
			applicationResumeComboBox.Location = new Point(123, 421);
			applicationResumeComboBox.Name = "applicationResumeComboBox";
			applicationResumeComboBox.Size = new Size(217, 33);
			applicationResumeComboBox.TabIndex = 28;
			applicationResumeComboBox.TextUpdate += StatusUpdated;
			// 
			// applicationResumeUploadButton
			// 
			applicationResumeUploadButton.Dock = DockStyle.Fill;
			applicationResumeUploadButton.Image = Properties.Resources.FolderOpened;
			applicationResumeUploadButton.Location = new Point(346, 421);
			applicationResumeUploadButton.Name = "applicationResumeUploadButton";
			applicationResumeUploadButton.Size = new Size(44, 44);
			applicationResumeUploadButton.TabIndex = 14;
			applicationResumeUploadButton.UseVisualStyleBackColor = true;
			applicationResumeUploadButton.Click += applicationResumeUploadButton_Click;
			// 
			// applicationCoverLetterLabel
			// 
			applicationCoverLetterLabel.AutoSize = true;
			applicationCoverLetterLabel.Dock = DockStyle.Fill;
			applicationCoverLetterLabel.Location = new Point(396, 418);
			applicationCoverLetterLabel.Name = "applicationCoverLetterLabel";
			applicationCoverLetterLabel.Size = new Size(114, 50);
			applicationCoverLetterLabel.TabIndex = 5;
			applicationCoverLetterLabel.Text = "Cover Letter:";
			// 
			// applicationCurrentCoverLetterLabel
			// 
			applicationCurrentCoverLetterLabel.AutoSize = true;
			applicationTableLayout.SetColumnSpan(applicationCurrentCoverLetterLabel, 3);
			applicationCurrentCoverLetterLabel.Dock = DockStyle.Fill;
			applicationCurrentCoverLetterLabel.Location = new Point(516, 418);
			applicationCurrentCoverLetterLabel.Name = "applicationCurrentCoverLetterLabel";
			applicationCurrentCoverLetterLabel.Size = new Size(167, 50);
			applicationCurrentCoverLetterLabel.TabIndex = 18;
			applicationCurrentCoverLetterLabel.Text = "None";
			applicationCurrentCoverLetterLabel.TextChanged += StatusUpdated;
			// 
			// applicationCoverLetterUploadButton
			// 
			applicationCoverLetterUploadButton.Dock = DockStyle.Fill;
			applicationCoverLetterUploadButton.Image = Properties.Resources.FolderOpened;
			applicationCoverLetterUploadButton.Location = new Point(689, 421);
			applicationCoverLetterUploadButton.Name = "applicationCoverLetterUploadButton";
			applicationCoverLetterUploadButton.Size = new Size(44, 44);
			applicationCoverLetterUploadButton.TabIndex = 15;
			applicationCoverLetterUploadButton.UseVisualStyleBackColor = true;
			applicationCoverLetterUploadButton.Click += applicationCoverLetterUploadButton_Click;
			// 
			// applicationCoverLetterDeleteButton
			// 
			applicationCoverLetterDeleteButton.Dock = DockStyle.Fill;
			applicationCoverLetterDeleteButton.Image = Properties.Resources.Close;
			applicationCoverLetterDeleteButton.Location = new Point(739, 421);
			applicationCoverLetterDeleteButton.Name = "applicationCoverLetterDeleteButton";
			applicationCoverLetterDeleteButton.Size = new Size(44, 44);
			applicationCoverLetterDeleteButton.TabIndex = 23;
			applicationCoverLetterDeleteButton.UseVisualStyleBackColor = true;
			applicationCoverLetterDeleteButton.Click += applicationCoverLetterDeleteButton_Click;
			// 
			// applicationInfoLabel
			// 
			applicationInfoLabel.AutoSize = true;
			applicationInfoLabel.Dock = DockStyle.Fill;
			applicationInfoLabel.Location = new Point(3, 468);
			applicationInfoLabel.Name = "applicationInfoLabel";
			applicationInfoLabel.Size = new Size(114, 169);
			applicationInfoLabel.TabIndex = 6;
			applicationInfoLabel.Text = "Info:";
			// 
			// applicationInfoTextBox
			// 
			applicationTableLayout.SetColumnSpan(applicationInfoTextBox, 11);
			applicationInfoTextBox.Dock = DockStyle.Fill;
			applicationInfoTextBox.Location = new Point(123, 471);
			applicationInfoTextBox.Multiline = true;
			applicationInfoTextBox.Name = "applicationInfoTextBox";
			applicationInfoTextBox.Size = new Size(660, 163);
			applicationInfoTextBox.TabIndex = 19;
			applicationInfoTextBox.TextChanged += StatusUpdated;
			// 
			// augmentationsTabPage
			// 
			augmentationsTabPage.Controls.Add(tableLayoutPanel1);
			augmentationsTabPage.Location = new Point(4, 34);
			augmentationsTabPage.Name = "augmentationsTabPage";
			augmentationsTabPage.Size = new Size(792, 643);
			augmentationsTabPage.TabIndex = 2;
			augmentationsTabPage.Text = "Augmentations";
			augmentationsTabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(companylabel, 0, 0);
			tableLayoutPanel1.Controls.Add(companyComboBox, 1, 0);
			tableLayoutPanel1.Controls.Add(creationTimeLabel, 0, 1);
			tableLayoutPanel1.Controls.Add(creationTimeDateTimePicker, 1, 1);
			tableLayoutPanel1.Controls.Add(statusLabel, 0, 2);
			tableLayoutPanel1.Controls.Add(statusComboBox, 1, 2);
			tableLayoutPanel1.Controls.Add(statusOtherLabel, 0, 3);
			tableLayoutPanel1.Controls.Add(statusOtherTextBox, 1, 3);
			tableLayoutPanel1.Controls.Add(statusTimeLabel, 0, 4);
			tableLayoutPanel1.Controls.Add(stausTimeDateTimePicker, 1, 4);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(792, 643);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// companylabel
			// 
			companylabel.AutoSize = true;
			companylabel.Dock = DockStyle.Fill;
			companylabel.Location = new Point(3, 0);
			companylabel.Name = "companylabel";
			companylabel.Size = new Size(194, 50);
			companylabel.TabIndex = 0;
			companylabel.Text = "Company:";
			// 
			// companyComboBox
			// 
			companyComboBox.Dock = DockStyle.Fill;
			companyComboBox.FormattingEnabled = true;
			companyComboBox.Location = new Point(203, 3);
			companyComboBox.Name = "companyComboBox";
			companyComboBox.Size = new Size(586, 33);
			companyComboBox.TabIndex = 4;
			// 
			// creationTimeLabel
			// 
			creationTimeLabel.AutoSize = true;
			creationTimeLabel.Dock = DockStyle.Fill;
			creationTimeLabel.Location = new Point(3, 50);
			creationTimeLabel.Name = "creationTimeLabel";
			creationTimeLabel.Size = new Size(194, 50);
			creationTimeLabel.TabIndex = 1;
			creationTimeLabel.Text = "Creation Time:";
			// 
			// creationTimeDateTimePicker
			// 
			creationTimeDateTimePicker.Dock = DockStyle.Fill;
			creationTimeDateTimePicker.Location = new Point(203, 53);
			creationTimeDateTimePicker.Name = "creationTimeDateTimePicker";
			creationTimeDateTimePicker.Size = new Size(586, 31);
			creationTimeDateTimePicker.TabIndex = 5;
			// 
			// statusLabel
			// 
			statusLabel.AutoSize = true;
			statusLabel.Dock = DockStyle.Fill;
			statusLabel.Location = new Point(3, 100);
			statusLabel.Name = "statusLabel";
			statusLabel.Size = new Size(194, 50);
			statusLabel.TabIndex = 2;
			statusLabel.Text = "Application Status:";
			// 
			// statusComboBox
			// 
			statusComboBox.Dock = DockStyle.Fill;
			statusComboBox.FormattingEnabled = true;
			statusComboBox.Location = new Point(203, 103);
			statusComboBox.Name = "statusComboBox";
			statusComboBox.Size = new Size(586, 33);
			statusComboBox.TabIndex = 7;
			// 
			// statusOtherLabel
			// 
			statusOtherLabel.AutoSize = true;
			statusOtherLabel.Dock = DockStyle.Fill;
			statusOtherLabel.Enabled = false;
			statusOtherLabel.Location = new Point(3, 150);
			statusOtherLabel.Name = "statusOtherLabel";
			statusOtherLabel.Size = new Size(194, 50);
			statusOtherLabel.TabIndex = 3;
			statusOtherLabel.Text = "Other:";
			// 
			// statusOtherTextBox
			// 
			statusOtherTextBox.Dock = DockStyle.Fill;
			statusOtherTextBox.Enabled = false;
			statusOtherTextBox.Location = new Point(203, 153);
			statusOtherTextBox.Name = "statusOtherTextBox";
			statusOtherTextBox.Size = new Size(586, 31);
			statusOtherTextBox.TabIndex = 9;
			// 
			// statusTimeLabel
			// 
			statusTimeLabel.AutoSize = true;
			statusTimeLabel.Dock = DockStyle.Fill;
			statusTimeLabel.Location = new Point(3, 200);
			statusTimeLabel.Name = "statusTimeLabel";
			statusTimeLabel.Size = new Size(194, 50);
			statusTimeLabel.TabIndex = 8;
			statusTimeLabel.Text = "Last Update Time:";
			// 
			// stausTimeDateTimePicker
			// 
			stausTimeDateTimePicker.Dock = DockStyle.Fill;
			stausTimeDateTimePicker.Location = new Point(203, 203);
			stausTimeDateTimePicker.Name = "stausTimeDateTimePicker";
			stausTimeDateTimePicker.Size = new Size(586, 31);
			stausTimeDateTimePicker.TabIndex = 6;
			// 
			// saveButton
			// 
			saveButton.Dock = DockStyle.Fill;
			saveButton.Location = new Point(3, 690);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(397, 44);
			saveButton.TabIndex = 1;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Dock = DockStyle.Fill;
			cancelButton.Location = new Point(406, 690);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(397, 44);
			cancelButton.TabIndex = 2;
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
			ClientSize = new Size(806, 737);
			Controls.Add(mainTableLayout);
			Name = "ApplicationEditor";
			ShowIcon = false;
			Text = "Application Editor";
			FormClosing += CreateApplication_FormClosing;
			Load += ApplicationEditor_Load;
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
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
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
		private Label applicationCurrentCoverLetterLabel;
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
		private TableLayoutPanel tableLayoutPanel1;
		private Label companylabel;
		private ComboBox companyComboBox;
		private Label creationTimeLabel;
		private Label statusLabel;
		private Label statusOtherLabel;
		private DateTimePicker creationTimeDateTimePicker;
		private DateTimePicker stausTimeDateTimePicker;
		private ComboBox statusComboBox;
		private Label statusTimeLabel;
		private TextBox statusOtherTextBox;
	}
}