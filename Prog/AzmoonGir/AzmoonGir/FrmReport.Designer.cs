namespace AzmoonGir
{
    partial class FrmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAllQuestion = new System.Windows.Forms.RadioButton();
            this.rdbOneGroupQustion = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.rdbOneGroupQustion);
            this.groupBox1.Controls.Add(this.rdbAllQuestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbAllQuestion
            // 
            this.rdbAllQuestion.AutoSize = true;
            this.rdbAllQuestion.Checked = true;
            this.rdbAllQuestion.Location = new System.Drawing.Point(342, 38);
            this.rdbAllQuestion.Name = "rdbAllQuestion";
            this.rdbAllQuestion.Size = new System.Drawing.Size(194, 17);
            this.rdbAllQuestion.TabIndex = 0;
            this.rdbAllQuestion.TabStop = true;
            this.rdbAllQuestion.Text = "گزارش تمامی سوالات بانک اطلاعاتی";
            this.rdbAllQuestion.UseVisualStyleBackColor = true;
            this.rdbAllQuestion.CheckedChanged += new System.EventHandler(this.rdbAllQuestion_CheckedChanged);
            // 
            // rdbOneGroupQustion
            // 
            this.rdbOneGroupQustion.AutoSize = true;
            this.rdbOneGroupQustion.Location = new System.Drawing.Point(454, 87);
            this.rdbOneGroupQustion.Name = "rdbOneGroupQustion";
            this.rdbOneGroupQustion.Size = new System.Drawing.Size(82, 17);
            this.rdbOneGroupQustion.TabIndex = 1;
            this.rdbOneGroupQustion.Text = "گزارش گروه:";
            this.rdbOneGroupQustion.UseVisualStyleBackColor = true;
            this.rdbOneGroupQustion.CheckedChanged += new System.EventHandler(this.rdbOneGroupQustion_CheckedChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(21, 203);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "گزارش گیری";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(285, 83);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(154, 21);
            this.cmbGroup.TabIndex = 3;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 274);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارشات";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbOneGroupQustion;
        private System.Windows.Forms.RadioButton rdbAllQuestion;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button btnReport;
    }
}