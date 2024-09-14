using SchoolManagment.Data.Entities;
using SchoolProject.Core.Features.Students.Commands.Models;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {


        public void EditStudent()
        {
            CreateMap<EditStudentCommand, Student>()
                   .ForMember(des => des.StudID, opt => opt.MapFrom(src => src.Id))
                   .ForMember(des => des.DID, opt => opt.MapFrom(src => src.DeptarmentID));
        }

    }
}
