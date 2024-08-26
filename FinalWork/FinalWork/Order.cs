using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork
{
    class Order
    {
        private int id;
        private int user_id;
        private int paper_id;
        private int amount;
        //订阅期数
        private int moonth;
        private decimal price;

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

        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public int Paper_id
        {
            get
            {
                return paper_id;
            }

            set
            {
                paper_id = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public int Moonth
        {
            get
            {
                return moonth;
            }

            set
            {
                moonth = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
