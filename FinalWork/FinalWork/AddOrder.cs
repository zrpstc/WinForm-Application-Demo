using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork
{
    public partial class AddOrder : NForm
    {
        //用户登录名和权限
        string name;
        int power;
        //订阅者工号
        int Uid;
        SqlCon sqlcon = new SqlCon();
        DataTable dt = new DataTable();
        Order order= new Order();
        int p_id;
        int p_amount;
        int p_month;
        decimal price = 0;
        decimal total_price;
        SqlParameter[] paras_order =
        {
            new SqlParameter("@u_id", SqlDbType.Int),
            new SqlParameter("@p_id", SqlDbType.Int),
            new SqlParameter("@o_amount", SqlDbType.Int),
            new SqlParameter("@o_month", SqlDbType.Int),
            new SqlParameter("@o_price", SqlDbType.Decimal),
        };

        public AddOrder()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            //如果身份是普通用户则只能添加自己工号的订阅信息
            if (power == 1)
            {
                //先获取当前用户的工号
                getUid();
                //查询订阅者表中是否有该用户信息
                sqlcon.getcon();
                SqlConnection mycon = sqlcon.getcon();
                string command = "select * from sys_customer where u_id ='" + Uid + "'";
                SqlCommand cmd = new SqlCommand(command, mycon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tb_uid.Text = Convert.ToString(Uid);
                    tb_uid.Enabled = false;
                }
                else
                {
                    bt_AddOrderOk.Enabled = false;
                    MessageBox.Show("请先在录入订阅者界面添加您的个人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmd.Dispose();
                sqlcon.con_close();
            }
        }

        public void getValue()
        {
            paras_order[0].Value = Convert.ToInt16(tb_uid.Text);
            paras_order[1].Value = Convert.ToInt16(tb_pid.Text);
            paras_order[2].Value = Convert.ToInt16(tb_amount.Text);
            paras_order[3].Value = Convert.ToInt16(tb_month.Text);
            paras_order[4].Value = Convert.ToDecimal(tb_price.Text);
        }

        public void getPrice()
        {
            sqlcon.getcon();
            SqlConnection mycon = sqlcon.getcon();
            string command = "select p_price from sys_paper where p_id ='" + p_id + "'";
            SqlCommand cmd = new SqlCommand(command, mycon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                price = Convert.ToDecimal(dr["p_price"]);
            }
            
            cmd.Dispose();
            sqlcon.con_close();
        }

        public void getUid()
        {
            sqlcon.getcon();
            SqlConnection mycon = sqlcon.getcon();
            string command = "select u_id from sys_user where u_name ='" + name + "'";
            SqlCommand cmd = new SqlCommand(command, mycon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Uid = Convert.ToInt16(dr["u_id"]);
            }
            cmd.Dispose();
            sqlcon.con_close();
        }

        private void bt_AddOrderOk_Click(object sender, EventArgs e)
        {
            try
            {
                getValue();
                if (sqlcon.ExecSql("order_insert", paras_order) > 0)
                {
                    MessageBox.Show("订阅信息添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("订阅信息添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("请输入信息，文本框不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.con_close();
                this.Hide();
            }
        }

        private void bt_ResetOrder_Click(object sender, EventArgs e)
        {
            tb_pid.Clear();
            tb_uid.Clear();
            tb_price.Clear();
            tb_note.Clear();
            tb_month.Clear();
            tb_amount.Clear();
        }

        private void tb_month_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p_month = Convert.ToInt16(tb_month.Text);
                getPrice();

                total_price = p_month * p_amount * price;
                tb_price.Text = Convert.ToString(total_price);
            }
            catch
            {
            }
        }

        private void tb_pid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p_id = Convert.ToInt16(tb_pid.Text);
            }
            catch
            {
            }
        }

        private void tb_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p_amount = Convert.ToInt16(tb_amount.Text);
            }
            catch
            {
            }
        }

        public void saveInfo(string name,int power)
        {
            this.name = name;
            this.power = power;
        }
    }
}
