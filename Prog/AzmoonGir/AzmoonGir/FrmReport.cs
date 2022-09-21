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
    public partial class FrmReport : Form
    {
        SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbGroup.DataSource = dt;
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.ValueMember = "GroupID";
            cmbGroup.Enabled = false;
        }

        private void rdbAllQuestion_CheckedChanged(object sender, EventArgs e)
        {
            cmbGroup.Enabled = false;
        }

        private void rdbOneGroupQustion_CheckedChanged(object sender, EventArgs e)
        {
            cmbGroup.Enabled = true;
        }
    }
}
