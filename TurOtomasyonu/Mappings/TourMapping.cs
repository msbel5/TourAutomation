using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class TourMapping:EntityTypeConfiguration<Tour>
    {
        public TourMapping()
        {
            //bir tura birden fazla müşteri gidebilir.
            //eğer ara tablonuz var ise one to many ilşşkileri ara tablolara yazabiliriz veya tek tek her entity ara entity ile bağlarız.
            //aşağıdaki yöntem bunu gösteriz fakat yanlız 1 yöntem geçerlidir. Aynı anda ara tablolar ve ara tablolara ilişkilendirilemez.


            this.HasKey<int>(x => x.Id);

            this.HasRequired(x => x.TourCategory)
                .WithMany(x => x.Tours)
                .HasForeignKey(x=> x.CategoryId);

            this.Property(x => x.Price)
                .HasColumnName("TurFiyati")
                .IsOptional();

            this.Property(x => x.TourName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("TurAdi");

            this.Property(x => x.StartDate)
                .HasColumnName("Tur_Baslangic")
                .HasColumnType("date")
                .IsRequired();

            this.Property(x => x.EndDate)
                .HasColumnName("Tur_Bitis")
                .HasColumnType("date")
                .IsRequired();

            this.Property(x => x.Quota)
                .HasColumnName("Kota")
                .IsRequired();
            
        }
    }
}
