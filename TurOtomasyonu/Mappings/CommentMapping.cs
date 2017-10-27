using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class CommentMapping:EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            this.HasKey(x => x.ID);

            this.Property(x => x.Body).IsRequired().HasMaxLength(500).HasColumnName("Yorumlar");

            
        }
    }
}
