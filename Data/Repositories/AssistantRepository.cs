using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data.Repositories
{
    public class AssistantRepository : Repository<Assistant>, IAssistantRepository
    {
        public AssistantRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Assistant>> SearchAsync(string name)
        {
            var trimmedName = name?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(trimmedName))
            {
                return await GetAllAsync();
            }

            return await _context.Assistants
                .Where(a => a.FirstName.ToLower().Contains(trimmedName) ||
                            a.LastName.ToLower().Contains(trimmedName))
                .ToListAsync();
        }
    }
}
