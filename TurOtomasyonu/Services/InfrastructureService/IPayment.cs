using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Services.InfrastructureService
{
    public enum PaymentResult
    {
        OK,
        Error,
        Insufficient_Funds
    }


    public interface IPayment
    {
        void Pay(int quantity, decimal unitPrice);
        PaymentResult PaymentResult { get; }
    }
}
