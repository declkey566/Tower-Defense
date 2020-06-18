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
using System.IO;
using System.Threading;

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
        List<int> Scores = new List<int>();

        List<Bullet> bullets = new List<Bullet>();
        List<Bullet> bulletsF = new List<Bullet>();
        List<Bullet> bulletsS = new List<Bullet>();



        static int basicH = 50;
        static int fastH = 70;
        static int bossH = 200;

        static int basicD = 50;
        static int fastD = 50;
        static int bossD = 150;

    

        List<PictureBox> GoblinBoxes = new List<PictureBox>();

        SolidBrush basicGBrush = new SolidBrush(Color.Green);
        int TowerX;
        int TowerY;
       // int HP;

        int counter = 50;
        int shotClock = 0;
        int shotClockF = 0;
        int shotClockS = 0;
        int MaxG;
        int basicNum = 0;
        int spawn = 100;
        int Fspawn = 200;
        int counterF = 0;
        int FastNum=0;
        int MaxF;

        int spawnS ;
        int counterS = 0;
        int StrongNum=0;
        int MaxS;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            if (Form1.GamePlayed == 0)
            {
                Form1.HP = 100;
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
               // HP = HP;
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
            Form1.Level = Form1.Level + 1;
            timer1.Enabled = true;
            if (Form1.Level == 1)
            {
                MaxG = 5;
                MaxF = 1;
                MaxS = 0;
                spawn = 100;
                Fspawn = 200;
                spawnS = 300;
            }
            if (Form1.Level == 2)
            {
                basicH = basicH + 20;
                fastH = fastH + 20;
                fastD = fastD + 10;
                basicD = basicD + 10;
                MaxG = 5;
                MaxF = 5;
                MaxS = 0;
                spawn = 80;
                Fspawn = 150;
                spawnS = 300;
            }
            if (Form1.Level == 3)
            {
                basicH = basicH + 30;
                fastH = fastH + 30;
                fastD = fastD + 10;
                basicD = basicD + 10;
                MaxG = 15;
                MaxF = 5;
                MaxS = 1;
                spawn = 60;
                Fspawn = 120;
                spawnS = 300;
            }
            if (Form1.Level == 4)
            {
                basicH = basicH + 50;
                fastH = fastH + 50;
                fastD = fastD + 20;
                basicD = basicD + 20;
                bossH = bossH + 100;
                bossD = bossD + 20;
                MaxG = 10;                
                MaxF = 10;
                MaxS = 2;
                spawn = 50;
                Fspawn = 100;
                spawnS = 250;
            }
            if (Form1.Level == 5)
            {
                basicH = basicH + 70;
                fastH = fastH + 70;
                fastD = fastD + 20;
                basicD = basicD + 20;
                bossH = bossH + 150;
                bossD = bossD + 20;
                MaxG = 10;
                MaxF = 12;
                MaxS = 3;
                spawn = 50;
                Fspawn = 100;
                spawnS = 250;
            }
            if (Form1.Level == 6)
            {
                basicH = basicH + 90;
                fastH = fastH + 90;
                fastD = fastD + 20;
                basicD = basicD + 20;
                bossH = bossH + 250;
                bossD = bossD + 20;
                MaxG = 10;
                MaxF = 15;
                MaxS = 4;
                spawn = 50;
                Fspawn = 100;
                spawnS = 250;
            }
            //Run Gameplay, set goblins and have them move in, set game level
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shotClock++;
            shotClockF++;
            shotClockS++;
            counter++;
            counterF++;
            counterS++;
            if (counter == spawn)
            {
                if (basicNum < MaxG)
                {
                    Goblin basicG = new Goblin(basicH, basicD, 1, 214, 2, 43, 61, "basic");
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
                    Goblin fastG = new Goblin(fastH, fastD, 4, 214, 2, 43, 61, "fast");
                    fastGList.Add(fastG);
                    this.Controls.Add(fastG.pb);
                    counter = 0;
                    FastNum = FastNum + 1;
                }
            }
            if (counterS == spawnS)
            {
                if (StrongNum < MaxS)
                {
                    Goblin strongG = new Goblin(bossH, bossD, 2, 214, 2, 43, 61, "boss");
                    strongGList.Add(strongG);
                    this.Controls.Add(strongG.pb);
                    counterS = 0;
                    StrongNum = StrongNum + 1;
                }
                counterS = 0;
            }
            foreach (Goblin basicG in basicGList)
            {
                basicG.Move();
            }
            foreach (Goblin fastG in fastGList)
            {
                fastG.Move();
            }
            foreach (Goblin strongG in strongGList)
            {
                strongG.Move();
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
            foreach (Tower strong in strongList)
            {
                if (shotClockS == 30)
                {
                    ShootS();
                    shotClockS = 0;
                }
            }

            for (int i = 0; i < basicList.Count; i++)
            {
                for (int j = 0; j < basicGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(basicGList[j].x, basicGList[j].y, basicGList[j].sizeX, basicGList[j].sizeY);

                    for (int k = 0; k < bullets.Count; k++)
                    {
                        int previousX = bullets[k].x;
                        if (basicGList[j].x > bullets[k].x)
                        {
                            bullets[k].BMove("Right");
                        }
                        if (basicGList[j].x < bullets[k].x)
                        {
                            bullets[k].BMove("Left");
                        }
                        if (basicGList[j].y > bullets[k].y)
                        {
                            bullets[k].BMove("Up");
                        }
                        if (basicGList[j].y < bullets[k].y)
                        {
                            bullets[k].BMove("Down");
                        }
                        if (bullets[k].x == previousX)
                        {
                            bullets.RemoveAt(k);
                        }
                    }
                    foreach (Bullet b in bullets)
                    {
                        Rectangle bulletRec = new Rectangle(b.x, b.y, b.size, b.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bullets.IndexOf(b);
                            bullets.RemoveAt(index);
                            basicGList[j].Health = basicGList[j].Health - basicList[i].Damage;
                            if (basicGList[j].Health <= 0)
                            {
                                basicGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 50;
                                Form1.coins = Form1.coins + 25;
                                basicGList.RemoveAt(j);


                            }
                            break;
                        }
                    }
                }
                for (int j = 0; j < fastGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(fastGList[j].x, fastGList[j].y, fastGList[j].sizeX, fastGList[j].sizeY);

                    for (int k = 0; k < bullets.Count; k++)
                    {
                        int previousX = bullets[k].x;
                        if (fastGList[j].x > bullets[k].x)
                        {
                            bullets[k].BMove("Right");
                        }
                        if (fastGList[j].x < bullets[k].x)
                        {
                            bullets[k].BMove("Left");
                        }
                        if (fastGList[j].y > bullets[k].y)
                        {
                            bullets[k].BMove("Up");
                        }
                        if (fastGList[j].y < bullets[k].y)
                        {
                            bullets[k].BMove("Down");
                        }
                        if (bullets[k].x == previousX)
                        {
                            bullets.RemoveAt(k);
                        }
                    }
                    foreach (Bullet c in bullets)
                    {
                        Rectangle bulletRec = new Rectangle(c.x, c.y, c.size, c.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bullets.IndexOf(c);
                            bullets.RemoveAt(index);
                            fastGList[j].Health = fastGList[j].Health - basicList[i].Damage;
                            if (fastGList[j].Health <= 0)
                            {
                                fastGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 100;
                                Form1.coins = Form1.coins + 50;
                                fastGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
                for (int j = 0; j < strongGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(strongGList[j].x, strongGList[j].y, strongGList[j].sizeX, strongGList[j].sizeY);

                    for (int k = 0; k < bullets.Count; k++)
                    {
                        int previousX = bullets[k].x;
                        if (strongGList[j].x > bullets[k].x)
                        {
                            bullets[k].BMove("Right");
                        }
                        if (strongGList[j].x < bullets[k].x)
                        {
                            bullets[k].BMove("Left");
                        }
                        if (strongGList[j].y > bullets[k].y)
                        {
                            bullets[k].BMove("Up");
                        }
                        if (strongGList[j].y < bullets[k].y)
                        {
                            bullets[k].BMove("Down");
                        }
                        if (bullets[k].x == previousX)
                        {
                            bullets.RemoveAt(k);
                        }
                    }
                    foreach (Bullet d in bullets)
                    {
                        Rectangle bulletRec = new Rectangle(d.x, d.y, d.size, d.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bullets.IndexOf(d);
                            bullets.RemoveAt(index);
                            strongGList[j].Health = strongGList[j].Health - basicList[i].Damage;
                            if (strongGList[j].Health <= 0)
                            {
                                strongGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 200;
                                Form1.coins = Form1.coins + 100;
                                strongGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
            }


            for (int i = 0; i < fastList.Count; i++)
            {
                for (int j = 0; j < basicGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(basicGList[j].x, basicGList[j].y, basicGList[j].sizeX, basicGList[j].sizeY);
                    //foreach (Bullet b in bulletsF)
                    //{
                    //    if (basicGList[j].x > b.x)
                    //    {
                    //        b.x = b.x + 2;

                    //    }
                    //    if (basicGList[j].x < b.x)
                    //    {
                    //        b.x = b.x - 2;

                    //    }
                    //    if (basicGList[j].y > b.y)
                    //    {
                    //        b.y = b.y + 2;

                    //    }
                    //    if (basicGList[j].y < b.y)
                    //    {
                    //        b.x = b.x - 2;

                    //    }
                    //}
                    for (int k = 0; k < bulletsF.Count; k++)
                    {
                        int previousX = bulletsF[k].x;
                        if (basicGList[j].x > bulletsF[k].x)
                        {
                            bulletsF[k].BMove("Right");

                        }
                        if (basicGList[j].x < bulletsF[k].x)
                        {
                            bulletsF[k].BMove("Left");
                        }
                        if (basicGList[j].y > bulletsF[k].y)
                        {
                            bulletsF[k].BMove("Up");
                        }
                        if (basicGList[j].y < bulletsF[k].y)
                        {
                            bulletsF[k].BMove("Down");
                        }
                        if (bulletsF[k].x == previousX)
                        {
                            bulletsF.RemoveAt(k);
                        }
                    }
                    foreach (Bullet b in bulletsF)
                    {
                        Rectangle bulletRec = new Rectangle(b.x, b.y, b.size, b.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bulletsF.IndexOf(b);
                            bulletsF.RemoveAt(index);
                            basicGList[j].Health = basicGList[j].Health - fastList[i].Damage;
                            if (basicGList[j].Health <= 0)
                            {
                                basicGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 50;
                                Form1.coins = Form1.coins + 25;
                                basicGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
                for (int j = 0; j < fastGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(fastGList[j].x, fastGList[j].y, fastGList[j].sizeX, fastGList[j].sizeY);

                    for (int k = 0; k < bulletsF.Count; k++)
                    {
                        int previousX = bulletsF[k].x;
                        if (fastGList[j].x > bulletsF[k].x)
                        {
                            bulletsF[k].BMove("Right");
                        }
                        if (fastGList[j].x < bulletsF[k].x)
                        {
                            bulletsF[k].BMove("Left");
                        }
                        if (fastGList[j].y > bulletsF[k].y)
                        {
                            bulletsF[k].BMove("Up");
                        }
                        if (fastGList[j].y < bulletsF[k].y)
                        {
                            bulletsF[k].BMove("Down");
                        }
                        if (bulletsF[k].x == previousX)
                        {
                            bulletsF.RemoveAt(k);
                        }
                    }
                    foreach (Bullet c in bulletsF)
                    {
                        Rectangle bulletRec = new Rectangle(c.x, c.y, c.size, c.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bulletsF.IndexOf(c);
                            bulletsF.RemoveAt(index);
                            fastGList[j].Health = fastGList[j].Health - fastList[i].Damage;
                            if (fastGList[j].Health <= 0)
                            {
                                fastGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 100;
                                Form1.coins = Form1.coins + 50;
                                fastGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
                for (int j = 0; j < strongGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(strongGList[j].x, strongGList[j].y, strongGList[j].sizeX, strongGList[j].sizeY);

                    for (int k = 0; k < bulletsF.Count; k++)
                    {
                        int previousX = bulletsF[k].x;
                        if (strongGList[j].x > bulletsF[k].x)
                        {
                            bulletsF[k].BMove("Right");
                        }
                        if (strongGList[j].x < bulletsF[k].x)
                        {
                            bulletsF[k].BMove("Left");
                        }
                        if (strongGList[j].y > bulletsF[k].y)
                        {
                            bulletsF[k].BMove("Up");
                        }
                        if (strongGList[j].y < bulletsF[k].y)
                        {
                            bulletsF[k].BMove("Down");
                        }
                        if (bulletsF[k].x == previousX)
                        {
                            bulletsF.RemoveAt(k);
                        }
                    }
                    foreach (Bullet d in bulletsF)
                    {
                        Rectangle bulletRec = new Rectangle(d.x, d.y, d.size, d.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bulletsF.IndexOf(d);
                            bulletsF.RemoveAt(index);
                            strongGList[j].Health = strongGList[j].Health - fastList[i].Damage;
                            if (strongGList[j].Health <= 0)
                            {
                                strongGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 200;
                                Form1.coins = Form1.coins + 100;
                                strongGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < strongList.Count; i++)
            {
                for (int j = 0; j < basicGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(basicGList[j].x, basicGList[j].y, basicGList[j].sizeX, basicGList[j].sizeY);
                    //foreach (Bullet b in bulletsS)
                    //{
                    //    if (basicGList[j].x > b.x)
                    //    {
                    //        b.x = b.x + 2;

                    //    }
                    //    if (basicGList[j].x < b.x)
                    //    {
                    //        b.x = b.x - 2;

                    //    }
                    //    if (basicGList[j].y > b.y)
                    //    {
                    //        b.y = b.y + 2;

                    //    }
                    //    if (basicGList[j].y < b.y)
                    //    {
                    //        b.x = b.x - 2;

                    //    }
                    //}
                    for (int k = 0; k < bulletsS.Count; k++)
                    {
                        int previousX = bulletsS[k].x;
                        if (basicGList[j].x > bulletsS[k].x)
                        {
                            bulletsS[k].BMove("Right");

                        }
                        if (basicGList[j].x < bulletsS[k].x)
                        {
                            bulletsS[k].BMove("Left");
                        }
                        if (basicGList[j].y > bulletsS[k].y)
                        {
                            bulletsS[k].BMove("Up");
                        }
                        if (basicGList[j].y < bulletsS[k].y)
                        {
                            bulletsS[k].BMove("Down");
                        }
                        if (bulletsS[k].x == previousX)
                        {
                            bulletsS.RemoveAt(k);
                        }
                    }
                    foreach (Bullet b in bulletsS)
                    {
                        Rectangle bulletRec = new Rectangle(b.x, b.y, b.size, b.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bulletsS.IndexOf(b);
                            bulletsS.RemoveAt(index);
                            basicGList[j].Health = basicGList[j].Health - strongList[i].Damage;
                            if (basicGList[j].Health <= 0)
                            {
                                basicGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 50;
                                Form1.coins = Form1.coins + 25;
                                basicGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
                for (int j = 0; j < fastGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(fastGList[j].x, fastGList[j].y, fastGList[j].sizeX, fastGList[j].sizeY);

                    for (int k = 0; k < bulletsS.Count; k++)
                    {
                        int previousX = bulletsS[k].x;
                        if (fastGList[j].x > bulletsS[k].x)
                        {
                            bulletsS[k].BMove("Right");
                        }
                        if (fastGList[j].x < bulletsS[k].x)
                        {
                            bulletsS[k].BMove("Left");
                        }
                        if (fastGList[j].y > bulletsS[k].y)
                        {
                            bulletsS[k].BMove("Up");
                        }
                        if (fastGList[j].y < bulletsS[k].y)
                        {
                            bulletsS[k].BMove("Down");
                        }
                        if (bulletsS[k].x == previousX)
                        {
                            bulletsS.RemoveAt(k);
                        }
                    }
                    foreach (Bullet c in bulletsS)
                    {
                        Rectangle bulletRec = new Rectangle(c.x, c.y, c.size, c.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bulletsS.IndexOf(c);
                            bulletsS.RemoveAt(index);
                            fastGList[j].Health = fastGList[j].Health - strongList[i].Damage;
                            if (fastGList[j].Health <= 0)
                            {
                                fastGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 100;
                                Form1.coins = Form1.coins + 50;
                                fastGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
                for (int j = 0; j < strongGList.Count; j++)
                {

                    Rectangle GoblinRec = new Rectangle(strongGList[j].x, strongGList[j].y, strongGList[j].sizeX, strongGList[j].sizeY);

                    for (int k = 0; k < bulletsS.Count; k++)
                    {
                        int previousX = bulletsF[k].x;
                        if (strongGList[j].x > bulletsS[k].x)
                        {
                            bulletsS[k].BMove("Right");
                        }
                        if (strongGList[j].x < bulletsS[k].x)
                        {
                            bulletsS[k].BMove("Left");
                        }
                        if (strongGList[j].y > bulletsS[k].y)
                        {
                            bulletsS[k].BMove("Up");
                        }
                        if (strongGList[j].y < bulletsS[k].y)
                        {
                            bulletsS[k].BMove("Down");
                        }
                        if (bulletsS[k].x == previousX)
                        {
                            bulletsS.RemoveAt(k);
                        }
                    }
                    foreach (Bullet d in bulletsS)
                    {
                        Rectangle bulletRec = new Rectangle(d.x, d.y, d.size, d.size);
                        if (bulletRec.IntersectsWith(GoblinRec))
                        {
                            int index = bulletsS.IndexOf(d);
                            bulletsS.RemoveAt(index);
                            strongGList[j].Health = strongGList[j].Health - strongList[i].Damage;
                            if (strongGList[j].Health <= 0)
                            {
                                strongGList[j].pb.Visible = false;
                                Form1.score = Form1.score + 200;
                                Form1.coins = Form1.coins + 100;
                                strongGList.RemoveAt(j);
                            }
                            break;
                        }
                    }
                }
            }




            label7.Text = ("Score:" + Convert.ToString(Form1.score));
            label8.Text = ("Coins:" + Convert.ToString(Form1.coins));

            CheckHit();

            if (basicGList.Count == 0 && fastGList.Count ==0 && strongGList.Count==0 && counter>100 && Form1.HP >0)
            {
                timer1.Enabled = false;
                Form1.GamePlayed = 1;
                basicNum = 0;
                FastNum = 0;
                StrongNum = 0;
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
                Form f = this.FindForm();
                f.Controls.Remove(this);
                ShopScreen ss = new ShopScreen();
                f.Controls.Add(ss);
            }
            
            Refresh();
        }
            //        private void BasicBullets()
            //{
            //    for (int i = 0; i < basicList.Count; i++)
            //    {
            //        for (int j = 0; j < basicGList.Count; j++)
            //        {

            //            Rectangle GoblinRec = new Rectangle(basicGList[j].x, basicGList[j].y, basicGList[j].sizeX, basicGList[j].sizeY);

            //            for (int k = 0; k < bullets.Count; k++)
            //            {
            //                int previousX = bullets[k].x;
            //                if (basicGList[j].x > bullets[k].x)
            //                {
            //                    bullets[k].BMove("Right");
            //                }
            //                if (basicGList[j].x < bullets[k].x)
            //                {
            //                    bullets[k].BMove("Left");
            //                }
            //                if (basicGList[j].y > bullets[k].y)
            //                {
            //                    bullets[k].BMove("Up");
            //                }
            //                if (basicGList[j].y < bullets[k].y)
            //                {
            //                    bullets[k].BMove("Down");
            //                }
            //                if (bullets[k].x == previousX)
            //                {
            //                    bullets.RemoveAt(k);
            //                }
            //            }
            //            foreach (Bullet b in bullets)
            //            {
            //                Rectangle bulletRec = new Rectangle(b.x, b.y, b.size, b.size);
            //                if (bulletRec.IntersectsWith(GoblinRec))
            //                {
            //                    int index = bullets.IndexOf(b);
            //                    bullets.RemoveAt(index);
            //                    basicGList[j].Health = basicGList[j].Health - basicList[i].Damage;
            //                    if (basicGList[j].Health <= 0)
            //                    {
            //                        basicGList[j].pb.Visible = false;
            //                        Form1.score = Form1.score + 50;
            //                        Form1.coins = Form1.coins + 25;
            //                        basicGList.RemoveAt(j);


            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //        for (int j = 0; j < fastGList.Count; j++)
            //        {

            //            Rectangle GoblinRec = new Rectangle(fastGList[j].x, fastGList[j].y, fastGList[j].sizeX, fastGList[j].sizeY);

            //            for (int k = 0; k < bullets.Count; k++)
            //            {
            //                int previousX = bullets[k].x;
            //                if (fastGList[j].x > bullets[k].x)
            //                {
            //                    bullets[k].BMove("Right");
            //                }
            //                if (fastGList[j].x < bullets[k].x)
            //                {
            //                    bullets[k].BMove("Left");
            //                }
            //                if (fastGList[j].y > bullets[k].y)
            //                {
            //                    bullets[k].BMove("Up");
            //                }
            //                if (fastGList[j].y < bullets[k].y)
            //                {
            //                    bullets[k].BMove("Down");
            //                }
            //                if (bullets[k].x == previousX)
            //                {
            //                    bullets.RemoveAt(k);
            //                }
            //            }
            //            foreach (Bullet c in bullets)
            //            {
            //                Rectangle bulletRec = new Rectangle(c.x, c.y, c.size, c.size);
            //                if (bulletRec.IntersectsWith(GoblinRec))
            //                {
            //                    int index = bullets.IndexOf(c);
            //                    bullets.RemoveAt(index);
            //                    fastGList[j].Health = fastGList[j].Health - basicList[i].Damage;
            //                    if (fastGList[j].Health <= 0)
            //                    {
            //                        fastGList[j].pb.Visible = false;
            //                        Form1.score = Form1.score + 100;
            //                        Form1.coins = Form1.coins + 50;
            //                        fastGList.RemoveAt(j);
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //        for (int j = 0; j < strongGList.Count; j++)
            //        {

            //            Rectangle GoblinRec = new Rectangle(strongGList[j].x, strongGList[j].y, strongGList[j].sizeX, strongGList[j].sizeY);

            //            for (int k = 0; k < bullets.Count; k++)
            //            {
            //                int previousX = bullets[k].x;
            //                if (strongGList[j].x > bullets[k].x)
            //                {
            //                    bullets[k].BMove("Right");
            //                }
            //                if (strongGList[j].x < bullets[k].x)
            //                {
            //                    bullets[k].BMove("Left");
            //                }
            //                if (strongGList[j].y > bullets[k].y)
            //                {
            //                    bullets[k].BMove("Up");
            //                }
            //                if (strongGList[j].y < bullets[k].y)
            //                {
            //                    bullets[k].BMove("Down");
            //                }
            //                if (bullets[k].x == previousX)
            //                {
            //                    bullets.RemoveAt(k);
            //                }
            //            }
            //            foreach (Bullet d in bullets)
            //            {
            //                Rectangle bulletRec = new Rectangle(d.x, d.y, d.size, d.size);
            //                if (bulletRec.IntersectsWith(GoblinRec))
            //                {
            //                    int index = bullets.IndexOf(d);
            //                    bullets.RemoveAt(index);
            //                    strongGList[j].Health = strongGList[j].Health - basicList[i].Damage;
            //                    if (strongGList[j].Health <= 0)
            //                    {
            //                        strongGList[j].pb.Visible = false;
            //                        Form1.score = Form1.score + 200;
            //                        Form1.coins = Form1.coins + 100;
            //                        strongGList.RemoveAt(j);
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
        private void GameScreen_Paint(Object sender,PaintEventArgs e)
        {
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(b.bulletBrush, b.x, b.y, b.size, b.size);
            }
            foreach (Bullet c in bullets)
            {
                e.Graphics.FillRectangle(c.bulletBrush, c.x, c.y, c.size, c.size);
            }
            foreach (Bullet d in bullets)
            {
                e.Graphics.FillRectangle(d.bulletBrush, d.x, d.y, d.size, d.size);
            }

            foreach (Bullet b in bulletsF)
            {
                e.Graphics.FillRectangle(b.bulletBrush, b.x, b.y, b.size, b.size);
            }
            foreach (Bullet c in bulletsF)
            {
                e.Graphics.FillRectangle(c.bulletBrush, c.x, c.y, c.size, c.size);
            }
            foreach (Bullet d in bulletsF)
            {
                e.Graphics.FillRectangle(d.bulletBrush, d.x, d.y, d.size, d.size);
            }
        }
        private void Shoot()
        {
            for (int i =0; i< basicList.Count;i++)
            {
                for (int j = 0; j < basicGList.Count; j++)
                {
                    var temp1 = Math.Pow((basicList[i].x - basicGList[j].x), 2);
                    var temp2 = Math.Pow((basicList[i].y - basicGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {
                        int x = basicList[i].x;
                        int y = basicList[i].y;
                        Bullet b = new Bullet(x, y, 10);
                        bullets.Add(b);
                    }
                }
                for (int j = 0; j < fastGList.Count; j++)
                {
                    var temp1 = Math.Pow((basicList[i].x - fastGList[j].x), 2);
                    var temp2 = Math.Pow((basicList[i].y - fastGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result< 150)
                    {
                        int x = basicList[i].x;
                        int y = basicList[i].y;
                        Bullet c = new Bullet(x, y, 10);
                        bullets.Add(c);
                    }
                }
                for (int j = 0; j < strongGList.Count; j++)
                {
                    var temp1 = Math.Pow((basicList[i].x - strongGList[j].x), 2);
                    var temp2 = Math.Pow((basicList[i].y - strongGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {
                        int x = basicList[i].x;
                        int y = basicList[i].y;
                        Bullet d = new Bullet(x, y, 10);
                        bullets.Add(d);
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
                    var temp1 = Math.Pow((fastList[i].x - basicGList[j].x), 2);
                    var temp2 = Math.Pow((fastList[i].y - basicGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result <150)
                    {
                        int x = fastList[i].x;
                        int y = fastList[i].y;
                        Bullet b = new Bullet(x, y, 10);
                        bulletsF.Add(b);
                    }
                }               
                for (int j = 0; j < fastGList.Count; j++)
                {
                    var temp1 = Math.Pow((fastList[i].x - fastGList[j].x), 2);
                    var temp2 = Math.Pow((fastList[i].y - fastGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {
                        int x = fastList[i].x;
                        int y = fastList[i].y;
                        Bullet c = new Bullet(x, y, 10);
                        bulletsF.Add(c);
                    }
                }
                for (int j = 0; j < strongGList.Count; j++)
                {
                    var temp1 = Math.Pow((fastList[i].x - strongGList[j].x), 2);
                    var temp2 = Math.Pow((fastList[i].y - strongGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {
                        int x = fastList[i].x;
                        int y = fastList[i].y;
                        Bullet d = new Bullet(x, y, 10);
                        bulletsF.Add(d);
                    }
                }
            }
        }
        private void ShootS()
        {
            for (int i = 0; i < strongList.Count; i++)
            {
                for (int j = 0; j < basicGList.Count; j++)
                {
                    var temp1 = Math.Pow((strongList[i].x - basicGList[j].x), 2);
                    var temp2 = Math.Pow((strongList[i].y - basicGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {
                        basicGList[j].Health = basicGList[j].Health - strongList[i].Damage;
                        if (basicGList[j].Health <= 0)
                        {
                            basicGList[j].pb.Visible = false;
                            Form1.score = Form1.score + 50;
                            Form1.coins = Form1.coins + 25;
                            basicGList.RemoveAt(j);
                        }
                    }
                }
                for (int j = 0; j < fastGList.Count; j++)
                {
                    var temp1 = Math.Pow((strongList[i].x - fastGList[j].x), 2);
                    var temp2 = Math.Pow((strongList[i].y - fastGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {

                        fastGList[j].Health = fastGList[j].Health - strongList[i].Damage;
                        if (fastGList[j].Health <= 0)
                        {
                            fastGList[j].pb.Visible = false;
                            Form1.score = Form1.score + 75;
                            Form1.coins = Form1.coins + 50;
                            fastGList.RemoveAt(j);

                        }
                    }
                }
                for (int j = 0; j < strongGList.Count; j++)
                {
                    var temp1 = Math.Pow((strongList[i].x - strongGList[j].x), 2);
                    var temp2 = Math.Pow((strongList[i].y - strongGList[j].y), 2);
                    var result = Math.Sqrt(temp1 + temp2);
                    if (result < 150)
                    {

                        strongGList[j].Health = strongGList[j].Health - strongList[i].Damage;
                        if (strongGList[j].Health <= 0)
                        {
                            strongGList[j].pb.Visible = false;
                            Form1.score = Form1.score + 200;
                            Form1.coins = Form1.coins + 100;
                            strongGList.RemoveAt(j);

                        }
                    }
                }
            }
        }
        private void CheckHit()
        {
           for (int i=0;i<basicGList.Count; i++)
            {
                if(basicGList[i].x >785)
                {
                    Form1.HP = Form1.HP - basicGList[i].Damage/5;
                    basicGList[i].pb.Visible = false;
                    basicGList.RemoveAt(i);
                    progressBar1.Value = Form1.HP;
                }
            }
            for (int i = 0; i < fastGList.Count; i++)
            {
                if (fastGList[i].x > 785)
                {
                    Form1.HP = Form1.HP - fastGList[i].Damage/5;
                    fastGList[i].pb.Visible = false;
                    fastGList.RemoveAt(i);
                    progressBar1.Value = Form1.HP;
                }
            }
            for (int i = 0; i < strongGList.Count; i++)
            {
                if (strongGList[i].x > 785)
                {
                    Form1.HP = Form1.HP - strongGList[i].Damage/5;
                    strongGList[i].pb.Visible = false;
                    strongGList.RemoveAt(i);
                    progressBar1.Value = Form1.HP;
                }
            }

            if (Form1.HP <=0)
            {
                timer1.Enabled = false;
                Form1.Scores = File.ReadAllLines("Scores.txt").ToList();
                Form1.Scores.Add(Form1.userName +": "+ Convert.ToString(Form1.score));

                foreach (string score in Form1.Scores)
                {
                    File.WriteAllLines("Scores.txt", Form1.Scores);
                }

                Form f = this.FindForm();
                f.Controls.Remove(this);
                EndScreenB esb = new EndScreenB();
                f.Controls.Add(esb);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.coins >= 50 && Form1.HP <100)
            {
                Form1.coins = Form1.coins - 50;
                Form1.HP = Form1.HP + 20;
                if (Form1.HP >100)
                {
                    Form1.HP = 100;
                }
                progressBar1.Value = Form1.HP;
            }
        }
    }
}
