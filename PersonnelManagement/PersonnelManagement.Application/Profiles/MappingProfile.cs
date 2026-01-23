using AutoMapper;
using PersonnelManagement.Application.DTOs.LeaveAllocation;
using PersonnelManagement.Application.DTOs.LeaveRequest;
using PersonnelManagement.Application.DTOs.LeaveType;
using PersonnelManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>()
                .ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>()
                .ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>()
                .ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>()
                .ReverseMap();
        }
    }
}
