using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GuessWhat
{
    internal class DataBase
    {
        private XML Data;
        private Password PasswordManager;

        public DataBase()
        {
            Data = new XML();
            PasswordManager = new Password();
        }
        
        public Player Authenticate(string login, string password)
        {
            if (!Data.IsLoginContains(login))
            {
                MessageBox.Show("Пользователя с таким логином не найдено в системе","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

            if (!PasswordManager.VerifyHashedPassword(Data.GetPassword(login), password))
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return Data.GetPlayer(login);
        }

        public Player Register(string login, string username, string password)
        {
            if (Data.IsLoginContains(login))
            {
                MessageBox.Show("Пользователя с таким логином уже зарегистрирован", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Player player = new Player(login, username, password, 0, 0,0);
            Data.AddNewPlayer(player);

            return player;
        }
    }
}
