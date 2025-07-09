using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift_App.Model
{
    internal class Driver
    {
        [Key]
        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<TransportUnit> TransportUnits { get; set; } = new List<TransportUnit>();
    }
}
