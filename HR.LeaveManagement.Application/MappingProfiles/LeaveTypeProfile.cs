﻿using AutoMapper;
using HR.LeaveManagement.Application.Features.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Features.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Features.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>();
            CreateMap<CreateLeaveTypeCommand, LeaveType>();
            CreateMap<UpdateLeaveTypeCommand, LeaveType>();
        }
    }
}
