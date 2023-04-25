using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWhat
{
    public partial class GuessWord : Form
    {
        private WordGame Words;
        private string HiddenWord;
        private int Index;
        private Player Players;
        private XML XMLDoc;
        public GuessWord(Player player)
        {
            InitializeComponent();
            Words = new WordGame();
            Index = 0;
            comboBox1.Text = comboBox1.Items[0].ToString();
            Players = player;
            XMLDoc = new XML();
            this.Text = "GuessWord " + Players.GetUserName() + " наибольшее количество очков - " + Players.GetWordScore().ToString();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StartGame()
        {
            HiddenWord = Words.GetRandomWord().ToLower();
            AddRows();
            NextWord.Visible = true;
            EntryWord.ReadOnly = false;
            EntryWord.Enabled = true;
            EntryWord.Visible = true;
            EntryWordText.Visible = true;
            comboBox1.Enabled = false;
            dataGridView1.CurrentCell.Selected = false;
        }

        private void AddRows()
        {
            if (comboBox1.Text == comboBox1.Items[0].ToString())
            {
                for (int i = 0; i < 9; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
            else if (comboBox1.Text == comboBox1.Items[1].ToString())
            {
                for (int i = 0; i < 7; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
        }

        private void CompareStringsAndColorCells(string firstString, string secondString, int index)
        {
            // Проходимся по всем символам в строках и сравниваем их
            for (int i = 0; i < firstString.Length; i++)
            {
                char firstChar = firstString[i];
                char secondChar = secondString[i];

                // Если символы равны и находятся в одном и том же месте, окрашиваем ячейку в зеленый цвет
                if (firstChar == secondChar)
                {
                    dataGridView1.Rows[index].Cells[i].Style.BackColor = Color.Green;
                }
                // Если символы равны, но находятся в разных местах, окрашиваем ячейку в желтый цвет
                else if (firstString.Contains(secondChar.ToString()))
                {
                    dataGridView1.Rows[index].Cells[i].Style.BackColor = Color.Yellow;
                }
                // Если символы отличаются, окрашиваем ячейку в красный цвет
                else
                {
                    dataGridView1.Rows[index].Cells[i].Style.BackColor = Color.Red;
                }
            }
        }

        private void StartTheGame_Click(object sender, EventArgs e)
        {
            StartGame();
            StartTheGame.Enabled = false;
        }

        private void NextWord_Click(object sender, EventArgs e)
        {
            if (Lose())
            {
                return;
            } 
            string currnetWord = EntryWord.Text.ToLower();
            if (!Words.CheckWordInCollection(currnetWord))
            {
                MessageBox.Show("Данного слово нет в словаре", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows[Index].Cells[i].Value = currnetWord[i];
            }
            CompareStringsAndColorCells(HiddenWord, currnetWord, Index);
            if (currnetWord == HiddenWord)
            {
                EndGame(EntryWord.Text);
                return;
            }
            Index++;
            EntryWord.Text = "";
        }

        private void Reset()
        {
            dataGridView1.Rows.Clear();
            StartTheGame.Enabled = true;
            RestartTheGameButton.Visible = false;
            comboBox1.Enabled = true;
            EntryWord.Text = "";
            Index = 0;
        }

        private void EndGame(string word)
        {
            EntryWord.Text = word;
            EntryWord.ReadOnly = true;
            RestartTheGameButton.Visible = true;
            NextWord.Enabled = false;
            int score;

            if (comboBox1.Text == comboBox1.Items[0].ToString())
            {
                score = 10;
            }
            else if (comboBox1.Text == comboBox1.Items[1].ToString())
            {
                score = 15;
            }
            else
            {
                score = 20;
            }
            if (score > Players.GetWordScore())
            {
                XMLDoc.SaveScore(Players, "wordscore", score);
                Players.SetWordScore(score);
                this.Text = "GuessWord " + Players.GetUserName() + " наибольшее количество очков - " + Players.GetWordScore().ToString();
            }
            MessageBox.Show("Вы набрали " + score.ToString() + " из 10", "Игра оконченая", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RestartTheGameButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BackToTheMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(Players);
            Hide();
            mainMenu.ShowDialog();
            Close();
        }

        private bool Lose()
        {
            if (Index == dataGridView1.Rows.Count)
            {
                MessageBox.Show("Загаданное слово - " + HiddenWord, "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                RestartTheGameButton.Enabled = true;
                RestartTheGameButton.Visible = true;
                NextWord.Visible = false;
                return true;
            }
            return false;
        }
    }
}
