using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Models
{
    public class InvoiceCalculate
    {
        public InvoiceType Type { get; set; }
        public double Tax { get; set; }

        public double CalculateTax()
        {
            if (Type == InvoiceType.Company)
                return Tax * 1.23; // %23 tax to company
            else if (Type == InvoiceType.Person)
                return Tax * 1.18; //%18 tax to people
            throw new Exception();
        }
    }

    public enum InvoiceType
    {
        Company,
        Person,

    }

    public abstract class BaseInvoice
    {
        public double Tax { get; set; }
        public abstract double CalculateTax();
    }

    public class InvoiceCompany : BaseInvoice
    {
        public override double CalculateTax()
        {
            return Tax * 1.23;

        }

        public class InvoicePerson : BaseInvoice
        {
            public override double CalculateTax()
            {
                return Tax * 1.18;

            }
        }
    }

}
