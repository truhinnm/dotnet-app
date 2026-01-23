using MediatR;
using PersonnelManagement.Application.DTOs.LeaveRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDto>>
    {
    }
}
