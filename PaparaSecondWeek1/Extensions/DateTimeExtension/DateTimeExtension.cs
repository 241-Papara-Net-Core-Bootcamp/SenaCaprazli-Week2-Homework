using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Extensions.DateTimeExtension
{
    public static class DateTimeExtension
    {
        public static string FormatDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy");
        }

        public static string FormatDate(this DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }

        public static int GetMonth(this DateTime date)
        {
            return date.Month;
        }

   
    }
}
