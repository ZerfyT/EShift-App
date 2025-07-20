using EShift_App.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EShift_App.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> PhoneNumberExistsAsync(string phoneNumber, int? customerIdToIgnore = null)
        {
            var query = _context.Customers.AsQueryable();

            if (customerIdToIgnore.HasValue)
            {
                query = query.Where(c => c.CustomerID != customerIdToIgnore.Value);
            }

            return await query.AnyAsync(c => c.PhoneNumber == phoneNumber);
        }

        public async Task<IEnumerable<Customer>> SearchAsync(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return await GetAllAsync();
            }

            var searchTextLower = searchText.Trim().ToLower();

            return await _context.Customers
                .Where(c => c.FirstName.ToLower().Contains(searchTextLower) ||
                            c.LastName.ToLower().Contains(searchTextLower) ||
                            c.PhoneNumber.Contains(searchTextLower))
                .ToListAsync();
        }

        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(c => c.Email.ToLower() == email.ToLower());
        }
    }
}
