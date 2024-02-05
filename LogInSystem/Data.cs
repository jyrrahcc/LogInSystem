using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInSystem
{
    internal class Data
    {
        public static string adminUser = "admin", adminPass = "BIT34", guestUser = "user", guestPass = "BIT43";
        public static string getAdminUser()
        {
            return adminUser;
        }
        public static string getAdminPass()
        {
            return adminPass;
        }
        public static string getGuestUser()
        {
            return guestUser;
        }
        public static string getGuestPass()
        {
            return guestPass;
        }
        public static void setAdminPass(string newAdminPass)
        {
            adminPass = newAdminPass;
        }
        public static void setGuestPass(string newGuestPass)
        {
            guestPass = newGuestPass;
        }
    }
}
