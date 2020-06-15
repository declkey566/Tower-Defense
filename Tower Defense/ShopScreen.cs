using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_Defense
{
    public partial class ShopScreen : UserControl
    {
        int cost = 0;

        public ShopScreen()
        {
            
            InitializeComponent();
            int newX = label1.Location.X - pictureBox1.Location.X;
            int newY = label1.Location.Y - pictureBox1.Location.Y;
            int newX2 = label2.Location.X - pictureBox4.Location.X;        
            int newY2 = label2.Location.Y - pictureBox4.Location.Y;
            int newX3 = label3.Location.X - pictureBox2.Location.X;
            int newY3 = label3.Location.Y - pictureBox2.Location.Y;
            int newX4 = label4.Location.X - pictureBox2.Location.X;
            int newY4 = label4.Location.Y - pictureBox2.Location.Y;
            int newX5 = label5.Location.X - pictureBox2.Location.X;
            int newY5 = label5.Location.Y - pictureBox2.Location.Y;
            int newX6 = pictureBox3.Location.X - pictureBox2.Location.X;
            int newY6 = pictureBox3.Location.Y - pictureBox2.Location.Y;
            int newX7 = label7.Location.X - pictureBox2.Location.X;
            int newY7 = label7.Location.Y - pictureBox2.Location.Y;
            int newX8 = label8.Location.X - pictureBox2.Location.X;
            int newY8 = label8.Location.Y - pictureBox2.Location.Y;
            int newX9 = label6.Location.X - pictureBox2.Location.X;
            int newY9 = label6.Location.Y - pictureBox2.Location.Y;
            int newX10 = pictureBox5.Location.X - pictureBox2.Location.X;
            int newY10 = pictureBox5.Location.Y - pictureBox2.Location.Y;
            int newX11 = pictureBox6.Location.X - pictureBox2.Location.X;
            int newY11 = pictureBox6.Location.Y - pictureBox2.Location.Y;
            int newX12 = pictureBox7.Location.X - pictureBox2.Location.X;
            int newY12 = pictureBox7.Location.Y - pictureBox2.Location.Y;
            int newX16 = label12.Location.X - pictureBox2.Location.X;
            int newY16 = label12.Location.Y - pictureBox2.Location.Y;
            int newX17 = label13.Location.X - pictureBox2.Location.X;
            int newY17 = label13.Location.Y - pictureBox2.Location.Y;


            if (Form1.GamePlayed == 0)
            {
                pictureBox3.Location = new Point(newX6, newY6);
                pictureBox3.Parent = pictureBox2;
                label1.Location = new Point(newX, newY);
                label1.Parent = pictureBox1;
                label2.Location = new Point(newX2, newY2);
                label2.Parent = pictureBox4;
                label3.Location = new Point(newX3, newY3);
                label3.Parent = pictureBox2;
                label4.Location = new Point(newX4, newY4);
                label4.Parent = pictureBox2;
                label5.Location = new Point(newX5, newY5);
                label5.Parent = pictureBox2;
                label7.Location = new Point(newX7, newY7);
                label7.Parent = pictureBox2;
                label8.Location = new Point(newX8, newY8);
                label8.Parent = pictureBox2;
                label6.Location = new Point(newX9, newY9);
                label6.Parent = pictureBox2;
                pictureBox5.Location = new Point(newX10, newY10);
                pictureBox5.Parent = pictureBox2;
                pictureBox6.Location = new Point(newX11, newY11);
                pictureBox6.Parent = pictureBox2;
                pictureBox7.Location = new Point(newX12, newY12);
                pictureBox7.Parent = pictureBox2;



                label12.Location = new Point(newX16, newY16);
                label12.Parent = pictureBox2;
                label13.Location = new Point(newX17, newY17);
                label13.Parent = pictureBox2;



                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                button1.Visible = false;
                pictureBox5.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
            }

            if (Form1.GamePlayed ==1)
            {
                pictureBox3.Location = new Point(newX6, newY6);
                pictureBox3.Parent = pictureBox2;
                label1.Location = new Point(newX, newY);
                label1.Parent = pictureBox1;
                label2.Location = new Point(newX2, newY2);
                label2.Parent = pictureBox4;
                label3.Location = new Point(newX3, newY3);
                label3.Parent = pictureBox2;
                label4.Location = new Point(newX4, newY4);
                label4.Parent = pictureBox2;
                label5.Location = new Point(newX5, newY5);
                label5.Parent = pictureBox2;
                label7.Location = new Point(newX7, newY7);
                label7.Parent = pictureBox2;
                label8.Location = new Point(newX8, newY8);
                label8.Parent = pictureBox2;
                label6.Location = new Point(newX9, newY9);
                label6.Parent = pictureBox2;
                pictureBox5.Location = new Point(newX10, newY10);
                pictureBox5.Parent = pictureBox2;
                pictureBox6.Location = new Point(newX11, newY11);
                pictureBox6.Parent = pictureBox2;
                pictureBox7.Location = new Point(newX12, newY12);
                pictureBox7.Parent = pictureBox2;



                label12.Location = new Point(newX16, newY16);
                label12.Parent = pictureBox2;
                label13.Location = new Point(newX17, newY17);
                label13.Parent = pictureBox2; 

                pictureBox3.Visible = false;
                label2.Visible = false;
                pictureBox4.Visible = false;
                button2.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                button1.Visible = true;
                pictureBox5.Visible = true;
                label12.Text = "Your Coins:" + Convert.ToString(Form1.coins);
                label13.Text = "Your Total:" + Convert.ToString(cost);
                label12.Visible = true;
                label13.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button2.Visible = false;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            button1.Visible = true;
            pictureBox5.Visible = true;
            label12.Text = "Your Coins:" + Convert.ToString(Form1.coins);
            label13.Text = "Your Total:" + Convert.ToString(cost);
            label12.Visible = true;
            label13.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cost = cost + 50;
            label13.Text = "Your Total:" + Convert.ToString(cost);
            Form1.basic = Form1.basic + 1;
            label9.Text = "Basic:" + Convert.ToString(Form1.basic);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cost = cost + 100;
            label13.Text = "Your Total:" + Convert.ToString(cost);
            Form1.fast = Form1.fast + 1;
            label10.Text = "Fast:" + Convert.ToString(Form1.fast);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cost = cost + 150;
            label13.Text = "Your Total:" + Convert.ToString(cost);
            Form1.strong = Form1.strong + 1;
            label11.Text = "Strong:" + Convert.ToString(Form1.strong);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (cost != 0 && Form1.basic >0)
            {
                cost = cost - 50;
                label13.Text = "Your Total:" + Convert.ToString(cost);
                Form1.basic = Form1.basic - 1;
                label9.Text = "Basic:" + Convert.ToString(Form1.basic);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (cost != 0 && Form1.fast > 0)
            {
                cost = cost - 100;
                label13.Text = "Your Total:" + Convert.ToString(cost);
                Form1.fast = Form1.fast - 1;
                label10.Text = "Fast:" + Convert.ToString(Form1.fast);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (cost != 0 && Form1.strong > 0)
            {
                cost = cost - 150;
                label13.Text = "Your Total:" + Convert.ToString(cost);
                Form1.strong = Form1.strong - 1;
                label11.Text = "Strong:" + Convert.ToString(Form1.strong);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cost > Form1.coins)
            {
                MessageBox.Show("You do not have enough to purchase these towers! please remove some by clicking the 'X' and try again.");
            }
            if (cost <= Form1.coins)
            {
                //change to game screen
                Form1.coins = Form1.coins - cost;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
            }
        }
    }
}
