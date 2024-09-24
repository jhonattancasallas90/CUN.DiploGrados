using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Domain.Interface;
using CUN.DiploGrados.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
