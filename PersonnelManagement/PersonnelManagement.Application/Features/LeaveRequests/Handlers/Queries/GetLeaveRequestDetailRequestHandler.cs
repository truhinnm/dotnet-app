using AutoMapper;
using MediatR;
using PersonnelManagement.Application.DTOs.LeaveRequest;
using PersonnelManagement.Application.Features.LeaveRequests.Requests.Queries;
using PersonnelManagement.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelManagement.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetails(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}
