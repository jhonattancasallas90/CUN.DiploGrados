using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Application.Interface
{
    public interface IStudentsApplication
    {
        Response<IEnumerable<StudentDTO>> GetStudentById(string studentId);
    }
}
