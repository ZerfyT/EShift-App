using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<IEnumerable<Customer>> SearchAsync(string searchText);
        Task<bool> PhoneNumberExistsAsync(string phoneNumber, int? customerIdToIgnore = null);
    }
}
