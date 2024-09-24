using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Application.Interface;
using System.Threading.Tasks;

namespace CUN.DiploGrados.Services.WebApi.Controllers.v1
{
    //[Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class CustomersController : Controller
    {
        private readonly IStudentsApplication _studentsApplication;
        public CustomersController(IStudentsApplication customersApplication)
        {
            _studentsApplication = customersApplication;
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