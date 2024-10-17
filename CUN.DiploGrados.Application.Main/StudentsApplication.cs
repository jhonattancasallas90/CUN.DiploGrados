using AutoMapper;
using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Application.Interface;
using CUN.DiploGrados.Domain.Entity;
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

        public StudentsApplication(IStudentsDomain studentDomain, IMapper mapper, IAppLogger<StudentsApplication> logger)
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
                    response.Message = "Successful Search";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Unsuccessful Search";
                }
            }
            catch (Exception e)
            {
                response.IsSuccess = false;
                response.Message = $"Error: {e.Message}"; // Incluir más información en el error
            }
            return response;
        }

        public Response<StudentDTO> GetStudentByParameters(string studentId, string codProgram)
        {
            var response = new Response<StudentDTO>();
            try
            {
                var student = _studentsDomain.GetStudentByParameters(studentId, codProgram);
                response.Data = _mapper.Map<StudentDTO>(student); // Mapear como colección

                if (response.Data != null) // Verificar que haya datos
                {
                    response.IsSuccess = true;
                    response.Message = "Successful Search";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Unsuccessful Search";
                }
            }
            catch (Exception e)
            {
                response.IsSuccess = false;
                response.Message = $"Error: {e.Message}"; // Incluir más información en el error
            }
            return response;
        }

        public Response<StudentsGradeInfo> GetStudentsGradeInfo(string studentId, string nivel)
        {
            Response<StudentsGradeInfo> response = new Response<StudentsGradeInfo>();
            try
            {
                StudentsGradeInfo payload = _studentsDomain.GetStudentsGradeInfo(studentId, nivel);
                response.Data = _mapper.Map<StudentsGradeInfo>(payload); // Mapear como colección

                if (response.Data != null) // Verificar que haya datos
                {
                    response.IsSuccess = true;
                    response.Message = "Successful Search";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Unsuccessful Search";
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
