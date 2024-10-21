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

                // Convertir la opción a int si es necesario
                int opcionInt = int.Parse(opcion);
                Master payload = _studentsDomain.GetTemplateType(opcionInt.ToString());
                response.Data = payload;

                if (payload != null && !string.IsNullOrEmpty(payload.TipoPlantilla)) // Verifica el campo TipoPlantilla
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
                response.Message = $"Error: {e.Message}"; // Considera registrar la excepción aquí
                                                          // logger.LogError(e, "Error al obtener el tipo de plantilla."); // Ejemplo de registro
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

                // Mapear el payload a la respuesta si tienes un mapper, de lo contrario asignar directamente
                response.Data = _mapper.Map<Payload>(payload); // Si usas AutoMapper, sino asigna directamente

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Certificados de grado obtenidos correctamente.";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "No se encontraron certificados de grado.";
                }
            }
            catch (Exception e)
            {
                response.IsSuccess = false;
                response.Message = $"Error: {e.Message}";
            }

            return response;
        }


    }
}
