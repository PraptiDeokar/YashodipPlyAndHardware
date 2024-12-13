using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YashodipPlyAndHardware.Data;

namespace YashodipPlyAndHardware
{
    public class UtilityClass
    {
        public static int pid;
        public static double qty;
        public static string cname;
        public static string sname;
        public static string pname;
        //public static AppDBContext db;
        public static void SetConnection() { 
        
        AppDBContext db=new AppDBContext();
            
        }
    }
}
