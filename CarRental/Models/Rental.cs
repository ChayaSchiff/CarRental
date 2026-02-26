using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
