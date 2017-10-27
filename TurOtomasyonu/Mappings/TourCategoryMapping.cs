using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class TourCategoryMapping : EntityTypeConfiguration<TourCategory>
    {
        public TourCategoryMapping()
        {
            this.ToTable("Tur_Kategori");

            this.Property(x => x.TopCategoryId)
                .IsOptional();

            //hasOptional alt kategorisi olabilir yani opsiyoneldir.
            this.HasOptional<TourCategory>(t => t.ParentCategory)
           .WithMany(x=> x.SubCategories)
           .HasForeignKey(d => d.TopCategoryId)
           .WillCascadeOnDelete(false);

            this.HasKey(x => x.Id);
        
            this.Property(x => x.CategoryName)
                .HasColumnName("Tur_Kategorisi")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);
        }
    }
}
