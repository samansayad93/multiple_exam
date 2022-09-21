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
    public partial class FrmQuestion : Form
    {
        readonly SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");

        int questionID = 0;

        public FrmQuestion()
        {
            InitializeComponent();
        }

        public void FillGrd()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SelectAllQuestionByGroupID", con);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            da2.SelectCommand.Parameters.AddWithValue("@groupid", cmbGroup.SelectedValue);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            GrdQuestion.DataSource = dt2;
        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbGroup.DataSource = dt;
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.ValueMember = "GroupID";
            cmbAnswer.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbGroup.Text))
                errorProvider1.SetError(cmbGroup, "گروه امتحانی باید مشخص گردد");

            else if (string.IsNullOrWhiteSpace(txtQuestion.Text))
                errorProvider1.SetError(txtQuestion, "پر کردن سوال امتحانی الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase1.Text))
                errorProvider1.SetError(txtCase1, "پر کردن گزینه 1 الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase2.Text))
                errorProvider1.SetError(txtCase2, "پر کردن گزینه 2 الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase3.Text))
                errorProvider1.SetError(txtCase3, "پر کردن گزینه 3 الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase4.Text))
                errorProvider1.SetError(txtCase4, "پر کردن گزینه 4 الزامی است");
            else
            {
                SqlCommand cmd = new SqlCommand("AddQuestion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupid", cmbGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@questiontext", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@case1", txtCase1.Text);
                cmd.Parameters.AddWithValue("@case2", txtCase2.Text);
                cmd.Parameters.AddWithValue("@case3", txtCase3.Text);
                cmd.Parameters.AddWithValue("@case4", txtCase4.Text);
                cmd.Parameters.AddWithValue("@answer", cmbAnswer.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("سوال مورد نظر با موفقیت اضافه گردید");
                FillGrd();
                errorProvider1.SetError(txtQuestion, "");
                errorProvider1.SetError(txtCase1, "");
                errorProvider1.SetError(txtCase2, "");
                errorProvider1.SetError(txtCase3, "");
                errorProvider1.SetError(txtCase4, "");
                txtQuestion.ResetText();
                txtCase1.ResetText();
                txtCase2.ResetText();
                txtCase3.ResetText();
                txtCase4.ResetText();
                cmbAnswer.ResetText();
                txtQuestion.Focus();
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllQuestionByGroupID", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@groupid", ((DataRowView)cmbGroup.SelectedItem)["GroupID"]);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GrdQuestion.DataSource = dt;
        }

        private void GrdQuestion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            txtQuestion.Text = GrdQuestion.CurrentRow.Cells["questiontext"].Value.ToString();
            txtCase1.Text = GrdQuestion.CurrentRow.Cells["case1"].Value.ToString();
            txtCase2.Text = GrdQuestion.CurrentRow.Cells["case2"].Value.ToString();
            txtCase3.Text = GrdQuestion.CurrentRow.Cells["case3"].Value.ToString();
            txtCase4.Text = GrdQuestion.CurrentRow.Cells["case4"].Value.ToString();
            cmbAnswer.SelectedIndex = Convert.ToInt32(GrdQuestion.CurrentRow.Cells["answer"].Value) - 1;
            questionID = Convert.ToInt32(GrdQuestion.CurrentRow.Cells["questionid"].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeleteQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@questionid", questionID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("سوال موردنظر با موفقیت پاک شد");
            FillGrd();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtQuestion.ResetText();
            txtCase1.ResetText();
            txtCase2.ResetText();
            txtCase3.ResetText();
            txtCase4.ResetText();
            txtQuestion.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbGroup.Text))
                errorProvider1.SetError(cmbGroup, "گروه امتحانی باید مشخص گردد");

            else if (string.IsNullOrWhiteSpace(txtQuestion.Text))
                errorProvider1.SetError(txtQuestion, "پر کردن سوال امتحانی الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase1.Text))
                errorProvider1.SetError(txtCase1, "پر کردن گزینه 1 الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase2.Text))
                errorProvider1.SetError(txtCase2, "پر کردن گزینه 2 الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase3.Text))
                errorProvider1.SetError(txtCase3, "پر کردن گزینه 3 الزامی است");

            else if (string.IsNullOrWhiteSpace(txtCase4.Text))
                errorProvider1.SetError(txtCase4, "پر کردن گزینه 4 الزامی است");
            else
            {
                SqlCommand cmd = new SqlCommand("EditQuestion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@questionid", questionID);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupid", cmbGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@questiontext", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@case1", txtCase1.Text);
                cmd.Parameters.AddWithValue("@case2", txtCase2.Text);
                cmd.Parameters.AddWithValue("@case3", txtCase3.Text);
                cmd.Parameters.AddWithValue("@case4", txtCase4.Text);
                cmd.Parameters.AddWithValue("@answer", cmbAnswer.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("سوال مورد نظر با موفقیت ویرایش گردید");
                FillGrd();
                errorProvider1.SetError(txtQuestion, "");
                errorProvider1.SetError(txtCase1, "");
                errorProvider1.SetError(txtCase2, "");
                errorProvider1.SetError(txtCase3, "");
                errorProvider1.SetError(txtCase4, "");
                txtQuestion.ResetText();
                txtCase1.ResetText();
                txtCase2.ResetText();
                txtCase3.ResetText();
                txtCase4.ResetText();
                txtQuestion.Focus();
            }
        }
    }
}
