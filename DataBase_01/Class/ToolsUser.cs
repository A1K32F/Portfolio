using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase_01.Interface_;

namespace DataBase_01
{
    class ToolsUser : IUser
    {
        
            private string uname;
            public string Uname 
            {
                get 
                {
                    return uname;
                }
                set 
                {
                    if (value.Length <4)
                    {
                       throw new Exception("Username");                    
                    }
                    else
                    {
                        uname = value;                
                    }
                } 
            }
            private string upass;
            public string Upass 
            { 
                get
                {
                    return upass;
                }
                set
                {
                    if(value.Length<8)
                    {
                        throw new Exception("password");
                    }
                    else
                    {
                        upass = value;
                    }
                } 
            }
        public ToolsUser(string username,string password)
        {
            this.Uname = username;
            this.Upass = password;
        }
        public void Clear ()
        {
            uname = "";
            upass = "";
        }
        
    }
}
