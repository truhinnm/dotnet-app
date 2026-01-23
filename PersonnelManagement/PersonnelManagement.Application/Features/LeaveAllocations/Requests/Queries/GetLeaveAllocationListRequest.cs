using MediatR;
using PersonnelManagement.Application.DTOs.LeaveAllocation;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
    }
}