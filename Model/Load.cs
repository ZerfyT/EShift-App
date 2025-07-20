using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShift_App.Model
{
    public class Load
    {
        [Key]
        public int LoadID { get; set; }
        public string LoadNumber { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public DateTime? PickupDateTime { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        //public string Status { get; set; } // e.g., "Pending", "In Transit", "Delivered"
        public int JobID { get; set; }
        public int? TransportUnitID { get; set; }
        public string GoodsDescription { get; set; }

        [ForeignKey("JobID")]
        public Job Job { get; set; }
        
        [ForeignKey("TransportUnitID")]
        public TransportUnit TransportUnit { get; set; }

    }
}
