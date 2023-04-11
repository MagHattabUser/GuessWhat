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
            this.SuspendLayout();
            // 
            // StartMelodyGame
            // 
            this.StartMelodyGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMelodyGame.Location = new System.Drawing.Point(143, 255);
            this.StartMelodyGame.Name = "StartMelodyGame";
            this.StartMelodyGame.Size = new System.Drawing.Size(118, 55);
            this.StartMelodyGame.TabIndex = 0;
            this.StartMelodyGame.Text = "Угадай мелодию";
            this.StartMelodyGame.UseVisualStyleBackColor = true;
            this.StartMelodyGame.Click += new System.EventHandler(this.StartMelodyGame_Click);
            // 
            // StartFilmGame
            // 
            this.StartFilmGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartFilmGame.Location = new System.Drawing.Point(502, 255);
            this.StartFilmGame.Name = "StartFilmGame";
            this.StartFilmGame.Size = new System.Drawing.Size(120, 55);
            this.StartFilmGame.TabIndex = 1;
            this.StartFilmGame.Text = "Угадай фильм";
            this.StartFilmGame.UseVisualStyleBackColor = true;
            this.StartFilmGame.Click += new System.EventHandler(this.StartFilmGame_Click);
            // 
            // StartWordGame
            // 
            this.StartWordGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWordGame.Location = new System.Drawing.Point(326, 255);
            this.StartWordGame.Name = "StartWordGame";
            this.StartWordGame.Size = new System.Drawing.Size(121, 55);
            this.StartWordGame.TabIndex = 2;
            this.StartWordGame.Text = "Угадай слово";
            this.StartWordGame.UseVisualStyleBackColor = true;
            this.StartWordGame.Click += new System.EventHandler(this.StartWordGame_Click);
            // 
            // MelodyRecordLabel
            // 
            this.MelodyRecordLabel.AutoSize = true;
            this.MelodyRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MelodyRecordLabel.Location = new System.Drawing.Point(139, 322);
            this.MelodyRecordLabel.Name = "MelodyRecordLabel";
            this.MelodyRecordLabel.Size = new System.Drawing.Size(51, 20);
            this.MelodyRecordLabel.TabIndex = 3;
            this.MelodyRecordLabel.Text = "label1";
            // 
            // FilmRecordLabel
            // 
            this.FilmRecordLabel.AutoSize = true;
            this.FilmRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmRecordLabel.Location = new System.Drawing.Point(322, 322);
            this.FilmRecordLabel.Name = "FilmRecordLabel";
            this.FilmRecordLabel.Size = new System.Drawing.Size(51, 20);
            this.FilmRecordLabel.TabIndex = 4;
            this.FilmRecordLabel.Text = "label2";
            // 
            // WordRecordLabel
            // 
            this.WordRecordLabel.AutoSize = true;
            this.WordRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordRecordLabel.Location = new System.Drawing.Point(498, 322);
            this.WordRecordLabel.Name = "WordRecordLabel";
            this.WordRecordLabel.Size = new System.Drawing.Size(51, 20);
            this.WordRecordLabel.TabIndex = 5;
            this.WordRecordLabel.Text = "label3";
            // 
            // BestPlayersList
            // 
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
            this.ExitFromAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFromAccount.Location = new System.Drawing.Point(640, 13);
            this.ExitFromAccount.Name = "ExitFromAccount";
            this.ExitFromAccount.Size = new System.Drawing.Size(148, 50);
            this.ExitFromAccount.TabIndex = 7;
            this.ExitFromAccount.Text = "Выйти из аккаунта";
            this.ExitFromAccount.UseVisualStyleBackColor = true;
            this.ExitFromAccount.Click += new System.EventHandler(this.ExitFromAccount_Click);
            // 
            // ExitFromGame
            // 
            this.ExitFromGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFromGame.Location = new System.Drawing.Point(640, 79);
            this.ExitFromGame.Name = "ExitFromGame";
            this.ExitFromGame.Size = new System.Drawing.Size(148, 50);
            this.ExitFromGame.TabIndex = 8;
            this.ExitFromGame.Text = "Выйти из игры";
            this.ExitFromGame.UseVisualStyleBackColor = true;
            this.ExitFromGame.Click += new System.EventHandler(this.ExitFromGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

