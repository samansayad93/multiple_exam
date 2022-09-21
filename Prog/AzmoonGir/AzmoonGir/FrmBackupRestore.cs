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
using System.IO;

namespace AzmoonGir
{
    public partial class FrmBackupRestore : Form
    {
        public FrmBackupRestore()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            bool bBackupStatus = true;
            Cursor.Current = Cursors.WaitCursor;
            if (Directory.Exists(@"D:\project\SQLBackUpAzmoon"))
            {
                if (File.Exists(@"D:\project\SQLBackUpAzmoon\backup.bak"))
                {
                    if (MessageBox.Show(@"آیا می خواهید پشتیبان جدیدتری بگیرید", "پشتیبان گرفته شده است", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        File.Delete(@"D:\project\SQLBackUpAzmoon\backup.bak");
                    else
                        bBackupStatus = false;
                }   
            }
            else
            {
                Directory.CreateDirectory(@"D:\project\SQLBackUpAzmoon");
            }
            if (bBackupStatus == true)
            {
                SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");
                con.Open();
                SqlCommand command = new SqlCommand(@"Backup DataBase DBAzmoon to disk = 'D:\project\SQLBackUpAzmoon\backup.bak' with init ,stats = 10", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("پشتیبان گیری با موفقیت انجام شد", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (File.Exists(@"D:\project\SQLBackUpAzmoon\backup.bak"))
                {
                    if (MessageBox.Show("آیا مایل به بازگردانی هستید", "بازگردانی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("server= DESKTOP-C4DNQ9C; Database= DBAzmoon; Integrated security=true");
                        con.Open();
                        SqlCommand command = new SqlCommand("use master", con);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(@"Restore DataBase DBAzmoon from disk = 'D:\project\SQLBackUpAzmoon\backup.bak'", con);
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("باز گردانی اطلاعات با موفقیت انجام شد", "بازگردانی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("فایل بازگردانی پیدا نشد", "بازگردانی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
