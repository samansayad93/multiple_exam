using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmoonGir
{
    public partial class SplashScreen : Form
    {
        string sentence = "به سامانه آزمونگیر خوش آمدید\n"+"برنامه نویس: سامان صیاد\n";
        int mytime = 0;

        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mytime++;
            LblSentence.Text = sentence.Substring(0, mytime);
            if(mytime == sentence.Length)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
