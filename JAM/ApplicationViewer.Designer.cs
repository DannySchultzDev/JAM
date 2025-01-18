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
			textTableLayout = new TableLayoutPanel();
			positionLabel = new Label();
			positionValueLabel = new Label();
			companyLabel = new Label();
			companyValueLabel = new Label();
			companyOpenButton = new Button();
			statusLabel = new Label();
			statusValueLabel = new Label();
			lastUpdateTimeLabel = new Label();
			lastUpdateTimeValueLabel = new Label();
			linkLabel = new Label();
			linkValueLabel = new LinkLabel();
			applicationTypeLabel = new Label();
			applicationTypeValueLabel = new Label();
			locationLabel = new Label();
			locationValueLabel = new Label();
			salaryLabel = new Label();
			salaryValueLabel = new Label();
			resumeLabel = new Label();
			resumeValueLabel = new Label();
			resumeOpenButton = new Button();
			coverLetterLabel = new Label();
			coverLetterValueLabel = new Label();
			coverLetterOpenButton = new Button();
			creationTimeLabel = new Label();
			creationTimeValueLabel = new Label();
			infoLabel = new Label();
			infoValueTextBox = new TextBox();
			imageLabel = new Label();
			imageFlowLayout = new FlowLayoutPanel();
			doneButton = new Button();
			mainSplitContainer = new SplitContainer();
			imageTableLayout = new TableLayoutPanel();
			mainTableLayout = new TableLayoutPanel();
			textTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
			mainSplitContainer.Panel1.SuspendLayout();
			mainSplitContainer.Panel2.SuspendLayout();
			mainSplitContainer.SuspendLayout();
			imageTableLayout.SuspendLayout();
			mainTableLayout.SuspendLayout();
			SuspendLayout();
			// 
			// textTableLayout
			// 
			textTableLayout.ColumnCount = 3;
			textTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			textTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			textTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			textTableLayout.Controls.Add(positionLabel, 0, 0);
			textTableLayout.Controls.Add(positionValueLabel, 1, 0);
			textTableLayout.Controls.Add(companyLabel, 0, 1);
			textTableLayout.Controls.Add(companyValueLabel, 1, 1);
			textTableLayout.Controls.Add(companyOpenButton, 2, 1);
			textTableLayout.Controls.Add(statusLabel, 0, 2);
			textTableLayout.Controls.Add(statusValueLabel, 1, 2);
			textTableLayout.Controls.Add(lastUpdateTimeLabel, 0, 3);
			textTableLayout.Controls.Add(lastUpdateTimeValueLabel, 1, 3);
			textTableLayout.Controls.Add(linkLabel, 0, 4);
			textTableLayout.Controls.Add(linkValueLabel, 1, 4);
			textTableLayout.Controls.Add(applicationTypeLabel, 0, 5);
			textTableLayout.Controls.Add(applicationTypeValueLabel, 1, 5);
			textTableLayout.Controls.Add(locationLabel, 0, 6);
			textTableLayout.Controls.Add(locationValueLabel, 1, 6);
			textTableLayout.Controls.Add(salaryLabel, 0, 7);
			textTableLayout.Controls.Add(salaryValueLabel, 1, 7);
			textTableLayout.Controls.Add(resumeLabel, 0, 8);
			textTableLayout.Controls.Add(resumeValueLabel, 1, 8);
			textTableLayout.Controls.Add(resumeOpenButton, 2, 8);
			textTableLayout.Controls.Add(coverLetterLabel, 0, 9);
			textTableLayout.Controls.Add(coverLetterValueLabel, 1, 9);
			textTableLayout.Controls.Add(coverLetterOpenButton, 2, 9);
			textTableLayout.Controls.Add(creationTimeLabel, 0, 10);
			textTableLayout.Controls.Add(creationTimeValueLabel, 1, 10);
			textTableLayout.Controls.Add(infoLabel, 0, 11);
			textTableLayout.Controls.Add(infoValueTextBox, 1, 11);
			textTableLayout.Dock = DockStyle.Fill;
			textTableLayout.Location = new Point(0, 0);
			textTableLayout.Name = "textTableLayout";
			textTableLayout.RowCount = 12;
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			textTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			textTableLayout.Size = new Size(494, 794);
			textTableLayout.TabIndex = 0;
			// 
			// positionLabel
			// 
			positionLabel.AutoSize = true;
			positionLabel.Dock = DockStyle.Fill;
			positionLabel.Location = new Point(3, 0);
			positionLabel.Name = "positionLabel";
			positionLabel.Size = new Size(144, 50);
			positionLabel.TabIndex = 0;
			positionLabel.Text = "Position:";
			// 
			// positionValueLabel
			// 
			positionValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(positionValueLabel, 2);
			positionValueLabel.Dock = DockStyle.Fill;
			positionValueLabel.Location = new Point(153, 0);
			positionValueLabel.Name = "positionValueLabel";
			positionValueLabel.Size = new Size(338, 50);
			positionValueLabel.TabIndex = 1;
			// 
			// companyLabel
			// 
			companyLabel.AutoSize = true;
			companyLabel.Dock = DockStyle.Fill;
			companyLabel.Location = new Point(3, 50);
			companyLabel.Name = "companyLabel";
			companyLabel.Size = new Size(144, 50);
			companyLabel.TabIndex = 2;
			companyLabel.Text = "Company:";
			// 
			// companyValueLabel
			// 
			companyValueLabel.AutoSize = true;
			companyValueLabel.Dock = DockStyle.Fill;
			companyValueLabel.Location = new Point(153, 50);
			companyValueLabel.Name = "companyValueLabel";
			companyValueLabel.Size = new Size(288, 50);
			companyValueLabel.TabIndex = 3;
			// 
			// companyOpenButton
			// 
			companyOpenButton.Dock = DockStyle.Fill;
			companyOpenButton.Image = Properties.Resources.Open;
			companyOpenButton.Location = new Point(447, 53);
			companyOpenButton.Name = "companyOpenButton";
			companyOpenButton.Size = new Size(44, 44);
			companyOpenButton.TabIndex = 4;
			companyOpenButton.UseVisualStyleBackColor = true;
			companyOpenButton.Click += companyOpenButton_Click;
			// 
			// statusLabel
			// 
			statusLabel.AutoSize = true;
			statusLabel.Dock = DockStyle.Fill;
			statusLabel.Location = new Point(3, 100);
			statusLabel.Name = "statusLabel";
			statusLabel.Size = new Size(144, 50);
			statusLabel.TabIndex = 5;
			statusLabel.Text = "Status:";
			// 
			// statusValueLabel
			// 
			statusValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(statusValueLabel, 2);
			statusValueLabel.Dock = DockStyle.Fill;
			statusValueLabel.Location = new Point(153, 100);
			statusValueLabel.Name = "statusValueLabel";
			statusValueLabel.Size = new Size(338, 50);
			statusValueLabel.TabIndex = 6;
			// 
			// lastUpdateTimeLabel
			// 
			lastUpdateTimeLabel.AutoSize = true;
			lastUpdateTimeLabel.Dock = DockStyle.Fill;
			lastUpdateTimeLabel.Location = new Point(3, 150);
			lastUpdateTimeLabel.Name = "lastUpdateTimeLabel";
			lastUpdateTimeLabel.Size = new Size(144, 50);
			lastUpdateTimeLabel.TabIndex = 7;
			lastUpdateTimeLabel.Text = "Last Update Time:";
			// 
			// lastUpdateTimeValueLabel
			// 
			lastUpdateTimeValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(lastUpdateTimeValueLabel, 2);
			lastUpdateTimeValueLabel.Dock = DockStyle.Fill;
			lastUpdateTimeValueLabel.Location = new Point(153, 150);
			lastUpdateTimeValueLabel.Name = "lastUpdateTimeValueLabel";
			lastUpdateTimeValueLabel.Size = new Size(338, 50);
			lastUpdateTimeValueLabel.TabIndex = 8;
			// 
			// linkLabel
			// 
			linkLabel.AutoSize = true;
			linkLabel.Dock = DockStyle.Fill;
			linkLabel.Location = new Point(3, 200);
			linkLabel.Name = "linkLabel";
			linkLabel.Size = new Size(144, 50);
			linkLabel.TabIndex = 9;
			linkLabel.Text = "Link:";
			// 
			// linkValueLabel
			// 
			linkValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(linkValueLabel, 2);
			linkValueLabel.Dock = DockStyle.Fill;
			linkValueLabel.Location = new Point(153, 200);
			linkValueLabel.Name = "linkValueLabel";
			linkValueLabel.Size = new Size(338, 50);
			linkValueLabel.TabIndex = 10;
			linkValueLabel.LinkClicked += linkValueLabel_LinkClicked;
			// 
			// applicationTypeLabel
			// 
			applicationTypeLabel.AutoSize = true;
			applicationTypeLabel.Dock = DockStyle.Fill;
			applicationTypeLabel.Location = new Point(3, 250);
			applicationTypeLabel.Name = "applicationTypeLabel";
			applicationTypeLabel.Size = new Size(144, 50);
			applicationTypeLabel.TabIndex = 11;
			applicationTypeLabel.Text = "Application Type:";
			// 
			// applicationTypeValueLabel
			// 
			applicationTypeValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(applicationTypeValueLabel, 2);
			applicationTypeValueLabel.Dock = DockStyle.Fill;
			applicationTypeValueLabel.Location = new Point(153, 250);
			applicationTypeValueLabel.Name = "applicationTypeValueLabel";
			applicationTypeValueLabel.Size = new Size(338, 50);
			applicationTypeValueLabel.TabIndex = 12;
			// 
			// locationLabel
			// 
			locationLabel.AutoSize = true;
			locationLabel.Dock = DockStyle.Fill;
			locationLabel.Location = new Point(3, 300);
			locationLabel.Name = "locationLabel";
			locationLabel.Size = new Size(144, 50);
			locationLabel.TabIndex = 13;
			locationLabel.Text = "Location:";
			// 
			// locationValueLabel
			// 
			locationValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(locationValueLabel, 2);
			locationValueLabel.Dock = DockStyle.Fill;
			locationValueLabel.Location = new Point(153, 300);
			locationValueLabel.Name = "locationValueLabel";
			locationValueLabel.Size = new Size(338, 50);
			locationValueLabel.TabIndex = 14;
			// 
			// salaryLabel
			// 
			salaryLabel.AutoSize = true;
			salaryLabel.Dock = DockStyle.Fill;
			salaryLabel.Location = new Point(3, 350);
			salaryLabel.Name = "salaryLabel";
			salaryLabel.Size = new Size(144, 50);
			salaryLabel.TabIndex = 15;
			salaryLabel.Text = "Salary:";
			// 
			// salaryValueLabel
			// 
			salaryValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(salaryValueLabel, 2);
			salaryValueLabel.Dock = DockStyle.Fill;
			salaryValueLabel.Location = new Point(153, 350);
			salaryValueLabel.Name = "salaryValueLabel";
			salaryValueLabel.Size = new Size(338, 50);
			salaryValueLabel.TabIndex = 16;
			// 
			// resumeLabel
			// 
			resumeLabel.AutoSize = true;
			resumeLabel.Dock = DockStyle.Fill;
			resumeLabel.Location = new Point(3, 400);
			resumeLabel.Name = "resumeLabel";
			resumeLabel.Size = new Size(144, 50);
			resumeLabel.TabIndex = 17;
			resumeLabel.Text = "Resume:";
			// 
			// resumeValueLabel
			// 
			resumeValueLabel.AutoSize = true;
			resumeValueLabel.Dock = DockStyle.Fill;
			resumeValueLabel.Location = new Point(153, 400);
			resumeValueLabel.Name = "resumeValueLabel";
			resumeValueLabel.Size = new Size(288, 50);
			resumeValueLabel.TabIndex = 27;
			// 
			// resumeOpenButton
			// 
			resumeOpenButton.Dock = DockStyle.Fill;
			resumeOpenButton.Image = Properties.Resources.Open;
			resumeOpenButton.Location = new Point(447, 403);
			resumeOpenButton.Name = "resumeOpenButton";
			resumeOpenButton.Size = new Size(44, 44);
			resumeOpenButton.TabIndex = 19;
			resumeOpenButton.UseVisualStyleBackColor = true;
			resumeOpenButton.Click += resumeOpenButton_Click;
			// 
			// coverLetterLabel
			// 
			coverLetterLabel.AutoSize = true;
			coverLetterLabel.Dock = DockStyle.Fill;
			coverLetterLabel.Location = new Point(3, 450);
			coverLetterLabel.Name = "coverLetterLabel";
			coverLetterLabel.Size = new Size(144, 50);
			coverLetterLabel.TabIndex = 20;
			coverLetterLabel.Text = "Cover Letter:";
			// 
			// coverLetterValueLabel
			// 
			coverLetterValueLabel.AutoSize = true;
			coverLetterValueLabel.Dock = DockStyle.Fill;
			coverLetterValueLabel.Location = new Point(153, 450);
			coverLetterValueLabel.Name = "coverLetterValueLabel";
			coverLetterValueLabel.Size = new Size(288, 50);
			coverLetterValueLabel.TabIndex = 28;
			// 
			// coverLetterOpenButton
			// 
			coverLetterOpenButton.Dock = DockStyle.Fill;
			coverLetterOpenButton.Image = Properties.Resources.Open;
			coverLetterOpenButton.Location = new Point(447, 453);
			coverLetterOpenButton.Name = "coverLetterOpenButton";
			coverLetterOpenButton.Size = new Size(44, 44);
			coverLetterOpenButton.TabIndex = 22;
			coverLetterOpenButton.UseVisualStyleBackColor = true;
			coverLetterOpenButton.Click += coverLetterOpenButton_Click;
			// 
			// creationTimeLabel
			// 
			creationTimeLabel.AutoSize = true;
			creationTimeLabel.Dock = DockStyle.Fill;
			creationTimeLabel.Location = new Point(3, 500);
			creationTimeLabel.Name = "creationTimeLabel";
			creationTimeLabel.Size = new Size(144, 50);
			creationTimeLabel.TabIndex = 23;
			creationTimeLabel.Text = "Creation Time:";
			// 
			// creationTimeValueLabel
			// 
			creationTimeValueLabel.AutoSize = true;
			textTableLayout.SetColumnSpan(creationTimeValueLabel, 2);
			creationTimeValueLabel.Dock = DockStyle.Fill;
			creationTimeValueLabel.Location = new Point(153, 500);
			creationTimeValueLabel.Name = "creationTimeValueLabel";
			creationTimeValueLabel.Size = new Size(338, 50);
			creationTimeValueLabel.TabIndex = 24;
			// 
			// infoLabel
			// 
			infoLabel.AutoSize = true;
			infoLabel.Dock = DockStyle.Fill;
			infoLabel.Location = new Point(3, 550);
			infoLabel.Name = "infoLabel";
			infoLabel.Size = new Size(144, 244);
			infoLabel.TabIndex = 25;
			infoLabel.Text = "Info:";
			// 
			// infoValueTextBox
			// 
			textTableLayout.SetColumnSpan(infoValueTextBox, 2);
			infoValueTextBox.Dock = DockStyle.Fill;
			infoValueTextBox.Location = new Point(153, 553);
			infoValueTextBox.Multiline = true;
			infoValueTextBox.Name = "infoValueTextBox";
			infoValueTextBox.ReadOnly = true;
			infoValueTextBox.Size = new Size(338, 238);
			infoValueTextBox.TabIndex = 26;
			// 
			// imageLabel
			// 
			imageLabel.AutoSize = true;
			imageLabel.Dock = DockStyle.Fill;
			imageLabel.Location = new Point(3, 0);
			imageLabel.Name = "imageLabel";
			imageLabel.Size = new Size(440, 50);
			imageLabel.TabIndex = 27;
			imageLabel.Text = "Backup Images:";
			// 
			// imageFlowLayout
			// 
			imageFlowLayout.AutoScroll = true;
			imageFlowLayout.Dock = DockStyle.Fill;
			imageFlowLayout.FlowDirection = FlowDirection.TopDown;
			imageFlowLayout.Location = new Point(3, 53);
			imageFlowLayout.Name = "imageFlowLayout";
			imageFlowLayout.Size = new Size(440, 738);
			imageFlowLayout.TabIndex = 28;
			imageFlowLayout.WrapContents = false;
			// 
			// doneButton
			// 
			doneButton.Dock = DockStyle.Fill;
			doneButton.Location = new Point(3, 805);
			doneButton.Name = "doneButton";
			doneButton.Size = new Size(948, 44);
			doneButton.TabIndex = 29;
			doneButton.Text = "Done";
			doneButton.UseVisualStyleBackColor = true;
			doneButton.Click += doneButton_Click;
			// 
			// mainSplitContainer
			// 
			mainSplitContainer.BorderStyle = BorderStyle.FixedSingle;
			mainSplitContainer.Dock = DockStyle.Fill;
			mainSplitContainer.Location = new Point(3, 3);
			mainSplitContainer.Name = "mainSplitContainer";
			// 
			// mainSplitContainer.Panel1
			// 
			mainSplitContainer.Panel1.Controls.Add(textTableLayout);
			// 
			// mainSplitContainer.Panel2
			// 
			mainSplitContainer.Panel2.Controls.Add(imageTableLayout);
			mainSplitContainer.Size = new Size(948, 796);
			mainSplitContainer.SplitterDistance = 496;
			mainSplitContainer.TabIndex = 1;
			// 
			// imageTableLayout
			// 
			imageTableLayout.ColumnCount = 1;
			imageTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			imageTableLayout.Controls.Add(imageLabel, 0, 0);
			imageTableLayout.Controls.Add(imageFlowLayout, 0, 1);
			imageTableLayout.Dock = DockStyle.Fill;
			imageTableLayout.Location = new Point(0, 0);
			imageTableLayout.Name = "imageTableLayout";
			imageTableLayout.RowCount = 2;
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			imageTableLayout.Size = new Size(446, 794);
			imageTableLayout.TabIndex = 0;
			// 
			// mainTableLayout
			// 
			mainTableLayout.ColumnCount = 1;
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			mainTableLayout.Controls.Add(mainSplitContainer, 0, 0);
			mainTableLayout.Controls.Add(doneButton, 0, 1);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 2;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainTableLayout.Size = new Size(954, 852);
			mainTableLayout.TabIndex = 30;
			// 
			// ApplicationViewer
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(954, 852);
			Controls.Add(mainTableLayout);
			Name = "ApplicationViewer";
			ShowIcon = false;
			Text = "Application Viewer";
			FormClosing += ApplicationViewer_FormClosing;
			Load += ApplicationViewer_Load;
			textTableLayout.ResumeLayout(false);
			textTableLayout.PerformLayout();
			mainSplitContainer.Panel1.ResumeLayout(false);
			mainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
			mainSplitContainer.ResumeLayout(false);
			imageTableLayout.ResumeLayout(false);
			imageTableLayout.PerformLayout();
			mainTableLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel textTableLayout;
		private Label positionLabel;
		private Label positionValueLabel;
		private Label companyLabel;
		private Label companyValueLabel;
		private Label statusLabel;
		private Label statusValueLabel;
		private Label lastUpdateTimeLabel;
		private Label lastUpdateTimeValueLabel;
		private Label linkLabel;
		private LinkLabel linkValueLabel;
		private Label applicationTypeLabel;
		private Label applicationTypeValueLabel;
		private Label locationLabel;
		private Label locationValueLabel;
		private Label salaryLabel;
		private Label salaryValueLabel;
		private Label resumeLabel;
		private Label coverLetterLabel;
		private Label creationTimeLabel;
		private Label creationTimeValueLabel;
		private Label infoLabel;
		private TextBox infoValueTextBox;
		private Label imageLabel;
		private FlowLayoutPanel imageFlowLayout;
		private Button doneButton;
		private SplitContainer mainSplitContainer;
		private TableLayoutPanel imageTableLayout;
		private TableLayoutPanel mainTableLayout;
		private Button companyOpenButton;
		private Button resumeOpenButton;
		private Button coverLetterOpenButton;
		private Label resumeValueLabel;
		private Label coverLetterValueLabel;
	}
}