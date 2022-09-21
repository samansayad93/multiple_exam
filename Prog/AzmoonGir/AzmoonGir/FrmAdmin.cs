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
    public partial class FrmAdmin : Form
    {
        readonly SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");

        public FrmAdmin()
        {
            InitializeComponent();
        }

        public void GrdView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllAdmin", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GrdAdmin.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsername.Text))
                errorProvider1.SetError(TxtUsername, "نام کاربری نمی تواند خالی باشد");
            else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                errorProvider1.SetError(TxtPassword, "رمز عبور نمی تواند خالی باشد");
            else if (string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
                errorProvider1.SetError(TxtConfirmPassword, "تکرار رمز عبور نمی تواند خالی باشد");
            else if (TxtPassword.Text.Trim() != TxtConfirmPassword.Text.Trim())
                errorProvider1.SetError(TxtConfirmPassword, "رمز عبور وارد سده با تکرار شده یکسان نمی باشد");
            else
            {
                SqlCommand cmd = new SqlCommand("AddAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username",TxtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
                cmd.Parameters.Add("@result",SqlDbType.Int);
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                if (res == 1)
                    MessageBox.Show("نام کاربری تکراری است");
                else
                {
                    MessageBox.Show("مدیر جدید با موفقیت اضافه گردید");
                    GrdView();
                    errorProvider1.SetError(TxtUsername, "");
                    errorProvider1.SetError(TxtPassword, "");
                    errorProvider1.SetError(TxtConfirmPassword, "");
                    TxtUsername.ResetText();
                    TxtPassword.ResetText();
                    TxtConfirmPassword.ResetText();
                    TxtUsername.Focus();
                }
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            GrdView();
        }

        private void GrdAdmin_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtUsername.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            TxtUsername.Text = GrdAdmin.CurrentRow.Cells["username"].Value.ToString();
            TxtPassword.Text = GrdAdmin.CurrentRow.Cells["password"].Value.ToString();
            TxtUsername.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeleteAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("مدیر مورد نظر با موفقیت حذف گردید");
            GrdView();
            TxtUsername.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            BtnDelete.Enabled=false;
            TxtUsername.ResetText();
            TxtPassword.ResetText();
            TxtUsername.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                errorProvider1.SetError(TxtPassword, "رمز عبور نمی تواند خالی باشد");
            else if (string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
                errorProvider1.SetError(TxtConfirmPassword, "تکرار رمز عبور نمی تواند خالی باشد");
            else if (TxtPassword.Text.Trim() != TxtConfirmPassword.Text.Trim())
                errorProvider1.SetError(TxtConfirmPassword, "رمز عبور وارد سده با تکرار شده یکسان نمی باشد");
            else
            {
                SqlCommand cmd = new SqlCommand("EditAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@password", TxtPassword.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کلمه عبور مدیر مورد نظر تغییر کرد");
                GrdView();
                TxtUsername.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                errorProvider1.SetError(TxtPassword, "");
                errorProvider1.SetError(TxtConfirmPassword, "");
                TxtUsername.ResetText();
                TxtPassword.ResetText();
                TxtConfirmPassword.ResetText();
                TxtUsername.Focus();
            }
        }
    }
}
