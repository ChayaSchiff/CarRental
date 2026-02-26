using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public int LocationId { get; set; }
        public bool AvailabilityStatus { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
