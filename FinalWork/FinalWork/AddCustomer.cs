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
    public partial class AddCustomer : NForm
    {
        SqlCon sqlcon = new SqlCon();
        DataTable dt = new DataTable();
        Customer customer = new Customer();
        SqlParameter[] paras_customer =
        {
            new SqlParameter("@u_id", SqlDbType.Int),
            new SqlParameter("@cname", SqlDbType.VarChar, 50),
            new SqlParameter("@cid", SqlDbType.VarChar, 20),
            new SqlParameter("@csex", SqlDbType.VarChar, 2),
            new SqlParameter("@cage", SqlDbType.Int),
            new SqlParameter("@d_id", SqlDbType.Int),
            new SqlParameter("@caddress", SqlDbType.VarChar, 50),
            new SqlParameter("@cphone", SqlDbType.VarChar, 15),
        };

        public AddCustomer()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            cb_csex.SelectedIndex = 0;
            dt = sqlcon.ExecSqlToDT("department_selectall");
            //绑定数据源
            cb_dep.DataSource = dt;
            //下拉框获得的值字段名
            cb_dep.ValueMember = "d_name";
        }

        public void getValue()
        {
            int u_id = Convert.ToInt16(tb_uid.Text);
            string cname = tb_cname.Text;
            string cid = tb_cid.Text;
            string csex = cb_csex.Text;
            int cage = Convert.ToInt16(tb_cage.Text);
            //部门数据表的id是下拉列表项的index值加1
            int d_id = cb_dep.SelectedIndex + 1;
            string caddress = tb_caddress.Text;
            string cphone = tb_cphone.Text;

            paras_customer[0].Value = u_id;
            paras_customer[1].Value = cname;
            paras_customer[2].Value = cid;
            paras_customer[3].Value = csex;
            paras_customer[4].Value = cage;
            paras_customer[5].Value = d_id;
            paras_customer[6].Value = caddress;
            paras_customer[7].Value = cphone;
        }

        private void bt_AddOk_Click(object sender, EventArgs e)
        {
            try
            {
                getValue();
                if (sqlcon.ExecSql("customer_insert", paras_customer) > 0)
                {
                    MessageBox.Show("订阅者信息添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("订阅者信息添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("请输入信息，文本框不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                sqlcon.con_close();
                this.Hide();
            }
            
        }

        private void bt_AddClear_Click(object sender, EventArgs e)
        {
            tb_uid.Clear();
            tb_cphone.Clear();
            tb_cname.Clear();
            tb_cid.Clear();
            tb_cage.Clear();
            tb_caddress.Clear();
        }
    }
}
