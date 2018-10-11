namespace RQReporter
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.acceptButton = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(110, 218);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(13, 51);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(78, 13);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server address";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(16, 120);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 172);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(16, 145);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(167, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // userBox
            // 
            this.userBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RQReporter.Settings1.Default, "user", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userBox.Location = new System.Drawing.Point(16, 93);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(167, 20);
            this.userBox.TabIndex = 3;
            this.userBox.Text = global::RQReporter.Settings1.Default.user;
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // serverBox
            // 
            this.serverBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RQReporter.Settings1.Default, "server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverBox.Location = new System.Drawing.Point(13, 24);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(170, 20);
            this.serverBox.TabIndex = 1;
            this.serverBox.Text = global::RQReporter.Settings1.Default.server;
            this.serverBox.TextChanged += new System.EventHandler(this.serverBox_TextChanged);
            // 
            // settingsForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 253);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.acceptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}