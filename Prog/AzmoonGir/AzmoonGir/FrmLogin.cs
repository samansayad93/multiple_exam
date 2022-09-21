using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AzmoonGir
{
    public partial class FrmLogin : Form
    {
        readonly SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");

        public static int myFlag = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (RdbUser.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(TxtUsername.Text))
                    errorProvider1.SetError(TxtUsername, "نام کاربری نمی تواند خالی باشد");
                else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                    errorProvider1.SetError(TxtPassword, "رمز عبور نمی تواند خالی باشد");
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchForLoginUser", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());
                    da.SelectCommand.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                        TxtUsername.Focus();
                        errorProvider1.SetError(TxtUsername, "");
                        errorProvider1.SetError(TxtPassword, "");
                    }
                    else
                    {
                        myFlag = 1;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else if (RdbAmin.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(TxtUsername.Text))
                    errorProvider1.SetError(TxtUsername, "نام کاربری نمی تواند خالی باشد");
                else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                    errorProvider1.SetError(TxtPassword, "رمز عبور نمی تواند خالی باشد");
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchForLoginAdmin", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());
                    da.SelectCommand.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                        TxtUsername.Focus();
                        errorProvider1.SetError(TxtUsername, "");
                        errorProvider1.SetError(TxtPassword, "");
                    }
                    else
                    {
                        myFlag = 0;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
