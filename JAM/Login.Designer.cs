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
			mainTableLayout = new TableLayoutPanel();
			passwordLabel = new Label();
			passwordTextbox = new TextBox();
			passwordViewButton = new Button();
			loginButton = new Button();
			cancelButton = new Button();
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
			mainTableLayout.Controls.Add(passwordLabel, 0, 0);
			mainTableLayout.Controls.Add(passwordTextbox, 1, 0);
			mainTableLayout.Controls.Add(passwordViewButton, 4, 0);
			mainTableLayout.Controls.Add(loginButton, 0, 1);
			mainTableLayout.Controls.Add(cancelButton, 2, 1);
			mainTableLayout.Dock = DockStyle.Fill;
			mainTableLayout.Location = new Point(0, 0);
			mainTableLayout.Name = "mainTableLayout";
			mainTableLayout.RowCount = 2;
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			mainTableLayout.Size = new Size(423, 87);
			mainTableLayout.TabIndex = 0;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Dock = DockStyle.Fill;
			passwordLabel.Location = new Point(3, 0);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(94, 43);
			passwordLabel.TabIndex = 2;
			passwordLabel.Text = "Password:";
			// 
			// passwordTextbox
			// 
			mainTableLayout.SetColumnSpan(passwordTextbox, 3);
			passwordTextbox.Dock = DockStyle.Fill;
			passwordTextbox.Location = new Point(103, 3);
			passwordTextbox.Name = "passwordTextbox";
			passwordTextbox.PasswordChar = '•';
			passwordTextbox.Size = new Size(266, 31);
			passwordTextbox.TabIndex = 3;
			// 
			// passwordViewButton
			// 
			passwordViewButton.Dock = DockStyle.Fill;
			passwordViewButton.Image = Properties.Resources.Visible;
			passwordViewButton.Location = new Point(375, 3);
			passwordViewButton.Name = "passwordViewButton";
			passwordViewButton.Size = new Size(45, 37);
			passwordViewButton.TabIndex = 4;
			passwordViewButton.UseVisualStyleBackColor = true;
			passwordViewButton.Click += passwordViewButton_Click;
			// 
			// loginButton
			// 
			mainTableLayout.SetColumnSpan(loginButton, 2);
			loginButton.Dock = DockStyle.Fill;
			loginButton.Location = new Point(3, 46);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(205, 38);
			loginButton.TabIndex = 0;
			loginButton.Text = "Login";
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += loginButton_Click;
			// 
			// cancelButton
			// 
			mainTableLayout.SetColumnSpan(cancelButton, 3);
			cancelButton.Dock = DockStyle.Fill;
			cancelButton.Location = new Point(214, 46);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(206, 38);
			cancelButton.TabIndex = 1;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(423, 87);
			Controls.Add(mainTableLayout);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Login";
			ShowIcon = false;
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
	}
}