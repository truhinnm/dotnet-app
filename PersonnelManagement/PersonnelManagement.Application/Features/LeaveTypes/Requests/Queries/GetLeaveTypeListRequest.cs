using MediatR;
using PersonnelManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
