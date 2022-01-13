using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    static class Tools //can't create an instance
    {
        public static void Printer(string str)
        {
            Console.WriteLine(str);
        }
        public static DateTime ConvertStrToDate(string date = "", string format = "dd-MM-yyyy")
        {             

            if (String.IsNullOrEmpty(date))
            {
                return DateTime.Now;
            }
            return DateTime.ParseExact(date, format, null);           
               
        }
    }
    
}
