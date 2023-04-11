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
    }
}
