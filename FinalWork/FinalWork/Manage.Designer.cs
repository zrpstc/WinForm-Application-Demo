namespace FinalWork
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("个人中心");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("权限设置");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("订阅者信息");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("报刊信息");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("信息录入", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("订阅报刊");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("信息查询");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("数据统计");
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.buttonReLogin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_RePwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_RsUser = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bt_ReCu = new System.Windows.Forms.Button();
            this.bt_DeleteCu = new System.Windows.Forms.Button();
            this.bt_AddCu = new System.Windows.Forms.Button();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bt_RePaper = new System.Windows.Forms.Button();
            this.bt_DeletePaper = new System.Windows.Forms.Button();
            this.bt_AddPress = new System.Windows.Forms.Button();
            this.dgv_paper = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.bt_ReOrder = new System.Windows.Forms.Button();
            this.bt_DeleteOrder = new System.Windows.Forms.Button();
            this.bt_AddOrder = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tb_pname = new System.Windows.Forms.TextBox();
            this.bt_printInfo = new System.Windows.Forms.Button();
            this.bt_selectinfo = new System.Windows.Forms.Button();
            this.cb_did = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_uid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_SelectRes = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgv_AnalyzeRes = new System.Windows.Forms.DataGridView();
            this.bt_printAyze = new System.Windows.Forms.Button();
            this.bt_analyze = new System.Windows.Forms.Button();
            this.cb_way = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paper)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectRes)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AnalyzeRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelShow);
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 648);
            this.panel1.TabIndex = 0;
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelShow.Controls.Add(this.tabControl);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(170, 91);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(852, 557);
            this.panelShow.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(852, 557);
            this.tabControl.TabIndex = 2;
            this.tabControl.Tag = "";
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDoubleClick);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.labelShow);
            this.tabPage1.Controls.Add(this.buttonReLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "欢迎页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShow.Location = new System.Drawing.Point(16, 19);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(63, 24);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "label1";
            // 
            // buttonReLogin
            // 
            this.buttonReLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReLogin.Location = new System.Drawing.Point(697, 10);
            this.buttonReLogin.Name = "buttonReLogin";
            this.buttonReLogin.Size = new System.Drawing.Size(126, 43);
            this.buttonReLogin.TabIndex = 1;
            this.buttonReLogin.Text = "返回登录";
            this.buttonReLogin.UseVisualStyleBackColor = true;
            this.buttonReLogin.Click += new System.EventHandler(this.buttonReLogin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_RePwd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_Pwd);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bt_reset);
            this.tabPage2.Controls.Add(this.bt_change);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_Name);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "个人中心";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_RePwd
            // 
            this.tb_RePwd.Location = new System.Drawing.Point(380, 230);
            this.tb_RePwd.Name = "tb_RePwd";
            this.tb_RePwd.Size = new System.Drawing.Size(156, 28);
            this.tb_RePwd.TabIndex = 31;
            this.tb_RePwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "确认密码";
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.Location = new System.Drawing.Point(380, 151);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(156, 28);
            this.tb_Pwd.TabIndex = 29;
            this.tb_Pwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "修改密码";
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(435, 335);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(135, 65);
            this.bt_reset.TabIndex = 27;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_change
            // 
            this.bt_change.Location = new System.Drawing.Point(267, 335);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(136, 65);
            this.bt_change.TabIndex = 26;
            this.bt_change.Text = "确认修改";
            this.bt_change.UseVisualStyleBackColor = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "用户名";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(380, 79);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(156, 28);
            this.tb_Name.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_RsUser);
            this.tabPage3.Controls.Add(this.dgv_user);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(844, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "权限设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_RsUser
            // 
            this.bt_RsUser.Location = new System.Drawing.Point(6, 22);
            this.bt_RsUser.Name = "bt_RsUser";
            this.bt_RsUser.Size = new System.Drawing.Size(112, 42);
            this.bt_RsUser.TabIndex = 2;
            this.bt_RsUser.Text = "刷新数据";
            this.bt_RsUser.UseVisualStyleBackColor = true;
            this.bt_RsUser.Click += new System.EventHandler(this.bt_RsUser_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_user.Location = new System.Drawing.Point(3, 87);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowTemplate.Height = 30;
            this.dgv_user.Size = new System.Drawing.Size(838, 435);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bt_ReCu);
            this.tabPage4.Controls.Add(this.bt_DeleteCu);
            this.tabPage4.Controls.Add(this.bt_AddCu);
            this.tabPage4.Controls.Add(this.dgv_customer);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(844, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "订阅者信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bt_ReCu
            // 
            this.bt_ReCu.Location = new System.Drawing.Point(296, 16);
            this.bt_ReCu.Name = "bt_ReCu";
            this.bt_ReCu.Size = new System.Drawing.Size(112, 42);
            this.bt_ReCu.TabIndex = 3;
            this.bt_ReCu.Text = "刷新数据";
            this.bt_ReCu.UseVisualStyleBackColor = true;
            this.bt_ReCu.Click += new System.EventHandler(this.bt_ReCu_Click);
            // 
            // bt_DeleteCu
            // 
            this.bt_DeleteCu.Location = new System.Drawing.Point(150, 16);
            this.bt_DeleteCu.Name = "bt_DeleteCu";
            this.bt_DeleteCu.Size = new System.Drawing.Size(112, 42);
            this.bt_DeleteCu.TabIndex = 2;
            this.bt_DeleteCu.Text = "删除订阅者";
            this.bt_DeleteCu.UseVisualStyleBackColor = true;
            this.bt_DeleteCu.Click += new System.EventHandler(this.bt_DeleteCu_Click);
            // 
            // bt_AddCu
            // 
            this.bt_AddCu.Location = new System.Drawing.Point(6, 16);
            this.bt_AddCu.Name = "bt_AddCu";
            this.bt_AddCu.Size = new System.Drawing.Size(112, 42);
            this.bt_AddCu.TabIndex = 1;
            this.bt_AddCu.Text = "添加订阅者";
            this.bt_AddCu.UseVisualStyleBackColor = true;
            this.bt_AddCu.Click += new System.EventHandler(this.bt_AddCu_Click);
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_customer.Location = new System.Drawing.Point(3, 87);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowTemplate.Height = 30;
            this.dgv_customer.Size = new System.Drawing.Size(838, 435);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bt_RePaper);
            this.tabPage5.Controls.Add(this.bt_DeletePaper);
            this.tabPage5.Controls.Add(this.bt_AddPress);
            this.tabPage5.Controls.Add(this.dgv_paper);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(844, 525);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "报刊信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bt_RePaper
            // 
            this.bt_RePaper.Location = new System.Drawing.Point(337, 17);
            this.bt_RePaper.Name = "bt_RePaper";
            this.bt_RePaper.Size = new System.Drawing.Size(138, 42);
            this.bt_RePaper.TabIndex = 3;
            this.bt_RePaper.Text = "刷新数据";
            this.bt_RePaper.UseVisualStyleBackColor = true;
            this.bt_RePaper.Click += new System.EventHandler(this.bt_RePaper_Click);
            // 
            // bt_DeletePaper
            // 
            this.bt_DeletePaper.Location = new System.Drawing.Point(172, 17);
            this.bt_DeletePaper.Name = "bt_DeletePaper";
            this.bt_DeletePaper.Size = new System.Drawing.Size(138, 42);
            this.bt_DeletePaper.TabIndex = 2;
            this.bt_DeletePaper.Text = "删除报刊信息";
            this.bt_DeletePaper.UseVisualStyleBackColor = true;
            this.bt_DeletePaper.Click += new System.EventHandler(this.bt_DeletePaper_Click);
            // 
            // bt_AddPress
            // 
            this.bt_AddPress.Location = new System.Drawing.Point(6, 17);
            this.bt_AddPress.Name = "bt_AddPress";
            this.bt_AddPress.Size = new System.Drawing.Size(138, 42);
            this.bt_AddPress.TabIndex = 1;
            this.bt_AddPress.Text = "添加报刊信息";
            this.bt_AddPress.UseVisualStyleBackColor = true;
            this.bt_AddPress.Click += new System.EventHandler(this.bt_AddPress_Click);
            // 
            // dgv_paper
            // 
            this.dgv_paper.AllowUserToAddRows = false;
            this.dgv_paper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_paper.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_paper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_paper.Location = new System.Drawing.Point(3, 87);
            this.dgv_paper.Name = "dgv_paper";
            this.dgv_paper.RowTemplate.Height = 30;
            this.dgv_paper.Size = new System.Drawing.Size(838, 435);
            this.dgv_paper.TabIndex = 0;
            this.dgv_paper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_paper_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.bt_ReOrder);
            this.tabPage6.Controls.Add(this.bt_DeleteOrder);
            this.tabPage6.Controls.Add(this.bt_AddOrder);
            this.tabPage6.Controls.Add(this.dgv_order);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(844, 525);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "订阅报刊";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // bt_ReOrder
            // 
            this.bt_ReOrder.Location = new System.Drawing.Point(283, 21);
            this.bt_ReOrder.Name = "bt_ReOrder";
            this.bt_ReOrder.Size = new System.Drawing.Size(112, 42);
            this.bt_ReOrder.TabIndex = 3;
            this.bt_ReOrder.Text = "刷新数据";
            this.bt_ReOrder.UseVisualStyleBackColor = true;
            this.bt_ReOrder.Click += new System.EventHandler(this.bt_ReOrder_Click);
            // 
            // bt_DeleteOrder
            // 
            this.bt_DeleteOrder.Location = new System.Drawing.Point(144, 21);
            this.bt_DeleteOrder.Name = "bt_DeleteOrder";
            this.bt_DeleteOrder.Size = new System.Drawing.Size(112, 42);
            this.bt_DeleteOrder.TabIndex = 2;
            this.bt_DeleteOrder.Text = "删除订阅";
            this.bt_DeleteOrder.UseVisualStyleBackColor = true;
            this.bt_DeleteOrder.Click += new System.EventHandler(this.bt_DeleteOrder_Click);
            // 
            // bt_AddOrder
            // 
            this.bt_AddOrder.Location = new System.Drawing.Point(6, 21);
            this.bt_AddOrder.Name = "bt_AddOrder";
            this.bt_AddOrder.Size = new System.Drawing.Size(112, 42);
            this.bt_AddOrder.TabIndex = 1;
            this.bt_AddOrder.Text = "添加订阅";
            this.bt_AddOrder.UseVisualStyleBackColor = true;
            this.bt_AddOrder.Click += new System.EventHandler(this.bt_AddOrder_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_order.Location = new System.Drawing.Point(3, 87);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowTemplate.Height = 30;
            this.dgv_order.Size = new System.Drawing.Size(838, 435);
            this.dgv_order.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tb_pname);
            this.tabPage7.Controls.Add(this.bt_printInfo);
            this.tabPage7.Controls.Add(this.bt_selectinfo);
            this.tabPage7.Controls.Add(this.cb_did);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.tb_uid);
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.dgv_SelectRes);
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(844, 525);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "信息查询";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tb_pname
            // 
            this.tb_pname.Location = new System.Drawing.Point(378, 44);
            this.tb_pname.Name = "tb_pname";
            this.tb_pname.Size = new System.Drawing.Size(121, 28);
            this.tb_pname.TabIndex = 10;
            this.tb_pname.Text = "请输入报刊名";
            // 
            // bt_printInfo
            // 
            this.bt_printInfo.Location = new System.Drawing.Point(198, 111);
            this.bt_printInfo.Name = "bt_printInfo";
            this.bt_printInfo.Size = new System.Drawing.Size(112, 42);
            this.bt_printInfo.TabIndex = 9;
            this.bt_printInfo.Text = "预览打印";
            this.bt_printInfo.UseVisualStyleBackColor = true;
            this.bt_printInfo.Click += new System.EventHandler(this.bt_printinfo_Click);
            // 
            // bt_selectinfo
            // 
            this.bt_selectinfo.Location = new System.Drawing.Point(38, 111);
            this.bt_selectinfo.Name = "bt_selectinfo";
            this.bt_selectinfo.Size = new System.Drawing.Size(112, 42);
            this.bt_selectinfo.TabIndex = 7;
            this.bt_selectinfo.Text = "查询结果";
            this.bt_selectinfo.UseVisualStyleBackColor = true;
            this.bt_selectinfo.Click += new System.EventHandler(this.bt_selectinfo_Click);
            // 
            // cb_did
            // 
            this.cb_did.FormattingEnabled = true;
            this.cb_did.Location = new System.Drawing.Point(625, 44);
            this.cb_did.Name = "cb_did";
            this.cb_did.Size = new System.Drawing.Size(121, 26);
            this.cb_did.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "报刊名";
            // 
            // tb_uid
            // 
            this.tb_uid.Location = new System.Drawing.Point(121, 44);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(121, 28);
            this.tb_uid.TabIndex = 2;
            this.tb_uid.Text = "请输入工号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "订阅人员";
            // 
            // dgv_SelectRes
            // 
            this.dgv_SelectRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SelectRes.Location = new System.Drawing.Point(3, 202);
            this.dgv_SelectRes.Name = "dgv_SelectRes";
            this.dgv_SelectRes.RowTemplate.Height = 30;
            this.dgv_SelectRes.Size = new System.Drawing.Size(838, 320);
            this.dgv_SelectRes.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgv_AnalyzeRes);
            this.tabPage8.Controls.Add(this.bt_printAyze);
            this.tabPage8.Controls.Add(this.bt_analyze);
            this.tabPage8.Controls.Add(this.cb_way);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(844, 525);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "数据统计";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgv_AnalyzeRes
            // 
            this.dgv_AnalyzeRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AnalyzeRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_AnalyzeRes.Location = new System.Drawing.Point(3, 202);
            this.dgv_AnalyzeRes.Name = "dgv_AnalyzeRes";
            this.dgv_AnalyzeRes.RowTemplate.Height = 30;
            this.dgv_AnalyzeRes.Size = new System.Drawing.Size(838, 320);
            this.dgv_AnalyzeRes.TabIndex = 19;
            // 
            // bt_printAyze
            // 
            this.bt_printAyze.Location = new System.Drawing.Point(198, 111);
            this.bt_printAyze.Name = "bt_printAyze";
            this.bt_printAyze.Size = new System.Drawing.Size(112, 42);
            this.bt_printAyze.TabIndex = 17;
            this.bt_printAyze.Text = "预览打印";
            this.bt_printAyze.UseVisualStyleBackColor = true;
            this.bt_printAyze.Click += new System.EventHandler(this.bt_printAyze_Click);
            // 
            // bt_analyze
            // 
            this.bt_analyze.Location = new System.Drawing.Point(38, 111);
            this.bt_analyze.Name = "bt_analyze";
            this.bt_analyze.Size = new System.Drawing.Size(112, 42);
            this.bt_analyze.TabIndex = 16;
            this.bt_analyze.Text = "结果统计";
            this.bt_analyze.UseVisualStyleBackColor = true;
            this.bt_analyze.Click += new System.EventHandler(this.bt_analyze_Click);
            // 
            // cb_way
            // 
            this.cb_way.FormattingEnabled = true;
            this.cb_way.Items.AddRange(new object[] {
            "按报刊统计",
            "按人员统计",
            "按部门统计"});
            this.cb_way.Location = new System.Drawing.Point(121, 41);
            this.cb_way.Name = "cb_way";
            this.cb_way.Size = new System.Drawing.Size(189, 26);
            this.cb_way.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "统计方式";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FloralWhite;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.Location = new System.Drawing.Point(0, 91);
            this.treeView.Name = "treeView";
            treeNode1.Name = "节点0";
            treeNode1.Text = "个人中心";
            treeNode2.Name = "节点1";
            treeNode2.Text = "权限设置";
            treeNode3.Name = "节点1";
            treeNode3.Text = "信息管理";
            treeNode4.Name = "节点0";
            treeNode4.Text = "订阅者信息";
            treeNode5.Name = "节点3";
            treeNode5.Text = "报刊信息";
            treeNode6.Name = "节点2";
            treeNode6.Text = "信息录入";
            treeNode7.Name = "节点3";
            treeNode7.Text = "订阅报刊";
            treeNode8.Name = "节点4";
            treeNode8.Text = "信息查询";
            treeNode9.Name = "节点5";
            treeNode9.Text = "数据统计";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView.Size = new System.Drawing.Size(170, 557);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1022, 91);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.panel1);
            this.Name = "Manage";
            this.Text = "订阅系统中心";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paper)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectRes)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AnalyzeRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonReLogin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox tb_RePwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Button bt_AddCu;
        private System.Windows.Forms.Button bt_AddPress;
        private System.Windows.Forms.DataGridView dgv_paper;
        private System.Windows.Forms.Button bt_DeleteCu;
        private System.Windows.Forms.Button bt_DeletePaper;
        private System.Windows.Forms.Button bt_DeleteOrder;
        private System.Windows.Forms.Button bt_AddOrder;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Button bt_RsUser;
        private System.Windows.Forms.Button bt_ReCu;
        private System.Windows.Forms.Button bt_RePaper;
        private System.Windows.Forms.Button bt_ReOrder;
        private System.Windows.Forms.Button bt_printInfo;
        private System.Windows.Forms.Button bt_selectinfo;
        private System.Windows.Forms.ComboBox cb_did;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_uid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_SelectRes;
        private System.Windows.Forms.TextBox tb_pname;
        private System.Windows.Forms.DataGridView dgv_AnalyzeRes;
        private System.Windows.Forms.Button bt_printAyze;
        private System.Windows.Forms.Button bt_analyze;
        private System.Windows.Forms.ComboBox cb_way;
        private System.Windows.Forms.Label label7;
    }
}