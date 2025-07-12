using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShift_App.Model
{
    public class TransportUnit
    {
        [Key]
        public int TransportUnitID { get; set; }
        public int LorryID { get; set; }
        public int DriverID { get; set; }
        public int AssistantID { get; set; }

        [ForeignKey("LorryID")]
        public Lorry Lorry { get; set; }

        [ForeignKey("DriverID")]
        public Driver Driver { get; set; }

        [ForeignKey("AssistantID")]
        public Assistant Assistant { get; set; }

        public ICollection<Load> Loads { get; set; } = new List<Load>();
    }
}
