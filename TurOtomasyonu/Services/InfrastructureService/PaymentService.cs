using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Services.InfrastructureService
{
    public class PaymentService:IInfraService
    {
        IPayment payment;
        PaymentType _paymentType;

        public PaymentType type { get { return _paymentType; }

            set {

                _paymentType = value;

                switch (_paymentType)
                {
                    case PaymentType.Cash:
                        payment = new CashPayment();
                        break;
                    case PaymentType.Credit:
                        payment = new CreditPayment();
                        break;
                    default:
                        break;
                }

            }

        }

        public PaymentService()
        {
            
        }

        
        public void Pay(IEnumerable<Customer> customerInfo,Tour tour)
        {
            payment.Pay(customerInfo.Count(), tour.Price);
        }
    }
}
