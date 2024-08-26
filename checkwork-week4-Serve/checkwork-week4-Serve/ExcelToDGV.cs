using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace checkwork_week4_Serve
{
    class ExcelToDGV
    {
        //Excel路径
        public static string pathName = "C:\\Users\\P30016775002\\Desktop\\非SZB工厂流水.xls";
        //表名
        public static string sheetName = "";

        public DataTable ExcelToDataTable(string pathName)
        {
            pathName = "C:\\Users\\P30016775002\\Desktop\\非SZB工厂流水.xls";
            //创建一个空数据表保存excel
            DataTable dt = new DataTable();
            //创建一个空的连接字符串
            string ConnectionString = string.Empty;
            FileInfo file = new FileInfo(pathName);
            if (!file.Exists)
            {
                throw new Exception("文件不存在");
            }
            //设置文件的扩展名
            string extension = file.Extension;
            // 连接字符串
            switch (extension)
            {
                case ".xls":
                    ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=no;IMEX=1;'";
                    break;
                case ".xlsx":
                    ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=no;IMEX=1;'";
                    break;
                default:
                    ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=no;IMEX=1;'";
                    break;
            }
            OleDbConnection con = new OleDbConnection(ConnectionString);
            try
            {
                con.Open();
                //如果要读特定的某一个工作表
                if (sheetName != "")
                {
                    OleDbCommand cmd = new OleDbCommand("select * from [" + sheetName + "$] where F1 is not null ", con);
                    OleDbDataAdapter apt = new OleDbDataAdapter(cmd);
                    try
                    {
                        apt.Fill(dt);
                    }
                    catch
                    {
                        throw new Exception("该Excel文件中未找到指定工作表名");
                        dt.TableName = sheetName;
                    }
                }
                //否则默认读取第一个有数据的工作表
                else
                {
                    var tables = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { });
                    if (tables.Rows.Count == 0)
                    {
                        throw new Exception("Excel不含表");
                    }
                    foreach (DataRow row in tables.Rows)
                    {
                        string strSheetTableName = row["TABLE_NAME"].ToString();
                        //过滤无效SheetName   
                        if (strSheetTableName.Contains("$") && strSheetTableName.Replace("'", "").EndsWith("$"))
                        {
                            DataTable tableColumns = con.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, new object[] { null, null, strSheetTableName, null });
                            if (tableColumns.Rows.Count < 2)                     //工作表列数
                                continue;
                            OleDbCommand cmd = new OleDbCommand("select * from [" + strSheetTableName + "] where F1 is not null", con);
                            OleDbDataAdapter apt = new OleDbDataAdapter(cmd);
                            apt.Fill(dt);
                            dt.TableName = strSheetTableName.Replace("$", "").Replace("'", "");
                            break;
                        }
                    }
                }
                if (dt.Rows.Count < 2)
                {
                    throw new Exception("表必须包含数据");
                }
                        
                //重构字段名
                DataRow headRow = dt.Rows[0];
                foreach (DataColumn c in dt.Columns)
                {
                    string headValue = (headRow[c.ColumnName] == DBNull.Value || headRow[c.ColumnName] == null) ? "" : headRow[c.ColumnName].ToString().Trim();
                    if (headValue.Length == 0)
                    {
                        throw new Exception("必须输入列标题");
                    }
                    if (dt.Columns.Contains(headValue))
                    {
                        throw new Exception("不能用重复的列标题：" + headValue);
                    }
                    c.ColumnName = headValue;
                }
                dt.Rows.RemoveAt(0);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        
    }
}
