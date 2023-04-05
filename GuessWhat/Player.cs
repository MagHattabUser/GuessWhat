using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuessWhat
{
    internal class Player
    {
        private string Login;
        private string UserName;
        private string Password;
        private int MusicScore;
        private int FilmScore;
        private int WordScore;

        public Player(string login, string username, string password,
            int musicScore, int filmScore, int wordScore,
            bool isAlreadyHash = false)
        {
            if (!isAlreadyHash)
            {
                var hashPass = new Password();
                Password = hashPass.HashPassword(password);
            }
            else
            {  
                Password = password;
            }
            Login = login;
            UserName = username;
            MusicScore = musicScore;
            FilmScore = filmScore;
            WordScore = wordScore;
        }

        public Player()
        {
            Login = "undefined";
            UserName = "undefined";
            Password = "undefined";
            MusicScore = 0;
            FilmScore = 0;
            WordScore = 0;
        }

        public void SetUserName(string userName)
        {
            UserName = userName;
        }

        public void SetLogin(string login)
        {
            Login = login;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
        public void SetMusicScore(int musicScore)
        {
            MusicScore = musicScore;
        }
        public void SetFilmScore(int filmScore)
        {
            FilmScore = filmScore;
        }
        public void SetWordScore(int wordScore)
        {
            WordScore = wordScore;
        }

        public string GetUserName()
        {
            return UserName;
        }
        public string GetPassword()
        {
            return Password;
        }
        public string GetLogin()
        {
            return Login;
        }

        public int GetMusicScore()
        {
            return MusicScore;
        }
        public int GetFilmScore()
        {
            return FilmScore;
        }
        public int GetWordScore()
        {
            return WordScore;
        }
    }
}
