using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CUN.DiploGrados.Infrastructure.Interface
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetStudentById(string studentId);
        Students GetStudentByParameters(string studentId, string codPrograma);
        StudentsGradeInfo GetStudentGradeInfo(string studentId, string nivel);
        Master GetTemplateType(string opcion);
        Task<Payload> GetGradeCertificatesAsync(string studentId, string codPrograma, string nivel, string opcion);

    }
}
