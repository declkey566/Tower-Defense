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
    public partial class EndScreenB : UserControl
    {
        public EndScreenB()
        {
            InitializeComponent();
            label2.Text = ("Final Score: " + Convert.ToString(Form1.score));
            foreach(string score in Form1.Scores)
           {
                label4.Text += (score +"\n");
               
           }
        }
    }
}
