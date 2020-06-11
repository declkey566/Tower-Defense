using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_Defense
{
    public class Goblin
    {
        //public SolidBrush basicBrush = new SolidBrush(Color.Black);
        public static int Health, Damage, Speed, x, y;
        string direction;
        public Goblin(int _Health, int _Damage, int _Speed, int _x, int _y )
        {
            Health = _Health;
            Damage = _Damage;
            Speed = _Speed;
            x = _x;
            y = _y;
            direction= "down";

        }
        public void Move ()
        {
            if (direction == "left")
            {
                x -= Speed;
            }
            if (direction=="right")
            {
                x +=Speed;
            }
            if (direction == "up")
            {
                y -=Speed;
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

            if (x == 90 && y == 440)
            {
                direction = "right";
            }

            if (x == 385 && y == 440)
            {
                direction = "up";
            }

            if (x == 385 && y == 75)
            {
                direction = "right";
            }

            if (x == 590 && y == 75)
            {
                direction = "down";
            }

            if (x == 590 && y == 440)
            {
                direction = "right";
            }


        }
    }
}
