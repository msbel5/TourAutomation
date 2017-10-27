using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Services.InfrastructureService
{
    public class CashPayment : IPayment
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
           
        }
    }
}
