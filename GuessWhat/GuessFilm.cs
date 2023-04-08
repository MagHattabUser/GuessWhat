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
    public partial class GuessFilm : Form
    {
        private FilmImage Images;
        private string CurrentImage;
        private List<int> AlreadyShow= new List<int>();
        private int Score = 0;
        private bool IsInit = false;
        public GuessFilm()
        {
            InitializeComponent();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void Init()
        {
            Images = new FilmImage(comboBox1.Text);
            IsInit = true;
            comboBox1.Enabled = false;
            StartFilmGame.Text = "Следующая песня";
            AnswerOne.Visible = true;
            AnswerTwo.Visible = true;
            AnswerThree.Visible = true;
        }
        private void FillButtonsText(int correctAnswer, int answerOne, int answerTwo)
        {
            List<Button> buttonList = new List<Button>();
            Random rnd = new Random();
            List<string> answerList = new List<string>();
            answerList.Add(Images.GetImage(correctAnswer));
            answerList.Add(Images.GetImage(answerOne));
            answerList.Add(Images.GetImage(answerTwo));

            foreach (Control button in this.Controls)
            {
                if (button is Button && button.Tag.ToString() != "main" && button.Tag.ToString() != "exit")
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
                    answerOne = random.Next(0, Images.Count());
                }
                else
                {
                    break;
                }
            }
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
            if (AlreadyShow.Count == 10)
            {
                foreach (Control button in this.Controls)
                {
                    if (button is Button)
                    {
                        button.Enabled = false;
                    }
                }
                RestartButton.Visible = true;
                RestartButton.Enabled = true;
                MessageBox.Show("Вы набрали " + Score.ToString() + " из 10", "Игра оконченая", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetGame()
        {
            IsInit = false;
            comboBox1.Enabled = true;
            StartFilmGame.Enabled = true;
            StartFilmGame.Text = "Начать игру";
            AnswerOne.Visible = false;
            AnswerTwo.Visible = false;
            AnswerThree.Visible = false;
            RestartButton.Visible = false;
            Score = 0;
            ScoreLabel.Text = Score.ToString();
            AlreadyShow.Clear();
            pictureBox1.Image = Properties.Resources.guessfilmback;
        }

        private void AnswerTwo_Click(object sender, EventArgs e)
        {
            if (Images.Check(CurrentImage, AnswerTwo.Text))
            {
                Score++;
            }

            StartFilmGame.Enabled = true;
            BlockedButtons();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            CheckGame();
        }

        private void StartFilmGame_Click_1(object sender, EventArgs e)
        {
            if (!IsInit)
            {
                Init();
            }

            UnBlockButtons();
            StartFilmGame.Enabled = false;
            Random random = new Random();
            int correctAnswer = random.Next(0, Images.Count());

            while (true)
            {
                if (AlreadyShow.Contains(correctAnswer))
                {
                    correctAnswer = random.Next(0, Images.Count());
                }
                else
                {
                    break;
                }
            }
            AlreadyShow.Add(correctAnswer);
            CurrentImage = Images.GetPath(correctAnswer);

            int answerOne = random.Next(0, Images.Count());
            int answerTwo = random.Next(0, Images.Count());

            CheckTheSameAnswer(correctAnswer, ref answerOne, answerTwo);
            CheckTheSameAnswer(correctAnswer, ref answerTwo, answerOne);
            FillButtonsText(correctAnswer, answerOne, answerTwo);
            pictureBox1.Image = Image.FromFile(Images.GetPath(correctAnswer));
        }

        private void AnswerOne_Click(object sender, EventArgs e)
        {
            if (Images.Check(CurrentImage, AnswerOne.Text))
            {
                Score++;
            }

            StartFilmGame.Enabled = true;
            BlockedButtons();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            CheckGame();
        }

        private void AnswerThree_Click(object sender, EventArgs e)
        {
            if (Images.Check(CurrentImage, AnswerThree.Text))
            {
                Score++;
            }

            StartFilmGame.Enabled = true;
            BlockedButtons();
            ScoreLabel.Text = "Очки: " + Score.ToString();
            CheckGame();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
