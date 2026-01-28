using PersonnelManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}
