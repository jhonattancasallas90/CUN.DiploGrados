using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Transversal.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CUN.DiploGrados.Application.Interface
{
    public interface IStudentsApplication
    {
        Response<IEnumerable<StudentDTO>> GetStudentById(string studentId);
        Response<StudentDTO> GetStudentByParameters(string studentId, string codProgram);
        Response<StudentsGradeInfo> GetStudentsGradeInfo(string studentId, string nivel);
        Response<Master> GetTemplateType(string opcion);
        Task<Response<Payload>> GetGradeCertificatesAsync(string studentId, string codProgram, string nivel, string opcion);
    }
}
