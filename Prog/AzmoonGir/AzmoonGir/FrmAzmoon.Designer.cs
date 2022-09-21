namespace AzmoonGir
{
    partial class FrmAzmoon
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkTime = new System.Windows.Forms.CheckBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.TxtQuestionNumber = new System.Windows.Forms.TextBox();
            this.CmbGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblRemoveChoice = new System.Windows.Forms.Label();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.RdbCase4 = new System.Windows.Forms.RadioButton();
            this.RdbCase3 = new System.Windows.Forms.RadioButton();
            this.RdbCase2 = new System.Windows.Forms.RadioButton();
            this.RdbCase1 = new System.Windows.Forms.RadioButton();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.LblTotalTime = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkTime);
            this.groupBox1.Controls.Add(this.BtnShow);
            this.groupBox1.Controls.Add(this.TxtQuestionNumber);
            this.groupBox1.Controls.Add(this.CmbGroup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(456, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب سوالات";
            // 
            // ChkTime
            // 
            this.ChkTime.AutoSize = true;
            this.ChkTime.Location = new System.Drawing.Point(170, 49);
            this.ChkTime.Name = "ChkTime";
            this.ChkTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkTime.Size = new System.Drawing.Size(98, 17);
            this.ChkTime.TabIndex = 2;
            this.ChkTime.Text = "محدودیت زمانی";
            this.ChkTime.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(49, 45);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 4;
            this.BtnShow.Text = "نمایش";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // TxtQuestionNumber
            // 
            this.TxtQuestionNumber.Location = new System.Drawing.Point(576, 45);
            this.TxtQuestionNumber.Name = "TxtQuestionNumber";
            this.TxtQuestionNumber.Size = new System.Drawing.Size(146, 21);
            this.TxtQuestionNumber.TabIndex = 3;
            // 
            // CmbGroup
            // 
            this.CmbGroup.FormattingEnabled = true;
            this.CmbGroup.Location = new System.Drawing.Point(313, 45);
            this.CmbGroup.Name = "CmbGroup";
            this.CmbGroup.Size = new System.Drawing.Size(121, 21);
            this.CmbGroup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "گروه های امتحانی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعداد سوالات:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblRemoveChoice);
            this.groupBox2.Controls.Add(this.BtnEnd);
            this.groupBox2.Controls.Add(this.BtnNext);
            this.groupBox2.Controls.Add(this.BtnPrev);
            this.groupBox2.Controls.Add(this.RdbCase4);
            this.groupBox2.Controls.Add(this.RdbCase3);
            this.groupBox2.Controls.Add(this.RdbCase2);
            this.groupBox2.Controls.Add(this.RdbCase1);
            this.groupBox2.Controls.Add(this.LblQuestion);
            this.groupBox2.Controls.Add(this.LblTotalTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1257, 489);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "آزمون";
            // 
            // LblRemoveChoice
            // 
            this.LblRemoveChoice.AutoSize = true;
            this.LblRemoveChoice.Location = new System.Drawing.Point(20, 343);
            this.LblRemoveChoice.Name = "LblRemoveChoice";
            this.LblRemoveChoice.Size = new System.Drawing.Size(74, 13);
            this.LblRemoveChoice.TabIndex = 8;
            this.LblRemoveChoice.Text = "پاک کردن گزینه";
            this.LblRemoveChoice.DoubleClick += new System.EventHandler(this.LblRemoveChoice_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(20, 433);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(75, 23);
            this.BtnEnd.TabIndex = 2;
            this.BtnEnd.Text = "پایان آزمون";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(539, 433);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 7;
            this.BtnNext.Text = "بعدی";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(690, 433);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(75, 23);
            this.BtnPrev.TabIndex = 6;
            this.BtnPrev.Text = "قبلی";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // RdbCase4
            // 
            this.RdbCase4.AutoSize = true;
            this.RdbCase4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCase4.Location = new System.Drawing.Point(20, 302);
            this.RdbCase4.Name = "RdbCase4";
            this.RdbCase4.Size = new System.Drawing.Size(63, 20);
            this.RdbCase4.TabIndex = 5;
            this.RdbCase4.TabStop = true;
            this.RdbCase4.Text = "گزینه 4";
            this.RdbCase4.UseVisualStyleBackColor = true;
            // 
            // RdbCase3
            // 
            this.RdbCase3.AutoSize = true;
            this.RdbCase3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCase3.Location = new System.Drawing.Point(20, 270);
            this.RdbCase3.Name = "RdbCase3";
            this.RdbCase3.Size = new System.Drawing.Size(63, 20);
            this.RdbCase3.TabIndex = 4;
            this.RdbCase3.TabStop = true;
            this.RdbCase3.Text = "گزینه 3";
            this.RdbCase3.UseVisualStyleBackColor = true;
            // 
            // RdbCase2
            // 
            this.RdbCase2.AutoSize = true;
            this.RdbCase2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCase2.Location = new System.Drawing.Point(20, 237);
            this.RdbCase2.Name = "RdbCase2";
            this.RdbCase2.Size = new System.Drawing.Size(63, 20);
            this.RdbCase2.TabIndex = 3;
            this.RdbCase2.TabStop = true;
            this.RdbCase2.Text = "گزینه 2";
            this.RdbCase2.UseVisualStyleBackColor = true;
            // 
            // RdbCase1
            // 
            this.RdbCase1.AutoSize = true;
            this.RdbCase1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCase1.Location = new System.Drawing.Point(20, 199);
            this.RdbCase1.Name = "RdbCase1";
            this.RdbCase1.Size = new System.Drawing.Size(63, 20);
            this.RdbCase1.TabIndex = 2;
            this.RdbCase1.TabStop = true;
            this.RdbCase1.Text = "گزینه 1";
            this.RdbCase1.UseVisualStyleBackColor = true;
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.Location = new System.Drawing.Point(16, 83);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblQuestion.Size = new System.Drawing.Size(77, 19);
            this.LblQuestion.TabIndex = 1;
            this.LblQuestion.Text = "متن سوال";
            // 
            // LblTotalTime
            // 
            this.LblTotalTime.AutoSize = true;
            this.LblTotalTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTime.Location = new System.Drawing.Point(20, 39);
            this.LblTotalTime.Name = "LblTotalTime";
            this.LblTotalTime.Size = new System.Drawing.Size(35, 18);
            this.LblTotalTime.TabIndex = 0;
            this.LblTotalTime.Text = "زمان";
            this.LblTotalTime.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAzmoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1281, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAzmoon";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برگزاری آزمون";
            this.Load += new System.EventHandler(this.FrmAzmoon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtQuestionNumber;
        private System.Windows.Forms.ComboBox CmbGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox ChkTime;
        private System.Windows.Forms.RadioButton RdbCase4;
        private System.Windows.Forms.RadioButton RdbCase3;
        private System.Windows.Forms.RadioButton RdbCase2;
        private System.Windows.Forms.RadioButton RdbCase1;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Label LblTotalTime;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Label LblRemoveChoice;
    }
}