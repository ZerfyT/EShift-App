using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Data.Repositories;
using EShift_App.Model;

namespace EShift_App.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly ILoadRepository _loadRepository;

        public JobService(IJobRepository jobRepository, ILoadRepository loadRepository)
        {
            _jobRepository = jobRepository;
            _loadRepository = loadRepository;
        }

        public async Task<Job> PlaceNewJobAsync(int customerId, string startLocation, string destination, DateTime jobDate, string goodsDescription, decimal weight, decimal volume)
        {
            var newJob = new Job
            {
                CustomerID = customerId,
                StartLocation = startLocation,
                Destination = destination,
                JobDate = jobDate,
                Status = "Pending",
                JobNumber = $"ESH-J{DateTime.Now:yyyyMMddHHmmss}",
                GoodsDescription = goodsDescription,
                EstimatedWeight = weight > 0 ? weight : (decimal?)null,
            };

            await _jobRepository.AddAsync(newJob);
            await _jobRepository.SaveChangesAsync();

            return newJob;
        }
    }
}
