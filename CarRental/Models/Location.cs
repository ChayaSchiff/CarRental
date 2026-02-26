using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
