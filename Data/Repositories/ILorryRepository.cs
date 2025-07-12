using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    public interface ILorryRepository : IRepository<Lorry>
    {
        Task<IEnumerable<Lorry>> SearchAsync(string searchText);
        Task<bool> RegistrationNumberExistsAsync(string registrationNumber, int? lorryIdToIgnore = null);
    }
}
