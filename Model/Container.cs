using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift_App.Model
{
    internal class Container
    {
        [Key]
        public int ContainerID { get; set; }
        public string ContainerNumber { get; set; }
        public string Type { get; set; } // e.g., "20ft", "40ft", "Reefer"
        public int Capacity { get; set; }
        public string Status { get; set; } // e.g., "Available", "In Use", "Maintenance"
    }
}
