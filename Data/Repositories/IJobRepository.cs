using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    public interface IJobRepository : IRepository<Job>
    {
        Task<IEnumerable<Job>> GetJobsByCustomerIdAsync(int customerId);
        Task<IEnumerable<Job>> GetJobsByStatusAsync(string status);
        Task<IEnumerable<Job>> SearchJobsAsync(string searchTerm);
    }
}
