using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data.Repositories
{
    public class LoadRepository : Repository<Load>, ILoadRepository
    {
        public LoadRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Load>> GetLoadsByJobIdAsync(int jobId)
        {
            return await _context.Loads
                .Where(l => l.JobID == jobId)
                .OrderBy(l => l.LoadNumber)
                .ToListAsync();
        }
    }
}
