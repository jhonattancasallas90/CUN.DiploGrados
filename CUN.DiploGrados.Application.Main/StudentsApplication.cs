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
using System.Threading.Tasks;

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


        // Se debe ingresar el numero de documento ya culminado y 1 Tecnico, 2 Teconologo, 3 Profesional
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


        public Response<Master> GetTemplateType(string opcion)
        {
            Response<Master> response = new Response<Master>();
            try
            {
                // Validar la opción
                if (string.IsNullOrEmpty(opcion) ||
                    (opcion != "1" && opcion != "2" && opcion != "3"))
                {
                    response.IsSuccess = false;
                    response.Message = "Opción no válida. Debe ser '1', '2' o '3'.";
                    return response;
                }

                // Obtener un solo Master en lugar de un array
                Master payload = _studentsDomain.GetTemplateType(opcion);

                response.Data = payload;  // Asignar el objeto Master directamente

                // Validar si el objeto tiene un dato válido
                if (payload != null && !string.IsNullOrEmpty(payload.TipoPlantilla))
                {
                    response.IsSuccess = true;
                    response.Message = "Búsqueda exitosa.";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "No se encontró ninguna plantilla para la opción dada.";
                }
            }
            catch (Exception e)
            {
                response.IsSuccess = false;
                response.Message = $"Error: {e.Message}"; // Puedes registrar el error aquí también
            }
            return response;
        }


        public async Task<Response<Payload>> GetGradeCertificatesAsync(string studentId, string codPrograma, string nivel, string opcion)
        {
            Response<Payload> response = new Response<Payload>();
            try
            {
                // Llamar a la capa de dominio de forma asíncrona usando await
                Payload payload = await _studentsDomain.GetGradeCertificatesAsync(studentId, codPrograma, nivel, opcion);

                // Mapear el payload a la respuesta
                response.Data = _mapper.Map<Payload>(payload); // Si usas AutoMapper, sino asigna directamente

                // Si no se encuentran datos, asignar el mensaje de error
                if (response.Data == null)
                {
                    response.IsSuccess = false;
                    response.Message = "No se encontraron certificados de grado.";
                }
                else
                {
                    response.IsSuccess = true; // Aquí solo se marca como exitoso, no se asigna mensaje
                }
            }
            catch (Exception e)
            {
                response.IsSuccess = false;
                response.Message = $"Error: {e.Message}";
            }

            return response; // Retornar la respuesta
        }



    }
}
