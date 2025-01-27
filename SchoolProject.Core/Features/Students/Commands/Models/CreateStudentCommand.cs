﻿using MediatR;
using SchoolProject.Core.Bases;

namespace SchoolProject.Core.Features.Students.Commands.Models
{
    public class CreateStudentCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
        public int DeptarmentID { get; set; }
    }
}
