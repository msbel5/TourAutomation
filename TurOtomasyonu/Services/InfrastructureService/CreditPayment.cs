using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Services.InfrastructureService
{
    public enum PaymentType
    {
        Cash,
        Credit
    }

    public class CreditPayment : IPayment
    {
        private PaymentResult pResult;

        public PaymentResult PaymentResult
        {
            get
            {
                return pResult;
            }
        }

        public void Pay(int quantity, decimal unitPrice)
        {
            throw new NotImplementedException();
        }
    }
}
