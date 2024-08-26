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

namespace checkwork_week5
{
    public partial class BookForm : NForm
    {
        SubscribeTable table = new SubscribeTable();
        SqlCon MyConn = new SqlCon();
        SqlParameter[] paras =
        {
            new SqlParameter("@name", SqlDbType.VarChar, 50),
            new SqlParameter("@date", SqlDbType.Date),
            new SqlParameter("@strattime", SqlDbType.Time),
            new SqlParameter("@endtime", SqlDbType.Time),
            new SqlParameter("@room", SqlDbType.Int),
            new SqlParameter("@note", SqlDbType.VarChar, 50)
        };

        SqlParameter[] paras1 = null;

        public BookForm()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        public void get_value()
        {
            int hour = Convert.ToInt32(tb_hour.Text);
            int min = Convert.ToInt32(tb_min.Text);
            int second = 0;
            TimeSpan ts = new TimeSpan(hour, min,second);

            table.Name = tb_name.Text;
            table.Date = dtp_strattime.Value.Date;
            table.Starttime = dtp_strattime.Value.TimeOfDay;
            table.Lasttime = ts;
            table.Endtime = table.Starttime.Add(table.Lasttime);
            table.Room = Convert.ToInt16(tb_room.Text);
            //table.Cretime = DateTime.Now;
            table.Note = tb_note.Text;

            paras[0].Value = table.Name;
            paras[1].Value = table.Date;
            paras[2].Value = table.Starttime;
            paras[3].Value = table.Endtime;
            paras[4].Value = table.Room;
            paras[5].Value = table.Note;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            get_value();
            //判断会议时间是否冲突
            bool flag = true;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds = MyConn.ExecSqlToDT("table_selectall", paras1);
            dt = ds.Tables[0];
            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string meet_date = dt.Rows[i][2].ToString();
                    string meet_room = dt.Rows[i][5].ToString();
                    TimeSpan meet_starttime = (TimeSpan)dt.Rows[i][3];
                    TimeSpan meet_endtime = (TimeSpan)dt.Rows[i][4];
                    if (meet_room == table.Room.ToString() && meet_date == table.Date.ToString())
                    {
                        //会议时间冲突
                        if (table.Starttime > meet_endtime || table.Endtime < meet_starttime)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    if (MyConn.ExecSql("table_insert", paras) > 0)
                    {
                        MessageBox.Show("会议室预定成功！");
                    }

                }
                else
                {
                    MessageBox.Show("会议室预定失败，请调整时间！");
                }
            }
            else
            {
                if (MyConn.ExecSql("table_insert", paras) > 0)
                {
                    MessageBox.Show("会议室预定成功！");
                }
            }
        }
        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_hour.Clear();
            tb_min.Clear();
            tb_room.Clear();
        }
    }
}

