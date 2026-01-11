using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct
{
    public class Person()
    {

     private string _nickname { get; set; }

        public string Nickname
        {
            get
            {
                if (string.IsNullOrEmpty(_nickname))
                    return "N/A";

                return _nickname;
            }
            set
            {
                if (value == null)

                    _nickname = string.Empty;
                else
                    _nickname = value;
            }
        }

        private string fname { get; set; }
        private string lname { get; set; }
        public DateTime? Birthday { get; set; }
        private int? Mymoney { get; set; }

        public int? MyMoney
        {
            get
            {
                    return Mymoney;
            }
            set
            {
                if (value < 0)
                {
                    Mymoney = 0;
                }
                else
                {
                    Mymoney = value;
                }

            }
        }
        public string FirstName
        {
            get
            {
                if (string.IsNullOrEmpty(fname))
                    return "N/A";

                return fname;
            }

            set
            {
                if (value == null)
                    fname = string.Empty;
                else
                    fname = value;
            }
        }
        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(lname))
                    return "N/A";

                return lname;
            }

            set
            {
                if (value == null)
                    lname = string.Empty;
                else
                    lname = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"Fullname:{fname} {lname}";
            }
        }
    }
}
