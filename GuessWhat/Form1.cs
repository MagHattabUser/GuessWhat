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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Melody melody = new Melody();
            button1.Text = melody.GetPath(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Melody melody = new Melody();
            button2.Text = melody.GetMelody(0);
        }
    }
}
