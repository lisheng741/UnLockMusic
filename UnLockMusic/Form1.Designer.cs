﻿namespace UnLockMusic
{
    partial class frmList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmList));
            this.btnSerch = new System.Windows.Forms.Button();
            this.txbSerch = new System.Windows.Forms.TextBox();
            this.dataGVscan = new System.Windows.Forms.DataGridView();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblFormatTip = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTopTip = new System.Windows.Forms.Label();
            this.lblMusicTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.watchAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.loopPlay = new System.Windows.Forms.CheckBox();
            this.WaitBar = new System.Windows.Forms.ProgressBar();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlayMusic = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDownload = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDownloadInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCanDownload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubheading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(568, 41);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(51, 26);
            this.btnSerch.TabIndex = 1;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txbSerch
            // 
            this.txbSerch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbSerch.Location = new System.Drawing.Point(194, 41);
            this.txbSerch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSerch.Name = "txbSerch";
            this.txbSerch.Size = new System.Drawing.Size(374, 26);
            this.txbSerch.TabIndex = 0;
            this.txbSerch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSerch_KeyDown);
            // 
            // dataGVscan
            // 
            this.dataGVscan.AllowDrop = true;
            this.dataGVscan.AllowUserToAddRows = false;
            this.dataGVscan.AllowUserToResizeRows = false;
            this.dataGVscan.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVscan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVscan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGVscan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.dgvID,
            this.dgvDisplayName,
            this.dgvSinger,
            this.dgvClass,
            this.dgvSourceName,
            this.dgvPlayMusic,
            this.dgvDownload,
            this.dgvSource,
            this.dgvDownloadInfo,
            this.dgvCanDownload,
            this.dgvName,
            this.dgvSubheading});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVscan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVscan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVscan.Location = new System.Drawing.Point(29, 86);
            this.dataGVscan.Name = "dataGVscan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVscan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVscan.RowHeadersVisible = false;
            this.dataGVscan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGVscan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVscan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGVscan.RowTemplate.Height = 23;
            this.dataGVscan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVscan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGVscan.Size = new System.Drawing.Size(740, 252);
            this.dataGVscan.TabIndex = 8;
            this.dataGVscan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVscan_CellContentClick);
            this.dataGVscan.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVscan_ColumnHeaderMouseClick);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("宋体", 9F);
            this.lblTip.ForeColor = System.Drawing.Color.Red;
            this.lblTip.Location = new System.Drawing.Point(32, 350);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(17, 12);
            this.lblTip.TabIndex = 6;
            this.lblTip.Text = "  ";
            // 
            // lblFormatTip
            // 
            this.lblFormatTip.AutoSize = true;
            this.lblFormatTip.Font = new System.Drawing.Font("宋体", 9F);
            this.lblFormatTip.Location = new System.Drawing.Point(508, 350);
            this.lblFormatTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormatTip.Name = "lblFormatTip";
            this.lblFormatTip.Size = new System.Drawing.Size(65, 12);
            this.lblFormatTip.TabIndex = 8;
            this.lblFormatTip.Text = "保存格式：";
            // 
            // cmbFormat
            // 
            this.cmbFormat.Font = new System.Drawing.Font("宋体", 9F);
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(561, 346);
            this.cmbFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(130, 20);
            this.cmbFormat.TabIndex = 6;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(29, 367);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(653, 45);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // lblTopTip
            // 
            this.lblTopTip.AutoSize = true;
            this.lblTopTip.Font = new System.Drawing.Font("宋体", 9F);
            this.lblTopTip.Location = new System.Drawing.Point(32, 70);
            this.lblTopTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopTip.Name = "lblTopTip";
            this.lblTopTip.Size = new System.Drawing.Size(17, 12);
            this.lblTopTip.TabIndex = 10;
            this.lblTopTip.Text = "  ";
            // 
            // lblMusicTime
            // 
            this.lblMusicTime.AutoSize = true;
            this.lblMusicTime.Location = new System.Drawing.Point(694, 385);
            this.lblMusicTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusicTime.Name = "lblMusicTime";
            this.lblMusicTime.Size = new System.Drawing.Size(71, 12);
            this.lblMusicTime.TabIndex = 11;
            this.lblMusicTime.Text = "00:00/00:00";
            this.lblMusicTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ttp
            // 
            this.ttp.AutomaticDelay = 100;
            this.ttp.AutoPopDelay = 30000;
            this.ttp.InitialDelay = 100;
            this.ttp.ReshowDelay = 20;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Location = new System.Drawing.Point(705, 345);
            this.btnOpenDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(64, 21);
            this.btnOpenDirectory.TabIndex = 14;
            this.btnOpenDirectory.Text = "打开目录";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchHelp,
            this.toolStripSeparator1,
            this.watchAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // watchHelp
            // 
            this.watchHelp.Name = "watchHelp";
            this.watchHelp.Size = new System.Drawing.Size(118, 22);
            this.watchHelp.Text = "查看帮助";
            this.watchHelp.Click += new System.EventHandler(this.watchHelp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // watchAbout
            // 
            this.watchAbout.Name = "watchAbout";
            this.watchAbout.Size = new System.Drawing.Size(118, 22);
            this.watchAbout.Text = "关于软件";
            // 
            // loopPlay
            // 
            this.loopPlay.AutoSize = true;
            this.loopPlay.Checked = true;
            this.loopPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopPlay.Location = new System.Drawing.Point(248, 385);
            this.loopPlay.Name = "loopPlay";
            this.loopPlay.Size = new System.Drawing.Size(72, 16);
            this.loopPlay.TabIndex = 17;
            this.loopPlay.Text = "循环播放";
            this.loopPlay.UseVisualStyleBackColor = true;
            this.loopPlay.CheckedChanged += new System.EventHandler(this.loopPlay_CheckedChanged);
            // 
            // WaitBar
            // 
            this.WaitBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.WaitBar.Location = new System.Drawing.Point(29, 344);
            this.WaitBar.Minimum = 10;
            this.WaitBar.Name = "WaitBar";
            this.WaitBar.Size = new System.Drawing.Size(456, 18);
            this.WaitBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.WaitBar.TabIndex = 18;
            this.WaitBar.Value = 20;
            this.WaitBar.Visible = false;
            // 
            // select
            // 
            this.select.HeaderText = "全选";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.Width = 40;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "序号";
            this.dgvID.Name = "dgvID";
            this.dgvID.Width = 50;
            // 
            // dgvDisplayName
            // 
            this.dgvDisplayName.HeaderText = "名称";
            this.dgvDisplayName.Name = "dgvDisplayName";
            this.dgvDisplayName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayName.Width = 200;
            // 
            // dgvSinger
            // 
            this.dgvSinger.HeaderText = "歌手";
            this.dgvSinger.Name = "dgvSinger";
            this.dgvSinger.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSinger.Width = 120;
            // 
            // dgvClass
            // 
            this.dgvClass.HeaderText = "专辑";
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.Width = 120;
            // 
            // dgvSourceName
            // 
            this.dgvSourceName.HeaderText = "来源";
            this.dgvSourceName.Name = "dgvSourceName";
            this.dgvSourceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSourceName.Width = 90;
            // 
            // dgvPlayMusic
            // 
            this.dgvPlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvPlayMusic.HeaderText = "试听";
            this.dgvPlayMusic.Name = "dgvPlayMusic";
            this.dgvPlayMusic.Text = "播放";
            this.dgvPlayMusic.UseColumnTextForButtonValue = true;
            this.dgvPlayMusic.Width = 50;
            // 
            // dgvDownload
            // 
            this.dgvDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvDownload.HeaderText = "下载";
            this.dgvDownload.Name = "dgvDownload";
            this.dgvDownload.Text = "下载";
            this.dgvDownload.UseColumnTextForButtonValue = true;
            this.dgvDownload.Width = 50;
            // 
            // dgvSource
            // 
            this.dgvSource.HeaderText = "Source";
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.Visible = false;
            // 
            // dgvDownloadInfo
            // 
            this.dgvDownloadInfo.HeaderText = "DownloadInfo";
            this.dgvDownloadInfo.Name = "dgvDownloadInfo";
            this.dgvDownloadInfo.Visible = false;
            // 
            // dgvCanDownload
            // 
            this.dgvCanDownload.HeaderText = "CanDownload";
            this.dgvCanDownload.Name = "dgvCanDownload";
            this.dgvCanDownload.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.Visible = false;
            // 
            // dgvSubheading
            // 
            this.dgvSubheading.HeaderText = "Subheading";
            this.dgvSubheading.Name = "dgvSubheading";
            this.dgvSubheading.Visible = false;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(157, 32);
            this.axWindowsMediaPlayer2.TabIndex = 12;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(803, 421);
            this.Controls.Add(this.WaitBar);
            this.Controls.Add(this.loopPlay);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.lblMusicTime);
            this.Controls.Add(this.lblTopTip);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.lblFormatTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.dataGVscan);
            this.Controls.Add(this.txbSerch);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmList";
            this.ShowIcon = false;
            this.Text = "歌曲搜索神器1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txbSerch;
        public System.Windows.Forms.DataGridView dataGVscan;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblFormatTip;
        private System.Windows.Forms.ComboBox cmbFormat;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblTopTip;
        private System.Windows.Forms.Label lblMusicTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem watchAbout;
        private System.Windows.Forms.CheckBox loopPlay;
        private System.Windows.Forms.ProgressBar WaitBar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSourceName;
        private System.Windows.Forms.DataGridViewButtonColumn dgvPlayMusic;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDownloadInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCanDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubheading;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}

