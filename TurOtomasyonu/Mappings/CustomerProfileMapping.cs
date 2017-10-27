using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class CustomerProfileMapping:EntityTypeConfiguration<CustomerProfile>
    {
        public CustomerProfileMapping()
        {
            this.ToTable("Musteri_Profil")
                .Property(x => x.Email)
                .HasColumnName("E-Posta")
                .IsRequired();

            this.Property(x => x.FirstName)
                .HasColumnName("Adınız")
                .IsRequired();

            this.Property(x => x.LastName)
                .HasColumnName("SoyAdınız")
                .IsRequired();

            this.Property(x => x.Hobies)
                .HasColumnName("Hobileriniz")
                .IsOptional() //Nullable
                .IsMaxLength(); //nvarchar max
          
        }
    }
}
