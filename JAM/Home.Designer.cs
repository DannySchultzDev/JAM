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
			mainTableLayoutPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			mainTableLayoutPanel.ColumnCount = 1;
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainTableLayoutPanel.Controls.Add(createApplicationButton, 0, 0);
			mainTableLayoutPanel.Controls.Add(viewApplicationsButton, 0, 1);
			mainTableLayoutPanel.Controls.Add(quickStatsButton, 0, 2);
			mainTableLayoutPanel.Controls.Add(settingsButton, 0, 3);
			mainTableLayoutPanel.Dock = DockStyle.Fill;
			mainTableLayoutPanel.Location = new Point(0, 0);
			mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			mainTableLayoutPanel.Padding = new Padding(3);
			mainTableLayoutPanel.RowCount = 4;
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.Size = new Size(372, 222);
			mainTableLayoutPanel.TabIndex = 0;
			// 
			// createApplicationButton
			// 
			createApplicationButton.Dock = DockStyle.Fill;
			createApplicationButton.Location = new Point(6, 6);
			createApplicationButton.Name = "createApplicationButton";
			createApplicationButton.Size = new Size(360, 48);
			createApplicationButton.TabIndex = 0;
			createApplicationButton.Text = "Create Application";
			createApplicationButton.UseVisualStyleBackColor = true;
			createApplicationButton.Click += createApplicationButton_Click;
			// 
			// viewApplicationsButton
			// 
			viewApplicationsButton.Dock = DockStyle.Fill;
			viewApplicationsButton.Location = new Point(6, 60);
			viewApplicationsButton.Name = "viewApplicationsButton";
			viewApplicationsButton.Size = new Size(360, 48);
			viewApplicationsButton.TabIndex = 1;
			viewApplicationsButton.Text = "View Applications";
			viewApplicationsButton.UseVisualStyleBackColor = true;
			viewApplicationsButton.Click += viewApplicationsButton_Click;
			// 
			// quickStatsButton
			// 
			quickStatsButton.Dock = DockStyle.Fill;
			quickStatsButton.Location = new Point(6, 114);
			quickStatsButton.Name = "quickStatsButton";
			quickStatsButton.Size = new Size(360, 48);
			quickStatsButton.TabIndex = 3;
			quickStatsButton.Text = "Quick Stats";
			quickStatsButton.UseVisualStyleBackColor = true;
			// 
			// settingsButton
			// 
			settingsButton.Dock = DockStyle.Fill;
			settingsButton.Location = new Point(6, 168);
			settingsButton.Name = "settingsButton";
			settingsButton.Size = new Size(360, 48);
			settingsButton.TabIndex = 2;
			settingsButton.Text = "Settings";
			settingsButton.UseVisualStyleBackColor = true;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 222);
			Controls.Add(mainTableLayoutPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Home";
			Text = "Home";
			FormClosing += Home_FormClosing;
			Load += Home_Load;
			mainTableLayoutPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel mainTableLayoutPanel;
		private Button createApplicationButton;
		private Button viewApplicationsButton;
		private Button settingsButton;
		private Button quickStatsButton;
	}
}
