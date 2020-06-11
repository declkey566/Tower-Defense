using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_Defense
{
    public partial class Form1 : Form
    {
        public static string userName;
        //int score;
        public  static int coins=100;
        public static int basic = 0;
        public static int fast = 0;
        public static int strong = 0;
        public static int slot;
        public Form1()
        {
            InitializeComponent();
            //Form f = this.FindForm();
            //f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

        }

    }
}
