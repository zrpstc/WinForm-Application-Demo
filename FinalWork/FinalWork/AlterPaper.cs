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
    public partial class AlterPaper : NForm
    {
        SqlCon sqlcon = new SqlCon();
        DataTable dt = new DataTable();
        Paper paper = new Paper();
        SqlParameter[] paras_selectpaper =
        {
            new SqlParameter("@id", SqlDbType.Int),
        };
        SqlParameter[] paras =
        {
            new SqlParameter("@id", SqlDbType.Int),
            new SqlParameter("@name", SqlDbType.VarChar, 50),
            new SqlParameter("@k_id", SqlDbType.Int),
            new SqlParameter("@public", SqlDbType.VarChar, 50),
            new SqlParameter("@date", SqlDbType.VarChar, 20),
            new SqlParameter("@price", SqlDbType.Decimal),
            new SqlParameter("@content", SqlDbType.VarChar, 50),
        };
        public AlterPaper()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        private void AlterPaper_Load(object sender, EventArgs e)
        {
            dt = sqlcon.ExecSqlToDT("presscategory");
            cb_altercategory.DataSource = dt;
            cb_altercategory.ValueMember = "k_name";
        }

        public void getValue()
        {
            string name = tb_altername.Text;
            string paper_public = tb_alterpublic.Text;
            decimal price = Convert.ToDecimal(tb_alterprice.Text);
            //类别id是下拉列表项的index值加1
            int c_id = cb_altercategory.SelectedIndex + 1;
            string content = rtb_altercontent.Text;
            string paper_date = cb_alterdate.Text;

            paras[0].Value = paras_selectpaper[0].Value;
            paras[1].Value = name;
            paras[2].Value = c_id;
            paras[3].Value = paper_public;
            paras[4].Value = paper_date;
            paras[5].Value = price;
            paras[5].Precision = 10;
            paras[5].Scale = 2;
            paras[6].Value = content;
        }

        public void WriteValue(int id)
        {
            paras_selectpaper[0].Value = id;
            //获取目前数据库原始数据
            dt = sqlcon.ExecSqlToDT("paper_select", paras_selectpaper);

            tb_altername.Text = dt.Rows[0][1].ToString();
            tb_alterprice.Text = dt.Rows[0][5].ToString();
            tb_alterpublic.Text = dt.Rows[0][3].ToString();
            rtb_altercontent.Text = dt.Rows[0][6].ToString();
            cb_altercategory.SelectedIndex = Convert.ToInt16(dt.Rows[0][2])-1;
            cb_alterdate.SelectedText = dt.Rows[0][4].ToString();
        }

        private void bt_alterPOk_Click(object sender, EventArgs e)
        {
            try
            {
                getValue();
                if (sqlcon.ExecSql("paper_alter", paras) > 0)
                {
                    MessageBox.Show("报刊信息修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("报刊信息修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bt_clearOk_Click(object sender, EventArgs e)
        {
            tb_altername.Clear();
            tb_alterprice.Clear();
            tb_alterpublic.Clear();
            rtb_altercontent.Clear();
        }
    }
}
