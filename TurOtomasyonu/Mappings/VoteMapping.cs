using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Models;

namespace TurOtomasyonu.Mappings
{
    public class VoteMapping:EntityTypeConfiguration<Vote>
    {
        public VoteMapping()
        {
            this.HasKey(x => x.ID);
        }
    }
}
