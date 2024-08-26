using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace FinalWork
{
    class SqlCon
    {
        #region 设置变量
        //定义一个SqlConnection类型的全局变量My_con，用于判断数据库是否连接成功
        public SqlConnection My_con;
        public SqlDataAdapter SQLda;
        //定义数据库连接字符串
        //本地服务器账户登录
        //public string Str_sqlcon1 = "Data Source=N30016775002;Initial Catalog=Data;Integrated Security=True";
        //个人用户登录
        public string Str_sqlcon = "Data Source=N30016775002;Initial Catalog=Data;Persist Security Info=True;User ID=zrp;Password=123456@byd";
        #endregion

        //建立数据库连接
        public SqlConnection getcon()
        {
            My_con = new SqlConnection(Str_sqlcon);//用SqlConnection对象与指定的数据库相连接  
            My_con.Open();//打开数据库连接
            return My_con;//返回SqlConnection对象信息
        }

        //关闭数据库连接
        public void con_close()
        {
            if (My_con.State == ConnectionState.Open)//判断是否打开与数据库的连接
            {
                My_con.Close();//关闭数据库的连接
                My_con.Dispose();//释放My_con变量的所有空间
            }
        }

        //执行SQL语句
        public void getSqlCom(string SQLstr)
        {
            getcon();//打开数据库连接
            SqlCommand SQLcom = new SqlCommand(SQLstr, My_con);//创建SqlConnection对象，用于执行SQL语句
            SQLcom.ExecuteNonQuery();//执行SQL语句
            SQLcom.Dispose();//释放所有空间
            con_close();//关闭数据库连接
        }

        //返回delete，insert，update语句执行后受影响的行数
        public int ExecSqlReturnNum(string SQLstr)
        {
            getcon();//打开数据库连接
            SqlCommand SQLcom = new SqlCommand(SQLstr, My_con);//创建SqlConnection对象，用于执行SQL语句
            int res = SQLcom.ExecuteNonQuery();//执行SQL语句
            SQLcom.Dispose();//释放所有空间
            con_close();//关闭数据库连接
            return res;
        }

        //执行SQL语句返回数据集合
        public DataSet getDataSet(string SQLstr, string tableName)
        {
            getcon();//打开数据库连接
            //SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);
            SQLda = new SqlDataAdapter(SQLstr, My_con);
            DataSet ds = new DataSet();//创建DataSet对象
            SQLda.Fill(ds, tableName);
            con_close();//关闭数据库连接
            return ds;//返回DataSet对象信息
        }

        //执行SQL语句返回数据集合
        public DataTable getDataTable(string SQLstr)
        {
            getcon();//打开数据库连接
            //SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);
            SQLda = new SqlDataAdapter(SQLstr, My_con);
            DataTable dt = new DataTable();
            SQLda.Fill(dt);
            con_close();
            return dt;
        }

        public SqlDataReader getDataReader(string SQLstr)
        {
            getcon();
            SqlCommand sqlQuery = new SqlCommand(SQLstr, My_con);
            SqlDataReader reader = sqlQuery.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// 执行SQL存储过程返回DataSet方法
        /// </summary>
        /// <param name="name">存储过程的名字</param>
        /// <param name="paras">存储过程需要传入的参数列表</param>
        /// <returns></returns>
        public DataSet ExecSqlToDS(string name, SqlParameter[] paras = null)
        {
            getcon();
            //使用datatable时无法写入其中数据
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(name, My_con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                //cmd.ExecuteNonQuery();
                //用SqlDataAdpter执行Command再填充到表
                //SqlDataAdapter SQLda = new SqlDataAdapter(cmd);
                SQLda = new SqlDataAdapter(cmd);
                //sda.Fill(dt);
                SQLda.Fill(ds);
            }
            catch
            {
            }
            finally
            {
                cmd.Parameters.Clear();
                My_con.Close();
            }
            //return dt;
            return ds;
        }

        /// <summary>
        /// 执行SQL存储过程返回DataSet方法
        /// </summary>
        /// <param name="name">存储过程的名字</param>
        /// <param name="paras">存储过程需要传入的参数列表</param>
        /// <returns></returns>
        public DataTable ExecSqlToDT(string name, SqlParameter[] paras = null)
        {
            getcon();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(name, My_con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                //cmd.ExecuteNonQuery();
                //用SqlDataAdpter执行Command再填充到表
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch
            {
            }
            finally
            {
                cmd.Parameters.Clear();
                My_con.Close();
            }
            return dt;
        }

        /// <summary>
        /// 执行SQL存储过程返回执行结果
        /// </summary>
        /// <param name="name">存储过程的名字</param>
        /// <param name="paras">存储过程需要传入的参数列表</param>
        /// <returns></returns>
        public int ExecSql(string name, SqlParameter[] paras)
        {
            int res = 0;
            getcon();
            SqlCommand cmd = new SqlCommand(name, My_con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                //定义输出参数
                //cmd.Parameters.Add(new SqlParameter("@returnNum", SqlDbType.Int));
                //参数输出方向为output
                //cmd.Parameters["@returnNum"].Direction = ParameterDirection.Output;
                SqlParameter parReturn = new SqlParameter("@return", SqlDbType.Int);
                parReturn.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(parReturn);
                cmd.ExecuteNonQuery();
                //res = (int)cmd.Parameters["@returnNum"].Value;
                res = (int)parReturn.Value;

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            finally
            {
                //SQL执行命令结束后要将使用完的Parameters集合清空
                //因为垃圾回收机制可能没有回收临时变量，同时下次执行sql不要重新生成Parameters对象，垃圾变量
                cmd.Parameters.Clear();
                My_con.Close();
            }
            return res;
        }

        /// <summary>
        /// 执行视图并保存到DS中
        /// </summary>
        public DataSet ExecViewToDS(string name)
        {
            getcon();
            DataSet ds = new DataSet();
            string SQLstr = "select * from ";
            SQLstr += name;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(SQLstr, My_con);
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                My_con.Close();
            }
            return ds;
        }

    }
}
