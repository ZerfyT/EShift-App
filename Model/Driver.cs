using System.ComponentModel.DataAnnotations;

namespace EShift_App.Model
{
    public class Driver
    {
        [Key]
        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public string PhoneNumber { get; set; }
        //public string? Email { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<TransportUnit> TransportUnits { get; set; } = new List<TransportUnit>();
    }
}
