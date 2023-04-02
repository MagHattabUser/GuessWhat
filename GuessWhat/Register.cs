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
    public partial class Register : Form
    {
        private DataBase Data;
        public Register()
        {
            InitializeComponent();
            Data = new DataBase();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Player player;
            if(EntryPassword.Text == "" || EntryLogin.Text == "" || EntryUsername.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            player = Data.Register(EntryLogin.Text, EntryUsername.Text, EntryPassword.Text);
            if(player != null)
            {
                GuessMelody guessMelody = new GuessMelody();
                Hide();
                guessMelody.ShowDialog();
                Close();
            }
        }

        private void HidePasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HidePasswordCheck.Checked)
            {
                EntryPassword.PasswordChar = '\0';
            }
            else
            {
                EntryPassword.PasswordChar = '*';
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            Hide();
            authentication.ShowDialog();
            Close();
        }
    }
}
