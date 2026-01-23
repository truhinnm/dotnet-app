using MediatR;
using PersonnelManagement.Application.DTOs.LeaveAllocation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
