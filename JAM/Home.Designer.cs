namespace JAM
{
	partial class Home
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			mainTableLayoutPanel = new TableLayoutPanel();
			createApplicationButton = new Button();
			viewApplicationsButton = new Button();
			quickStatsButton = new Button();
			settingsButton = new Button();
			creditsLPictureBox = new PictureBox();
			creditsButton = new Button();
			creditsRPictureBox = new PictureBox();
			mainTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)creditsLPictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)creditsRPictureBox).BeginInit();
			SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			mainTableLayoutPanel.ColumnCount = 3;
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.Controls.Add(createApplicationButton, 0, 0);
			mainTableLayoutPanel.Controls.Add(viewApplicationsButton, 0, 1);
			mainTableLayoutPanel.Controls.Add(quickStatsButton, 0, 2);
			mainTableLayoutPanel.Controls.Add(settingsButton, 0, 3);
			mainTableLayoutPanel.Controls.Add(creditsLPictureBox, 0, 4);
			mainTableLayoutPanel.Controls.Add(creditsButton, 1, 4);
			mainTableLayoutPanel.Controls.Add(creditsRPictureBox, 2, 4);
			mainTableLayoutPanel.Dock = DockStyle.Fill;
			mainTableLayoutPanel.Location = new Point(0, 0);
			mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			mainTableLayoutPanel.Padding = new Padding(3);
			mainTableLayoutPanel.RowCount = 5;
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			mainTableLayoutPanel.Size = new Size(372, 266);
			mainTableLayoutPanel.TabIndex = 0;
			// 
			// createApplicationButton
			// 
			mainTableLayoutPanel.SetColumnSpan(createApplicationButton, 3);
			createApplicationButton.Dock = DockStyle.Fill;
			createApplicationButton.Location = new Point(6, 6);
			createApplicationButton.Name = "createApplicationButton";
			createApplicationButton.Size = new Size(360, 46);
			createApplicationButton.TabIndex = 0;
			createApplicationButton.Text = "Create Application";
			createApplicationButton.UseVisualStyleBackColor = true;
			createApplicationButton.Click += createApplicationButton_Click;
			// 
			// viewApplicationsButton
			// 
			mainTableLayoutPanel.SetColumnSpan(viewApplicationsButton, 3);
			viewApplicationsButton.Dock = DockStyle.Fill;
			viewApplicationsButton.Location = new Point(6, 58);
			viewApplicationsButton.Name = "viewApplicationsButton";
			viewApplicationsButton.Size = new Size(360, 46);
			viewApplicationsButton.TabIndex = 1;
			viewApplicationsButton.Text = "View Applications";
			viewApplicationsButton.UseVisualStyleBackColor = true;
			viewApplicationsButton.Click += viewApplicationsButton_Click;
			// 
			// quickStatsButton
			// 
			mainTableLayoutPanel.SetColumnSpan(quickStatsButton, 3);
			quickStatsButton.Dock = DockStyle.Fill;
			quickStatsButton.Location = new Point(6, 110);
			quickStatsButton.Name = "quickStatsButton";
			quickStatsButton.Size = new Size(360, 46);
			quickStatsButton.TabIndex = 3;
			quickStatsButton.Text = "Quick Stats";
			quickStatsButton.UseVisualStyleBackColor = true;
			quickStatsButton.Click += quickStatsButton_Click;
			// 
			// settingsButton
			// 
			mainTableLayoutPanel.SetColumnSpan(settingsButton, 3);
			settingsButton.Dock = DockStyle.Fill;
			settingsButton.Location = new Point(6, 162);
			settingsButton.Name = "settingsButton";
			settingsButton.Size = new Size(360, 46);
			settingsButton.TabIndex = 2;
			settingsButton.Text = "Settings";
			settingsButton.UseVisualStyleBackColor = true;
			settingsButton.Click += settingsButton_Click;
			// 
			// creditsLPictureBox
			// 
			creditsLPictureBox.Dock = DockStyle.Fill;
			creditsLPictureBox.Image = Properties.Resources.WAH;
			creditsLPictureBox.Location = new Point(6, 214);
			creditsLPictureBox.Name = "creditsLPictureBox";
			creditsLPictureBox.Size = new Size(67, 46);
			creditsLPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			creditsLPictureBox.TabIndex = 4;
			creditsLPictureBox.TabStop = false;
			// 
			// creditsButton
			// 
			creditsButton.Dock = DockStyle.Fill;
			creditsButton.Location = new Point(79, 214);
			creditsButton.Name = "creditsButton";
			creditsButton.Size = new Size(213, 46);
			creditsButton.TabIndex = 7;
			creditsButton.Text = "Credits && License";
			creditsButton.UseVisualStyleBackColor = true;
			creditsButton.Click += creditsButton_Click;
			// 
			// creditsRPictureBox
			// 
			creditsRPictureBox.Dock = DockStyle.Fill;
			creditsRPictureBox.Image = Properties.Resources.WAH;
			creditsRPictureBox.Location = new Point(298, 214);
			creditsRPictureBox.Name = "creditsRPictureBox";
			creditsRPictureBox.Size = new Size(68, 46);
			creditsRPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			creditsRPictureBox.TabIndex = 6;
			creditsRPictureBox.TabStop = false;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 266);
			Controls.Add(mainTableLayoutPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Home";
			Text = "Home";
			FormClosing += Home_FormClosing;
			Load += Home_Load;
			mainTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)creditsLPictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)creditsRPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayoutPanel;
		private Button createApplicationButton;
		private Button viewApplicationsButton;
		private Button settingsButton;
		private Button quickStatsButton;
		private PictureBox creditsLPictureBox;
		private PictureBox creditsRPictureBox;
		private Button creditsButton;
	}
}
