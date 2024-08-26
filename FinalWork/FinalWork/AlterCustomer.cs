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
    public partial class AlterCustomer : NForm
    {
        SqlCon sqlcon = new SqlCon();
        DataTable dt = new DataTable();
        Paper paper = new Paper();
        SqlParameter[] paras_selectcustomer =
        {
            new SqlParameter("@id", SqlDbType.Int),
        };
        SqlParameter[] paras =
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
        public AlterCustomer()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        private void AlterCustomer_Load(object sender, EventArgs e)
        {
            dt = sqlcon.ExecSqlToDT("department_selectall");
            cb_alterdep.DataSource = dt;
            cb_alterdep.ValueMember = "d_name";
        }

        public void getValue()
        {
            int u_id = Convert.ToInt16(tb_alteruid.Text);
            string cname = tb_altercname.Text;
            string cid = tb_altercid.Text;
            string csex = cb_altercsex.Text;
            int cage = Convert.ToInt16(tb_altercage.Text);
            //部门数据表的id是下拉列表项的index值加1
            int d_id = cb_alterdep.SelectedIndex + 1;
            string caddress = tb_altercaddress.Text;
            string cphone = tb_altercphone.Text;

            paras[0].Value = u_id;
            paras[1].Value = cname;
            paras[2].Value = cid;
            paras[3].Value = csex;
            paras[4].Value = cage;
            paras[5].Value = d_id;
            paras[6].Value = caddress;
            paras[7].Value = cphone;
        }

        public void WriteValue(int id)
        {
            paras_selectcustomer[0].Value = id;
            //获取目前数据库原始数据
            dt = sqlcon.ExecSqlToDT("customer_select", paras_selectcustomer);
            //将原始数据填充到修改面板中
            tb_alteruid.Text = id.ToString();
            tb_altercname.Text = dt.Rows[0][1].ToString();
            tb_altercid.Text = dt.Rows[0][2].ToString();
            cb_altercsex.SelectedText = dt.Rows[0][3].ToString();
            tb_altercage.Text = dt.Rows[0][4].ToString();
            cb_alterdep.SelectedIndex = Convert.ToInt16(dt.Rows[0][5])-1;
            tb_altercaddress.Text = dt.Rows[0][6].ToString();
            tb_altercphone.Text = dt.Rows[0][7].ToString();
        }

        private void bt_AlterOk_Click(object sender, EventArgs e)
        {
            try
            {
                getValue();
                if (sqlcon.ExecSql("customer_alter", paras) > 0)
                {
                    MessageBox.Show("订阅者信息修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("订阅者信息修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
            finally
            {
                sqlcon.con_close();
                this.Hide();
            }
        }

        private void bt_AlterClear_Click(object sender, EventArgs e)
        {
            tb_alteruid.Clear();
            tb_altercphone.Clear();
            tb_altercname.Clear();
            tb_altercid.Clear();
            tb_altercage.Clear();
            tb_altercaddress.Clear();
        }
    }
}
