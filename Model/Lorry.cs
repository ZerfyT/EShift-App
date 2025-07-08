using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift_App.Model
{
    internal class Lorry
    {
        public int LorryID { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; } // e.g., "Available", "In Use", "Maintenance"
    }
}
