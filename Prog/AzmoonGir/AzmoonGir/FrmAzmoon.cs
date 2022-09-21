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
    public partial class FrmAzmoon : Form
    {
        readonly SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");
        DataTable dt;
        //int num = 0;
        int Time = 0;
        int k = 0;
        ListBox Mylistanswer;
        public static int sahih, ghalat, bipasokh;

        public FrmAzmoon()
        {
            InitializeComponent();
        }

        public void UncheckRadioButton()
        {
            foreach(Control ctrl in this.groupBox2.Controls)
            {
                if(object.ReferenceEquals(ctrl.GetType(), typeof(RadioButton)))
                {
                    ((RadioButton)ctrl).Checked = false;
                }
            }
        }

        private void FrmAzmoon_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbGroup.DataSource = dt;
            CmbGroup.DisplayMember = "GroupName";
            CmbGroup.ValueMember = "GroupID";
            UncheckRadioButton();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            UncheckRadioButton();

            if (string.IsNullOrWhiteSpace(TxtQuestionNumber.Text))
                errorProvider1.SetError(TxtQuestionNumber, "لطفا تعداد سوالات را وارد کنید");
            else
            {
                SqlCommand cmd = new SqlCommand("CheckQuestionNumber", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@questionnumber", TxtQuestionNumber.Text);
                cmd.Parameters.AddWithValue("@groupid", CmbGroup.SelectedValue);
                cmd.Parameters.Add("@result", SqlDbType.Int);
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                if (res == 0)
                    MessageBox.Show("تعداد سوالات درخواستی از تعداد سوالات بانک اطلاعاتی بیشتر است");
                else if(res == 1)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);
                    /*
                    ListBox MyResult = new ListBox();
                    while (MyResult.Items.Count < Convert.ToInt32(TxtQuestionNumber.Text.Trim()))
                    {
                        Random rand = new Random();
                        num = rand.Next(Convert.ToInt32(dt.Rows[0][0].ToString()),Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString()));
                        for ( int i=0 ; i < dt.Rows.Count ; i++)
                        {
                            if (num == Convert.ToInt32(dt.Rows[i][0].ToString()))
                            {
                                if (MyResult.Items.Count == 0)
                                    MyResult.Items.Add(num);
                                else
                                {
                                    for (int j = 0; j < MyResult.Items.Count; j++)
                                    {
                                        if (num == Convert.ToInt32(MyResult.Items[j]))
                                            j = MyResult.Items.Count;
                                        else
                                        {
                                            if (j == MyResult.Items.Count - 1)
                                                MyResult.Items.Add(num);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    string s = "";
                    for (int i = 0; i < MyResult.Items.Count; i++)
                    {
                        s += MyResult.Items[i].ToString() + ",";
                    }

                    s = s.Remove(s.Length - 1, 1);

                    da = new SqlDataAdapter("SelectFilterQuestion", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@listquestionnumber", s);
                    dt = new DataTable();
                    da.Fill(dt);
                    */
                    BtnNext.Enabled = true;
                    BtnPrev.Enabled = true;
                    if (ChkTime.Checked == true)
                    {
                        LblTotalTime.Visible = true;
                        timer1.Enabled = true;
                        LblTotalTime.Text = (Properties.Settings.Default.QuestionTime * dt.Rows.Count).ToString();
                    }
                    k = 0;
                    LblQuestion.Text = dt.Rows[0]["QuestionText"].ToString();
                    RdbCase1.Text = dt.Rows[0]["Case1"].ToString();
                    RdbCase2.Text = dt.Rows[0]["Case2"].ToString();
                    RdbCase3.Text = dt.Rows[0]["Case3"].ToString();
                    RdbCase4.Text = dt.Rows[0]["Case4"].ToString();
                    Mylistanswer = new ListBox();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Mylistanswer.Items.Add(0);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time = Convert.ToInt32(LblTotalTime.Text);
            Time--;
            LblTotalTime.Text = Time.ToString();

            if (Time < 20)
                this.LblTotalTime.ForeColor = Color.IndianRed;

            if (Time == 0)
            {
                timer1.Enabled = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(Mylistanswer.Items[i]) == Convert.ToInt32(dt.Rows[i]["Answer"].ToString()))
                        sahih++;
                    else if (Convert.ToInt32(Mylistanswer.Items[i]) == 0)
                        bipasokh++;
                    else if (Convert.ToInt32(Mylistanswer.Items[i]) != Convert.ToInt32(dt.Rows[i]["Answer"].ToString()))
                        ghalat++;
                }
                MessageBox.Show("وقت شما به پایان رسید");
                FrmResultQuestion fresult = new FrmResultQuestion();
                fresult.ShowDialog();

            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!RdbCase1.Checked && !RdbCase2.Checked && !RdbCase3.Checked && !RdbCase4.Checked)
                Mylistanswer.Items[k] = 0;
            else if (RdbCase1.Checked)
                Mylistanswer.Items[k] = 1;
            else if (RdbCase2.Checked)
                Mylistanswer.Items[k] = 2;
            else if (RdbCase3.Checked)
                Mylistanswer.Items[k] = 3;
            else if (RdbCase4.Checked)
                Mylistanswer.Items[k] = 4;
            if (k == dt.Rows.Count - 1)
            {
                BtnNext.Enabled = false;
            }
            else
            {
                UncheckRadioButton();
                k++;
                LblQuestion.Text = dt.Rows[k]["QuestionText"].ToString();
                RdbCase1.Text = dt.Rows[k]["Case1"].ToString();
                RdbCase2.Text = dt.Rows[k]["Case2"].ToString();
                RdbCase3.Text = dt.Rows[k]["Case3"].ToString();
                RdbCase4.Text = dt.Rows[k]["Case4"].ToString();
            }
        }

        private void LblRemoveChoice_Click(object sender, EventArgs e)
        {
            UncheckRadioButton();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            if (!RdbCase1.Checked && !RdbCase2.Checked && !RdbCase3.Checked && !RdbCase4.Checked)
                Mylistanswer.Items[k] = 0;
            else if (RdbCase1.Checked)
                Mylistanswer.Items[k] = 1;
            else if (RdbCase2.Checked)
                Mylistanswer.Items[k] = 2;
            else if (RdbCase3.Checked)
                Mylistanswer.Items[k] = 3;
            else if (RdbCase4.Checked)
                Mylistanswer.Items[k] = 4;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(Mylistanswer.Items[i]) == Convert.ToInt32(dt.Rows[i]["Answer"].ToString()))
                    sahih++;
                else if (Convert.ToInt32(Mylistanswer.Items[i]) == 0)
                    bipasokh++;
                else if (Convert.ToInt32(Mylistanswer.Items[i]) != Convert.ToInt32(dt.Rows[i]["Answer"].ToString()))
                    ghalat++;
            }
            timer1.Stop();
            MessageBox.Show("شما به آزمون خود پایان دادید");
            FrmResultQuestion freult = new FrmResultQuestion();
            freult.ShowDialog();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
                LblQuestion.Text = dt.Rows[k]["QuestionText"].ToString();
                RdbCase1.Text = dt.Rows[k]["Case1"].ToString();
                RdbCase2.Text = dt.Rows[k]["Case2"].ToString();
                RdbCase3.Text = dt.Rows[k]["Case3"].ToString();
                RdbCase4.Text = dt.Rows[k]["Case4"].ToString();
            }
            if (k == 0)
            {
                BtnPrev.Enabled = false;
            }
        }
    }
}
