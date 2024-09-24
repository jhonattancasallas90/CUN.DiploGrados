using CUN.DiploGrados.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CUN.DiploGrados.Services.WebApi.Controllers.v1
{
    //[Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class StudentsController : Controller
    {
        private readonly IStudentsApplication _studentsApplication;
        public StudentsController(IStudentsApplication studentApplication)
        {
            _studentsApplication = studentApplication;
        }

        [HttpGet("GetStudentById/{customerId}")]
        public IActionResult GetStudentById(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();
            var response = _studentsApplication.GetStudentById(customerId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
