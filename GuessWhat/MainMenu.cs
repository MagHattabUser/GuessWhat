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
    public partial class MainMenu : Form
    {
        private Player Players;
        private XML XMLDoc;
        public MainMenu(Player players)
        {
            InitializeComponent();
            Players = players;
            XMLDoc = new XML();
            this.Text = "GuessWhat " + " Хорошоей игры " + Players.GetUserName();
            MelodyRecordLabel.Text = "Рекорд: " + Players.GetMusicScore().ToString();
            FilmRecordLabel.Text = "Рекорд: " + Players.GetFilmScore().ToString();
            WordRecordLabel.Text = "Рекорд: " + Players.GetWordScore().ToString();
            GetTableScore();
        }

        private void StartMelodyGame_Click(object sender, EventArgs e)
        {
            GuessMelody guessMelody = new GuessMelody(Players);
            Hide();
            guessMelody.ShowDialog();
            Close();
        }

        private void StartWordGame_Click(object sender, EventArgs e)
        {
            GuessWord guessWord = new GuessWord(Players);
            Hide();
            guessWord.ShowDialog();
            Close();
        }

        private void StartFilmGame_Click(object sender, EventArgs e)
        {
            GuessFilm guessFilm = new GuessFilm(Players);
            Hide();
            guessFilm.ShowDialog();
            Close();
        }

        private void GetTableScore()
        {
            List<Player> playersList = XMLDoc.GetAllPlayers();
            playersList.Sort((p1,p2)=>p2.GetAllScores().CompareTo(p1.GetAllScores()));
            if (playersList.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    BestPlayersList.Items.Add(playersList[i].GetAllScores() + "\t" + playersList[i].GetUserName() + "\n\r");
                }
            }
            else
            {
                for (int i = 0; i < playersList.Count; i++)
                {
                    BestPlayersList.Items.Add(playersList[i].GetAllScores() + "\t" + playersList[i].GetUserName() + "\n\r");
                }
            }
        }

        private void ExitFromGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitFromAccount_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            Hide();
            authentication.ShowDialog();
            Close();
        }

        private void RuleMelody_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроку предоставляется 10-секундный отрывок песни." +
                "\r\n\r\nИгроку предоставляется три варианта ответа на выбор." +
                "\r\n\r\nИгроку нужно выбрать правильный ответ из трех вариантов." +
                "\r\n\r\nЕсли игрок выбирает правильный ответ, ему начисляется очко.",
                "Правило игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RuleFilm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроку предоставляется кадр из фильма." +
                "\r\n\r\nИгроку предоставляется три варианта ответа на выбор." +
                "\r\n\r\nИгроку нужно выбрать правильный ответ из трех вариантов." +
                "\r\n\r\nЕсли игрок выбирает правильный ответ, ему начисляется очко.",
                "Правило игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RuleWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загадывается слово из 5 букв. Ваша задача — его угадать." +
               "\r\n\r\nСлово должно быть существительным, состоять из 5 буквы" +
               "\r\n\r\nУ вас будет несколько попыток угадать слово(в зависимости от уровня сложности)" +
               "\r\n\r\nПосле каждой попытки цвет буквы будет меняться." +
               "\r\n\r\nЗеленый — буква есть в слово и стоит именно в этом месте." +
               "\r\n\r\nЖелтый — буква есть в слове, но она должна стоять в другом месте." +
               "\r\n\r\nКрасный - кбуквы вообще нет в этом слове.",
               "Правило игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
