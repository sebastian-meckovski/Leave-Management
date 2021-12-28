using leave_management.Constants;
using leave_management.Contracts;
using leave_management.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : GenericRepositorty<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> userManager;
        private readonly IleaveTypeRepository leaveTypeRepository;
        public LeaveAllocationRepository(ApplicationDbContext context, 
                                         UserManager<Employee> userManager,
                                         IleaveTypeRepository leaveTypeRepository) : base(context)
        {
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees =  await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;

            foreach (var employee in employees)
            {
                var allocation = new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                };
            }

            throw new NotImplementedException();
        }
    }
}
