using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
