using CUN.DiploGrados.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CUN.DiploGrados.Domain.Interface
{
    public interface IStudentsDomain
    {
        IEnumerable<Students> GetStudentById(string studentId);
        Students GetStudentByParameters(string studentId, string codPrograma);
        StudentsGradeInfo GetStudentsGradeInfo(string studentId, string nivel);
        Master GetTemplateType(string opcion); // Cambiado a string
        Task<Payload> GetGradeCertificatesAsync(string studentId, string codPrograma, string nivel, string opcion);     
    }
}
