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
  
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {

 
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nameBox.Text = Form1.userName;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ShopScreen ss = new ShopScreen();
            this.Controls.Add(ss);
        }
    }
}
