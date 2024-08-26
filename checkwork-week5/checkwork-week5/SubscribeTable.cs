using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkwork_week5
{
    class SubscribeTable
    {
        //预定编号
        private int id;
        //预定者姓名
        private string name;
        //预定日期
        private DateTime date;
        //开始时间
        private TimeSpan starttime;
        //持续时间
        private TimeSpan lasttime;
        //结束时间
        private TimeSpan endtime;
        //会议室编号
        private int room;
        //预定者填写时间
        private DateTime cretime;
        //备注
        private string note;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public TimeSpan Starttime
        {
            get
            {
                return starttime;
            }

            set
            {
                starttime = value;
            }
        }

        public TimeSpan Lasttime
        {
            get
            {
                return lasttime;
            }

            set
            {
                lasttime = value;
            }
        }

        public int Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        public DateTime Cretime
        {
            get
            {
                return cretime;
            }

            set
            {
                cretime = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public TimeSpan Endtime
        {
            get
            {
                return endtime;
            }

            set
            {
                endtime = value;
            }
        }
    }
}
