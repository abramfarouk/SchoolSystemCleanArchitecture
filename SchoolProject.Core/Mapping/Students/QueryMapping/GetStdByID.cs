using SchoolManagment.Data.Entities;
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
        public void GetStudentByIDMapping()
        {
            CreateMap<Student, GetStudentReponse>()
                   .ForMember(des => des.Code, opt => opt.MapFrom(src => src.StudID))
                   .ForMember(des => des.DepartName, opt => opt.MapFrom(src => src.Department.DName));

        }
    }
}
