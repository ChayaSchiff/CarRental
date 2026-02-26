using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string LicenseNumber { get; set; }

        //public virtual ICollection<Rental> Rentals { get; set; }
    }
}
