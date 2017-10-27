using System.Collections.Generic;

namespace TurOtomasyonu.Models
{
    public class TourCategory
    {
        //Alt kategori ise parent kategorisi olur değilse null olur.
        public TourCategory()
        {
            this.SubCategories = new HashSet<TourCategory>();
            this.Tours = new HashSet<Tour>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? TopCategoryId { get; set; }


        public virtual ICollection<TourCategory> SubCategories { get; set; }
        public virtual TourCategory ParentCategory { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

    }
}