using System;
using System.CodeDom.Compiler;

namespace TurOtomasyonu.Models
{
    public class CustomerTourHistory
    {
        private string _orderRefNumber;

        public CustomerTourHistory()
        {
            _orderRefNumber = Services.CommonServices.CodeGenerator.Generate();
        }

        public int TourId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string OrderRefNumber { get; private set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Tour Tour { get; set; }
        public virtual Customer Customer { get; set; }

    }
}