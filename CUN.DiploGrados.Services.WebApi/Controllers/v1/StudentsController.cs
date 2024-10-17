using CUN.DiploGrados.Application.Interface;
using CUN.DiploGrados.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CUN.DiploGrados.Services.WebApi.Controllers.v1
{
    //[Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = false)]                 // Se reemplaza el valor de Deprecated, puesto a que es primera version disponible
    public class StudentsController : Controller
    {
        private readonly IStudentsApplication _studentsApplication;
        public StudentsController(IStudentsApplication studentApplication)
        {
            _studentsApplication = studentApplication;
        }

        /// <summary>
        ///  Metodo para obtener la informacioó del estudiante por identificación
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        [HttpGet("GetStudentById/{studentId}")]
        public IActionResult GetStudentById(string studentId)
        {
            if (string.IsNullOrEmpty(studentId))
                return BadRequest();
            var response = _studentsApplication.GetStudentById(studentId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        /// <summary>
        ///  Metodo para obtener la informacion del estudiante por Identificación y código de programa
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="codPrograma"></param>
        /// <returns></returns>
        [HttpGet("GetStudentsByParameters/{studentId}/{codPrograma}")]
        public IActionResult GetStudentsByParameters(string studentId, string codPrograma)
        {
            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(codPrograma))
                return BadRequest();
            var response = _studentsApplication.GetStudentByParameters(studentId, codPrograma);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        /// <summary>
        ///  Método para obtener los certificados del tercero 
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="nivel"></param>
        /// <returns></returns>
        [HttpGet("GetStudentGradeInfo/{studentId}")]
        public IActionResult GetStudentGradeInfo(string studentId, string nivel)
        {
            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(studentId))
                return BadRequest("Los parámetros no pueden estar vacíos.");

            var response = _studentsApplication.GetStudentsGradeInfo(studentId, nivel);
            if (response.IsSuccess)
                return Ok(response.Data); // Asegúrate de devolver los datos correctos

            return BadRequest(response.Message);
        }


        /// <summary>
        ///  Método para obtener los certificados del tercero 
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="codPrograma"></param>
        /// <returns></returns>
        //[HttpGet("GetGradeCertificates/{studentId}/{codPrograma}")]
        //public IActionResult GetGradeCertificates(string studentId, string codPrograma)
        //{
        //    if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(codPrograma))
        //        return BadRequest();

        //    var response = _studentsApplication.GetGradeCertificates(studentId, codPrograma);
        //    if (response.IsSuccess)
        //        return Ok(response);

        //    return BadRequest(response.Message);
        //}
    }
}
