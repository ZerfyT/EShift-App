using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    public interface IAssistantRepository : IRepository<Assistant>
    {
        Task<IEnumerable<Assistant>> SearchAsync(string name);
    }
}
