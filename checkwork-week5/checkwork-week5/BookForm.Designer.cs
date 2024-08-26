namespace checkwork_week5
{
    partial class BookForm
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
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.lable8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.tb_hour = new System.Windows.Forms.TextBox();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_strattime = new System.Windows.Forms.DateTimePicker();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_reset);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.lable8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_min);
            this.panel1.Controls.Add(this.tb_hour);
            this.panel1.Controls.Add(this.tb_room);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_strattime);
            this.panel1.Controls.Add(this.tb_note);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 511);
            this.panel1.TabIndex = 0;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(358, 434);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(92, 35);
            this.bt_reset.TabIndex = 19;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(183, 434);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(92, 35);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(457, 212);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(17, 18);
            this.lable8.TabIndex = 17;
            this.lable8.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "h";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(401, 209);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(50, 28);
            this.tb_min.TabIndex = 15;
            // 
            // tb_hour
            // 
            this.tb_hour.Location = new System.Drawing.Point(317, 209);
            this.tb_hour.Name = "tb_hour";
            this.tb_hour.Size = new System.Drawing.Size(50, 28);
            this.tb_hour.TabIndex = 14;
            // 
            // tb_room
            // 
            this.tb_room.Location = new System.Drawing.Point(317, 283);
            this.tb_room.Name = "tb_room";
            this.tb_room.Size = new System.Drawing.Size(100, 28);
            this.tb_room.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "备    注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "会议室编号";
            // 
            // dtp_strattime
            // 
            this.dtp_strattime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_strattime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_strattime.Location = new System.Drawing.Point(317, 136);
            this.dtp_strattime.Name = "dtp_strattime";
            this.dtp_strattime.Size = new System.Drawing.Size(295, 28);
            this.dtp_strattime.TabIndex = 9;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(317, 352);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(100, 28);
            this.tb_note.TabIndex = 6;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(317, 69);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 28);
            this.tb_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "会议持续时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "会议开始时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "预定人姓名";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 511);
            this.Controls.Add(this.panel1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_strattime;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.TextBox tb_hour;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_add;
    }
}