using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShift_App.Model
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }
        public string JobNumber { get; set; }
        public int CustomerID { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public DateTime JobDate { get; set; }
        public string Status { get; set; } // Consider using an enum here

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        public ICollection<Load> Loads { get; set; } = new List<Load>();
    }
}
