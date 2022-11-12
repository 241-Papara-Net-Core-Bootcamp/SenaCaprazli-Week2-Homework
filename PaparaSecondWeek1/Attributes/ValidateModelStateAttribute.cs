using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple =false)]
    public class ValidateModelStateAttribute : Attribute
    {

    }
}
