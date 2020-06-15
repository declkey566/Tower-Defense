using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tower_Defense
{
    public class Tower
    {
        public  int ShotSpeed, Damage, x, y, SizeX, SizeY;
        public PictureBox pb = new PictureBox();
        string Type;
        public Tower(int _ShotSpeed, int _Damage, int _x, int _y, int _SizeX, int _SizeY, string _Type)
        {
            ShotSpeed = _ShotSpeed;
            Damage = _Damage;
            x = _x;
            y = _y;
            SizeX = _SizeX;
            SizeY = _SizeY;
            Type = _Type;

            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(SizeX, SizeY);
            pb.BackColor = Color.Transparent;
            if (Type == "basic")
            {
                pb.Image = Properties.Resources.basic;
            }
            if (Type == "fast")
            {
                pb.Image = Properties.Resources.fast;

            }
            if (Type == "strong")
            {
                pb.Image = Properties.Resources.strong;
            }
            pb.Location = new Point(x, y);
        }

        //public void Shoot()
      //  {
       //     if (Tower.x -Goblin.x <100 && Tower.y -Goblin.y<100)
        //    {
         //       Goblin.Health = Goblin.Health - Damage;
                
         //   }
      //  }

    }
    
}
