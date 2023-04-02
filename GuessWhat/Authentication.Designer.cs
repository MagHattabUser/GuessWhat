namespace GuessWhat
{
    partial class Authentication
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
            this.EntryLogin = new System.Windows.Forms.TextBox();
            this.EntryPassword = new System.Windows.Forms.TextBox();
            this.LoginInButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.HidePasswordCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EntryLogin
            // 
            this.EntryLogin.Location = new System.Drawing.Point(91, 129);
            this.EntryLogin.Multiline = true;
            this.EntryLogin.Name = "EntryLogin";
            this.EntryLogin.Size = new System.Drawing.Size(145, 30);
            this.EntryLogin.TabIndex = 0;
            // 
            // EntryPassword
            // 
            this.EntryPassword.Location = new System.Drawing.Point(91, 191);
            this.EntryPassword.Multiline = true;
            this.EntryPassword.Name = "EntryPassword";
            this.EntryPassword.PasswordChar = '*';
            this.EntryPassword.Size = new System.Drawing.Size(145, 30);
            this.EntryPassword.TabIndex = 1;
            // 
            // LoginInButton
            // 
            this.LoginInButton.Location = new System.Drawing.Point(110, 346);
            this.LoginInButton.Name = "LoginInButton";
            this.LoginInButton.Size = new System.Drawing.Size(106, 28);
            this.LoginInButton.TabIndex = 3;
            this.LoginInButton.Text = "Войти";
            this.LoginInButton.UseVisualStyleBackColor = true;
            this.LoginInButton.Click += new System.EventHandler(this.LoginInButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(91, 401);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(163, 26);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Зарегистрироваться";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // HidePasswordCheck
            // 
            this.HidePasswordCheck.AutoSize = true;
            this.HidePasswordCheck.Location = new System.Drawing.Point(91, 236);
            this.HidePasswordCheck.Name = "HidePasswordCheck";
            this.HidePasswordCheck.Size = new System.Drawing.Size(114, 17);
            this.HidePasswordCheck.TabIndex = 5;
            this.HidePasswordCheck.Text = "Показать пароль";
            this.HidePasswordCheck.UseVisualStyleBackColor = true;
            this.HidePasswordCheck.CheckedChanged += new System.EventHandler(this.HidePasswordCheck_CheckedChanged);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.HidePasswordCheck);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.LoginInButton);
            this.Controls.Add(this.EntryPassword);
            this.Controls.Add(this.EntryLogin);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EntryLogin;
        private System.Windows.Forms.TextBox EntryPassword;
        private System.Windows.Forms.Button LoginInButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.CheckBox HidePasswordCheck;
    }
}