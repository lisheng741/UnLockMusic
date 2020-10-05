namespace UnLockMusic
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblFormatTip = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTopTip = new System.Windows.Forms.Label();
            this.lblMusicTime = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoopPlay = new System.Windows.Forms.Button();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(486, 17);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(80, 25);
            this.btnSerch.TabIndex = 1;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txbSerch
            // 
            this.txbSerch.Location = new System.Drawing.Point(32, 17);
            this.txbSerch.Name = "txbSerch";
            this.txbSerch.Size = new System.Drawing.Size(448, 25);
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
            this.dataGVscan.Location = new System.Drawing.Point(32, 83);
            this.dataGVscan.Margin = new System.Windows.Forms.Padding(4);
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
            this.dataGVscan.Size = new System.Drawing.Size(998, 337);
            this.dataGVscan.TabIndex = 8;
            this.dataGVscan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVscan_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = " ";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.dgvDisplayName.Width = 200;
            // 
            // dgvSinger
            // 
            this.dgvSinger.HeaderText = "歌手";
            this.dgvSinger.Name = "dgvSinger";
            this.dgvSinger.Width = 120;
            // 
            // dgvClass
            // 
            this.dgvClass.HeaderText = "专辑";
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Width = 120;
            // 
            // dgvSourceName
            // 
            this.dgvSourceName.HeaderText = "来源";
            this.dgvSourceName.Name = "dgvSourceName";
            this.dgvSourceName.Width = 90;
            // 
            // dgvPlayMusic
            // 
            this.dgvPlayMusic.HeaderText = "试听";
            this.dgvPlayMusic.Name = "dgvPlayMusic";
            this.dgvPlayMusic.Width = 50;
            // 
            // dgvDownload
            // 
            this.dgvDownload.HeaderText = "下载";
            this.dgvDownload.Name = "dgvDownload";
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
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(744, 17);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 25);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "下载选中";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(572, 17);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(80, 25);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnCancelSelect
            // 
            this.btnCancelSelect.Location = new System.Drawing.Point(658, 17);
            this.btnCancelSelect.Name = "btnCancelSelect";
            this.btnCancelSelect.Size = new System.Drawing.Size(80, 25);
            this.btnCancelSelect.TabIndex = 3;
            this.btnCancelSelect.Text = "取消选中";
            this.btnCancelSelect.UseVisualStyleBackColor = true;
            this.btnCancelSelect.Click += new System.EventHandler(this.btnCancelSelect_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("宋体", 11F);
            this.lblTip.ForeColor = System.Drawing.Color.Red;
            this.lblTip.Location = new System.Drawing.Point(28, 424);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(29, 19);
            this.lblTip.TabIndex = 6;
            this.lblTip.Text = "  ";
            // 
            // lblFormatTip
            // 
            this.lblFormatTip.AutoSize = true;
            this.lblFormatTip.Font = new System.Drawing.Font("宋体", 11F);
            this.lblFormatTip.Location = new System.Drawing.Point(471, 51);
            this.lblFormatTip.Name = "lblFormatTip";
            this.lblFormatTip.Size = new System.Drawing.Size(142, 19);
            this.lblFormatTip.TabIndex = 8;
            this.lblFormatTip.Text = "歌曲保存格式：";
            // 
            // cmbFormat
            // 
            this.cmbFormat.Font = new System.Drawing.Font("宋体", 11F);
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(632, 48);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(240, 26);
            this.cmbFormat.TabIndex = 6;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(32, 453);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(653, 45);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // lblTopTip
            // 
            this.lblTopTip.AutoSize = true;
            this.lblTopTip.Font = new System.Drawing.Font("宋体", 11F);
            this.lblTopTip.Location = new System.Drawing.Point(28, 51);
            this.lblTopTip.Name = "lblTopTip";
            this.lblTopTip.Size = new System.Drawing.Size(29, 19);
            this.lblTopTip.TabIndex = 10;
            this.lblTopTip.Text = "  ";
            // 
            // lblMusicTime
            // 
            this.lblMusicTime.AutoSize = true;
            this.lblMusicTime.Location = new System.Drawing.Point(925, 483);
            this.lblMusicTime.Name = "lblMusicTime";
            this.lblMusicTime.Size = new System.Drawing.Size(95, 15);
            this.lblMusicTime.TabIndex = 11;
            this.lblMusicTime.Text = "00:00/00:00";
            this.lblMusicTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(1, -4);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(79, 32);
            this.axWindowsMediaPlayer2.TabIndex = 12;
            this.axWindowsMediaPlayer2.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(888, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "鼠标放这看说明";
            this.ttp.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnLoopPlay
            // 
            this.btnLoopPlay.Location = new System.Drawing.Point(850, 15);
            this.btnLoopPlay.Name = "btnLoopPlay";
            this.btnLoopPlay.Size = new System.Drawing.Size(100, 25);
            this.btnLoopPlay.TabIndex = 5;
            this.btnLoopPlay.Text = "试听循环开";
            this.btnLoopPlay.UseVisualStyleBackColor = true;
            this.btnLoopPlay.Click += new System.EventHandler(this.btnLoopPlay_Click);
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Location = new System.Drawing.Point(959, 15);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(100, 25);
            this.btnOpenDirectory.TabIndex = 14;
            this.btnOpenDirectory.Text = "打开目录";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1071, 526);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.btnLoopPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.lblMusicTime);
            this.Controls.Add(this.lblTopTip);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.lblFormatTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnCancelSelect);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dataGVscan);
            this.Controls.Add(this.txbSerch);
            this.Controls.Add(this.btnSerch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmList";
            this.ShowIcon = false;
            this.Text = "歌曲搜索神器1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txbSerch;
        public System.Windows.Forms.DataGridView dataGVscan;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblFormatTip;
        private System.Windows.Forms.ComboBox cmbFormat;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblTopTip;
        private System.Windows.Forms.Label lblMusicTime;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoopPlay;
        private System.Windows.Forms.Button btnOpenDirectory;
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


    }
}

