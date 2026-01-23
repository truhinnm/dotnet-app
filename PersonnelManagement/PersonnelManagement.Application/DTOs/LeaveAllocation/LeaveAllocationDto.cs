using PersonnelManagement.Application.DTOs.Common;
using PersonnelManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
