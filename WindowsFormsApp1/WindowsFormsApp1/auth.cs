using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class auth
    {
        public string userName { get; set; }
        public string password { get; set; }

        public auth(string userID , string pass)
        {
            this.userName = userID;
            this.password = pass;
        }
       
        public bool authStatus(string in1,string in2)
        {
            in1 = this.userName;
            in2 = this.password;
            return this.isAuthenticated(in1, in2);
            
        }
        public bool isAuthenticated(string dt1, string dt2)
        {
            byte[] encode1 = Encoding.ASCII.GetBytes("Admin");
            byte[] encode2 = Encoding.ASCII.GetBytes("admin123");
            dt1 = this.userName;
            dt2 = this.password;
            if (encode1 == Encoding.ASCII.GetBytes(dt1) && encode2 == Encoding.ASCII.GetBytes(dt2))
            { 
                return true;
            }
            return false;
        }
    }
}
