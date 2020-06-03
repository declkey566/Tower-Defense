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
        int score;
        int coins;
        public Form1()
        {
            InitializeComponent();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

        }

    }
}
