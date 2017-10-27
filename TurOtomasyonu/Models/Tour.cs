using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TurOtomasyonu.Models
{
    public class Tour
    {
        public Tour()
        {
            this.Histories = new HashSet<CustomerTourHistory>();
            this.Comments = new HashSet<Comment>();
            this.Votes = new HashSet<Vote>();

        }

        public int Id { get; set; }
        public string TourName { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        [Range(30,45)] //Fluent API ile yapamıyoruz range aralık belirler.
        public int Quota { get; set; }

        public virtual ICollection<CustomerTourHistory> Histories { get; set; }
        public virtual TourCategory TourCategory { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

    }
}