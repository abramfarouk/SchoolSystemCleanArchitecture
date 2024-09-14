using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolSystemCleanArchitecture.Api.Base;
using Router = SchoolProject.Data.AppMetaData.Router;

namespace SchoolSystemCleanArchitecture.Api.Controllers
{
    [ApiController]
    public class StudentController : AppControllerBase
    {

        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> GetListStudentAsync()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            return abram(response);
        }

        [HttpGet(Router.StudentRouting.GetById)]
        public async Task<IActionResult> GetStdById(int id)
        {
            var response = await _mediator.Send(new GetStudentQuery() { Id = id });
            return abram(response);


        }
        [HttpGet(Router.StudentRouting.GetByName)]
        public async Task<IActionResult> GetStdByName(string name)
        {
            var response = await _mediator.Send(new GetStdentByNameQuery(name));
            return abram(response);


        }

        [HttpPost(Router.StudentRouting.Create)]
        public async Task<IActionResult> CreateAsync(CreateStudentCommand command)
        {
            var res = await _mediator.Send(command);
            return abram(res);
        }

        [HttpPut(Router.StudentRouting.Update)]
        public async Task<IActionResult> UpdateAsync(EditStudentCommand command)
        {
            var res = await _mediator.Send(command);
            return abram(res);
        }

        [HttpDelete(Router.StudentRouting.Delete)]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var res = await _mediator.Send(new DeleteStudentCommand(id));
            return abram(res);
        }



    }
}
