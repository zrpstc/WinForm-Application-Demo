using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork
{
    class Paper
    {
        private int id;
        private string name;
        private int category;
        private string paper_public;
        private string paper_date;
        //decimal的格式默认是（18，2）
        private decimal pricae;
        private string content;

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

        public int Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Paper_public
        {
            get
            {
                return paper_public;
            }

            set
            {
                paper_public = value;
            }
        }

        public string Paper_date
        {
            get
            {
                return paper_date;
            }

            set
            {
                paper_date = value;
            }
        }

        public decimal Pricae
        {
            get
            {
                return pricae;
            }

            set
            {
                pricae = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

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
    }
}
