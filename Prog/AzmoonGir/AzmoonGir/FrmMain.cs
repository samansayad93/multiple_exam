using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AzmoonGir
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            LblDate.Text = pc.GetYear(today).ToString("0000/") + pc.GetMonth(today).ToString("00/") + pc.GetDayOfMonth(today).ToString("00");
            string myday = DateTime.Now.DayOfWeek.ToString();
            if (myday == DayOfWeek.Saturday.ToString())
                LblDayWeek.Text = "شنبه";
            else if (myday == DayOfWeek.Sunday.ToString())
                LblDayWeek.Text = "یک شنبه";
            else if (myday == DayOfWeek.Monday.ToString())
                LblDayWeek.Text = "دو شنبه";
            else if (myday == DayOfWeek.Tuesday.ToString())
                LblDayWeek.Text = "سه شنبه";
            else if (myday == DayOfWeek.Wednesday.ToString())
                LblDayWeek.Text = "چهار شنبه";
            else if (myday == DayOfWeek.Thursday.ToString())
                LblDayWeek.Text = "پنج شنبه";
            else if (myday == DayOfWeek.Friday.ToString())
                LblDayWeek.Text = "جمعه";
            timer1.Start();
        }

        private void M00_Click(object sender, EventArgs e)
        {
            FrmGroup fGroup = new FrmGroup();
            fGroup.ShowDialog();
        }

        private void M01_Click(object sender, EventArgs e)
        {
            FrmQuestion fQuestion = new FrmQuestion();
            fQuestion.ShowDialog();
        }

        private void M10_Click(object sender, EventArgs e)
        {
            FrmAdmin fadmin = new FrmAdmin();
            fadmin.ShowDialog();
        }

        private void M11_Click(object sender, EventArgs e)
        {
            FrmUser fuser = new FrmUser();
            fuser.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if(frmLogin.DialogResult != System.Windows.Forms.DialogResult.OK)
                Application.ExitThread();
            //
            //User
            //
            if (FrmLogin.myFlag == 1)
            {
                menuStrip1.Items["M0"].Enabled = false;
                menuStrip1.Items["M1"].Enabled = false;
                menuStrip1.Items["M3"].Enabled = false;
                menuStrip1.Items["M4"].Enabled = false;
            }
            //
            //Admin
            //
            else if (FrmLogin.myFlag == 0)
            {

            }
            
        }

        private void M2_Click(object sender, EventArgs e)
        {
            FrmAzmoon fazmoon = new FrmAzmoon();
            fazmoon.ShowDialog();
        }

        private void M02_Click(object sender, EventArgs e)
        {
            FrmQuestionTime frmQuestionTime = new FrmQuestionTime();
            frmQuestionTime.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            LblTime.Text = today.Hour.ToString("00 :") + today.Minute.ToString(" 00 :") + today.Second.ToString(" 00");

        }

        private void M3_Click(object sender, EventArgs e)
        {
            FrmBackupRestore frmBackupRestore = new FrmBackupRestore();
            frmBackupRestore.ShowDialog();
        }

        private void M40_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.ShowDialog();
        }
    }
}
