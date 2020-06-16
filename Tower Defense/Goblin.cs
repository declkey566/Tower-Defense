using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tower_Defense
{
    public class Goblin
    {
        //public SolidBrush basicBrush = new SolidBrush(Color.Black);
        public int Health,Damage, Speed, x, y, sizeX, sizeY;
      //  int Health;
        string direction;
        string Type;

        public PictureBox pb = new PictureBox();
        public Goblin(int _Health, int _Damage, int _Speed, int _x, int _y, int _sizeX, int _sizeY, string _Type )
        {
            Health = _Health;
            Damage = _Damage;
            Speed = _Speed;
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            Type = _Type;

            direction= "down";

            if (Type == "boss")
            {
                pb.Image = Properties.Resources.ogre;
            }
            if (Type == "basic")
            {
                pb.Image = Properties.Resources.goblin;
            }
            if (Type == "fast")
            {
                pb.Image = Properties.Resources.goblin;
            }

            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(sizeX, sizeY);
            pb.BackColor = Color.Transparent;
            //pb.Image = Properties.Resources.goblin;
            pb.Location = new Point(x, y);
        }
        public void Move()
        {
            if (direction == "left")
            {
                x -= Speed;
            }
            if (direction == "right")
            {
                x += Speed;
            }
            if (direction == "up")
            {
                y -= Speed;
            }
            if (direction == "down")
            {
                y += Speed;
            }

            if (x == 214 && y == 150)
            {
                direction = "left";
            }

            if (x == 90 && y == 150)
            {
                direction = "down";
            }

            if (x == 90 && y == 442)
            {
                direction = "right";
            }

            if (x == 386 && y == 442)
            {
                direction = "up";
            }

            if (x == 386 && y == 78)
            {
                direction = "right";
            }

            if (x == 590 && y == 78)
            {
                direction = "down";
            }

            if (x == 590 && y == 442)
            {
                direction = "right";
            }

            pb.Location = new Point(x, y);


        }
    }
}
