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
            this.numUpDownLV = new System.Windows.Forms.NumericUpDown();
            this.btnRank = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlay,
            this.toolStripSeparator1,
            this.btnGiveUp,
            this.toolStripSeparator2,
            this.btnRule,
            this.toolStripSeparator3,
            this.btnAuto,
            this.toolStripSeparator5,
            this.btnExit,
            this.toolStripSeparator6});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnGiveUp
            // 
            resources.ApplyResources(this.btnGiveUp, "btnGiveUp");
            this.btnGiveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGiveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGiveUp.ForeColor = System.Drawing.Color.Black;
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnRule
            // 
            resources.ApplyResources(this.btnRule, "btnRule");
            this.btnRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRule.ForeColor = System.Drawing.Color.Black;
            this.btnRule.Name = "btnRule";
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // btnAuto
            // 
            resources.ApplyResources(this.btnAuto, "btnAuto");
            this.btnAuto.BackColor = System.Drawing.Color.Yellow;
            this.btnAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTime.Name = "lblTime";
            // 
            // lblMoveCount
            // 
            resources.ApplyResources(this.lblMoveCount, "lblMoveCount");
            this.lblMoveCount.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMoveCount.Name = "lblMoveCount";
            // 
            // nubLevel
            // 
            resources.ApplyResources(this.nubLevel, "nubLevel");
            this.nubLevel.InterceptArrowKeys = false;
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
            this.nubLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Name = "label6";
            // 
            // tmrCountTime
            // 
            this.tmrCountTime.Interval = 1000;
            this.tmrCountTime.Tick += new System.EventHandler(this.tmrCountTime_Tick);
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic3, "pic3");
            this.pic3.Name = "pic3";
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic4, "pic4");
            this.pic4.Name = "pic4";
            this.pic4.TabStop = false;
            this.pic4.Tag = "4";
            this.pic4.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic5, "pic5");
            this.pic5.Name = "pic5";
            this.pic5.TabStop = false;
            this.pic5.Tag = "5";
            this.pic5.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic6, "pic6");
            this.pic6.Name = "pic6";
            this.pic6.TabStop = false;
            this.pic6.Tag = "6";
            this.pic6.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic7, "pic7");
            this.pic7.Name = "pic7";
            this.pic7.TabStop = false;
            this.pic7.Tag = "7";
            this.pic7.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic8, "pic8");
            this.pic8.Name = "pic8";
            this.pic8.TabStop = false;
            this.pic8.Tag = "8";
            this.pic8.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic2, "pic2");
            this.pic2.Name = "pic2";
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pic1, "pic1");
            this.pic1.Name = "pic1";
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Click += new System.EventHandler(this.picDisks_Click);
            // 
            // picTowerC
            // 
            this.picTowerC.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picTowerC, "picTowerC");
            this.picTowerC.Name = "picTowerC";
            this.picTowerC.TabStop = false;
            this.picTowerC.Click += new System.EventHandler(this.picTower_Click);
            // 
            // picTowerB
            // 
            this.picTowerB.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picTowerB, "picTowerB");
            this.picTowerB.Name = "picTowerB";
            this.picTowerB.TabStop = false;
            this.picTowerB.Click += new System.EventHandler(this.picTower_Click);
            // 
            // picTowerA
            // 
            this.picTowerA.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picTowerA, "picTowerA");
            this.picTowerA.Name = "picTowerA";
            this.picTowerA.TabStop = false;
            this.picTowerA.Click += new System.EventHandler(this.picTower_Click);
            // 
            // lblLeast
            // 
            resources.ApplyResources(this.lblLeast, "lblLeast");
            this.lblLeast.BackColor = System.Drawing.Color.Transparent;
            this.lblLeast.ForeColor = System.Drawing.Color.Red;
            this.lblLeast.Name = "lblLeast";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 1;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.rtbLog, "rtbLog");
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            // 
            // numUpDownLV
            // 
            this.numUpDownLV.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.numUpDownLV, "numUpDownLV");
            this.numUpDownLV.InterceptArrowKeys = false;
            this.numUpDownLV.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownLV.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownLV.Name = "numUpDownLV";
            this.numUpDownLV.ReadOnly = true;
            this.numUpDownLV.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnRank, "btnRank");
            this.btnRank.Name = "btnRank";
            this.btnRank.UseVisualStyleBackColor = false;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // FrmTHN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.numUpDownLV);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTHN";
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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLV)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numUpDownLV;
        private System.Windows.Forms.Button btnRank;
    }
}

