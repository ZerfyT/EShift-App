using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    public interface ILoadRepository: IRepository<Load>
    {
        Task<IEnumerable<Load>> GetLoadsByJobIdAsync(int jobId);
    }
}
