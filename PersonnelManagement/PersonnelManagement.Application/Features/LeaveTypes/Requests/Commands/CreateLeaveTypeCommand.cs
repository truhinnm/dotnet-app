using MediatR;
using PersonnelManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
