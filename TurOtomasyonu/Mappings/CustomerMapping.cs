using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class CustomerMapping:EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            //one to one or zero association
            this.HasOptional(x => x.CustomerProfile)
                .WithRequired(x => x.Customer)
                .WillCascadeOnDelete(true);

            this.ToTable("Musteri");

            this.Property(x => x.UserName)
                .HasColumnName("Kullanıcı Adi")
                .HasColumnType("nchar")
                .HasMaxLength(8);
                //.IsOptional();
            //.IsRequired(); //Not Null

            this.Property(x => x.Password)
                .HasColumnName("Parola")
                .HasMaxLength(12)
                .IsRequired();
                

        }
    }
}
