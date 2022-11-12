using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Models
{
    public interface IPayment
    {
        void DoPayment();
        //void Refund();
        //void UsePoint();

    }

    public interface IRefund
    {
        void Refund();
    }
    public class PaymentwithCreditCard : IPayment
    {
        private readonly IRefund _refund;
        public PaymentwithCreditCard(IRefund refund)
        {
            _refund = refund;
        }
        public void Refund()
        {
            _refund.Refund();
        }
        public void DoPayment()
        {
            // kredi kartıyla ödeme işlemi yaptım
        }
    }

        public class PaymentwithBankCard
    {
        private readonly IPayment _payment;
        public PaymentwithBankCard(IPayment payment)
        {
            _payment = payment;

        }

        public void DoPayment()
        {
            _payment.DoPayment();
        }
    }
    public class PaymentwithEFT
    {
        private readonly IPayment _payment;

        public PaymentwithEFT(IPayment payment)
        {
            _payment = payment;
        }

        public void Payment()
        {
            _payment.DoPayment();
        }

        public void Refund()
        {
         // _payment.Refund();
        }
    }

    public class PaymentwithHavale
    {
        private readonly IPayment _payment;
        private readonly IRefund _refund;
        public PaymentwithHavale(IPayment payment, IRefund refund)
        {
            _payment = payment;
            _refund = refund;
        }

        public void HavaleYap()
        {
            _payment.DoPayment();
        }
    }
}
