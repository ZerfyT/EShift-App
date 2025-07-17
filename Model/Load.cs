using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShift_App.Model
{
    public class Load
    {
        [Key]
        public int LoadID { get; set; }
        public string LoadNumber { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }
        public DateTime PickupDateTime { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public string Status { get; set; } // e.g., "Pending", "In Transit", "Delivered"
        //public int ContainerID { get; set; }
        public int JobID { get; set; }
        public int TransportUnitID { get; set; }
        public string GoodsDescription { get; set; }
        public decimal EstimatedWeight { get; set; }
        public decimal EstimatedVolume { get; set; }


        //[ForeignKey("ContainerID")]
        //public Container Container { get; set; }

        [ForeignKey("JobID")]
        public Job Job { get; set; }
        
        [ForeignKey("TransportUnitID")]
        public TransportUnit TransportUnit { get; set; }

    }
}
