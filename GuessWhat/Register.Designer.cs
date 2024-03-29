﻿namespace GuessWhat
{
    partial class Register
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
            this.EntryUsername = new System.Windows.Forms.TextBox();
            this.EntryPassword = new System.Windows.Forms.TextBox();
            this.HidePasswordCheck = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntryLogin
            // 
            this.EntryLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EntryLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryLogin.ForeColor = System.Drawing.Color.White;
            this.EntryLogin.Location = new System.Drawing.Point(90, 58);
            this.EntryLogin.Multiline = true;
            this.EntryLogin.Name = "EntryLogin";
            this.EntryLogin.Size = new System.Drawing.Size(138, 29);
            this.EntryLogin.TabIndex = 0;
            // 
            // EntryUsername
            // 
            this.EntryUsername.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EntryUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryUsername.ForeColor = System.Drawing.Color.White;
            this.EntryUsername.Location = new System.Drawing.Point(90, 130);
            this.EntryUsername.Multiline = true;
            this.EntryUsername.Name = "EntryUsername";
            this.EntryUsername.Size = new System.Drawing.Size(138, 29);
            this.EntryUsername.TabIndex = 1;
            // 
            // EntryPassword
            // 
            this.EntryPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EntryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryPassword.ForeColor = System.Drawing.Color.White;
            this.EntryPassword.Location = new System.Drawing.Point(90, 195);
            this.EntryPassword.Multiline = true;
            this.EntryPassword.Name = "EntryPassword";
            this.EntryPassword.PasswordChar = '*';
            this.EntryPassword.Size = new System.Drawing.Size(138, 29);
            this.EntryPassword.TabIndex = 2;
            // 
            // HidePasswordCheck
            // 
            this.HidePasswordCheck.AutoSize = true;
            this.HidePasswordCheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.HidePasswordCheck.ForeColor = System.Drawing.Color.White;
            this.HidePasswordCheck.Location = new System.Drawing.Point(93, 242);
            this.HidePasswordCheck.Name = "HidePasswordCheck";
            this.HidePasswordCheck.Size = new System.Drawing.Size(114, 17);
            this.HidePasswordCheck.TabIndex = 3;
            this.HidePasswordCheck.Text = "Показать пароль";
            this.HidePasswordCheck.UseVisualStyleBackColor = false;
            this.HidePasswordCheck.CheckedChanged += new System.EventHandler(this.HidePasswordCheck_CheckedChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(77, 317);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(165, 25);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(116, 348);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(90, 39);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(90, 114);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(103, 13);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Имя пользователя";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(90, 179);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Пароль";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessWhat.Properties.Resources.hqdefault;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.HidePasswordCheck);
            this.Controls.Add(this.EntryPassword);
            this.Controls.Add(this.EntryUsername);
            this.Controls.Add(this.EntryLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(336, 519);
            this.MinimumSize = new System.Drawing.Size(336, 519);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EntryLogin;
        private System.Windows.Forms.TextBox EntryUsername;
        private System.Windows.Forms.TextBox EntryPassword;
        private System.Windows.Forms.CheckBox HidePasswordCheck;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}