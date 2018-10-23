namespace TowerOfHanoi
{
    partial class FrmTHN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTHN));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGiveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRule = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAuto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRank = new System.Windows.Forms.ToolStripButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoveCount = new System.Windows.Forms.Label();
            this.nubLevel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrCountTime = new System.Windows.Forms.Timer(this.components);
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.picTowerC = new System.Windows.Forms.PictureBox();
            this.picTowerB = new System.Windows.Forms.PictureBox();
            this.picTowerA = new System.Windows.Forms.PictureBox();
            this.lblLeast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTowerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTowerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTowerA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlay,
            this.toolStripSeparator1,
            this.btnGiveUp,
            this.toolStripSeparator2,
            this.btnRule,
            this.toolStripSeparator3,
            this.btnExit,
            this.toolStripSeparator5,
            this.btnAuto,
            this.toolStripSeparator6,
            this.btnRank});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1468, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(49, 34);
            this.btnPlay.Text = "PLAY";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = false;
            this.btnGiveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGiveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGiveUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGiveUp.ForeColor = System.Drawing.Color.Black;
            this.btnGiveUp.ImageTransparentColor = System.Drawing.Color.White;
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(55, 25);
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // btnRule
            // 
            this.btnRule.AutoSize = false;
            this.btnRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRule.ForeColor = System.Drawing.Color.Black;
            this.btnRule.ImageTransparentColor = System.Drawing.Color.White;
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(55, 25);
            this.btnRule.Text = "Rules";
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 25);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // btnAuto
            // 
            this.btnAuto.AutoSize = false;
            this.btnAuto.BackColor = System.Drawing.Color.Yellow;
            this.btnAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAuto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(55, 25);
            this.btnAuto.Text = "Auto";
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 37);
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(48, 34);
            this.btnRank.Text = "Rank";
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTime.Location = new System.Drawing.Point(476, 54);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(213, 27);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Thời Gian: 00:00:00 ";
            // 
            // lblMoveCount
            // 
            this.lblMoveCount.AutoSize = true;
            this.lblMoveCount.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMoveCount.Location = new System.Drawing.Point(452, 81);
            this.lblMoveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoveCount.Name = "lblMoveCount";
            this.lblMoveCount.Size = new System.Drawing.Size(256, 27);
            this.lblMoveCount.TabIndex = 16;
            this.lblMoveCount.Text = "Số Lần Di Chuyển: 0 lần ";
            // 
            // nubLevel
            // 
            this.nubLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nubLevel.InterceptArrowKeys = false;
            this.nubLevel.Location = new System.Drawing.Point(517, 113);
            this.nubLevel.Margin = new System.Windows.Forms.Padding(4);
            this.nubLevel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nubLevel.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nubLevel.Name = "nubLevel";
            this.nubLevel.ReadOnly = true;
            this.nubLevel.Size = new System.Drawing.Size(60, 26);
            this.nubLevel.TabIndex = 17;
            this.nubLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(415, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số đĩa:";
            // 
            // tmrCountTime
            // 
            this.tmrCountTime.Interval = 1000;
            this.tmrCountTime.Tick += new System.EventHandler(this.tmrCountTime_Tick);
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(775, 284);
            this.pic3.Margin = new System.Windows.Forms.Padding(4);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(285, 37);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic3.TabIndex = 14;
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.Visible = false;
            this.pic3.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(775, 329);
            this.pic4.Margin = new System.Windows.Forms.Padding(4);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(285, 37);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic4.TabIndex = 13;
            this.pic4.TabStop = false;
            this.pic4.Tag = "4";
            this.pic4.Visible = false;
            this.pic4.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(775, 373);
            this.pic5.Margin = new System.Windows.Forms.Padding(4);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(285, 37);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic5.TabIndex = 12;
            this.pic5.TabStop = false;
            this.pic5.Tag = "5";
            this.pic5.Visible = false;
            this.pic5.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.Transparent;
            this.pic6.Image = ((System.Drawing.Image)(resources.GetObject("pic6.Image")));
            this.pic6.Location = new System.Drawing.Point(775, 417);
            this.pic6.Margin = new System.Windows.Forms.Padding(4);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(285, 37);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic6.TabIndex = 11;
            this.pic6.TabStop = false;
            this.pic6.Tag = "6";
            this.pic6.Visible = false;
            this.pic6.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.Transparent;
            this.pic7.Image = ((System.Drawing.Image)(resources.GetObject("pic7.Image")));
            this.pic7.Location = new System.Drawing.Point(775, 462);
            this.pic7.Margin = new System.Windows.Forms.Padding(4);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(285, 37);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic7.TabIndex = 10;
            this.pic7.TabStop = false;
            this.pic7.Tag = "7";
            this.pic7.Visible = false;
            this.pic7.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.Transparent;
            this.pic8.Image = ((System.Drawing.Image)(resources.GetObject("pic8.Image")));
            this.pic8.Location = new System.Drawing.Point(775, 506);
            this.pic8.Margin = new System.Windows.Forms.Padding(4);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(285, 37);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic8.TabIndex = 9;
            this.pic8.TabStop = false;
            this.pic8.Tag = "8";
            this.pic8.Visible = false;
            this.pic8.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(452, 506);
            this.pic2.Margin = new System.Windows.Forms.Padding(4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(285, 37);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic2.TabIndex = 8;
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.Visible = false;
            this.pic2.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(128, 506);
            this.pic1.Margin = new System.Windows.Forms.Padding(4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(285, 37);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Visible = false;
            this.pic1.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // picTowerC
            // 
            this.picTowerC.BackColor = System.Drawing.Color.Transparent;
            this.picTowerC.Image = ((System.Drawing.Image)(resources.GetObject("picTowerC.Image")));
            this.picTowerC.Location = new System.Drawing.Point(759, 196);
            this.picTowerC.Margin = new System.Windows.Forms.Padding(4);
            this.picTowerC.Name = "picTowerC";
            this.picTowerC.Size = new System.Drawing.Size(315, 377);
            this.picTowerC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTowerC.TabIndex = 3;
            this.picTowerC.TabStop = false;
            this.picTowerC.Click += new System.EventHandler(this.picTower_Click);
            // 
            // picTowerB
            // 
            this.picTowerB.BackColor = System.Drawing.Color.Transparent;
            this.picTowerB.Image = ((System.Drawing.Image)(resources.GetObject("picTowerB.Image")));
            this.picTowerB.Location = new System.Drawing.Point(436, 196);
            this.picTowerB.Margin = new System.Windows.Forms.Padding(4);
            this.picTowerB.Name = "picTowerB";
            this.picTowerB.Size = new System.Drawing.Size(315, 377);
            this.picTowerB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTowerB.TabIndex = 2;
            this.picTowerB.TabStop = false;
            this.picTowerB.Click += new System.EventHandler(this.picTower_Click);
            // 
            // picTowerA
            // 
            this.picTowerA.BackColor = System.Drawing.Color.Transparent;
            this.picTowerA.Image = ((System.Drawing.Image)(resources.GetObject("picTowerA.Image")));
            this.picTowerA.Location = new System.Drawing.Point(113, 196);
            this.picTowerA.Margin = new System.Windows.Forms.Padding(4);
            this.picTowerA.Name = "picTowerA";
            this.picTowerA.Size = new System.Drawing.Size(315, 377);
            this.picTowerA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTowerA.TabIndex = 0;
            this.picTowerA.TabStop = false;
            this.picTowerA.Click += new System.EventHandler(this.picTower_Click);
            // 
            // lblLeast
            // 
            this.lblLeast.AutoSize = true;
            this.lblLeast.BackColor = System.Drawing.Color.Transparent;
            this.lblLeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeast.ForeColor = System.Drawing.Color.Red;
            this.lblLeast.Location = new System.Drawing.Point(585, 112);
            this.lblLeast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeast.Name = "lblLeast";
            this.lblLeast.Size = new System.Drawing.Size(274, 25);
            this.lblLeast.TabIndex = 19;
            this.lblLeast.Text = "(Số Lần Di Chuyển Tối Thiểu)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(899, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "C";
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 1;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(1111, 54);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(344, 517);
            this.rtbLog.TabIndex = 23;
            this.rtbLog.Text = "Đồ án 1 - Poon & Thanh Tuấn";
            // 
            // FrmTHN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1468, 587);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nubLevel);
            this.Controls.Add(this.lblMoveCount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.picTowerC);
            this.Controls.Add(this.picTowerB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.picTowerA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTHN";
            this.Text = "TowerOfHanoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTHN_FormClosing);
            this.Load += new System.EventHandler(this.FrmTHN_Load);
            this.Click += new System.EventHandler(this.picDisks_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTowerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTowerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTowerA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTowerA;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox picTowerB;
        private System.Windows.Forms.PictureBox picTowerC;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoveCount;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton btnGiveUp;
        private System.Windows.Forms.ToolStripButton btnRule;
        private System.Windows.Forms.NumericUpDown nubLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrCountTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Label lblLeast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.ToolStripButton btnAuto;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnRank;
    }
}

