using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurOtomasyonu.Models
{
    public class CustomerProfile
    {
        private int _Id;

        public CustomerProfile(int Id)
        {
            _Id = Id;
        }

        public int Id {
            get { return _Id; }
            private set { _Id = value; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Hobies { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public virtual Customer Customer { get; set; }

    }
}