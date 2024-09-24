using CUN.DiploGrados.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Infrastructure.Interface
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetStudentById(string studentId);
    }
}
