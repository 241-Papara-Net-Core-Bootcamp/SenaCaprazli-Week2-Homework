using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Extensions.IntExtension
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
