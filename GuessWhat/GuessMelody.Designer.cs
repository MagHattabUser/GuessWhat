namespace GuessWhat
{
    partial class GuessMelody
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
            this.StartMelodyGame = new System.Windows.Forms.Button();
            this.AnswerOne = new System.Windows.Forms.Button();
            this.AnswerTwo = new System.Windows.Forms.Button();
            this.AnswerThree = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMelodyGame
            // 
            this.StartMelodyGame.BackColor = System.Drawing.Color.YellowGreen;
            this.StartMelodyGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMelodyGame.Location = new System.Drawing.Point(267, 287);
            this.StartMelodyGame.Name = "StartMelodyGame";
            this.StartMelodyGame.Size = new System.Drawing.Size(182, 41);
            this.StartMelodyGame.TabIndex = 0;
            this.StartMelodyGame.Tag = "main";
            this.StartMelodyGame.Text = "Начать";
            this.StartMelodyGame.UseVisualStyleBackColor = false;
            this.StartMelodyGame.Click += new System.EventHandler(this.StartMelodyGame_Click);
            // 
            // AnswerOne
            // 
            this.AnswerOne.BackColor = System.Drawing.Color.Khaki;
            this.AnswerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerOne.Location = new System.Drawing.Point(12, 367);
            this.AnswerOne.Name = "AnswerOne";
            this.AnswerOne.Size = new System.Drawing.Size(199, 71);
            this.AnswerOne.TabIndex = 1;
            this.AnswerOne.Tag = "answer";
            this.AnswerOne.Text = "button1";
            this.AnswerOne.UseVisualStyleBackColor = false;
            this.AnswerOne.Visible = false;
            this.AnswerOne.Click += new System.EventHandler(this.AnswerOne_Click);
            // 
            // AnswerTwo
            // 
            this.AnswerTwo.BackColor = System.Drawing.Color.Khaki;
            this.AnswerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTwo.Location = new System.Drawing.Point(257, 367);
            this.AnswerTwo.Name = "AnswerTwo";
            this.AnswerTwo.Size = new System.Drawing.Size(204, 71);
            this.AnswerTwo.TabIndex = 2;
            this.AnswerTwo.Tag = "answer";
            this.AnswerTwo.Text = "button1";
            this.AnswerTwo.UseVisualStyleBackColor = false;
            this.AnswerTwo.Visible = false;
            this.AnswerTwo.Click += new System.EventHandler(this.AnswerTwo_Click);
            // 
            // AnswerThree
            // 
            this.AnswerThree.BackColor = System.Drawing.Color.Khaki;
            this.AnswerThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerThree.Location = new System.Drawing.Point(501, 367);
            this.AnswerThree.Name = "AnswerThree";
            this.AnswerThree.Size = new System.Drawing.Size(196, 71);
            this.AnswerThree.TabIndex = 3;
            this.AnswerThree.Tag = "answer";
            this.AnswerThree.Text = "button1";
            this.AnswerThree.UseVisualStyleBackColor = false;
            this.AnswerThree.Visible = false;
            this.AnswerThree.Click += new System.EventHandler(this.AnswerThree_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(613, 169);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(66, 24);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuessWhat.Properties.Resources.guessmusicbackground;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GuessMelody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.AnswerThree);
            this.Controls.Add(this.AnswerTwo);
            this.Controls.Add(this.AnswerOne);
            this.Controls.Add(this.StartMelodyGame);
            this.Name = "GuessMelody";
            this.Text = "GuessMelody";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartMelodyGame;
        private System.Windows.Forms.Button AnswerOne;
        private System.Windows.Forms.Button AnswerTwo;
        private System.Windows.Forms.Button AnswerThree;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}