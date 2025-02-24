namespace JAM
{
	partial class CompanyViewer
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
			nameLabel = new Label();
			nameValueLabel = new Label();
			applicationAmountLabel = new Label();
			applicationAmountValueLabel = new Label();
			websiteLabel = new Label();
			websitePanel = new Panel();
			websiteValueLabel = new LinkLabel();
			careerWebsiteLabel = new Label();
			careerWebsitePanel = new Panel();
			careerWebsiteValueLabel = new LinkLabel();
			careerHomeLabel = new Label();
			careerHomePanel = new Panel();
			careerHomeValueLabel = new LinkLabel();
			emailLabel = new Label();
			emailValueTextBox = new TextBox();
			passwordLabel = new Label();
			passwordValueTextBox = new TextBox();
			passwordViewButton = new Button();
			infoLabel = new Label();
			infoValueTextBox = new TextBox();
			doneButton = new Button();
			mainTableLayout.SuspendLayout();
			websitePanel.SuspendLayout();
			careerWebsitePanel.SuspendLayout();
			careerHomePanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayout
			// 
			mainTableLayout.ColumnCount = 3;
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			mainTableLayout.Controls.Add(nameLabel, 0, 0);
			mainTableLayout.Controls.Add(nameValueLabel, 1, 0);
			mainTableLayout.Controls.Add(applicationAmountLabel, 0, 1);
			mainTableLayout.Controls.Add(applicationAmountValueLabel, 1, 1);
			mainTableLayout.Controls.Add(websiteLabel, 0, 2);
			mainTableLayout.Controls.Add(websitePanel, 1, 2);
			mainTableLayout.Controls.Add(careerWebsiteLabel, 0, 3);
			mainTableLayout.Controls.Add(careerWebsitePanel, 1, 3);
			mainTableLayout.Controls.Add(careerHomeLabel, 0, 4);
			mainTableLayout.Controls.Add(careerHomePanel, 1, 4);
			mainTableLayout.Controls.Add(emailLabel, 0, 5);
			mainTableLayout.Controls.Add(emailValueTextBox, 1, 5);
			mainTableLayout.Controls.Add(passwordLabel, 0, 6);
			mainTableLayout.Controls.Add(passwordValueTextBox, 1, 6);
			mainTableLayout.Controls.Add(passwordViewButton, 2, 6);
			mainTableLayout.Controls.Add(infoLabel, 0, 7);
			mainTableLayout.Controls.Add(infoValueTextBox, 1, 7);
			mainTableLayout.Controls.Add(doneButton, 0, 8);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 9;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			mainTableLayout.Size = new Size(463, 636);
			mainTableLayout.TabIndex = 0;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Dock = DockStyle.Fill;
			nameLabel.Location = new Point(3, 0);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(144, 40);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "Name:";
			// 
			// nameValueLabel
			// 
			nameValueLabel.AutoSize = true;
			mainTableLayout.SetColumnSpan(nameValueLabel, 2);
			nameValueLabel.Dock = DockStyle.Fill;
			nameValueLabel.Location = new Point(153, 0);
			nameValueLabel.Name = "nameValueLabel";
			nameValueLabel.Size = new Size(307, 40);
			nameValueLabel.TabIndex = 1;
			// 
			// applicationAmountLabel
			// 
			applicationAmountLabel.AutoSize = true;
			applicationAmountLabel.Dock = DockStyle.Fill;
			applicationAmountLabel.Location = new Point(3, 40);
			applicationAmountLabel.Name = "applicationAmountLabel";
			applicationAmountLabel.Size = new Size(144, 60);
			applicationAmountLabel.TabIndex = 2;
			applicationAmountLabel.Text = "Number of applications:";
			// 
			// applicationAmountValueLabel
			// 
			applicationAmountValueLabel.AutoSize = true;
			mainTableLayout.SetColumnSpan(applicationAmountValueLabel, 2);
			applicationAmountValueLabel.Dock = DockStyle.Fill;
			applicationAmountValueLabel.Location = new Point(153, 40);
			applicationAmountValueLabel.Name = "applicationAmountValueLabel";
			applicationAmountValueLabel.Size = new Size(307, 60);
			applicationAmountValueLabel.TabIndex = 3;
			// 
			// websiteLabel
			// 
			websiteLabel.AutoSize = true;
			websiteLabel.Dock = DockStyle.Fill;
			websiteLabel.Location = new Point(3, 100);
			websiteLabel.Name = "websiteLabel";
			websiteLabel.Size = new Size(144, 40);
			websiteLabel.TabIndex = 4;
			websiteLabel.Text = "Website:";
			// 
			// websitePanel
			// 
			mainTableLayout.SetColumnSpan(websitePanel, 2);
			websitePanel.Controls.Add(websiteValueLabel);
			websitePanel.Dock = DockStyle.Fill;
			websitePanel.Location = new Point(153, 103);
			websitePanel.Name = "websitePanel";
			websitePanel.Size = new Size(307, 34);
			websitePanel.TabIndex = 18;
			// 
			// websiteValueLabel
			// 
			websiteValueLabel.AutoSize = true;
			websiteValueLabel.Dock = DockStyle.Fill;
			websiteValueLabel.Location = new Point(0, 0);
			websiteValueLabel.Name = "websiteValueLabel";
			websiteValueLabel.Size = new Size(0, 25);
			websiteValueLabel.TabIndex = 5;
			websiteValueLabel.LinkClicked += LinkClicked;
			// 
			// careerWebsiteLabel
			// 
			careerWebsiteLabel.AutoSize = true;
			careerWebsiteLabel.Dock = DockStyle.Fill;
			careerWebsiteLabel.Location = new Point(3, 140);
			careerWebsiteLabel.Name = "careerWebsiteLabel";
			careerWebsiteLabel.Size = new Size(144, 40);
			careerWebsiteLabel.TabIndex = 6;
			careerWebsiteLabel.Text = "Career Website:";
			// 
			// careerWebsitePanel
			// 
			mainTableLayout.SetColumnSpan(careerWebsitePanel, 2);
			careerWebsitePanel.Controls.Add(careerWebsiteValueLabel);
			careerWebsitePanel.Dock = DockStyle.Fill;
			careerWebsitePanel.Location = new Point(153, 143);
			careerWebsitePanel.Name = "careerWebsitePanel";
			careerWebsitePanel.Size = new Size(307, 34);
			careerWebsitePanel.TabIndex = 19;
			// 
			// careerWebsiteValueLabel
			// 
			careerWebsiteValueLabel.AutoSize = true;
			careerWebsiteValueLabel.Dock = DockStyle.Fill;
			careerWebsiteValueLabel.Location = new Point(0, 0);
			careerWebsiteValueLabel.Name = "careerWebsiteValueLabel";
			careerWebsiteValueLabel.Size = new Size(0, 25);
			careerWebsiteValueLabel.TabIndex = 7;
			careerWebsiteValueLabel.LinkClicked += LinkClicked;
			// 
			// careerHomeLabel
			// 
			careerHomeLabel.AutoSize = true;
			careerHomeLabel.Dock = DockStyle.Fill;
			careerHomeLabel.Location = new Point(3, 180);
			careerHomeLabel.Name = "careerHomeLabel";
			careerHomeLabel.Size = new Size(144, 40);
			careerHomeLabel.TabIndex = 8;
			careerHomeLabel.Text = "Career Home:";
			// 
			// careerHomePanel
			// 
			mainTableLayout.SetColumnSpan(careerHomePanel, 2);
			careerHomePanel.Controls.Add(careerHomeValueLabel);
			careerHomePanel.Dock = DockStyle.Fill;
			careerHomePanel.Location = new Point(153, 183);
			careerHomePanel.Name = "careerHomePanel";
			careerHomePanel.Size = new Size(307, 34);
			careerHomePanel.TabIndex = 20;
			// 
			// careerHomeValueLabel
			// 
			careerHomeValueLabel.AutoSize = true;
			careerHomeValueLabel.Dock = DockStyle.Fill;
			careerHomeValueLabel.Location = new Point(0, 0);
			careerHomeValueLabel.Name = "careerHomeValueLabel";
			careerHomeValueLabel.Size = new Size(0, 25);
			careerHomeValueLabel.TabIndex = 9;
			careerHomeValueLabel.LinkClicked += LinkClicked;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Dock = DockStyle.Fill;
			emailLabel.Location = new Point(3, 220);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(144, 40);
			emailLabel.TabIndex = 10;
			emailLabel.Text = "Email:";
			// 
			// emailValueTextBox
			// 
			mainTableLayout.SetColumnSpan(emailValueTextBox, 2);
			emailValueTextBox.Dock = DockStyle.Fill;
			emailValueTextBox.Location = new Point(153, 223);
			emailValueTextBox.Name = "emailValueTextBox";
			emailValueTextBox.ReadOnly = true;
			emailValueTextBox.Size = new Size(307, 31);
			emailValueTextBox.TabIndex = 11;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Dock = DockStyle.Fill;
			passwordLabel.Location = new Point(3, 260);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(144, 40);
			passwordLabel.TabIndex = 12;
			passwordLabel.Text = "Password:";
			// 
			// passwordValueTextBox
			// 
			passwordValueTextBox.Dock = DockStyle.Fill;
			passwordValueTextBox.Location = new Point(153, 263);
			passwordValueTextBox.Name = "passwordValueTextBox";
			passwordValueTextBox.PasswordChar = '•';
			passwordValueTextBox.ReadOnly = true;
			passwordValueTextBox.Size = new Size(257, 31);
			passwordValueTextBox.TabIndex = 13;
			// 
			// passwordViewButton
			// 
			passwordViewButton.Dock = DockStyle.Fill;
			passwordViewButton.Image = Properties.Resources.Visible;
			passwordViewButton.Location = new Point(416, 263);
			passwordViewButton.Name = "passwordViewButton";
			passwordViewButton.Size = new Size(44, 34);
			passwordViewButton.TabIndex = 14;
			passwordViewButton.UseVisualStyleBackColor = true;
			passwordViewButton.Click += passwordViewButton_Click;
			// 
			// infoLabel
			// 
			infoLabel.AutoSize = true;
			infoLabel.Dock = DockStyle.Fill;
			infoLabel.Location = new Point(3, 300);
			infoLabel.Name = "infoLabel";
			infoLabel.Size = new Size(144, 286);
			infoLabel.TabIndex = 15;
			infoLabel.Text = "Info:";
			// 
			// infoValueTextBox
			// 
			mainTableLayout.SetColumnSpan(infoValueTextBox, 2);
			infoValueTextBox.Dock = DockStyle.Fill;
			infoValueTextBox.Location = new Point(153, 303);
			infoValueTextBox.Multiline = true;
			infoValueTextBox.Name = "infoValueTextBox";
			infoValueTextBox.ReadOnly = true;
			infoValueTextBox.ScrollBars = ScrollBars.Vertical;
			infoValueTextBox.Size = new Size(307, 280);
			infoValueTextBox.TabIndex = 16;
			// 
			// doneButton
			// 
			mainTableLayout.SetColumnSpan(doneButton, 3);
			doneButton.Dock = DockStyle.Fill;
			doneButton.Location = new Point(3, 589);
			doneButton.Name = "doneButton";
			doneButton.Size = new Size(457, 44);
			doneButton.TabIndex = 17;
			doneButton.Text = "Done";
			doneButton.UseVisualStyleBackColor = true;
			doneButton.Click += doneButton_Click;
			// 
			// CompanyViewer
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(463, 636);
			Controls.Add(mainTableLayout);
			Name = "CompanyViewer";
			ShowIcon = false;
			Text = "Company Viewer";
			FormClosing += CompanyViewer_FormClosing;
			Load += CompanyViewer_Load;
			mainTableLayout.ResumeLayout(false);
			mainTableLayout.PerformLayout();
			websitePanel.ResumeLayout(false);
			websitePanel.PerformLayout();
			careerWebsitePanel.ResumeLayout(false);
			careerWebsitePanel.PerformLayout();
			careerHomePanel.ResumeLayout(false);
			careerHomePanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayout;
		private Label nameLabel;
		private Label nameValueLabel;
		private Label applicationAmountLabel;
		private Label applicationAmountValueLabel;
		private Label websiteLabel;
		private LinkLabel websiteValueLabel;
		private Label careerWebsiteLabel;
		private LinkLabel careerWebsiteValueLabel;
		private Label careerHomeLabel;
		private LinkLabel careerHomeValueLabel;
		private Label emailLabel;
		private Label passwordLabel;
		private Button passwordViewButton;
		private Label infoLabel;
		private TextBox infoValueTextBox;
		private Button doneButton;
		private TextBox passwordValueTextBox;
		private Panel websitePanel;
		private Panel careerWebsitePanel;
		private Panel careerHomePanel;
		private TextBox emailValueTextBox;
	}
}