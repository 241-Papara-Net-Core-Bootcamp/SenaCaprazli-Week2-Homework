using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Models
{
    public class Invoice
    {
        private readonly IEmail _email;
        
        public Invoice (IEmail email)
        {
            _email = email;
        }

        public void Create()
        {
            //Invoice create

            _email.Send();
        }

        //public void SendMail()
        //{
        //    // Invoice send mail   
        //}
    }
}
