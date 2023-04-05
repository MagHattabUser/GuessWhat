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
    public partial class Authentication : Form
    {
        private DataBase Data;
        public Authentication()
        {
            InitializeComponent();
            Data = new DataBase();
        }

        private void LoginInButton_Click(object sender, EventArgs e)
        {
            Player player;
            player = Data.Authenticate(EntryLogin.Text, EntryPassword.Text);
            if (player!=null)
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

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Hide();
            register.ShowDialog();
            Close();
        }
    }
}
