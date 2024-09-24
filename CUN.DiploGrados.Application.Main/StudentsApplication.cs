using AutoMapper;
using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Application.Interface;
using CUN.DiploGrados.Domain.Interface;
using CUN.DiploGrados.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CUN.DiploGrados.Application.Main
{
    public class StudentsApplication : IStudentsApplication
    {
        private readonly IStudentsDomain _studentsDomain;

        private readonly IMapper _mapper;

        private readonly IAppLogger<StudentsApplication> _logger;

        public StudentsApplication(IStudentsDomain studentDomain, IMapper mapper, IAppLogger<StudentsApplication> logger ) 
        { 
            _studentsDomain = studentDomain;
            _mapper = mapper;
            _logger = logger;
        }

        public Response<IEnumerable<StudentDTO>> GetStudentById(string studentId)
        {
            var response = new Response<IEnumerable<StudentDTO>>();
            try
            {
                var customer = _studentsDomain.GetStudentById(studentId);
                response.Data = _mapper.Map<IEnumerable<StudentDTO>>(customer); // Mapear como colección

                if (response.Data != null && response.Data.Any()) // Verificar que haya datos
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "No se encontraron registros.";
                }
            }
            catch (Exception e)
            {
                response.IsSuccess = false;
                response.Message = $"Error: {e.Message}"; // Incluir más información en el error
            }
            return response;
        }
    }
}
