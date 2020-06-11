using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tower_Defense
{
    public partial class GameScreen : UserControl
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<Tower> basicList = new List<Tower>();
        List<Tower> fastList = new List<Tower>();
        List<Tower> strongList = new List<Tower>();

        List<Goblin> basicGList = new List<Goblin>();
        List<Goblin> fastGList = new List<Goblin>();
        List<Goblin> strongGList = new List<Goblin>();
        List<Goblin> bossGList = new List<Goblin>();

        List<PictureBox> GoblinBoxes = new List<PictureBox>();

        SolidBrush basicGBrush = new SolidBrush(Color.Green);
        int Level = 0;
       // int counter = 0;
        //int newX=210;
        //int newY;
       //int newX2 = 210;
       // int newY2;
       // int CastleHP = 100;
       // int i = 0;
       // int loop;
        int counter = 100;
        

        //Goblin basicG = new Goblin(100, 50, 1, 214, 3);
        Goblin fastG = new Goblin(50, 100, 2, 214, 3,43,61);
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            int newX2 = label2.Location.X - pictureBox20.Location.X;
            int newY2 = label2.Location.Y - pictureBox20.Location.Y;
            label2.Location = new Point(newX2, newY2);
            label2.Parent = pictureBox20;
            panel1.Visible = false;
            button3.Visible = false;
            label3.Text = "Basic: x" + (Form1.basic);
            label4.Text = "Fast: x" + (Form1.fast);
            label5.Text = "Strong: x" + (Form1.strong);

            for (int i = 1; i < 19; i++)
            {
                pictureBoxes.Add((PictureBox)Controls.Find("pictureBox" + i, true)[0]);
            }

            for (int i = 0; i < 18; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                pictureBoxes[i].Visible = true;
            }
            button3.Visible = true;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            button2.Visible = false;
            label2.Visible = false;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 9;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 4;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 5;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 6;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 7;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 8;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 10;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 11;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 12;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 13;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 14;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 15;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 16;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Form1.slot = 17;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (Form1.basic > 0)
            {
                pictureBoxes[Form1.slot].Image = Tower_Defense.Properties.Resources.basic;
                pictureBoxes[Form1.slot].Width = 81;
                panel1.Visible = false;
                Form1.basic = Form1.basic - 1;
                label3.Text = "Basic: x" + (Form1.basic);
                int Damage = 10;
                int ShotSpeed = 10;
                Tower basic = new Tower(ShotSpeed, Damage);
                basicList.Add(basic);
            }
            if (Form1.basic == 0)
            {
                MessageBox.Show("You do not have any basic towers, please try something else.");
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (Form1.fast > 0)
            {
                pictureBoxes[Form1.slot].Image = Tower_Defense.Properties.Resources.fast;
                pictureBoxes[Form1.slot].Width = 81;
                panel1.Visible = false;
                Form1.fast = Form1.fast - 1;
                label4.Text = "Fast: x" + (Form1.fast);
                int Damage = 10;
                int ShotSpeed = 15;
                Tower fast = new Tower(ShotSpeed, Damage);
                basicList.Add(fast);
            }
            else if (Form1.fast == 0)
            {
                MessageBox.Show("You do not have any fast towers, please try something else.");
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (Form1.strong > 0)
            {
                pictureBoxes[Form1.slot].Image = Tower_Defense.Properties.Resources.strong;
                pictureBoxes[Form1.slot].Width = 81;
                panel1.Visible = false;
                Form1.strong = Form1.strong - 1;
                label5.Text = "Strong: x" + (Form1.strong);
                int Damage = 20;
                int ShotSpeed = 10;
                Tower strong = new Tower(ShotSpeed, Damage);
                basicList.Add(strong);
            }
            if (Form1.basic == 0)
            {
                MessageBox.Show("You do not have any strong towers, please try something else.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        } //Panel exit button is pressed

        private void button3_Click(object sender, EventArgs e) //Defend button is pressed
        {
            button3.Visible = false;
            Level = Level + 1;
            timer1.Enabled = true;
            //Run Gameplay, set goblins and have them move in, set game level
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 100)
            {
                Goblin basicG = new Goblin(100, 50, 1, 214, 3,43,61);
                basicGList.Add(basicG);
                counter = 0;
            }
            foreach (Goblin basicG in basicGList)
            {
                basicG.Move();
            }

           // GoblinBox1.Location = new Point(Goblin.x, Goblin.y);

            Refresh();


        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Goblin basicG in basicGList)
            {
                e.Graphics.FillRectangle(basicGBrush, basicG.x, basicG.y, basicG.sizeX, basicG.sizeY);
            }
        }

    }
}
