using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_01
{
    static class GlobalVariables
    {
        private static bool g_repair = true;
        public static bool G_Repair
        {
            get { return g_repair; }
            set { g_repair = value; }
        }
        private static string g_user = "";
        public static string G_user
        {
            get { return g_user; }
            set { g_user = value; }
        }


        private static bool g_user_p = false;
        public static bool G_User_p
        {
            get { return g_user_p; }
            set { g_user_p = value; }
        }


    }
}
