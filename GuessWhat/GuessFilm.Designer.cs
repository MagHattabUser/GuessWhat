namespace GuessWhat
{
    partial class GuessFilm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.AnswerThree = new System.Windows.Forms.Button();
            this.AnswerTwo = new System.Windows.Forms.Button();
            this.AnswerOne = new System.Windows.Forms.Button();
            this.StartFilmGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Orange;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(479, 379);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(169, 60);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Tag = "exit";
            this.ExitButton.Text = "Выйти в главное меню";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Yellow;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(252, 428);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(169, 41);
            this.RestartButton.TabIndex = 15;
            this.RestartButton.Tag = "main";
            this.RestartButton.Text = "Сыграть еще";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Популярный"});
            this.comboBox1.Location = new System.Drawing.Point(12, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 32);
            this.comboBox1.TabIndex = 14;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 436);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(66, 24);
            this.ScoreLabel.TabIndex = 13;
            this.ScoreLabel.Text = "label1";
            // 
            // AnswerThree
            // 
            this.AnswerThree.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerThree.Location = new System.Drawing.Point(452, 576);
            this.AnswerThree.Name = "AnswerThree";
            this.AnswerThree.Size = new System.Drawing.Size(196, 71);
            this.AnswerThree.TabIndex = 12;
            this.AnswerThree.Tag = "answer";
            this.AnswerThree.Text = "button1";
            this.AnswerThree.UseVisualStyleBackColor = false;
            this.AnswerThree.Visible = false;
            this.AnswerThree.Click += new System.EventHandler(this.AnswerThree_Click);
            // 
            // AnswerTwo
            // 
            this.AnswerTwo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTwo.Location = new System.Drawing.Point(231, 576);
            this.AnswerTwo.Name = "AnswerTwo";
            this.AnswerTwo.Size = new System.Drawing.Size(199, 71);
            this.AnswerTwo.TabIndex = 11;
            this.AnswerTwo.Tag = "answer";
            this.AnswerTwo.Text = "button1";
            this.AnswerTwo.UseVisualStyleBackColor = false;
            this.AnswerTwo.Visible = false;
            this.AnswerTwo.Click += new System.EventHandler(this.AnswerTwo_Click);
            // 
            // AnswerOne
            // 
            this.AnswerOne.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerOne.Location = new System.Drawing.Point(12, 576);
            this.AnswerOne.Name = "AnswerOne";
            this.AnswerOne.Size = new System.Drawing.Size(199, 71);
            this.AnswerOne.TabIndex = 10;
            this.AnswerOne.Tag = "answer";
            this.AnswerOne.Text = "button1";
            this.AnswerOne.UseVisualStyleBackColor = false;
            this.AnswerOne.Visible = false;
            this.AnswerOne.Click += new System.EventHandler(this.AnswerOne_Click);
            // 
            // StartFilmGame
            // 
            this.StartFilmGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartFilmGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartFilmGame.Location = new System.Drawing.Point(252, 488);
            this.StartFilmGame.Name = "StartFilmGame";
            this.StartFilmGame.Size = new System.Drawing.Size(169, 41);
            this.StartFilmGame.TabIndex = 9;
            this.StartFilmGame.Tag = "main";
            this.StartFilmGame.Text = "Начать";
            this.StartFilmGame.UseVisualStyleBackColor = false;
            this.StartFilmGame.Click += new System.EventHandler(this.StartFilmGame_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuessWhat.Properties.Resources.guessfilmback;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GuessFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 659);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.AnswerThree);
            this.Controls.Add(this.AnswerTwo);
            this.Controls.Add(this.AnswerOne);
            this.Controls.Add(this.StartFilmGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GuessFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessFilm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button AnswerThree;
        private System.Windows.Forms.Button AnswerTwo;
        private System.Windows.Forms.Button AnswerOne;
        private System.Windows.Forms.Button StartFilmGame;
    }
}