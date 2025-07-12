using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data.Repositories
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        public DriverRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Driver>> SearchAsync(string searchText)
        {
            var trimmedSearchText = searchText?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(trimmedSearchText))
            {
                return await GetAllAsync();
            }

            return await _context.Drivers
                .Where(d => d.FirstName.ToLower().Contains(trimmedSearchText) ||
                            d.LastName.ToLower().Contains(trimmedSearchText) ||
                            d.LicenseNumber.ToLower().Contains(trimmedSearchText))
                .ToListAsync();
        }

        public async Task<bool> LicenseNumberExistsAsync(string licenseNumber, int? driverIdToIgnore = null)
        {
            var query = _context.Drivers.AsQueryable();

            if (driverIdToIgnore.HasValue)
            {
                query = query.Where(d => d.DriverID != driverIdToIgnore.Value);
            }

            return await query.AnyAsync(d => d.LicenseNumber == licenseNumber);
        }
    }
}
