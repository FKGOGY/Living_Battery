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

    public partial class Level1 : Form
    {
        
        bool moveRight, moveLeft, moveUp, moveDown;
        public bool pickup;

        public int speed = 5;

        int pocetsec = 0;
        int caslevelu = 30;

        public Level1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

      

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft == true && charBattery.Left > 0)
            {
                charBattery.Left -= speed;
            }

            if (moveRight == true && charBattery.Left < 930)
            {
                charBattery.Left += speed;
            }

            if (moveUp == true && charBattery.Top > 45)
            {
                charBattery.Top -= speed;
            }

            if (moveDown == true && charBattery.Top < 612)
            {
                charBattery.Top += speed;
            }

            if(pickupBattery.Bounds.IntersectsWith(charBattery.Bounds))
            {
                pickup = true;
                pickupBattery.Visible = false;
            }

            pocetsec++;
            if (pocetsec == 50)
            {
                pocetsec = 0;
                caslevelu = caslevelu - 1;
                timeBar.Value = caslevelu;
            }
            
            if (nabijecka.Bounds.IntersectsWith(charBattery.Bounds) && pickup)
            {
                this.Hide();
                moveTimer.Stop();

                pickup = false;

                Level2 lvl2= new Level2();
                lvl2.Show();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
