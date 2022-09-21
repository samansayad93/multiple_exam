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
    public partial class FrmGroup : Form
    {
        readonly SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");

        int IDGroup = 0;

        public FrmGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
            {
                errorTxtGroupName.SetError(txtGroupName, "وارد کردن نام گروه امتحانی الزامی می باشد");
            }
            else {
                SqlCommand cmd = new SqlCommand("AddGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupname", txtGroupName.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("گروه امتحانی با موفقیت اضافه گردید");
                FrmGroup_Load(null, null);
                txtGroupName.ResetText();
                txtGroupName.Focus();
            }
        }

        private void FrmGroup_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GrdGroup.DataSource = dt;
        }

        private void GrdGroup_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            txtGroupName.Text = GrdGroup.CurrentRow.Cells["groupname"].Value.ToString();
            IDGroup = Convert.ToInt32(GrdGroup.CurrentRow.Cells["groupid"].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EditGroup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupid", IDGroup);
            cmd.Parameters.AddWithValue("@groupname", txtGroupName.Text.Trim());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("گروه امتحانی با موفقیت اصلاح گردید");
            FrmGroup_Load(null, null);
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            txtGroupName.ResetText();
            txtGroupName.Focus();
        }
    }
}
