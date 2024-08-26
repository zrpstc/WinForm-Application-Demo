namespace checkwork_week4_Client
{
    partial class Client
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonConn = new System.Windows.Forms.Button();
            this.buttonDisConn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSendMess = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.buttonDownData = new System.Windows.Forms.Button();
            this.buttonDeleData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(182, 57);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(235, 28);
            this.textBoxAddress.TabIndex = 0;
            this.textBoxAddress.Text = "10.76.17.95";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(182, 124);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(235, 28);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "5000";
            // 
            // buttonConn
            // 
            this.buttonConn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConn.Location = new System.Drawing.Point(39, 30);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(230, 48);
            this.buttonConn.TabIndex = 2;
            this.buttonConn.Text = "连接服务器";
            this.buttonConn.UseVisualStyleBackColor = true;
            this.buttonConn.Click += new System.EventHandler(this.buttonConn_Click);
            // 
            // buttonDisConn
            // 
            this.buttonDisConn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDisConn.Location = new System.Drawing.Point(39, 110);
            this.buttonDisConn.Name = "buttonDisConn";
            this.buttonDisConn.Size = new System.Drawing.Size(230, 52);
            this.buttonDisConn.TabIndex = 3;
            this.buttonDisConn.Text = "断开服务器";
            this.buttonDisConn.UseVisualStyleBackColor = true;
            this.buttonDisConn.Click += new System.EventHandler(this.buttonDisConn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "服务器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口号";
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(6, 27);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(754, 138);
            this.textBoxReceive.TabIndex = 6;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(14, 27);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSend.Size = new System.Drawing.Size(754, 135);
            this.textBoxSend.TabIndex = 7;
            // 
            // buttonSendMess
            // 
            this.buttonSendMess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSendMess.Location = new System.Drawing.Point(53, 628);
            this.buttonSendMess.Name = "buttonSendMess";
            this.buttonSendMess.Size = new System.Drawing.Size(150, 48);
            this.buttonSendMess.TabIndex = 8;
            this.buttonSendMess.Text = "发送信息";
            this.buttonSendMess.UseVisualStyleBackColor = true;
            this.buttonSendMess.Click += new System.EventHandler(this.buttonSendMess_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearLog.Location = new System.Drawing.Point(238, 628);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(150, 48);
            this.buttonClearLog.TabIndex = 9;
            this.buttonClearLog.Text = "清除日志";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // buttonDownData
            // 
            this.buttonDownData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDownData.Location = new System.Drawing.Point(427, 628);
            this.buttonDownData.Name = "buttonDownData";
            this.buttonDownData.Size = new System.Drawing.Size(150, 48);
            this.buttonDownData.TabIndex = 10;
            this.buttonDownData.Text = "加载数据";
            this.buttonDownData.UseVisualStyleBackColor = true;
            this.buttonDownData.Click += new System.EventHandler(this.buttonDownData_Click);
            // 
            // buttonDeleData
            // 
            this.buttonDeleData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDeleData.Location = new System.Drawing.Point(611, 628);
            this.buttonDeleData.Name = "buttonDeleData";
            this.buttonDeleData.Size = new System.Drawing.Size(150, 48);
            this.buttonDeleData.TabIndex = 11;
            this.buttonDeleData.Text = "清除数据";
            this.buttonDeleData.UseVisualStyleBackColor = true;
            this.buttonDeleData.Click += new System.EventHandler(this.buttonDeleData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReceive);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息接收窗口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSend);
            this.groupBox2.Location = new System.Drawing.Point(12, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 168);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息发送窗口";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPort);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxAddress);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 193);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "服务器信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonConn);
            this.groupBox4.Controls.Add(this.buttonDisConn);
            this.groupBox4.Location = new System.Drawing.Point(466, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 193);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeleData);
            this.Controls.Add(this.buttonDownData);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.buttonSendMess);
            this.Controls.Add(this.groupBox4);
            this.Name = "Client";
            this.Text = "客户端";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.Button buttonDisConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSendMess;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonDownData;
        private System.Windows.Forms.Button buttonDeleData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}