namespace GuessWhat
{
    partial class GuessWord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTheGame = new System.Windows.Forms.Button();
            this.EntryWord = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NextWord = new System.Windows.Forms.Button();
            this.EntryWordText = new System.Windows.Forms.Label();
            this.RestartTheGameButton = new System.Windows.Forms.Button();
            this.BackToTheMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle23;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle24;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle25;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // StartTheGame
            // 
            this.StartTheGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTheGame.Location = new System.Drawing.Point(587, 59);
            this.StartTheGame.Name = "StartTheGame";
            this.StartTheGame.Size = new System.Drawing.Size(143, 34);
            this.StartTheGame.TabIndex = 1;
            this.StartTheGame.Text = "Начать игру";
            this.StartTheGame.UseVisualStyleBackColor = true;
            this.StartTheGame.Click += new System.EventHandler(this.StartTheGame_Click);
            // 
            // EntryWord
            // 
            this.EntryWord.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EntryWord.Enabled = false;
            this.EntryWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryWord.Location = new System.Drawing.Point(587, 251);
            this.EntryWord.Multiline = true;
            this.EntryWord.Name = "EntryWord";
            this.EntryWord.ReadOnly = true;
            this.EntryWord.Size = new System.Drawing.Size(143, 34);
            this.EntryWord.TabIndex = 2;
            this.EntryWord.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Легкий",
            "Нормальный",
            "Сложный"});
            this.comboBox1.Location = new System.Drawing.Point(587, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // NextWord
            // 
            this.NextWord.BackColor = System.Drawing.Color.PaleGreen;
            this.NextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextWord.Location = new System.Drawing.Point(587, 291);
            this.NextWord.Name = "NextWord";
            this.NextWord.Size = new System.Drawing.Size(143, 59);
            this.NextWord.TabIndex = 5;
            this.NextWord.Text = "Угадать слово";
            this.NextWord.UseVisualStyleBackColor = false;
            this.NextWord.Visible = false;
            this.NextWord.Click += new System.EventHandler(this.NextWord_Click);
            // 
            // EntryWordText
            // 
            this.EntryWordText.AutoSize = true;
            this.EntryWordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryWordText.Location = new System.Drawing.Point(583, 228);
            this.EntryWordText.Name = "EntryWordText";
            this.EntryWordText.Size = new System.Drawing.Size(125, 20);
            this.EntryWordText.TabIndex = 6;
            this.EntryWordText.Text = "Введите слово";
            this.EntryWordText.Visible = false;
            // 
            // RestartTheGameButton
            // 
            this.RestartTheGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartTheGameButton.Location = new System.Drawing.Point(587, 99);
            this.RestartTheGameButton.Name = "RestartTheGameButton";
            this.RestartTheGameButton.Size = new System.Drawing.Size(143, 34);
            this.RestartTheGameButton.TabIndex = 7;
            this.RestartTheGameButton.Text = "Играть снова";
            this.RestartTheGameButton.UseVisualStyleBackColor = true;
            this.RestartTheGameButton.Visible = false;
            this.RestartTheGameButton.Click += new System.EventHandler(this.RestartTheGameButton_Click);
            // 
            // BackToTheMenuButton
            // 
            this.BackToTheMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToTheMenuButton.Location = new System.Drawing.Point(587, 139);
            this.BackToTheMenuButton.Name = "BackToTheMenuButton";
            this.BackToTheMenuButton.Size = new System.Drawing.Size(143, 59);
            this.BackToTheMenuButton.TabIndex = 8;
            this.BackToTheMenuButton.Text = "Вернуться в меню";
            this.BackToTheMenuButton.UseVisualStyleBackColor = true;
            this.BackToTheMenuButton.Click += new System.EventHandler(this.BackToTheMenuButton_Click);
            // 
            // GuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(751, 360);
            this.Controls.Add(this.BackToTheMenuButton);
            this.Controls.Add(this.RestartTheGameButton);
            this.Controls.Add(this.EntryWordText);
            this.Controls.Add(this.NextWord);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EntryWord);
            this.Controls.Add(this.StartTheGame);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GuessWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessWord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StartTheGame;
        private System.Windows.Forms.TextBox EntryWord;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button NextWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label EntryWordText;
        private System.Windows.Forms.Button RestartTheGameButton;
        private System.Windows.Forms.Button BackToTheMenuButton;
    }
}