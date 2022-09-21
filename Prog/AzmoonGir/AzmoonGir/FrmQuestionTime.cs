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
    public partial class FrmQuestionTime : Form
    {
        public FrmQuestionTime()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtQuestionTime.Text))
                errorProvider1.SetError(TxtQuestionTime, "لطفا زمان هر سوال را وارد کنید");
            else
            {
                Properties.Settings.Default.QuestionTime = Convert.ToInt32(TxtQuestionTime.Text.Trim());
                Properties.Settings.Default.Save();
                MessageBox.Show("زمان جدید برای پاسخ کویی به هر سوال ثبت گردید");
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
