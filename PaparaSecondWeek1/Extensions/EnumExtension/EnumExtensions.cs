using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Extensions.EnumExtension
{
    public static class EnumExtensions
    {
        public static string GetColorEnums(this Enum value)
        {
            return value.ToString();
                 

            //var stringBuilder = new StringBuilder();
            //foreach ( var item in value.GetType))
        }
    }
}
