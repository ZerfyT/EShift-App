using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift_App.Model
{
    internal class Load
    {
        [Key]
        public int LoadID { get; set; }
        public string LoadNumber { get; set; } // Unique identifier for the load
        public string Description { get; set; } // Description of the load
        public int Weight { get; set; } // Weight of the load in kilograms
        public int Volume { get; set; } // Volume of the load in cubic meters
        public DateTime PickupDateTime { get; set; } // Date and time for pickup
        public DateTime DeliveryDateTime { get; set; } // Scheduled date for the load
        public string Status { get; set; } // e.g., "Pending", "In Transit", "Delivered"
        public int ContainerID { get; set; } // Foreign key to Container
        public int JobID { get; set; } // Foreign key to Job
        public int TransportUnitID { get; set; } // Foreign key to Lorry or Trailer
        
        [ForeignKey("ContainerID")]
        public Container Container { get; set; }
        
        [ForeignKey("JobID")]
        public Job Job { get; set; }
        
        [ForeignKey("TransportUnitID")]
        public TransportUnit TransportUnit { get; set; }

    }
}
