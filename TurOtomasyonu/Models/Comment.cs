using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurOtomasyonu.Models
{
    public class Comment
    {
        public int ID { get; set; }
        [StringLength(500)]
        public string Body { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
