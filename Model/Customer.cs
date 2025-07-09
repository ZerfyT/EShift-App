using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift_App.Model
{
    internal class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Job> Jobs { get; set; } = new List<Job>(); 
    }
}
