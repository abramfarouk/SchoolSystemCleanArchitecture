using MediatR;
using SchoolManagment.Data.Entities;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery :IRequest<Response<IEnumerable<GetStudentListResponse>>>
    {

    }
}
