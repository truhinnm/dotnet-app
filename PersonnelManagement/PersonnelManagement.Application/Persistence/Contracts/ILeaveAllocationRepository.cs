using PersonnelManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task <List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
