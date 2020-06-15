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
        int TowerX;
        int TowerY;

        int counter = 50;
        int shotClock = 0;
        int shotClockF = 0;
        int MaxG;
        int basicNum = 0;
        int spawn = 100;
        int Fspawn = 200;
        int counterF = 0;
        int FastNum;
        int MaxF;
        //int 
        

        //Goblin basicG = new Goblin(100, 50, 1, 214, 3);
       // Goblin fastG = new Goblin(50, 100, 2, 214, 2,43,61);
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            if (Form1.GamePlayed == 0)
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
            if (Form1.GamePlayed == 1)
            {
                pictureBox19.Visible = false;
                button2.Visible = false;
                pictureBox20.Visible = false;
                panel1.Visible = false;
                button3.Visible = true;
                label2.Visible = false;
                Form1.basic = Form1.basic + Form1.Oldbasic;
                Form1.fast = Form1.fast + Form1.Oldfast;
                Form1.strong = Form1.strong + Form1.Oldstrong;
                label3.Text = "Basic: x" + (Form1.basic);
                label4.Text = "Fast: x" + (Form1.fast);
                label5.Text = "Strong: x" + (Form1.strong);
                Form1.Oldbasic = 0;
                Form1.Oldfast = 0;
                Form1.Oldstrong = 0;

                for (int i = 1; i < 19; i++)
                {
                    pictureBoxes.Add((PictureBox)Controls.Find("pictureBox" + i, true)[0]);
                }
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
            if (Form1.basic == 0)
            {
                MessageBox.Show("You do not have any basic towers, please try something else.");
            }
            if (Form1.basic > 0)
            {
                pictureBoxes[Form1.slot].Image = Tower_Defense.Properties.Resources.basic;
                pictureBoxes[Form1.slot].Width = 81;
                panel1.Visible = false;
                Form1.basic = Form1.basic - 1;
                label3.Text = "Basic: x" + (Form1.basic);
                int Damage = 10;
                int ShotSpeed = 10;
                TowerX = pictureBoxes[Form1.slot].Location.X;
                TowerY = pictureBoxes[Form1.slot].Location.Y;
                Tower basic = new Tower(ShotSpeed, Damage,TowerX,TowerY, pictureBoxes[Form1.slot].Width, pictureBoxes[Form1.slot].Height, "basic");
                basicList.Add(basic);
            }
      
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (Form1.fast == 0)
            {
                MessageBox.Show("You do not have any fast towers, please try something else.");
            }
            if (Form1.fast > 0)
            {
               pictureBoxes[Form1.slot].Image = Tower_Defense.Properties.Resources.fast;
                pictureBoxes[Form1.slot].Width = 81;
                panel1.Visible = false;
                Form1.fast = Form1.fast - 1;
                label4.Text = "Fast: x" + (Form1.fast);
                int Damage = 10;
                int ShotSpeed = 15;
                TowerX = pictureBoxes[Form1.slot].Location.X;
                TowerY = pictureBoxes[Form1.slot].Location.Y;
                Tower fast = new Tower(ShotSpeed, Damage, TowerX,TowerY, pictureBoxes[Form1.slot].Width, pictureBoxes[Form1.slot].Height, "fast");
                fastList.Add(fast);
            }
            
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (Form1.strong == 0)
            {
                MessageBox.Show("You do not have any strong towers, please try something else.");
            }
            if (Form1.strong > 0)
            {
                pictureBoxes[Form1.slot].Image = Tower_Defense.Properties.Resources.strong;
                pictureBoxes[Form1.slot].Width = 81;
                panel1.Visible = false;
                Form1.strong = Form1.strong - 1;
                label5.Text = "Strong: x" + (Form1.strong);
                int Damage = 20;
                int ShotSpeed = 10;
                TowerX = pictureBoxes[Form1.slot].Location.X;
                TowerY = pictureBoxes[Form1.slot].Location.Y;
                Tower strong = new Tower(ShotSpeed, Damage,TowerX,TowerY,pictureBoxes[Form1.slot].Width, pictureBoxes[Form1.slot].Height, "strong");
                strongList.Add(strong);
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
            if (Level == 1)
            {
                MaxG = 5;
                MaxF = 1;
                spawn = 100;
                Fspawn = 200;
            }
            if (Level == 2)
            {
                MaxG = 10;
                MaxF = 3;
                spawn = 80;
                Fspawn = 180;
            }
            if (Level == 15)
            {
                MaxG = 15;
                MaxF = 5;
                spawn = 60;
            }
            if (Level == 20)
            {
                MaxG = 10;
                MaxF = 10;
                spawn = 50;
            }
            //Run Gameplay, set goblins and have them move in, set game level
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shotClock++;
            shotClockF++;
            counter++;
            counterF++;
           
            label9.Text = Convert.ToString(basicNum);
            if (counter == spawn)
            {
                if (basicNum < MaxG)
                {

                    Goblin basicG = new Goblin(50, 50, 1, 214, 2, 43, 61);
                    basicGList.Add(basicG);
                    this.Controls.Add(basicG.pb);
                    counter = 0;
                    basicNum = basicNum + 1;
                }
            }
            if (counterF == Fspawn)
            {
                if (FastNum < MaxF)
                {

                    Goblin fastG = new Goblin(50, 50, 2, 214, 2, 43, 61);
                    fastGList.Add(fastG);
                    this.Controls.Add(fastG.pb);
                    counter = 0;
                    FastNum = FastNum + 1;
                }
            }
            foreach (Goblin basicG in basicGList)
            {
                basicG.Move();
            }
            foreach (Goblin fastG in fastGList)
            {
                fastG.Move();
            }
            foreach (Tower basic in basicList)
            {
                if (shotClock == 25)
                {
                    Shoot();
                    shotClock = 0;
                    
                }
                
            }   
            foreach (Tower fast in fastList)
            {
                if (shotClockF == 15)
                {
                    ShootF();
                    shotClockF = 0;
                }
            }

            label7.Text = ("Score:" + Convert.ToString(Form1.score));
            label8.Text = ("Coins:" + Convert.ToString(Form1.coins));


          if (basicGList.Count == 0 && fastGList.Count ==0 && strongGList.Count==0 && counter>100)
            {
                timer1.Enabled = false;
                Form1.GamePlayed = 1;
                basicNum = 0;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                ShopScreen ss = new ShopScreen();
                f.Controls.Add(ss);
            }
            Refresh();
        }
        private void Shoot()
        {
            for (int i =0; i< basicList.Count;i++)
            {
                for (int j = 0; j < basicGList.Count ; j++)
                {
                    if (basicList[i].x - basicGList[j].x < 50 && basicList[i].y - basicGList[j].y < 50)
                    {
                        basicGList[j].Health = basicGList[j].Health - basicList[i].Damage;
                        label6.Text = Convert.ToString(basicGList[j].Health);
                        if (basicGList[j].Health <= 0)
                        {
                            basicGList[j].pb.Visible = false;
                            Form1.score = Form1.score + 50;
                            Form1.coins = Form1.coins + 25;
                            basicGList.RemoveAt(j);
                            foreach (Tower fast in fastList)
                            {
                                Form1.Oldfast = Form1.Oldfast + 1;
                            }
                            foreach (Tower basic in basicList)
                            {
                                Form1.Oldbasic = Form1.Oldbasic + 1;
                            }
                            foreach (Tower strong in strongList)
                            {
                                Form1.Oldstrong = Form1.Oldstrong + 1;
                            }
                        }
                    }
                }
            }
            
        }
        private void ShootF()
        {
            for (int i = 0; i < fastList.Count; i++)
            {
                for (int j = 0; j < basicGList.Count; j++)
                {
                    if (fastList[i].x - basicGList[j].x < 50 && fastList[i].y - basicGList[j].y < 50) //TRY TO FIND A BETTER METHOD TO ATTACK CLOSEST GOBLIN
                    {
                        basicGList[j].Health = basicGList[j].Health - fastList[i].Damage;
                        label6.Text = Convert.ToString(basicGList[j].Health);
                        if (basicGList[j].Health <= 0)
                        {
                            basicGList[j].pb.Visible = false;
                            Form1.score = Form1.score + 50;
                            Form1.coins = Form1.coins + 25;
                             basicGList.RemoveAt(j);
                        }
                    }
                }
            }
        }
    }
}
