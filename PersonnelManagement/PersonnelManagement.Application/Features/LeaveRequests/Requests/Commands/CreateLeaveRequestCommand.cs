using MediatR;
using PersonnelManagement.Application.DTOs.LeaveRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
