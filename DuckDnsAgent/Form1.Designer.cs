namespace DuckDnsAgent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TB_userToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NUM_updateInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_addDomain = new System.Windows.Forms.Button();
            this.TB_newDomain = new System.Windows.Forms.TextBox();
            this.LB_Domains = new System.Windows.Forms.ListBox();
            this.domainsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.BTN_configSave = new System.Windows.Forms.Button();
            this.BTN_updateNow = new System.Windows.Forms.Button();
            this.timerUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_updateInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.domainsMenuStrip.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "I\'m Here. Click to me to open GUI";
            this.notifyIcon1.BalloonTipTitle = "DuckDNS Agent";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DuckDNS Agent";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "user token = ";
            // 
            // TB_userToken
            // 
            this.TB_userToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_userToken.Location = new System.Drawing.Point(150, 3);
            this.TB_userToken.Name = "TB_userToken";
            this.TB_userToken.Size = new System.Drawing.Size(213, 23);
            this.TB_userToken.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update each = ";
            // 
            // NUM_updateInterval
            // 
            this.NUM_updateInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUM_updateInterval.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUM_updateInterval.Location = new System.Drawing.Point(150, 32);
            this.NUM_updateInterval.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.NUM_updateInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUM_updateInterval.Name = "NUM_updateInterval";
            this.NUM_updateInterval.Size = new System.Drawing.Size(157, 23);
            this.NUM_updateInterval.TabIndex = 3;
            this.NUM_updateInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "seconds";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BTN_addDomain);
            this.groupBox1.Controls.Add(this.TB_newDomain);
            this.groupBox1.Controls.Add(this.LB_Domains);
            this.groupBox1.Location = new System.Drawing.Point(8, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domains to update with this machine IP";
            // 
            // BTN_addDomain
            // 
            this.BTN_addDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_addDomain.Location = new System.Drawing.Point(263, 122);
            this.BTN_addDomain.Name = "BTN_addDomain";
            this.BTN_addDomain.Size = new System.Drawing.Size(75, 23);
            this.BTN_addDomain.TabIndex = 2;
            this.BTN_addDomain.Text = "Add";
            this.BTN_addDomain.UseVisualStyleBackColor = true;
            this.BTN_addDomain.Click += new System.EventHandler(this.BTN_addDomain_Click);
            // 
            // TB_newDomain
            // 
            this.TB_newDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_newDomain.Location = new System.Drawing.Point(17, 122);
            this.TB_newDomain.Name = "TB_newDomain";
            this.TB_newDomain.PlaceholderText = "New DuckDns\'s domain to update";
            this.TB_newDomain.Size = new System.Drawing.Size(237, 23);
            this.TB_newDomain.TabIndex = 1;
            // 
            // LB_Domains
            // 
            this.LB_Domains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Domains.ContextMenuStrip = this.domainsMenuStrip;
            this.LB_Domains.FormattingEnabled = true;
            this.LB_Domains.ItemHeight = 15;
            this.LB_Domains.Location = new System.Drawing.Point(17, 22);
            this.LB_Domains.Name = "LB_Domains";
            this.LB_Domains.Size = new System.Drawing.Size(321, 94);
            this.LB_Domains.TabIndex = 0;
            // 
            // domainsMenuStrip
            // 
            this.domainsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Remove});
            this.domainsMenuStrip.Name = "domainsMenuStrip";
            this.domainsMenuStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // toolStripMenuItem_Remove
            // 
            this.toolStripMenuItem_Remove.Name = "toolStripMenuItem_Remove";
            this.toolStripMenuItem_Remove.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem_Remove.Text = "Remove";
            this.toolStripMenuItem_Remove.Click += new System.EventHandler(this.toolStripMenuItem_Remove_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBottom.Controls.Add(this.LBL_Status);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.ForeColor = System.Drawing.Color.White;
            this.panelBottom.Location = new System.Drawing.Point(0, 263);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(375, 28);
            this.panelBottom.TabIndex = 6;
            // 
            // LBL_Status
            // 
            this.LBL_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Status.Location = new System.Drawing.Point(8, 2);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(355, 23);
            this.LBL_Status.TabIndex = 0;
            this.LBL_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_configSave
            // 
            this.BTN_configSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_configSave.Location = new System.Drawing.Point(271, 229);
            this.BTN_configSave.Name = "BTN_configSave";
            this.BTN_configSave.Size = new System.Drawing.Size(92, 23);
            this.BTN_configSave.TabIndex = 7;
            this.BTN_configSave.Text = "Save changes";
            this.BTN_configSave.UseVisualStyleBackColor = true;
            this.BTN_configSave.Click += new System.EventHandler(this.BTN_configSave_Click);
            // 
            // BTN_updateNow
            // 
            this.BTN_updateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_updateNow.Location = new System.Drawing.Point(8, 229);
            this.BTN_updateNow.Name = "BTN_updateNow";
            this.BTN_updateNow.Size = new System.Drawing.Size(92, 23);
            this.BTN_updateNow.TabIndex = 8;
            this.BTN_updateNow.Text = "Update now";
            this.BTN_updateNow.UseVisualStyleBackColor = true;
            this.BTN_updateNow.Click += new System.EventHandler(this.BTN_updateNow_Click);
            // 
            // timerUpdater
            // 
            this.timerUpdater.Interval = 1000;
            this.timerUpdater.Tick += new System.EventHandler(this.timerUpdater_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 291);
            this.Controls.Add(this.BTN_updateNow);
            this.Controls.Add(this.BTN_configSave);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUM_updateInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_userToken);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuckDns Agent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_updateInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.domainsMenuStrip.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_userToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUM_updateInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_addDomain;
        private System.Windows.Forms.TextBox TB_newDomain;
        private System.Windows.Forms.ListBox LB_Domains;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button BTN_configSave;
        private System.Windows.Forms.Button BTN_updateNow;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.ContextMenuStrip domainsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Remove;
        private System.Windows.Forms.Timer timerUpdater;
    }
}
