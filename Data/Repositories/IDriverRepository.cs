using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    public interface IDriverRepository : IRepository<Driver>
    {
        Task<IEnumerable<Driver>> SearchAsync(string searchText);
        Task<bool> LicenseNumberExistsAsync(string licenseNumber, int? driverIdToIgnore = null);
    }
}
