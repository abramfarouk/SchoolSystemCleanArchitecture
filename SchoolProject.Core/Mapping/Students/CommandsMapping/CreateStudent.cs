using SchoolManagment.Data.Entities;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile 
    {


        public void CreateStudent()
        {
            CreateMap<CreateStudentCommand, Student>()
                   .ForMember(des => des.DID, opt => opt.MapFrom(src => src.DeptarmentID));

        }

    }
}
