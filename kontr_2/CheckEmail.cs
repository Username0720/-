using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontr_2
{
    class CheckEmail
    {
        public string name { get; set; }
        public string email { get; set; }
        Form1 f1 = new Form1();
        public CheckEmail(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public bool Check()
        {
            if (name == "" && email == "")
                return true;
            if (!email.Contains("@") && !email.Contains("."))
                return true;
            return false;
        }
    }
}
