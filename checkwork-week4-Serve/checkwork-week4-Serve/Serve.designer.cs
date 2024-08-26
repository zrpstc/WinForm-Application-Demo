namespace checkwork_week4_Serve
{
    partial class Serve
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonStartWatch = new System.Windows.Forms.Button();
            this.comboBoxConList = new System.Windows.Forms.ComboBox();
            this.buttonStopWatch = new System.Windows.Forms.Button();
            this.textBoxSendMess = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxReceMess = new System.Windows.Forms.TextBox();
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(32, 27);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(157, 28);
            this.textBoxPort.TabIndex = 0;
            this.textBoxPort.Text = "5000";
            // 
            // buttonStartWatch
            // 
            this.buttonStartWatch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStartWatch.Location = new System.Drawing.Point(211, 18);
            this.buttonStartWatch.Name = "buttonStartWatch";
            this.buttonStartWatch.Size = new System.Drawing.Size(177, 48);
            this.buttonStartWatch.TabIndex = 1;
            this.buttonStartWatch.Text = "开始监听";
            this.buttonStartWatch.UseVisualStyleBackColor = true;
            this.buttonStartWatch.Click += new System.EventHandler(this.buttonStartWatch_Click);
            // 
            // comboBoxConList
            // 
            this.comboBoxConList.FormattingEnabled = true;
            this.comboBoxConList.Items.AddRange(new object[] {
            "ALL"});
            this.comboBoxConList.Location = new System.Drawing.Point(738, 45);
            this.comboBoxConList.Name = "comboBoxConList";
            this.comboBoxConList.Size = new System.Drawing.Size(248, 26);
            this.comboBoxConList.TabIndex = 2;
            // 
            // buttonStopWatch
            // 
            this.buttonStopWatch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStopWatch.Location = new System.Drawing.Point(407, 18);
            this.buttonStopWatch.Name = "buttonStopWatch";
            this.buttonStopWatch.Size = new System.Drawing.Size(177, 48);
            this.buttonStopWatch.TabIndex = 3;
            this.buttonStopWatch.Text = "停止监听";
            this.buttonStopWatch.UseVisualStyleBackColor = true;
            this.buttonStopWatch.Click += new System.EventHandler(this.buttonStopWatch_Click);
            // 
            // textBoxSendMess
            // 
            this.textBoxSendMess.Location = new System.Drawing.Point(62, 97);
            this.textBoxSendMess.Multiline = true;
            this.textBoxSendMess.Name = "textBoxSendMess";
            this.textBoxSendMess.Size = new System.Drawing.Size(357, 91);
            this.textBoxSendMess.TabIndex = 5;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(32, 27);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(507, 179);
            this.textBoxLog.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1028, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "连接列表";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConNum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1257, 29);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConNum
            // 
            this.toolStripStatusLabelConNum.Name = "toolStripStatusLabelConNum";
            this.toolStripStatusLabelConNum.Size = new System.Drawing.Size(261, 24);
            this.toolStripStatusLabelConNum.Text = "toolStripStatusLabelConNum";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSendMessage.Location = new System.Drawing.Point(437, 140);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(177, 48);
            this.buttonSendMessage.TabIndex = 13;
            this.buttonSendMessage.Text = "发送信息";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxReceMess
            // 
            this.textBoxReceMess.Location = new System.Drawing.Point(32, 35);
            this.textBoxReceMess.Multiline = true;
            this.textBoxReceMess.Name = "textBoxReceMess";
            this.textBoxReceMess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceMess.Size = new System.Drawing.Size(507, 218);
            this.textBoxReceMess.TabIndex = 14;
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(32, 27);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.RowTemplate.Height = 30;
            this.dataGridViewExcel.Size = new System.Drawing.Size(611, 444);
            this.dataGridViewExcel.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStartWatch);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.buttonStopWatch);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 79);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxReceMess);
            this.groupBox2.Location = new System.Drawing.Point(30, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 259);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息窗口";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxLog);
            this.groupBox3.Location = new System.Drawing.Point(30, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 212);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志窗口";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewExcel);
            this.groupBox4.Location = new System.Drawing.Point(589, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 480);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据窗口";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSendMessage);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.comboBoxConList);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 699);
            this.panel1.TabIndex = 20;
            // 
            // Serve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 757);
            this.Controls.Add(this.textBoxSendMess);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Serve";
            this.Text = "服务端";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonStartWatch;
        private System.Windows.Forms.ComboBox comboBoxConList;
        private System.Windows.Forms.Button buttonStopWatch;
        private System.Windows.Forms.TextBox textBoxSendMess;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBoxReceMess;
        private System.Windows.Forms.DataGridView dataGridViewExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConNum;
        private System.Windows.Forms.Panel panel1;
    }
}

