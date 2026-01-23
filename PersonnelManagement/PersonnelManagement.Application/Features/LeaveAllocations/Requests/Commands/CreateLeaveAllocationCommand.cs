using MediatR;
using PersonnelManagement.Application.DTOs.LeaveAllocation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
