﻿using System;
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
    public partial class GuessMelody : Form
    {
        private Melody Melodies;
        private string CurrentPlayMelody;
        private List<int> AlreadyPlayed = new List<int>();
        private int Score = 0;
        private bool IsInit = false;
        public GuessMelody()
        {
            InitializeComponent();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void StartMelodyGame_Click(object sender, EventArgs e)
        {
            if (!IsInit)
            {
                Init();
            }

            UnBlockButtons();
            StartMelodyGame.Enabled = false;
            Random random = new Random();
            int correctAnswer = random.Next(0, Melodies.Count());

            while (true)
            {
                if (AlreadyPlayed.Contains(correctAnswer))
                {
                    correctAnswer = random.Next(0, Melodies.Count());
                }
                else
                {
                    break;
                }
            }
            AlreadyPlayed.Add(correctAnswer);
            CurrentPlayMelody = Melodies.GetPath(correctAnswer);

            int answerOne = random.Next(0, Melodies.Count());
            int answerTwo = random.Next(0, Melodies.Count());

            CheckTheSameAnswer(correctAnswer, ref answerOne, answerTwo);
            CheckTheSameAnswer(correctAnswer, ref answerTwo, answerOne);
            FillButtonsText(correctAnswer, answerOne, answerTwo);
            Melodies.Begin(correctAnswer);
        }

        private void Init()
        {
            Melodies = new Melody(comboBox1.Text);
            IsInit = true;
            comboBox1.Enabled = false;
            StartMelodyGame.Text = "Следующая песня";
            AnswerOne.Visible = true;
            AnswerTwo.Visible = true;
            AnswerThree.Visible = true;
        }

        private void FillButtonsText(int correctAnswer, int answerOne, int answerTwo)
        {
            List<Button> buttonList = new List<Button>();
            Random rnd = new Random();
            List<string> answerList = new List<string>();
            answerList.Add(Melodies.GetMelody(correctAnswer));
            answerList.Add(Melodies.GetMelody(answerOne));
            answerList.Add(Melodies.GetMelody(answerTwo));

            foreach (Control button in this.Controls)
            {
                if (button is Button && button.Tag.ToString() != "main")
                {
                    buttonList.Add((Button)button);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                var index = rnd.Next(0, buttonList.Count);
                buttonList[index].Text = answerList[i];
                buttonList.RemoveAt(index);
            }
        }

        private void CheckTheSameAnswer(int correctAnswer, ref int answerOne, int answerTwo)
        {
            Random random = new Random();
            while (true)
            {
                if (answerOne == correctAnswer || answerOne == answerTwo)
                {
                    answerOne = random.Next(0, Melodies.Count());
                }
                else
                {
                    break;
                }
            }
        }

        private void AnswerOne_Click(object sender, EventArgs e)
        {
            if (Melodies.Check(CurrentPlayMelody, AnswerOne.Text))
            {
                Score++;
            }

            StartMelodyGame.Enabled = true;
            BlockedButtons();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            CheckGame();
        }

        private void AnswerTwo_Click(object sender, EventArgs e)
        {
            if (Melodies.Check(CurrentPlayMelody, AnswerTwo.Text))
            {
                Score++;
            }

            StartMelodyGame.Enabled = true;
            BlockedButtons();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            CheckGame();
        }
        
        private void AnswerThree_Click(object sender, EventArgs e)
        {
            if (Melodies.Check(CurrentPlayMelody, AnswerThree.Text))
            {
                Score++;
            }

            StartMelodyGame.Enabled = true;
            BlockedButtons();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            CheckGame();
        }

        private void BlockedButtons()
        {
            AnswerOne.Enabled = false;
            AnswerTwo.Enabled = false;
            AnswerThree.Enabled = false;
        }

        private void UnBlockButtons()
        {
            AnswerOne.Enabled = true;
            AnswerTwo.Enabled = true;
            AnswerThree.Enabled = true;
        }

        private void CheckGame()
        {
            if (AlreadyPlayed.Count == 10)
            {
                foreach (Control button in this.Controls)
                {
                    if (button is Button)
                    {
                        button.Enabled = false;
                    }
                }
                Melodies.Stop();
                RestartButton.Visible = true;
                RestartButton.Enabled = true;
                MessageBox.Show("Вы набрали " + Score.ToString() + " из 10", "Игра оконченая", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetGame()
        {
            IsInit = false;
            comboBox1.Enabled = true;
            StartMelodyGame.Enabled=true;
            StartMelodyGame.Text = "Начать игру";
            AnswerOne.Visible = false;
            AnswerTwo.Visible = false;
            AnswerThree.Visible = false;
            RestartButton.Visible = false;
            Score = 0;
            ScoreLabel.Text = Score.ToString();
        }

        private void ReserButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
