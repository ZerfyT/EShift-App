using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data.Repositories
{
    public class TransportUnitRepository : Repository<TransportUnit>, ITransportUnitRepository
    {
        public TransportUnitRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<TransportUnit> FindOrCreateAsync(int lorryId, int driverId, int assistantId)
        {
            var existingUnit = await _context.TransportUnits
                .FirstOrDefaultAsync(tu => tu.LorryID == lorryId &&
                                           tu.DriverID == driverId &&
                                           tu.AssistantID == assistantId);

            if (existingUnit != null)
            {
                return existingUnit;
            }

            var newUnit = new TransportUnit
            {
                LorryID = lorryId,
                DriverID = driverId,
                AssistantID = assistantId
            };

            await AddAsync(newUnit);
            await SaveChangesAsync();

            return newUnit;
        }
    }
}
