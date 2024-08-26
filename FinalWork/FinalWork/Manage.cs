using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INI;
using System.Data.SqlClient;
using System.Threading;

namespace FinalWork
{
    public delegate void ManageToOrderMessage(string username, int power);
    public partial class Manage : NForm
    {
        DbConn dbc = new DbConn();
        //保存当前登录用户信息的类
        User curuser = new User();
        SqlCon MyConn = new SqlCon();
        DataTable dt = new DataTable();
        Class_INI ini = new Class_INI("AccountPassword");
        SqlParameter[] paras_user =
        {
            new SqlParameter("@name", SqlDbType.VarChar, 50),
            new SqlParameter("@newname", SqlDbType.VarChar, 50),
            new SqlParameter("@newpassword", SqlDbType.VarChar, 50),
        };
        SqlParameter[] paras_selectorder =
        {
            new SqlParameter("@u_id", SqlDbType.Int),
            new SqlParameter("@p_name", SqlDbType.VarChar, 50),
            new SqlParameter("@d_id", SqlDbType.Int),
        };
        SqlParameter[] paras_power =
        {
            new SqlParameter("@u_id", SqlDbType.Int),
            new SqlParameter("@u_power", SqlDbType.Int),
        };

        public event ManageToOrderMessage mtom_event;


        public Manage()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);

            //设置下拉框的数据项
            DataTable dt = new DataTable();
            dt = MyConn.ExecSqlToDT("department_selectall");
            //绑定数据源
            cb_did.DataSource = dt;
            //下拉框获得的值字段名
            cb_did.ValueMember = "d_name";
            cb_did.SelectedIndex = -1;
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            labelShow.Text = "你好" + curuser.Name + "，欢迎使用报刊订阅系统，请浏览流程图并选择要执行的操作！";
            treeView.ExpandAll();
            //个人中心用户名和密码框默认字符
            tb_Name.Text = curuser.Name;
            tb_Pwd.Text = curuser.Password;

            //重绘标签页
            DrawTabControl drawTabControl = new DrawTabControl(tabControl);
            drawTabControl.ClearPage();

            //隐藏TabPage
            TabHide();

            //加载订阅者数据表
            LoadCustomerDGV();
            //加载登录用户的数据表
            LoadUserDGV();
            //加载报刊信息的数据表
            LoadPressDGV();
            //加载报刊信息的数据表
            LoadOrderDGV();

            powerGet();
            uidGet();
            //非管理员不能修改
            if (curuser.Power == 1)
            {
                dgv_customer.ReadOnly = true;
            }
            //非管理员不能修改
            if (curuser.Power == 1)
            {
                dgv_paper.Columns["btnModify"].ReadOnly = true;
            }
        }

        //获得当前登录用户的角色权限
        public void powerGet()
        {
            string sql = "select u_power from sys_user where u_name ='" + curuser.Name + "'";
            SqlConnection conn = MyConn.getcon();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            //重要
            dr.Read();
            curuser.Power = Convert.ToInt16(dr["u_power"]);
        }

        //获得当前登录用户的ID
        public void uidGet()
        {
            string sql = "select u_id from sys_user where u_name ='" + curuser.Name + "'";
            //SqlConnection conn = MyConn.getcon();
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //重要
            //dr.Read();
            //curuser.Id = Convert.ToInt16(dr["u_id"]);

            DataTable dtt = dbc.GetDataReader(sql);
            curuser.Id = Convert.ToInt16(dtt.Rows[0][0]);
        }

        /// <summary>
        ///点击树形图打开标签页方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView.SelectedNode != null)
            {
                string selectedNode = this.treeView.SelectedNode.Text;
                if(selectedNode == "欢迎页")
                {
                    this.tabPage1.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage1;
                }
                else if (selectedNode == "个人中心")
                {
                    this.tabPage2.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage2;
                }
                else if (selectedNode == "权限设置")
                {
                    //如果是管理员才有权限打开此选项卡
                    if(curuser.Power == 0)
                    {
                        this.tabPage3.Parent = this.tabControl;
                        tabControl.SelectedTab = tabPage3;
                    }
                    else
                    {
                        MessageBox.Show("无法操作，非管理员用户不能进行权限设置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (selectedNode == "订阅者信息")
                {
                    this.tabPage4.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage4;

                    string sql = "select * from sys_customer where u_id ='" + curuser.Id + "'";
                    SqlConnection conn = MyConn.getcon();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //重要
                    dr.Read();
                    
                    //非管理员用户不可以删除订阅者信息
                    if (curuser.Power == 1)
                    {
                        bt_DeleteCu.Enabled = false;
                        //订阅者信息中已有当前用户信息则不可添加
                        if (dr.HasRows)
                        {
                            bt_AddCu.Enabled = false;
                        }
                    }
                }
                else if (selectedNode == "报刊信息")
                {
                    this.tabPage5.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage5;
                    //非管理员无权限修改此选项卡信息，只能读取
                    if (curuser.Power == 1)
                    {
                        bt_DeletePaper.Enabled = false;
                        bt_AddPress.Enabled = false;
                        MessageBox.Show("无法操作，请联系管理员添加报刊信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (selectedNode == "订阅报刊")
                {
                    this.tabPage6.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage6;

                    //非管理员不可删除订阅信息
                    if (curuser.Power == 1)
                    {
                        bt_DeleteOrder.Enabled = false;
                    }
                }
                else if (selectedNode == "信息查询")
                {
                    this.tabPage7.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage7;
                }
                else if (selectedNode == "数据统计")
                {
                    this.tabPage8.Parent = this.tabControl;
                    tabControl.SelectedTab = tabPage8;
                }
            }
        }

        //重新返回登录界面按钮
        private void buttonReLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login relogin = new Login();
            relogin.Show();

            //清除自动登录配置文件中的内容
            ini.FileExists(ini.path);
            ini.WriteIniKey("autoLogin", "sp_user", null);
        }

        /// <summary>
        /// 4.定义事件响应方法
        /// </summary>
        /// <param name="username">Login界面传递的用户名字符</param>
        /// <param name="password">Login界面传递的用户密码字符</param>
        /// <param name="power">Login界面传递的用户权限字符</param>
        public void SaveInfoToUser(string username, string password, int power)
        {
            curuser.Name = username;
            curuser.Password = password;
            curuser.Power = power;
        }

        //加载订阅者新消息的数据表
        public void LoadCustomerDGV()
        {
            DataSet ds_customer = new DataSet();
            ds_customer = MyConn.ExecViewToDS("customer");
            dgv_customer.DataSource = ds_customer.Tables[0];
            dgv_customer.Refresh();

            //在DataGridView控件中添加Button
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnModify";
            btn.HeaderText = "操作";
            btn.DefaultCellStyle.NullValue = "修改";
            dgv_customer.Columns.Add(btn);
        }

        //加载登录用户的数据表
        public void LoadUserDGV()
        {
            DataSet ds_user = new DataSet();
            ds_user = MyConn.ExecViewToDS("usertable");
            dgv_user.DataSource = ds_user.Tables[0];

            //在DataGridView控件中添加Button
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnModify";
            btn.HeaderText = "操作";
            btn.DefaultCellStyle.NullValue = "修改权限";
            dgv_user.Columns.Add(btn);
        }

        //加载报刊信息的数据表
        public void LoadPressDGV()
        {
            DataSet ds_paper = new DataSet();
            ds_paper = MyConn.ExecViewToDS("paper");
            dgv_paper.DataSource = ds_paper.Tables[0];
            dgv_paper.Refresh();

            //在DataGridView控件中添加Button
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnModify";
            btn.HeaderText = "操作";
            btn.DefaultCellStyle.NullValue = "修改";
            dgv_paper.Columns.Add(btn);
        }

        //加载订阅信息的数据表
        public void LoadOrderDGV()
        {
            DataSet ds_order = new DataSet();
            ds_order = MyConn.ExecViewToDS("ordertable");
            dgv_order.DataSource = ds_order.Tables[0];
            dgv_order.Refresh();
        }

        /// <summary>
        /// 隐藏标签页
        /// </summary>
        public void TabHide()
        {
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
            tabPage5.Parent = null;
            tabPage6.Parent = null;
            tabPage7.Parent = null;
            tabPage8.Parent = null;
        }

        const int CLOSEBUTTON_SIZE = 10;

        /// <summary>
        /// 绘制标签页关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                //获取当前Tab选项卡的绘图区域
                Rectangle myTabRect = this.tabControl.GetTabRect(e.Index);
                //设置笔刷
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                //居中显示
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;

                //绘制标签页背景颜色
                e.Graphics.FillRectangle(white, myTabRect);
                //设置选中的标签页背景颜色
                using (Brush selectColor = new SolidBrush(Color.SeaShell))
                {
                    if (e.Index == this.tabControl.SelectedIndex)
                    {
                        e.Graphics.FillRectangle(selectColor, myTabRect);
                    }
                }
                //绘制标签页文本
                e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, new Font("微软雅黑", 10), black, myTabRect, stringFormat);

                //画关闭标志的矩形框
                using (Pen p = new Pen(Color.White))
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSEBUTTON_SIZE + 3), 2);
                    myTabRect.Width = CLOSEBUTTON_SIZE;
                    myTabRect.Height = CLOSEBUTTON_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                //填充关闭按钮矩形框颜色
                Color recolor = e.State == DrawItemState.Selected ? Color.Red : Color.White;
                using (Brush b = new SolidBrush(recolor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }

                //画关闭符号
                using (Pen objpen = new Pen(Color.Black))
                {
                    //画X
                    Point p1 = new Point(myTabRect.X + 3, myTabRect.Y + 3);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + myTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);

                    Point p3 = new Point(myTabRect.X + 3, myTabRect.Y + myTabRect.Height - 3);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);
                    //Bitmap bt = new Bitmap(inage);
                    //获取绘图区域的开始坐标位置
                    //Point p5 = new Point(myTabRect.X, 4);
                    //e.Graphics.DrawImage(bt_change, p5);
                    //e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, Font, objpen.Brush, p5);
                }
                e.Graphics.Dispose();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 点击关闭按钮关闭选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //获得关闭按钮的区域
                //存在打开的
                if (tabControl.TabPages.Count > 0)
                {
                    Rectangle myTabRect = this.tabControl.GetTabRect(this.tabControl.SelectedIndex);

                    myTabRect.Offset(myTabRect.Width - (CLOSEBUTTON_SIZE + 3), 2);
                    myTabRect.Width = CLOSEBUTTON_SIZE;
                    myTabRect.Height = CLOSEBUTTON_SIZE;
                    //如果鼠标在关闭按钮范围之内则关闭选项卡
                    bool isclose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                    if (isclose == true)
                    {
                        this.tabControl.TabPages.Remove(this.tabControl.SelectedTab);
                    }
                }
            }
        }

        /// <summary>
        /// 双击标签页移除选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }


        //密码重置按钮
        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_Pwd.Clear();
            tb_RePwd.Clear();
        }

        //修改密码按钮
        private void bt_change_Click(object sender, EventArgs e)
        {
            string name = curuser.Name; 
            string newname = tb_Name.Text;
            string newpassword = tb_Pwd.Text;
            paras_user[0].Value = name;
            paras_user[1].Value = newname;
            paras_user[2].Value = newpassword;
            if (tb_Pwd.Text != "" || tb_RePwd.Text != "")
            {
                if (tb_Pwd.Text != tb_RePwd.Text)
                {
                    MessageBox.Show("两次密码不一致，请检查！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MyConn.ExecSql("sysuser_alter", paras_user) > 0)
                    {
                        MessageBox.Show("登录信息修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login relogin = new Login();
                        relogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("登录信息修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("修改密码不允许为空，请检查！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //添加订阅者信息按钮
        private void bt_AddCu_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.TopLevel = true;
            addcustomer.Show();
        }

        //添加报刊信息按钮
        private void bt_AddPress_Click(object sender, EventArgs e)
        {
            AddPress addpress = new AddPress();
            addpress.TopLevel = true;
            addpress.Show();
        }

        //删除订阅者信息按钮
        private void bt_DeleteCu_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            //将数据表中的学号一列数据转换成int类型匹配数据库对象
            int a = dgv_customer.CurrentRow.Index;
            customer.Id = dgv_customer.Rows[a].Cells[1].Value.ToString();
            int u_id = Convert.ToInt16(customer.Id);
            string command = "delete from sys_customer where u_id ='" + u_id + "'";

            DialogResult res = MessageBox.Show("确定要删除列表中所选的一行吗？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)  //按确定才进行下一步删除
            {
                if (dgv_customer.Rows.Count >= 1)//判断是否是非空的表，防止报错
                {
                    dgv_customer.Rows.Remove(dgv_customer.CurrentRow);
                    dgv_customer.Refresh();

                    if (MyConn.ExecSqlReturnNum(command) > 0)
                    {
                        MessageBox.Show("删除成功！");
                    }
                }
            }
        }

        //删除报刊信息按钮
        private void bt_DeletePaper_Click(object sender, EventArgs e)
        {
            Paper paper = new Paper();
            //将数据表中的学号一列数据转换成int类型匹配数据库对象
            int a = dgv_paper.CurrentRow.Index;
            paper.Id = Convert.ToInt16(dgv_paper.Rows[a].Cells[1].Value.ToString());
            string command = "delete from sys_paper where p_id ='" + paper.Id + "'";

            DialogResult res = MessageBox.Show("确定要删除列表中所选的一行吗？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)  //按确定才进行下一步删除
            {
                if (dgv_paper.Rows.Count >= 1)//判断是否是非空的表，防止报错
                {
                    dgv_paper.Rows.Remove(dgv_paper.CurrentRow);
                    dgv_paper.Refresh();

                    if (MyConn.ExecSqlReturnNum(command) > 0)
                    {
                        MessageBox.Show("删除成功！");
                    }
                }
            }
        }

        //添加订阅信息按钮
        private void bt_AddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addorder = new AddOrder();

            //给添加订阅者窗口传递参数
            mtom_event += new ManageToOrderMessage(addorder.saveInfo);
            mtom_event(curuser.Name, curuser.Power);

            addorder.TopLevel = true;
            addorder.Show();
        }

        //删除订阅信息按钮
        private void bt_DeleteOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            //将数据表中的学号一列数据转换成int类型匹配数据库对象
            int a = dgv_order.CurrentRow.Index;
            order.Id = Convert.ToInt16(dgv_order.Rows[a].Cells[0].Value.ToString());
            string command = "delete from sys_order where o_id ='" + order.Id + "'";

            DialogResult res = MessageBox.Show("确定要删除列表中所选的一行吗？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)  //按确定才进行下一步删除
            {
                if (dgv_order.Rows.Count >= 1)//判断是否是非空的表，防止报错
                {
                    dgv_order.Rows.Remove(dgv_order.CurrentRow);
                    dgv_order.Refresh();

                    if (MyConn.ExecSqlReturnNum(command) > 0)
                    {
                        MessageBox.Show("删除成功！");
                    }
                }
            }
        }

        //刷新用户数据按钮
        private void bt_RsUser_Click(object sender, EventArgs e)
        {
            //LoadUserDGV();
            DataSet ds_user = new DataSet();
            ds_user = MyConn.ExecViewToDS("usertable");
            dgv_user.DataSource = ds_user.Tables[0];
        }

        //刷新订阅者信息按钮
        private void bt_ReCu_Click(object sender, EventArgs e)
        {
            //LoadCustomerDGV();
            DataSet ds_customer = new DataSet();
            ds_customer = MyConn.ExecViewToDS("customer");
            dgv_customer.DataSource = ds_customer.Tables[0];
            dgv_customer.Refresh();
        }

        //刷新报刊信息按钮
        private void bt_RePaper_Click(object sender, EventArgs e)
        {
            DataSet ds_paper = new DataSet();
            ds_paper = MyConn.ExecViewToDS("paper");
            dgv_paper.DataSource = ds_paper.Tables[0];
            dgv_paper.Refresh();
        }

        //刷新订单信息按钮
        private void bt_ReOrder_Click(object sender, EventArgs e)
        {
            LoadOrderDGV();
        }

        //查询信息按钮
        private void bt_selectinfo_Click(object sender, EventArgs e)
        {
            if(tb_uid.Text != "请输入工号")
            {
                //报错：原因是文本框输入为空时无法转换为int类型
                //paras_selectorder[0].Value = Convert.ToInt16(tb_uid.Text);
                int u_id = 0;
                int.TryParse(this.tb_uid.Text, out u_id);
                paras_selectorder[0].Value = u_id;
            }
            else
            {
                paras_selectorder[0].Value = "";
            }
            if(tb_pname.Text != "请输入报刊名")
            {
                //paras_selectorder[1].Value = Convert.ToString(tb_pname.Text);
                //模糊查询语句传入参数格式 %str%
                paras_selectorder[1].Value = Convert.ToString("%" + tb_pname.Text + "%");
            }
            else
            {
                paras_selectorder[1].Value = "";
            }
            if(cb_did.SelectedText != null)
            {
                //只提供部门编号无法查询订阅信息，因为订票系统表中只保存了工号信息
                //根据工号才能找到所属部门
                paras_selectorder[2].Value = cb_did.SelectedIndex + 1;
            }
            else
            {
                paras_selectorder[2].Value = "";
            }
            try
            {
                DataSet ds = new DataSet();
                ds = MyConn.ExecSqlToDS("order_likeselect", paras_selectorder);
                dgv_SelectRes.DataSource = ds.Tables[0];
                dgv_SelectRes.Refresh();
            }
            catch
            {
            }
        }

        //打印和预览信息按钮
        private void bt_printinfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("提交完成，是否打印", "【温馨提示】", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                PrintDataGridView.Print(dgv_SelectRes, "查询结果", "");
            }
        }

        //统计数据按钮
        private void bt_analyze_Click(object sender, EventArgs e)
        {
            if(cb_way.Text == "按报刊统计")
            {
                DataSet ds = new DataSet();
                ds = MyConn.ExecSqlToDS("analyzeByPaper");
                dgv_AnalyzeRes.DataSource = ds.Tables[0];
                dgv_AnalyzeRes.Refresh();
            }
            else if (cb_way.Text == "按人员统计")
            {
                DataSet ds = new DataSet();
                ds = MyConn.ExecSqlToDS("analyzeByCustomer");
                dgv_AnalyzeRes.DataSource = ds.Tables[0];
                dgv_AnalyzeRes.Refresh();
            }
            else if (cb_way.Text == "按部门统计")
            {
                DataSet ds = new DataSet();
                ds = MyConn.ExecSqlToDS("analyzeByDepartment");
                dgv_AnalyzeRes.DataSource = ds.Tables[0];
                dgv_AnalyzeRes.Refresh();
            }
        }

        //打印和预览统计数据按钮
        private void bt_printAyze_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("提交完成，是否打印", "【温馨提示】", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                PrintDataGridView.Print(dgv_AnalyzeRes, "统计结果", "");
            }
        }

        //报刊数据DGV的修改按钮
        private void dgv_paper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是管理员用户才会弹出修改面板
            if (dgv_paper.Columns[e.ColumnIndex].Name == "btnModify" && e.RowIndex >= 0 && curuser.Power == 0)
            {
                DataGridViewColumn column = dgv_paper.Columns[e.ColumnIndex];
                AlterPaper alterpaper = new AlterPaper();
                alterpaper.Show();
                int id = Convert.ToInt16(dgv_paper.CurrentRow.Cells[1].Value);
                alterpaper.WriteValue(id);
            }
        }

        //用户数据DGV的修改按钮
        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_user.Columns[e.ColumnIndex].Name == "btnModify" && e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv_user.Columns[e.ColumnIndex];
                int id = Convert.ToInt16(dgv_user.CurrentRow.Cells[1].Value);
                int alterpower;
                if(dgv_user.CurrentRow.Cells[4].Value.ToString()  == "管理员")
                {
                    alterpower = 1;
                }
                else
                {
                    alterpower = 0;
                }
                paras_power[0].Value = id;
                paras_power[1].Value = alterpower;
                if (MyConn.ExecSql("power_alter", paras_power) > 0)
                {
                    MessageBox.Show("用户权限修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户权限修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //订阅者数据DGV的修改按钮
        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是管理员用户才会弹出修改面板  && curuser.Power == 0
            if (dgv_customer.Columns[e.ColumnIndex].Name == "btnModify" && e.RowIndex >= 0 && curuser.Power == 0)
            {
                DataGridViewColumn column = dgv_customer.Columns[e.ColumnIndex];
                AlterCustomer altercustomer = new AlterCustomer();
                altercustomer.Show();
                int id = Convert.ToInt16(dgv_customer.CurrentRow.Cells[1].Value);
                altercustomer.WriteValue(id);
            }
        }
    }
}
