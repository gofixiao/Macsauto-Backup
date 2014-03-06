namespace Macsauto.Presentation.WinForm.ConfigurationModule.Startup
{
    partial class StartupConfiguration
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
            this.gbxMainConnection = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxMainConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainConnection
            // 
            this.gbxMainConnection.Controls.Add(this.txtPassword);
            this.gbxMainConnection.Controls.Add(this.txtUsername);
            this.gbxMainConnection.Controls.Add(this.txtDatabase);
            this.gbxMainConnection.Controls.Add(this.txtHost);
            this.gbxMainConnection.Controls.Add(this.lblPassword);
            this.gbxMainConnection.Controls.Add(this.lblUsername);
            this.gbxMainConnection.Controls.Add(this.lblDatabase);
            this.gbxMainConnection.Controls.Add(this.lblHost);
            this.gbxMainConnection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbxMainConnection.Location = new System.Drawing.Point(12, 13);
            this.gbxMainConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxMainConnection.Name = "gbxMainConnection";
            this.gbxMainConnection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxMainConnection.Size = new System.Drawing.Size(309, 170);
            this.gbxMainConnection.TabIndex = 0;
            this.gbxMainConnection.TabStop = false;
            this.gbxMainConnection.Text = "Main Connection";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(101, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 25);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsername.Location = new System.Drawing.Point(101, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 25);
            this.txtUsername.TabIndex = 6;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDatabase.Location = new System.Drawing.Point(101, 64);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(156, 25);
            this.txtDatabase.TabIndex = 5;
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtHost.Location = new System.Drawing.Point(101, 33);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(156, 25);
            this.txtHost.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPassword.Location = new System.Drawing.Point(28, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUsername.Location = new System.Drawing.Point(28, 98);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDatabase.Location = new System.Drawing.Point(28, 67);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(63, 17);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "Database";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHost.Location = new System.Drawing.Point(28, 36);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(35, 17);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StartupConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 239);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxMainConnection);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartupConfiguration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Startup Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartupConfiguration_FormClosing);
            this.gbxMainConnection.ResumeLayout(false);
            this.gbxMainConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainConnection;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnSave;
    }
}