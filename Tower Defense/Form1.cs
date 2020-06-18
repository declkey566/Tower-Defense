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
        public static int score =0;
        public  static int coins=100;
        public static int basic = 0;
        public static int fast = 0;
        public static int strong = 0;
        public static int slot;
        public static int GamePlayed = 0;
        public static int Oldbasic = 0;
        public static int Oldfast = 0;
        public static int Oldstrong = 0;
        public static int Level = 0;
        public static int HP = 100;
       public static List<string> Scores = new List<string>();

        public Form1()
        {
            InitializeComponent();

            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

        }

    }
}
