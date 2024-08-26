namespace FinalWork
{
    partial class AddOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_ResetOrder = new System.Windows.Forms.Button();
            this.bt_AddOrderOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_uid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bt_ResetOrder);
            this.panel1.Controls.Add(this.bt_AddOrderOk);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_note);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_month);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_amount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_pid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_uid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 403);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "元";
            // 
            // bt_ResetOrder
            // 
            this.bt_ResetOrder.Location = new System.Drawing.Point(377, 314);
            this.bt_ResetOrder.Name = "bt_ResetOrder";
            this.bt_ResetOrder.Size = new System.Drawing.Size(100, 42);
            this.bt_ResetOrder.TabIndex = 28;
            this.bt_ResetOrder.Text = "重置";
            this.bt_ResetOrder.UseVisualStyleBackColor = true;
            this.bt_ResetOrder.Click += new System.EventHandler(this.bt_ResetOrder_Click);
            // 
            // bt_AddOrderOk
            // 
            this.bt_AddOrderOk.Location = new System.Drawing.Point(197, 314);
            this.bt_AddOrderOk.Name = "bt_AddOrderOk";
            this.bt_AddOrderOk.Size = new System.Drawing.Size(100, 42);
            this.bt_AddOrderOk.TabIndex = 27;
            this.bt_AddOrderOk.Text = "确认";
            this.bt_AddOrderOk.UseVisualStyleBackColor = true;
            this.bt_AddOrderOk.Click += new System.EventHandler(this.bt_AddOrderOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "备    注";
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(471, 214);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(118, 28);
            this.tb_note.TabIndex = 25;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(179, 214);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(118, 28);
            this.tb_price.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "订阅金额";
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(471, 127);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(118, 28);
            this.tb_month.TabIndex = 22;
            this.tb_month.TextChanged += new System.EventHandler(this.tb_month_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "订阅期数";
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(179, 127);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(118, 28);
            this.tb_amount.TabIndex = 20;
            this.tb_amount.TextChanged += new System.EventHandler(this.tb_amount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "报刊份数";
            // 
            // tb_pid
            // 
            this.tb_pid.Location = new System.Drawing.Point(471, 46);
            this.tb_pid.Name = "tb_pid";
            this.tb_pid.Size = new System.Drawing.Size(118, 28);
            this.tb_pid.TabIndex = 18;
            this.tb_pid.TextChanged += new System.EventHandler(this.tb_pid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "报刊编号";
            // 
            // tb_uid
            // 
            this.tb_uid.Location = new System.Drawing.Point(179, 46);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(118, 28);
            this.tb_uid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "工   号";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 403);
            this.Controls.Add(this.panel1);
            this.Name = "AddOrder";
            this.Text = "订阅报刊";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_ResetOrder;
        private System.Windows.Forms.Button bt_AddOrderOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_uid;
        private System.Windows.Forms.Label label1;
    }
}