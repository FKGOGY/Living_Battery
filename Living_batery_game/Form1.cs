using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Living_batery_game
{
    public partial class startmenu : Form
    {

        public startmenu()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 lvl1 = new Level1();
            lvl1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ovladani ovladani= new Ovladani();
            ovladani.Show();
        }
    }
}
