using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Infrastructure.Data;
using CUN.DiploGrados.Infrastructure.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CUN.DiploGrados.Infrastructure.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly DapperContext _context;
        private readonly DapperOracleContext _oracleContext;

        public StudentsRepository(DapperContext context, DapperOracleContext oracleContext)
        {
            _context = context;
            _oracleContext = oracleContext;
        }

        public IEnumerable<Students> GetStudentById(string studentId)
        {
            using (var connection = _context.CreateConnectionSql())
            {
                var query = @" SELECT
                         [NUM_IDENTIFICACION],
                         [NOMBRE_ESCUELA],
                         [NOM_TERCERO],
                         [SEG_NOMBRE],
                         [PRI_APELLIDO],
                         [SEG_APELLIDO],
                         [GEN_TERCERO],
                         [DIR_EMAIL],
                         [TIP_IDENTIFICACION]
                     FROM [CUN_REPOSITORIO].[CUN].[ESTADISTICA_ESTUDIANTE_2]
                     WHERE [NUM_IDENTIFICACION] = @NumIdentificacion";

                var parameters = new { NumIdentificacion = studentId };

                var customers = connection.Query<Students>(query, parameters);

                return customers;
            }
        }


        public Students GetStudentByParametersR(string codPrograma, string studentId)
        {
            try
            {
                using (var connection = _context.CreateConnectionSql())
                {
                    var query = @"SELECT
                                [NUM_IDENTIFICACION],
                                [NOMBRE_ESCUELA],
                                [NOM_TERCERO],
                                [SEG_NOMBRE],
                                [PRI_APELLIDO],
                                [SEG_APELLIDO],
                                [GEN_TERCERO],
                                [DIR_EMAIL],
                                [TIP_IDENTIFICACION]
                            FROM [CUN_REPOSITORIO].[CUN].[ESTADISTICA_ESTUDIANTE_2]
                            WHERE [NUM_IDENTIFICACION] = @NumIdentificacion
                            AND [COD_PERIODO] = @CodPrograma; ";

                    var parameters = new { CodPrograma = codPrograma, NumIdentificacion = studentId };

                    var students = connection.QueryFirstOrDefault<Students>(query, parameters);

                    return students;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetStudentByParameters: {ex.Message}");
                return null; // Devuelve null si ocurre un error
            }
        }

        // Para tomar esta referencia, se debe tener en cuenta que el estudiante debe estar graduado
        public StudentsGradeInfo GetStudentGradeInfo(string studentId, string nivel)
        {
            StudentsGradeInfo gradeInfo = null; // Inicializamos en null para verificar si se recupera algo.

            using (var connection = _oracleContext.CreateConnectionOracle())
            {
                try
                {
                    // Asegúrate de que la conexión esté abierta
                    connection.Open();

                    var query = @"SELECT DISTINCT gc.SEDE_GRADO, gc.SNIES, gc.TITULACION, gc.ACTA, gc.NRO_REGISTRO, gc.FOLIO, gc.LIBRO, gc.GRADO_FECHA 
                                FROM ICEBERG.GRADOS_CUN gc
                                WHERE IDENTIFICACION_SINU = :IDENTIFICACION
                                AND (
                                    (gc.NIVEL = 'TÉCNICO' AND :NIVEL = 1) OR
                                    (gc.NIVEL = 'TECNÓLOGO' AND :NIVEL = 2) OR
                                    (gc.NIVEL = 'PROFESIONAL' AND :NIVEL = 3)
                                )";

                    var parameters = new { IDENTIFICACION = studentId, NIVEL = nivel };

                    // Ejecutamos la consulta y asignamos el resultado a 'info'

                    gradeInfo = connection.QueryFirstOrDefault<StudentsGradeInfo>(query, parameters);
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    // Aquí puedes capturar errores específicos de Oracle
                    Console.WriteLine($"Error de Oracle: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Captura cualquier otro tipo de excepción
                    Console.WriteLine($"Error general: {ex.Message}");
                }
                finally
                {
                    // Asegúrate de cerrar la conexión si estaba abierta
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return gradeInfo; // Devuelve el resultado o null si no se encontró nada
        }

        public Master GetTemplateType(string opcion)
        {
            // Creamos una nueva instancia de Master
            Master master = new Master();

            // Limpiamos la lista para asegurar que no tenga valores anteriores
            master.TipoPlantilla.Clear();

            // Asignar TipoPlantilla basado en la opción
            if (opcion == "1")
            {
                master.TipoPlantilla.Add("grados");
            }
            else if (opcion == "2")
            {
                master.TipoPlantilla.Add("duplicados");
            }
            else if (opcion == "3")
            {
                master.TipoPlantilla.Add("honores Causa");
            }
            else
            {
                master.TipoPlantilla.Add("Opción inválida");
            }

            // Devolver la instancia de Master
            return master;
        }

        // CodPrograma es equivalente a la columna PLAN
        public async Task<Payload> GetGradeCertificatesAsync(string studentId, string codPrograma, string nivel, string opcion)
        {
            Master tipoPlantilla = new Master();
            Payload payload = new Payload();
            Students student = null;
            StudentsPayload studentPay = new StudentsPayload(); // Payload del estudiante
            StudentsGradeInfo gradeInfo = null;

            string url = "https://digisign-backend.onrender.com/api/workflows/NewIntegration";
            string gender = "Masculino";
            string tipoIdentificacion = "TI";

            try
            {
                // Obtener la plantilla basada en la opción seleccionada
                tipoPlantilla = GetTemplateType(opcion); // Este método ya devuelve un objeto Master con el valor seleccionado
                student = GetStudentByParametersR(codPrograma, studentId);
                gradeInfo = GetStudentGradeInfo(studentId, nivel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error obteniendo datos: {ex.Message}");
            }

            if (student != null || gradeInfo != null)
            {
                try
                {
                    if (student.TIP_IDENTIFICACION?.ToUpper() == "C")
                    {
                        tipoIdentificacion = "CC";
                    }

                    Guid guid = new Guid("5c0e5a08-1a5f-4f4b-99c7-c3fc8c57da27");
                    payload.Guid = guid;
                    payload.Emailkey = "email";

                    // Asignar las propiedades generales del estudiante a studentPay
                    studentPay.Master =  tipoPlantilla; // Asignar el array de plantillas

                    studentPay.Identificacion = student?.NUM_IDENTIFICACION;
                    studentPay.NombreEscuela = student?.NOMBRE_ESCUELA;
                    studentPay.Nombres = $"{student?.NOM_TERCERO ?? ""} {student?.SEG_NOMBRE ?? ""}".Trim();
                    studentPay.Apellidos = $"{student?.PRI_APELLIDO ?? ""} {student?.SEG_APELLIDO ?? ""}".Trim();
                    studentPay.NombresYApellidos = $"{student?.NOM_TERCERO ?? ""} {student?.SEG_NOMBRE ?? ""} {student?.PRI_APELLIDO ?? ""} {student?.SEG_APELLIDO ?? ""}".Trim();
                    studentPay.Genero = student?.GEN_TERCERO;
                    studentPay.Email = student?.DIR_EMAIL;
                    studentPay.TipoDocumento = tipoIdentificacion;

                    studentPay.TipoDocumentoActa = student?.TIP_IDENTIFICACION switch
                    {
                        "C" => "Cédula de ciudadanía",
                        "P" => "Pasaporte",
                        "T" => "Tarjeta de Identidad",
                        "E" => "Cédula de extranjería",
                        "PPT" => "Permiso de Protección Temporal",
                        "R" => "Registro civil",
                        "N" => "Número de identificación tributaria (NIT)",
                        _ => "Tipo de documento desconocido"
                    };

                    // Asignar la información específica de grado directamente a studentPay
                    studentPay.SEDE_GRADO = gradeInfo?.SEDE_GRADO;
                    studentPay.SNIES = gradeInfo?.SNIES;
                    studentPay.TITULACION = gradeInfo?.TITULACION;
                    studentPay.ACTA = gradeInfo?.ACTA;
                    studentPay.NRO_REGISTRO = gradeInfo?.NRO_REGISTRO;
                    studentPay.FOLIO = gradeInfo?.FOLIO;
                    studentPay.LIBRO = gradeInfo?.LIBRO;

                    // Parsear y asignar la fecha de grado si es válida
                    if (DateTime.TryParse(gradeInfo?.GRADO_FECHA, out DateTime fecha))
                    {
                        studentPay.DiaNumero = fecha.Day;
                        studentPay.DiaTexto = DateConversor.DiaALetras(fecha.Day);
                        studentPay.MesNumero = fecha.Month;
                        studentPay.MesTexto = DateConversor.MesEnLetras(fecha.Month);
                        studentPay.AgnoNumero = fecha.Year;
                        studentPay.AgnoTexto = DateConversor.AñoALetras(fecha.Year);
                    }
                    else
                    {
                        studentPay.DiaTexto = null;
                        studentPay.MesTexto = null;
                        studentPay.AgnoTexto = null;
                    }

                    // Asignar el payload
                    payload.Datos = new StudentsPayload[] { studentPay };

                    // Convertir el payload a JSON
                    var jsonPayload = JsonSerializer.Serialize(payload);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    using (var httpClient = new HttpClient())
                    {
                        // Enviar el payload al servicio
                        HttpResponseMessage httpResponse = await httpClient.PostAsync(url, content);

                        if (httpResponse.IsSuccessStatusCode)
                        {
                            string jsonResponse = await httpResponse.Content.ReadAsStringAsync();
                            return payload;
                        }
                        else
                        {
                            Console.WriteLine($"Error al llamar a la API: {httpResponse.StatusCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al procesar los datos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("El estudiante o la información de grado son nulos.");
            }

            return payload;
        }


    }
}
