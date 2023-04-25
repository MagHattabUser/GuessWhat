namespace GuessWhat
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartMelodyGame = new System.Windows.Forms.Button();
            this.StartFilmGame = new System.Windows.Forms.Button();
            this.StartWordGame = new System.Windows.Forms.Button();
            this.MelodyRecordLabel = new System.Windows.Forms.Label();
            this.FilmRecordLabel = new System.Windows.Forms.Label();
            this.WordRecordLabel = new System.Windows.Forms.Label();
            this.BestPlayersList = new System.Windows.Forms.ListBox();
            this.ExitFromAccount = new System.Windows.Forms.Button();
            this.ExitFromGame = new System.Windows.Forms.Button();
            this.RuleMelody = new System.Windows.Forms.PictureBox();
            this.RuleWord = new System.Windows.Forms.PictureBox();
            this.RuleFilm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RuleMelody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RuleWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RuleFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMelodyGame
            // 
            this.StartMelodyGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartMelodyGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMelodyGame.Location = new System.Drawing.Point(143, 255);
            this.StartMelodyGame.Name = "StartMelodyGame";
            this.StartMelodyGame.Size = new System.Drawing.Size(118, 55);
            this.StartMelodyGame.TabIndex = 0;
            this.StartMelodyGame.Text = "Угадай мелодию";
            this.StartMelodyGame.UseVisualStyleBackColor = false;
            this.StartMelodyGame.Click += new System.EventHandler(this.StartMelodyGame_Click);
            // 
            // StartFilmGame
            // 
            this.StartFilmGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartFilmGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartFilmGame.Location = new System.Drawing.Point(502, 255);
            this.StartFilmGame.Name = "StartFilmGame";
            this.StartFilmGame.Size = new System.Drawing.Size(120, 55);
            this.StartFilmGame.TabIndex = 1;
            this.StartFilmGame.Text = "Угадай фильм";
            this.StartFilmGame.UseVisualStyleBackColor = false;
            this.StartFilmGame.Click += new System.EventHandler(this.StartFilmGame_Click);
            // 
            // StartWordGame
            // 
            this.StartWordGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartWordGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWordGame.Location = new System.Drawing.Point(326, 255);
            this.StartWordGame.Name = "StartWordGame";
            this.StartWordGame.Size = new System.Drawing.Size(121, 55);
            this.StartWordGame.TabIndex = 2;
            this.StartWordGame.Text = "Угадай слово";
            this.StartWordGame.UseVisualStyleBackColor = false;
            this.StartWordGame.Click += new System.EventHandler(this.StartWordGame_Click);
            // 
            // MelodyRecordLabel
            // 
            this.MelodyRecordLabel.AutoSize = true;
            this.MelodyRecordLabel.BackColor = System.Drawing.Color.Transparent;
            this.MelodyRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MelodyRecordLabel.ForeColor = System.Drawing.Color.White;
            this.MelodyRecordLabel.Location = new System.Drawing.Point(139, 322);
            this.MelodyRecordLabel.Name = "MelodyRecordLabel";
            this.MelodyRecordLabel.Size = new System.Drawing.Size(51, 20);
            this.MelodyRecordLabel.TabIndex = 3;
            this.MelodyRecordLabel.Text = "label1";
            // 
            // FilmRecordLabel
            // 
            this.FilmRecordLabel.AutoSize = true;
            this.FilmRecordLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilmRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmRecordLabel.ForeColor = System.Drawing.Color.White;
            this.FilmRecordLabel.Location = new System.Drawing.Point(498, 322);
            this.FilmRecordLabel.Name = "FilmRecordLabel";
            this.FilmRecordLabel.Size = new System.Drawing.Size(51, 20);
            this.FilmRecordLabel.TabIndex = 4;
            this.FilmRecordLabel.Text = "label2";
            // 
            // WordRecordLabel
            // 
            this.WordRecordLabel.AutoSize = true;
            this.WordRecordLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordRecordLabel.ForeColor = System.Drawing.Color.White;
            this.WordRecordLabel.Location = new System.Drawing.Point(322, 322);
            this.WordRecordLabel.Name = "WordRecordLabel";
            this.WordRecordLabel.Size = new System.Drawing.Size(51, 20);
            this.WordRecordLabel.TabIndex = 5;
            this.WordRecordLabel.Text = "label3";
            // 
            // BestPlayersList
            // 
            this.BestPlayersList.BackColor = System.Drawing.Color.DodgerBlue;
            this.BestPlayersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestPlayersList.FormattingEnabled = true;
            this.BestPlayersList.ItemHeight = 20;
            this.BestPlayersList.Location = new System.Drawing.Point(12, 12);
            this.BestPlayersList.Name = "BestPlayersList";
            this.BestPlayersList.Size = new System.Drawing.Size(293, 104);
            this.BestPlayersList.TabIndex = 6;
            // 
            // ExitFromAccount
            // 
            this.ExitFromAccount.BackColor = System.Drawing.Color.Blue;
            this.ExitFromAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFromAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitFromAccount.Location = new System.Drawing.Point(640, 13);
            this.ExitFromAccount.Name = "ExitFromAccount";
            this.ExitFromAccount.Size = new System.Drawing.Size(148, 50);
            this.ExitFromAccount.TabIndex = 7;
            this.ExitFromAccount.Text = "Выйти из аккаунта";
            this.ExitFromAccount.UseVisualStyleBackColor = false;
            this.ExitFromAccount.Click += new System.EventHandler(this.ExitFromAccount_Click);
            // 
            // ExitFromGame
            // 
            this.ExitFromGame.BackColor = System.Drawing.Color.Blue;
            this.ExitFromGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFromGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitFromGame.Location = new System.Drawing.Point(640, 79);
            this.ExitFromGame.Name = "ExitFromGame";
            this.ExitFromGame.Size = new System.Drawing.Size(148, 50);
            this.ExitFromGame.TabIndex = 8;
            this.ExitFromGame.Text = "Выйти из игры";
            this.ExitFromGame.UseVisualStyleBackColor = false;
            this.ExitFromGame.Click += new System.EventHandler(this.ExitFromGame_Click);
            // 
            // RuleMelody
            // 
            this.RuleMelody.Image = global::GuessWhat.Properties.Resources.rules;
            this.RuleMelody.Location = new System.Drawing.Point(185, 223);
            this.RuleMelody.Name = "RuleMelody";
            this.RuleMelody.Size = new System.Drawing.Size(27, 27);
            this.RuleMelody.TabIndex = 9;
            this.RuleMelody.TabStop = false;
            this.RuleMelody.Click += new System.EventHandler(this.RuleMelody_Click);
            // 
            // RuleWord
            // 
            this.RuleWord.Image = global::GuessWhat.Properties.Resources.rules;
            this.RuleWord.Location = new System.Drawing.Point(378, 223);
            this.RuleWord.Name = "RuleWord";
            this.RuleWord.Size = new System.Drawing.Size(27, 27);
            this.RuleWord.TabIndex = 10;
            this.RuleWord.TabStop = false;
            this.RuleWord.Click += new System.EventHandler(this.RuleWord_Click);
            // 
            // RuleFilm
            // 
            this.RuleFilm.Image = global::GuessWhat.Properties.Resources.rules;
            this.RuleFilm.Location = new System.Drawing.Point(548, 223);
            this.RuleFilm.Name = "RuleFilm";
            this.RuleFilm.Size = new System.Drawing.Size(27, 27);
            this.RuleFilm.TabIndex = 11;
            this.RuleFilm.TabStop = false;
            this.RuleFilm.Click += new System.EventHandler(this.RuleFilm_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessWhat.Properties.Resources.m1000x1000;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RuleFilm);
            this.Controls.Add(this.RuleWord);
            this.Controls.Add(this.RuleMelody);
            this.Controls.Add(this.ExitFromGame);
            this.Controls.Add(this.ExitFromAccount);
            this.Controls.Add(this.BestPlayersList);
            this.Controls.Add(this.WordRecordLabel);
            this.Controls.Add(this.FilmRecordLabel);
            this.Controls.Add(this.MelodyRecordLabel);
            this.Controls.Add(this.StartWordGame);
            this.Controls.Add(this.StartFilmGame);
            this.Controls.Add(this.StartMelodyGame);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessWhat";
            ((System.ComponentModel.ISupportInitialize)(this.RuleMelody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RuleWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RuleFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartMelodyGame;
        private System.Windows.Forms.Button StartFilmGame;
        private System.Windows.Forms.Button StartWordGame;
        private System.Windows.Forms.Label MelodyRecordLabel;
        private System.Windows.Forms.Label FilmRecordLabel;
        private System.Windows.Forms.Label WordRecordLabel;
        private System.Windows.Forms.ListBox BestPlayersList;
        private System.Windows.Forms.Button ExitFromAccount;
        private System.Windows.Forms.Button ExitFromGame;
        private System.Windows.Forms.PictureBox RuleMelody;
        private System.Windows.Forms.PictureBox RuleWord;
        private System.Windows.Forms.PictureBox RuleFilm;
    }
}

