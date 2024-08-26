namespace FinalWork
{
    partial class AddPress
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
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_addOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_public = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rtb_content);
            this.panel1.Controls.Add(this.cb_date);
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.bt_addOK);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_public);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 489);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "元";
            // 
            // rtb_content
            // 
            this.rtb_content.Location = new System.Drawing.Point(188, 253);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(423, 137);
            this.rtb_content.TabIndex = 30;
            this.rtb_content.Text = "";
            // 
            // cb_date
            // 
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Items.AddRange(new object[] {
            "日报（1天）",
            "周报（7天）",
            "旬刊（10天）",
            "半月刊（15天）",
            "月刊（30天）",
            "双月刊（60天）",
            "季刊（3个月）",
            "半年刊（6个月）",
            "年刊（12个月）"});
            this.cb_date.Location = new System.Drawing.Point(462, 103);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(172, 26);
            this.cb_date.TabIndex = 29;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(439, 413);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(100, 42);
            this.bt_clear.TabIndex = 28;
            this.bt_clear.Text = "重置";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_addOK
            // 
            this.bt_addOK.Location = new System.Drawing.Point(216, 413);
            this.bt_addOK.Name = "bt_addOK";
            this.bt_addOK.Size = new System.Drawing.Size(100, 42);
            this.bt_addOK.TabIndex = 27;
            this.bt_addOK.Text = "确认";
            this.bt_addOK.UseVisualStyleBackColor = true;
            this.bt_addOK.Click += new System.EventHandler(this.bt_addOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "报刊摘要";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(188, 178);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(128, 28);
            this.tb_price.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "每期报价";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(462, 33);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(172, 26);
            this.cb_category.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "报刊类别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "出版周期";
            // 
            // tb_public
            // 
            this.tb_public.Location = new System.Drawing.Point(188, 103);
            this.tb_public.Name = "tb_public";
            this.tb_public.Size = new System.Drawing.Size(128, 28);
            this.tb_public.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "出版社";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(188, 33);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(128, 28);
            this.tb_name.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "报刊名";
            // 
            // AddPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 489);
            this.Controls.Add(this.panel1);
            this.Name = "AddPress";
            this.Text = "添加报刊信息";
            this.Load += new System.EventHandler(this.AddPress_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_addOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_public;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
    }
}