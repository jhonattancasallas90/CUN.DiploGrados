using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Domain.Interface;
using CUN.DiploGrados.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CUN.DiploGrados.Domain.Core
{
    public class StudentsDomain : IStudentsDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentsDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Students> GetStudentById(string studentId)
        {
            return _unitOfWork.Students.GetStudentById(studentId);
        }

        public Students GetStudentByParameters(string studentId, string codPrograma) 
        {
            return _unitOfWork.Students.GetStudentByParameters(studentId, codPrograma);
        }

        public StudentsGradeInfo GetStudentsGradeInfo(string studentId, string nivel)
        {
            return _unitOfWork.Students.GetStudentGradeInfo(studentId, nivel);
        }

        public Master GetTemplateType(string opcion)
        {
            return _unitOfWork.Students.GetTemplateType(opcion);
        }

        public async Task<Payload> GetGradeCertificatesAsync(string studentId, string codPrograma, string nivel, string opcion)
        {
            // Utilizamos await para esperar el resultado del método asíncrono
            return await _unitOfWork.Students.GetGradeCertificatesAsync(studentId, codPrograma, nivel, opcion);
        }
    }
}
