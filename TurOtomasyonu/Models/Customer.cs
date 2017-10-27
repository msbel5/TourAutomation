using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TurOtomasyonu.Validations;

namespace TurOtomasyonu.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Histories = new HashSet<CustomerTourHistory>();
            this.Comments = new HashSet<Comment>();
            this.Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [ComplexPassword]
        public string Password { get; set; }

        public virtual CustomerProfile CustomerProfile { get; set; }
        public virtual ICollection<CustomerTourHistory> Histories { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}