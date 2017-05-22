using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.DateTimeFormats
{
    public static class DateTimeFormats
    {
        public static string GetDateTimeFormats(int Case)
        {
            
            switch(Case)
            {
                //MMMM DD YYYY
                case 1:
                    {
                        return DateTime.Now.ToString("MMMM dd yyyy");
                    }
                //mmmm dd yyy
                case 2:
                    {
                        return DateTime.Now.ToString("mmmm dd yyy");
                    }                
                //MM:DD:YYYY
                default:
                    {
                        return DateTime.Now.ToString("MM:DD:YYYY");
                    }
            }
        }

        public static string getUTCDate(string time)
        {
            return DateTimeOffset.Parse(time).AddHours(1).ToString();
        }
    }
}
