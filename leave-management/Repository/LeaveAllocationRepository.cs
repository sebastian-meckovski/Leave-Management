﻿using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : GenericRepositorty<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(ApplicationDbContext context) : base(context)
        {

        }

        public bool Create(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task LeaveAllocation(int leaveTypeId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
