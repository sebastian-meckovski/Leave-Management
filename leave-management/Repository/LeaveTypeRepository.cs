using leave_management.Contracts;
using leave_management.Data;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : GenericRepositorty<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
