using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;

namespace EShift_App.Service
{
    public interface IJobService
    {
        Task<Job> PlaceNewJobAsync(int customerId, string startLocation, string destination, DateTime jobDate, string goodsDescription, decimal weight, decimal volume);
    }
}
