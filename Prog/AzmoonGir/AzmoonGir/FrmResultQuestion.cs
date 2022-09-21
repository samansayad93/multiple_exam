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
    public partial class FrmResultQuestion : Form
    {
        public FrmResultQuestion()
        {
            InitializeComponent();
        }

        private void FrmResultQuestion_Load(object sender, EventArgs e)
        {
            LblCorrect.Text = FrmAzmoon.sahih.ToString();
            LblFalse.Text = FrmAzmoon.ghalat.ToString();
            LblNon.Text = FrmAzmoon.bipasokh.ToString();
            LblResult.Text = (((FrmAzmoon.sahih*300)-(FrmAzmoon.ghalat*100))/((FrmAzmoon.sahih+FrmAzmoon.ghalat+FrmAzmoon.bipasokh)*3)).ToString();
            FrmAzmoon.sahih = 0;
            FrmAzmoon.ghalat = 0;
            FrmAzmoon.bipasokh = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            FrmAzmoon obj = (FrmAzmoon)Application.OpenForms["FrmAzmoon"];
            obj.Close();
        }
    }
}
