using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Models
{
    public class Vote
    {
        public int ID { get; set; }
        public int VotePoint { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual Customer Customer { get; set; }

      
    }
}
