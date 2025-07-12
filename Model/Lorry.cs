using System.ComponentModel.DataAnnotations;

namespace EShift_App.Model
{
    public class Lorry
    {
        [Key]
        public int LorryID { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public float Capacity { get; set; }
        //public string Status { get; set; } // e.g., "Available", "In Use", "Maintenance"

        public ICollection<TransportUnit> TransportUnits { get; set; } = new List<TransportUnit>();
    }
}
