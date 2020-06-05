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
        int Health, Damage, Speed, x, y;
        public Goblin(int _Health, int _Damage, int _Speed, int _x, int _y )
        {
            Health = _Health;
            Damage = _Damage;
            Speed = _Speed;
            x = _x;
            y = _y;

        }
        public void Move (string direction)
        {
            if (direction == "left")
            {
                x = x + Speed;
            }
            if (direction=="right")
            {
                x = x - Speed;
            }
            if (direction == "up")
            {
                y = y + Speed;
            }
            if (direction == "down")
            {
                y = y - Speed;
            }

        }
    }
}
