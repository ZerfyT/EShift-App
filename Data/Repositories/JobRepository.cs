using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Job>> GetJobsByCustomerIdAsync(int customerId)
        {
            return await _context.Jobs
                .Include(j => j.Loads)
                .Where(j => j.CustomerID == customerId)
                .OrderByDescending(j => j.JobDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Job>> GetJobsByStatusAsync(string status)
        {
            return await _context.Jobs
                .Include(j => j.Customer)
                .Where(j => j.Status == status)
                .OrderBy(j => j.JobDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Job>> SearchJobsAsync(string searchTerm)
        {
            var trimmedSearchTerm = searchTerm?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(trimmedSearchTerm))
            {
                return await _context.Jobs.Include(j => j.Customer).OrderByDescending(j => j.JobDate).ToListAsync();
            }

            return await _context.Jobs
                .Include(j => j.Customer)
                .Where(j =>
                    j.JobNumber.ToLower().Contains(trimmedSearchTerm) ||
                    (j.Customer.FirstName + " " + j.Customer.LastName).ToLower().Contains(trimmedSearchTerm) ||
                    j.StartLocation.ToLower().Contains(trimmedSearchTerm) ||
                    j.Destination.ToLower().Contains(trimmedSearchTerm))
                .ToListAsync();
        }
    }
}
