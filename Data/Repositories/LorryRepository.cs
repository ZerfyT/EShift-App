using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data.Repositories
{
    public class LorryRepository : Repository<Lorry>, ILorryRepository
    {
        public LorryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Lorry>> SearchAsync(string searchText)
        {
            var trimmedSearchText = searchText?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(trimmedSearchText))
            {
                return await GetAllAsync();
            }

            return await _context.Lorries
                .Where(l => l.RegistrationNumber.ToLower().Contains(trimmedSearchText) ||
                            (l.Model != null && l.Model.ToLower().Contains(trimmedSearchText)))
                .ToListAsync();
        }

        public async Task<bool> RegistrationNumberExistsAsync(string registrationNumber, int? lorryIdToIgnore = null)
        {
            var query = _context.Lorries.AsQueryable();

            if (lorryIdToIgnore.HasValue)
            {
                query = query.Where(l => l.LorryID != lorryIdToIgnore.Value);
            }

            return await query.AnyAsync(l => l.RegistrationNumber == registrationNumber);
        }
    }
}
