using Azure;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStdentByNameQuery :IRequest<Bases.Response<GetStdentByNameResponse>>
    {
        public  string Name { get; set; }
        public GetStdentByNameQuery(string name)
        {
            Name = name;
        }
    }
}
