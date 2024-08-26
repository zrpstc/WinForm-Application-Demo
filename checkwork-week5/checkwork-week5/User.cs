using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkwork_week5
{
    class User
    {
        private int id;
        private string name;
        private string password;
        private string username;
        private DateTime cretime;
        private string note;
        private int power;

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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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

        public int Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }
    }
}
