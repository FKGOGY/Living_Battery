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
    public partial class Ovladani : Form
    {
        public Ovladani()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            startmenu startmenu= new startmenu();
            startmenu.Show();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
