using AutoMapper;
using MediatR;
using SchoolManagment.Data.Entities;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Wrappers;
using SchoolProject.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class GetStudentListQueryHandler : ResponseHandler,
        IRequestHandler<GetStudentListQuery, Response<IEnumerable<GetStudentListResponse>>>
        ,IRequestHandler<GetStudentQuery , Response<GetStudentReponse>> 
        ,IRequestHandler<GetStdentByNameQuery, Response<GetStdentByNameResponse>>
        , IRequestHandler<GetStudentListPaginatedQuery, PaginatedResult<GetStudentListPaginatedResponse>>
    {

        #region Fields
        private readonly IStudentServices _studentServices;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor
        public GetStudentListQueryHandler(IStudentServices studentServices, IMapper mapper)
        {
            _studentServices = studentServices;
            _mapper = mapper;
        }
        #endregion

        #region  Functions

        public async Task<Response<IEnumerable<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentServices.GetStudentsAysnc();
            var studentMapper = _mapper.Map<IEnumerable<GetStudentListResponse>>(studentList);
            return Success(studentMapper);

        }

        public async Task<Response<GetStudentReponse>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            var std = await _studentServices.GetStudentByIdAysnc(request.Id);
            if (std == null)
            {
                return NotFound<GetStudentReponse>($"ID: {request.Id} Not Founded ");
            }
            var stdMapper = _mapper.Map<GetStudentReponse>(std);
            return Success(stdMapper);

        }

        public async Task<Response<GetStdentByNameResponse>> Handle(GetStdentByNameQuery request, CancellationToken cancellationToken)
        {
            var stdName = await _studentServices.GetStudentByNameAysnc(request.Name);
            if(stdName == null) { return NotFound<GetStdentByNameResponse>($"Name : {request.Name} not found"); }

            var stdMapper= _mapper.Map<GetStdentByNameResponse>(stdName);
            return Success(stdMapper);  
        }

    
        Task<PaginatedResult<GetStudentListPaginatedResponse>> IRequestHandler<GetStudentListPaginatedQuery, PaginatedResult<GetStudentListPaginatedResponse>>.Handle(GetStudentListPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
