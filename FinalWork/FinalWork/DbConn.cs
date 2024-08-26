using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalWork
{
    class DbConn
    {
        //设置连接池的最大连接数和最小连接数
        private const int MaxPool = 10;
        private const int MinPool = 5;
        //设置异步访问数据库
        private const bool Asyn_Process = true;
        //在单个连接上得到和管理多个，仅向前引用和只读的结果集(ADO.NET2.0)
        private const bool Mars = true;
        //设置连接等待时间
        private const int Conn_Timeout = 15;
        //设置连接生命周期
        private const int Conn_Lifetime = 15;
        //连接字符串
        private string ConnString = "";
        //连接对象
        private SqlConnection SqlDrConn = null;

        //构造函数
        public DbConn()
        {
            ConnString = GetConnString();
            SqlDrConn = new SqlConnection(ConnString);
        }

        public string GetConnString()
        {
            //return "Data Source=N30016775002;Initial Catalog=Data;Persist Security Info=True;User ID=zrp;Password=123456@byd";
            //return "Data Source=.;Initial Catalog=Data;User ID=zrp;Password=123456@byd;Integrated Security = false";
            return "Data Source = N30016775002;" + "Initial Catalog=Data;" + "User ID=zrp;Password=123456@byd;Integrated Security = true;"
                + "Max Pool Size=" + MaxPool + ";" + "Min Pool Size=" + MinPool + ";" 
                + "Connect Timeout=" + Conn_Timeout + ";" + "Connection Lifetime=" + Conn_Lifetime + ";" 
                + "Asynchronous Processing=" + Asyn_Process + ";";
             
        }

        public DataTable GetDataReader(string StrSQl)
        {
            //当有连接处于打开状态时关闭，然后再打开，避免有数据时不能及时更新
            if(SqlDrConn.State == ConnectionState.Open)
            {
                SqlDrConn.Close();
            }
            try
            {
                SqlDrConn.Open();
                SqlCommand SqlCmd = new SqlCommand(StrSQl, SqlDrConn);
                SqlDataReader SqlDr = SqlCmd.ExecuteReader();
                if (SqlDr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(SqlDr);
                    SqlDr.Close();
                    SqlDrConn.Close();
                    return dt;
                }
                return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SqlDrConn.Close();
            }
        }
            
    }
}
