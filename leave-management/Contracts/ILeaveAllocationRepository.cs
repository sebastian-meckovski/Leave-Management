using leave_management.Data;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
    }
}
