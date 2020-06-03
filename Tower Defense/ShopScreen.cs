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
        public ShopScreen()
        {
            InitializeComponent();
            int newX = label1.Location.X - pictureBox1.Location.X;

            int newY = label1.Location.Y - pictureBox1.Location.Y;



            label1.Location = new Point(newX, newY);
            label1.Parent = pictureBox1;
        }
    }
}
