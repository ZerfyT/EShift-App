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
        public string GoodsDescription { get; set; }
        public decimal EstimatedWeight { get; set; }
        public string Status { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        public ICollection<Load> Loads { get; set; } = new List<Load>();
    }
}
