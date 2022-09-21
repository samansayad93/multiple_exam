namespace AzmoonGir
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.M0 = new System.Windows.Forms.ToolStripMenuItem();
            this.M00 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.M01 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.M02 = new System.Windows.Forms.ToolStripMenuItem();
            this.M1 = new System.Windows.Forms.ToolStripMenuItem();
            this.M10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.M11 = new System.Windows.Forms.ToolStripMenuItem();
            this.M2 = new System.Windows.Forms.ToolStripMenuItem();
            this.M3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vistaClock1 = new VistaClockPersian.Controls.VistaClock();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDayWeek = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M4 = new System.Windows.Forms.ToolStripMenuItem();
            this.M40 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M0,
            this.M1,
            this.M2,
            this.M3,
            this.M4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // M0
            // 
            this.M0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M00,
            this.toolStripMenuItem1,
            this.M01,
            this.toolStripMenuItem3,
            this.M02});
            this.M0.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M0.Name = "M0";
            this.M0.Size = new System.Drawing.Size(76, 20);
            this.M0.Text = "عملیات پایه";
            // 
            // M00
            // 
            this.M00.Name = "M00";
            this.M00.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.M00.Size = new System.Drawing.Size(207, 22);
            this.M00.Text = "گروه های امتحانی";
            this.M00.Click += new System.EventHandler(this.M00_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // M01
            // 
            this.M01.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M01.Name = "M01";
            this.M01.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.M01.Size = new System.Drawing.Size(207, 22);
            this.M01.Text = "مدیریت سوالات";
            this.M01.Click += new System.EventHandler(this.M01_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(204, 6);
            // 
            // M02
            // 
            this.M02.Name = "M02";
            this.M02.Size = new System.Drawing.Size(207, 22);
            this.M02.Text = "زمان بندی سوالات";
            this.M02.Click += new System.EventHandler(this.M02_Click);
            // 
            // M1
            // 
            this.M1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M10,
            this.toolStripMenuItem2,
            this.M11});
            this.M1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(54, 20);
            this.M1.Text = "مدیریت";
            // 
            // M10
            // 
            this.M10.Name = "M10";
            this.M10.Size = new System.Drawing.Size(146, 22);
            this.M10.Text = "مدیریت مدیران";
            this.M10.Click += new System.EventHandler(this.M10_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // M11
            // 
            this.M11.Name = "M11";
            this.M11.Size = new System.Drawing.Size(146, 22);
            this.M11.Text = "مدیریت کاربران";
            this.M11.Click += new System.EventHandler(this.M11_Click);
            // 
            // M2
            // 
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(45, 20);
            this.M2.Text = "آزمون";
            this.M2.Click += new System.EventHandler(this.M2_Click);
            // 
            // M3
            // 
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(179, 20);
            this.M3.Text = "پشتیبان گیری و بازیابی اطلاعات";
            this.M3.Click += new System.EventHandler(this.M3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vistaClock1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblTime);
            this.panel1.Controls.Add(this.LblDayWeek);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(716, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 473);
            this.panel1.TabIndex = 1;
            // 
            // vistaClock1
            // 
            this.vistaClock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vistaClock1.BackColor = System.Drawing.Color.Transparent;
            this.vistaClock1.Location = new System.Drawing.Point(52, 279);
            this.vistaClock1.MaximumSize = new System.Drawing.Size(132, 131);
            this.vistaClock1.MinimumSize = new System.Drawing.Size(132, 131);
            this.vistaClock1.Name = "vistaClock1";
            this.vistaClock1.SecondSpring = true;
            this.vistaClock1.ShowSecond = true;
            this.vistaClock1.Size = new System.Drawing.Size(132, 131);
            this.vistaClock1.Style = VistaClockPersian.Controls.VistaClock.VistaClockStyle.Silver;
            this.vistaClock1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ساعت:";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(70, 431);
            this.LblTime.Name = "LblTime";
            this.LblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTime.Size = new System.Drawing.Size(51, 19);
            this.LblTime.TabIndex = 4;
            this.LblTime.Text = "label2";
            // 
            // LblDayWeek
            // 
            this.LblDayWeek.AutoSize = true;
            this.LblDayWeek.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDayWeek.ForeColor = System.Drawing.Color.IndianRed;
            this.LblDayWeek.Location = new System.Drawing.Point(88, 141);
            this.LblDayWeek.Name = "LblDayWeek";
            this.LblDayWeek.Size = new System.Drawing.Size(68, 23);
            this.LblDayWeek.TabIndex = 3;
            this.LblDayWeek.Text = "label2";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDate.Location = new System.Drawing.Point(59, 93);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(68, 23);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "امروز:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AzmoonGir.Properties.Resources.azmoon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // M4
            // 
            this.M4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M40});
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(63, 20);
            this.M4.Text = "گزارشات";
            // 
            // M40
            // 
            this.M40.Name = "M40";
            this.M40.Size = new System.Drawing.Size(180, 22);
            this.M40.Text = "لیست گزارشات";
            this.M40.Click += new System.EventHandler(this.M40_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار آزمون گیر";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem M0;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem M01;
        private System.Windows.Forms.ToolStripMenuItem M00;
        private System.Windows.Forms.ToolStripMenuItem M1;
        private System.Windows.Forms.ToolStripMenuItem M10;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem M11;
        private System.Windows.Forms.ToolStripMenuItem M2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem M02;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDayWeek;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private VistaClockPersian.Controls.VistaClock vistaClock1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem M3;
        private System.Windows.Forms.ToolStripMenuItem M4;
        private System.Windows.Forms.ToolStripMenuItem M40;
    }
}