using CUN.DiploGrados.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Interface
{
    public interface IStudentsDomain
    {
        IEnumerable<Students> GetStudentById(string studentId);

        IEnumerable<Students> GetStudentByParameters(string studentId, string codPrograma);
    }
}
