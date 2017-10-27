using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class CustomerTourHistoryMapping:EntityTypeConfiguration<CustomerTourHistory>
    {
        public CustomerTourHistoryMapping()
        {

            this.HasKey(x => x.TourId);

            this.HasRequired<Tour>(x => x.Tour)
                .WithMany(x => x.Histories).Map(x=> x.MapKey("Tour"))
                .WillCascadeOnDelete(true);


            this.HasKey(x => x.CustomerId);

            this.HasRequired<Customer>(x => x.Customer)
                .WithMany(x => x.Histories).Map(x=> x.MapKey("Customer"))
                .WillCascadeOnDelete(true);
        }
    }
}
