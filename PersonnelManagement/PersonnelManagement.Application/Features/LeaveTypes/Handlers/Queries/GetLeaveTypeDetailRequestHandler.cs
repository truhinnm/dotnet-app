using AutoMapper;
using MediatR;
using PersonnelManagement.Application.DTOs.LeaveType;
using PersonnelManagement.Application.Features.LeaveTypes.Requests.Queries;
using PersonnelManagement.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
