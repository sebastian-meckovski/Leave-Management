using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        public Task<LeaveHistory> AddSync(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveHistory>> GetAllSync()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveHistory> GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
