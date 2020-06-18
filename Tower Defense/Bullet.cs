using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_Defense
{
   public class Bullet
    {
        public SolidBrush bulletBrush = new SolidBrush(Color.Red);
        public int x, y,size;
        //string direction;
        public Bullet(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
           // direction= "Still";
        }
        public void BMove(string direction)
        {
            if (direction == "Left")
            {
                x = x - 2;
            }
            if (direction == "Right")
            {
                x = x + 2;
            }
            if (direction == "Up")
            {
                y = y + 2;
            }
            if (direction == "Down")
            {
                y = y - 2;
            }
        }
    }
}
