namespace AzmoonGir
{
    partial class FrmQuestion
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
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtCase1 = new System.Windows.Forms.TextBox();
            this.txtCase2 = new System.Windows.Forms.TextBox();
            this.txtCase3 = new System.Windows.Forms.TextBox();
            this.txtCase4 = new System.Windows.Forms.TextBox();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrdQuestion = new System.Windows.Forms.DataGridView();
            this.questionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questiontext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdQuestion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(253, 33);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(222, 21);
            this.cmbGroup.TabIndex = 0;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(18, 81);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(457, 82);
            this.txtQuestion.TabIndex = 1;
            // 
            // txtCase1
            // 
            this.txtCase1.Location = new System.Drawing.Point(209, 192);
            this.txtCase1.MaxLength = 400;
            this.txtCase1.Multiline = true;
            this.txtCase1.Name = "txtCase1";
            this.txtCase1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCase1.Size = new System.Drawing.Size(266, 48);
            this.txtCase1.TabIndex = 2;
            // 
            // txtCase2
            // 
            this.txtCase2.Location = new System.Drawing.Point(209, 256);
            this.txtCase2.MaxLength = 400;
            this.txtCase2.Multiline = true;
            this.txtCase2.Name = "txtCase2";
            this.txtCase2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCase2.Size = new System.Drawing.Size(266, 48);
            this.txtCase2.TabIndex = 3;
            // 
            // txtCase3
            // 
            this.txtCase3.Location = new System.Drawing.Point(209, 321);
            this.txtCase3.MaxLength = 400;
            this.txtCase3.Multiline = true;
            this.txtCase3.Name = "txtCase3";
            this.txtCase3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCase3.Size = new System.Drawing.Size(266, 48);
            this.txtCase3.TabIndex = 4;
            // 
            // txtCase4
            // 
            this.txtCase4.Location = new System.Drawing.Point(209, 386);
            this.txtCase4.MaxLength = 400;
            this.txtCase4.Multiline = true;
            this.txtCase4.Name = "txtCase4";
            this.txtCase4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCase4.Size = new System.Drawing.Size(266, 48);
            this.txtCase4.TabIndex = 5;
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbAnswer.Location = new System.Drawing.Point(404, 462);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(71, 21);
            this.cmbAnswer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "گروه امتحانی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "متن سوال:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "گزینه 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "گزینه 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "گزینه 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "گزینه 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "جواب درست:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(18, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(116, 531);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(209, 531);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // GrdQuestion
            // 
            this.GrdQuestion.AllowUserToAddRows = false;
            this.GrdQuestion.AllowUserToDeleteRows = false;
            this.GrdQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionid,
            this.groupid,
            this.questiontext,
            this.case1,
            this.case2,
            this.case3,
            this.case4,
            this.answer});
            this.GrdQuestion.Location = new System.Drawing.Point(12, 12);
            this.GrdQuestion.Name = "GrdQuestion";
            this.GrdQuestion.ReadOnly = true;
            this.GrdQuestion.Size = new System.Drawing.Size(488, 571);
            this.GrdQuestion.TabIndex = 17;
            this.GrdQuestion.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdQuestion_RowHeaderMouseDoubleClick);
            // 
            // questionid
            // 
            this.questionid.DataPropertyName = "QuestionID";
            this.questionid.HeaderText = "کد سوال";
            this.questionid.Name = "questionid";
            this.questionid.ReadOnly = true;
            this.questionid.Visible = false;
            // 
            // groupid
            // 
            this.groupid.DataPropertyName = "GroupID";
            this.groupid.HeaderText = "کد گروه";
            this.groupid.Name = "groupid";
            this.groupid.ReadOnly = true;
            this.groupid.Visible = false;
            // 
            // questiontext
            // 
            this.questiontext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questiontext.DataPropertyName = "QuestionText";
            this.questiontext.HeaderText = "متن سوال";
            this.questiontext.Name = "questiontext";
            this.questiontext.ReadOnly = true;
            // 
            // case1
            // 
            this.case1.DataPropertyName = "Case1";
            this.case1.HeaderText = "گزینه 1";
            this.case1.Name = "case1";
            this.case1.ReadOnly = true;
            this.case1.Visible = false;
            // 
            // case2
            // 
            this.case2.DataPropertyName = "Case2";
            this.case2.HeaderText = "گزینه 2";
            this.case2.Name = "case2";
            this.case2.ReadOnly = true;
            this.case2.Visible = false;
            // 
            // case3
            // 
            this.case3.DataPropertyName = "Case3";
            this.case3.HeaderText = "گزینه 3";
            this.case3.Name = "case3";
            this.case3.ReadOnly = true;
            this.case3.Visible = false;
            // 
            // case4
            // 
            this.case4.DataPropertyName = "Case4";
            this.case4.HeaderText = "گزینه 4";
            this.case4.Name = "case4";
            this.case4.ReadOnly = true;
            this.case4.Visible = false;
            // 
            // answer
            // 
            this.answer.DataPropertyName = "Answer";
            this.answer.HeaderText = "جواب";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtCase1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtCase2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtCase3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCase4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbAnswer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(522, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 571);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت سوالات";
            // 
            // FrmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrdQuestion);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuestion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سوالات چهار گزینه ای";
            this.Load += new System.EventHandler(this.FrmQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdQuestion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtCase1;
        private System.Windows.Forms.TextBox txtCase2;
        private System.Windows.Forms.TextBox txtCase3;
        private System.Windows.Forms.TextBox txtCase4;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView GrdQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionid;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupid;
        private System.Windows.Forms.DataGridViewTextBoxColumn questiontext;
        private System.Windows.Forms.DataGridViewTextBoxColumn case1;
        private System.Windows.Forms.DataGridViewTextBoxColumn case2;
        private System.Windows.Forms.DataGridViewTextBoxColumn case3;
        private System.Windows.Forms.DataGridViewTextBoxColumn case4;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
    }
}