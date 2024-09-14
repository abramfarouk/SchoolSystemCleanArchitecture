using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListPaginatedQuery :IRequest<PaginatedResult<GetStudentListPaginatedResponse>>
    {
        public  int PageNumber { get; set; }
        public   int PageSize { get; set; }
        public  string[]? OrderBy { get; set; }
        public  string Search { get; set; }
    }
}
