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
    public partial class AddPress : NForm
    {
        SqlCon sqlcon = new SqlCon();
        DataTable dt = new DataTable();
        Paper paper = new Paper();
        SqlParameter[] paras_paper =
        {
            //注意此处的参数名要与存储过程中定义的输入参数名字一致！！！！
            new SqlParameter("@name", SqlDbType.VarChar, 50),
            new SqlParameter("@k_id", SqlDbType.Int),
            new SqlParameter("@public", SqlDbType.VarChar, 50),
            new SqlParameter("@date", SqlDbType.VarChar, 20),
            new SqlParameter("@price", SqlDbType.Decimal,10),
            new SqlParameter("@content", SqlDbType.VarChar, 50),
        };
        
        public AddPress()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        private void AddPress_Load(object sender, EventArgs e)
        {
            cb_date.SelectedIndex = 0;
            dt = sqlcon.ExecSqlToDT("presscategory");
            //绑定数据源
            cb_category.DataSource = dt;
            //下拉框获得的值字段名
            cb_category.ValueMember = "k_name";
            
        }

        public void getValue()
        {
            string name = tb_name.Text;
            string paper_public = tb_public.Text;
            decimal price = Convert.ToDecimal(tb_price.Text);
            //类别id是下拉列表项的index值加1
            int c_id = cb_category.SelectedIndex + 1;
            string content = rtb_content.Text;
            string paper_date = cb_date.Text;

            paras_paper[0].Value = name;
            paras_paper[1].Value = c_id;
            paras_paper[2].Value = paper_public;
            paras_paper[3].Value = paper_date;
            paras_paper[4].Value = price;
            //设置精度
            paras_paper[4].Precision = 10;
            paras_paper[4].Scale = 2;
            paras_paper[5].Value = content;
        }

        private void bt_addOK_Click(object sender, EventArgs e)
        {
            try
            {
                getValue();
                if (sqlcon.ExecSql("paper_insert", paras_paper) > 0)
                {
                    MessageBox.Show("报刊信息添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("报刊信息添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_price.Clear();
            tb_public.Clear();
            rtb_content.Clear();
        }
    }
}
