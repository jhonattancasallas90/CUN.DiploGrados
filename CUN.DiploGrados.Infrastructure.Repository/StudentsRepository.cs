using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Infrastructure.Data;
using CUN.DiploGrados.Infrastructure.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                         [COD_PERIODO],
                         [NOM_TERCERO],
                         [SEG_NOMBRE],
                         [PRI_APELLIDO],
                         [SEG_APELLIDO],
                         [NUM_IDENTIFICACION],
                         [GEN_TERCERO],
                         [TIP_IDENTIFICACION],
                         [DIR_EMAIL_PER],
                         [DIR_EMAIL],
                         [TEL_RESIDENCIA],
                         [TEL_CELULAR],
                         [COD_UNIDAD],
                         [NOM_UNIDAD],
                         [COD_PENSUM],
                         [COD_PENSUM_LAURA],
                         [NOM_DEPENDENCIA],
                         [MUNICIPIO_RESIDENCIA],
                         [DEPARTAMENTO_RESIDENCIA],
                         [MUNICIPIO_SEDE],
                         [DEPARTAMENTO_SEDE],
                         [FEC_NACIMIENTO],
                         [EDAD],
                         [MODALIDAD],
                         [NIVEL_FORMACION],
                         [NOM_SECCIONAL],
                         [COD_DPTO],
                         [CICLO],
                         [ubicacion],
                         [CLASE_ACTUAL],
                         [NUEVO],
                         [ESTADO_ALUMNO],
                         [ESTADO_PAGO],
                         [UNIDADNEGOCIO],
                         [SEMESTRE],
                         [NOM_SEDE],
                         [ESTADO_MOODLE],
                         [ultimo_acceso_moodle],
                         [AÑO],
                         [SEMESTRE_CALCULADO],
                         [NOMBRE_ESCUELA],
                         [Estrato],
                         [promedio],
                         [PRO_ACUMULADO],
                         [ESTADO_CIVIL],
                         [ESTADO_CIVIL_ACTUAL],
                         [RANGO_EDAD],
                         [FECHA_EXP_CEDULA_ACTUALIZADO],
                         [TELEFONO_ACTUALIZADO],
                         [TIENE_DISCAPACIDAD],
                         [DISCAPACIDAD],
                         [OTRA_DISCAPACIDAD],
                         [PERTENECE_GRUPO_ETNICO],
                         [GRUPO_ETNICO],
                         [LGBTIQ],
                         [REGIMEN_SISTEMA_SALUD],
                         [SISTEMA_SALUD],
                         [ESTRATO_ACTUALIZADO],
                         [ZONA_RESIDENCIA],
                         [DEPARTAMENTO_RESIDENCIA_ACTUAL],
                         [EXPERIENCIA_LABORAL_PREVIA_AREA_ESTUDIO],
                         [ESTA_TRABAJANDO],
                         [RANGO_SALARIO],
                         [RANGO_INGRESO_MENSUAL],
                         [JORNADA_TRABAJO],
                         [SECTOR_EMPRESA],
                         [EMPRESA],
                         [DESCRIPCION_RELACION_TECNOLOGIA],
                         [METODO_FINANCIAMIENTO],
                         [CANAL_INFORMACION_CONOCIO_CUN],
                         [ULTIMO_NIVEL_EDUCAT_COMPLETADO],
                         [PRINCIPAL_MOTIVACION_CONTINUAR_ESTUDIOS],
                         [INST_EDUCATIVA_CONSIDERO_ANTES_QUE_CUN]
                     FROM [CUN_REPOSITORIO].[CUN].[ESTADISTICA_ESTUDIANTE_2]
                     WHERE [NUM_IDENTIFICACION] = @NumIdentificacion";

                var parameters = new { NumIdentificacion = studentId };

                var customers = connection.Query<Students>(query, parameters);

                return customers;
            }
        }


        public Students GetStudentByParameters(string studentId, string codPrograma)
        {
            using (var connection = _context.CreateConnectionSql())
            {
                var query = @" SELECT
                         [COD_PERIODO],
                         [NOM_TERCERO],
                         [SEG_NOMBRE],
                         [PRI_APELLIDO],
                         [SEG_APELLIDO],
                         [NUM_IDENTIFICACION],
                         [GEN_TERCERO],
                         [TIP_IDENTIFICACION],
                         [DIR_EMAIL_PER],
                         [DIR_EMAIL],
                         [TEL_RESIDENCIA],
                         [TEL_CELULAR],
                         [COD_UNIDAD],
                         [NOM_UNIDAD],
                         [COD_PENSUM],
                         [COD_PENSUM_LAURA],
                         [NOM_DEPENDENCIA],
                         [MUNICIPIO_RESIDENCIA],
                         [DEPARTAMENTO_RESIDENCIA],
                         [MUNICIPIO_SEDE],
                         [DEPARTAMENTO_SEDE],
                         [FEC_NACIMIENTO],
                         [EDAD],
                         [MODALIDAD],
                         [NIVEL_FORMACION],
                         [NOM_SECCIONAL],
                         [COD_DPTO],
                         [CICLO],
                         [ubicacion],
                         [CLASE_ACTUAL],
                         [NUEVO],
                         [ESTADO_ALUMNO],
                         [ESTADO_PAGO],
                         [UNIDADNEGOCIO],
                         [SEMESTRE],
                         [NOM_SEDE],
                         [ESTADO_MOODLE],
                         [ultimo_acceso_moodle],
                         [AÑO],
                         [SEMESTRE_CALCULADO],
                         [NOMBRE_ESCUELA],
                         [Estrato],
                         [promedio],
                         [PRO_ACUMULADO],
                         [ESTADO_CIVIL],
                         [ESTADO_CIVIL_ACTUAL],
                         [RANGO_EDAD],
                         [FECHA_EXP_CEDULA_ACTUALIZADO],
                         [TELEFONO_ACTUALIZADO],
                         [TIENE_DISCAPACIDAD],
                         [DISCAPACIDAD],
                         [OTRA_DISCAPACIDAD],
                         [PERTENECE_GRUPO_ETNICO],
                         [GRUPO_ETNICO],
                         [LGBTIQ],
                         [REGIMEN_SISTEMA_SALUD],
                         [SISTEMA_SALUD],
                         [ESTRATO_ACTUALIZADO],
                         [ZONA_RESIDENCIA],
                         [DEPARTAMENTO_RESIDENCIA_ACTUAL],
                         [EXPERIENCIA_LABORAL_PREVIA_AREA_ESTUDIO],
                         [ESTA_TRABAJANDO],
                         [RANGO_SALARIO],
                         [RANGO_INGRESO_MENSUAL],
                         [JORNADA_TRABAJO],
                         [SECTOR_EMPRESA],
                         [EMPRESA],
                         [DESCRIPCION_RELACION_TECNOLOGIA],
                         [METODO_FINANCIAMIENTO],
                         [CANAL_INFORMACION_CONOCIO_CUN],
                         [ULTIMO_NIVEL_EDUCAT_COMPLETADO],
                         [PRINCIPAL_MOTIVACION_CONTINUAR_ESTUDIOS],
                         [INST_EDUCATIVA_CONSIDERO_ANTES_QUE_CUN]
                     FROM [CUN_REPOSITORIO].[CUN].[ESTADISTICA_ESTUDIANTE_2]
                     WHERE [NUM_IDENTIFICACION] = @NumIdentificacion
                        AND [COD_PERIODO] = @CodPrograma ";

                var parameters = new { NumIdentificacion = studentId, CodPrograma = codPrograma };

                var students = connection.QueryFirstOrDefault<Students>(query, parameters);

                return students;
            }
        }


        public StudentsGradeInfo GetStudentGradeInfo(string studentId, string nivel)
        {
            StudentsGradeInfo info = null; // Inicializamos en null para verificar si se recupera algo.

            using (var connection = _oracleContext.CreateConnectionOracle())
            {
                try
                {
                    // Asegúrate de que la conexión esté abierta
                    connection.Open();

                    var query = @"SELECT DISTINCT gc.SEDE_GRADO, gc.SNIES, gc.TITULACION, gc.ACTA, gc.NRO_REGISTRO, gc.FOLIO, gc.LIBRO
                                    FROM ICEBERG.GRADOS_CUN gc
                                    WHERE IDENTIFICACION_SINU = :IDENTIFICACION
                                    AND (
                                        (gc.NIVEL = 'TÉCNICO' AND :NIVEL = 1) OR
                                        (gc.NIVEL = 'TECNÓLOGO' AND :NIVEL = 2) OR
                                        (gc.NIVEL = 'PROFESIONAL' AND :NIVEL = 3))";

                    var parameters = new { IDENTIFICACION = studentId, NIVEL = nivel };

                    // Ejecutamos la consulta y asignamos el resultado a 'info'

                    info = connection.QueryFirstOrDefault<StudentsGradeInfo>(query, parameters);
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

            return info; // Devuelve el resultado o null si no se encontró nada
        }


        //public PayloadResponse GetGradeCertificatesAsync(string studentId, string codPrograma, string databaseType)
        //{
        //    Payload payload = new Payload();
        //    Students student = new Students();
        //    StudentsPayload studentPay = new StudentsPayload();
        //    StudentsGradeInfo studentsGradeInfo = new StudentsGradeInfo();
        //    Master master = new Master();

        //    string url = "https://digisign-backend.onrender.com/api/workflows/NewIntegration";
        //    string gender = "Masculino";
        //    string tipoIdentificacion = "TI";

        //    try
        //    {
        //        student = GetStudentByParameters(studentId, codPrograma, databaseType);
        //        studentsGradeInfo = GetStudentGradeInfo(studentId, databaseType);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return new PayloadResponse(); // Retornar DTO vacío en caso de error
        //    }

        //    if (student != null)
        //    {
        //        try
        //        {

        //            Guid u = new Guid("5c0e5a08-1a5f-4f4b-99c7-c3fc8c57da27");

        //            payload.Guid = u;
        //            payload.MasterEndata = "true";
        //            payload.Emailkey = "email";

        //            //Datos
        //            studentPay.Identificacion = student.NUM_IDENTIFICACION;

        //            studentPay.Nombres = $"{student.NOM_TERCERO} {student.SEG_NOMBRE}";
        //            studentPay.Apellidos = $"{student.PRI_APELLIDO} {student.SEG_APELLIDO}";
        //            //studentPay.NombresYApellidos = $"{student.NOM_TERCERO} {student.SEG_NOMBRE} {student.PRI_APELLIDO} {student.SEG_APELLIDO} ";
        //            studentPay.NombresYApellidos = $"{student.NOM_TERCERO} {student.SEG_NOMBRE} {student.PRI_APELLIDO} {student.SEG_APELLIDO} " + "PRUEBAS";

        //            studentPay.Genero = gender;
        //            studentPay.Email = student.DIR_EMAIL;

        //            gender = student.GEN_TERCERO.ToUpper() == "F" ? "Femenino" : "Masculino";
        //            tipoIdentificacion = student.TIP_IDENTIFICACION.ToUpper() == "C" ? "CC" : "TI";

        //            if (tipoIdentificacion == "C" || tipoIdentificacion == "CC")
        //            {
        //                tipoIdentificacion = "Cédula de ciudadania";
        //            }
        //            else if (tipoIdentificacion == "TI")
        //            {
        //                tipoIdentificacion = "Tarjeta de identidad";
        //            }

        //            studentPay.DadoEn = student.MUNICIPIO_SEDE;
        //            studentPay.Snies = "Snies por determinar";
        //            studentPay.CarreraOTitulo = student.NOM_DEPENDENCIA;
        //            studentPay.Acta = student.ACTA;
        //            studentPay.Registro = student.REGISTRO;
        //            studentPay.Folio = student.FOLIO;
        //            studentPay.Libro = student.LIBRO;

        //            // Asignación de fechas en texto y número
        //            var fechaActual = DateTime.Now;

        //            studentPay.DiaTexto = fechaActual.ToString("dddd");
        //            studentPay.DiaNumero = fechaActual.Day;
        //            studentPay.MesTexto = fechaActual.ToString("MMMM");
        //            studentPay.MesNumero = fechaActual.Month;
        //            studentPay.AgnoTexto = fechaActual.Year.ToString(); // Texto del año, ej: "2024"
        //            studentPay.AgnoNumero = fechaActual.Year; // Número del año

        //            //studentPay.FechaCeremonia = DateTime.Now;
        //            //studentPay.CodigoPrograma = student.COD_UNIDAD;
        //            //studentPay.NombrePrograma = student.NOM_UNIDAD;

        //            //master.CodigoUnico = student.COD_PENSUM_LAURA;
        //            //master.Escuela = student.NOMBRE_ESCUELA;
        //            //master.Nombres = student.NOM_DEPENDENCIA;
        //            //master.GenTercero = student.GEN_TERCERO;
        //            //master.Email = student.DIR_EMAIL;
        //            //master.TipoDeDocumento = tipoIdentificacion;


        //            //master.Clave = student.NIVEL_FORMACION;

        //            //studentPay.Master = new Master[] { master };
        //            //studentPay.FechaDiploma = DateTime.Now;
        //            //studentPay.Tipo = student.MODALIDAD;
        //            //studentPay.TipoDocumento = tipoIdentificacion;
        //            //studentPay.Tabla = "<table border='1'><tr><th>Columna 1</th><th>Columna 2</th><th>Columna 3</th></tr><tr><td>Fila 1, Columna 1</td><td>Fila 1, Columna 2</td><td>Fila 1, Columna 3</td></tr><tr><td>Fila 2, Columna 1</td><td>Fila 2, Columna 2</td><td>Fila 2, Columna 3</td></tr><tr><td>Fila 3, Columna 1</td><td>Fila 3, Columna 2</td><td>Fila 3, Columna 3</td></tr><tr><td>Fila 4, Columna 1</td><td>Fila 4, Columna 2</td><td>Fila 4, Columna 3</td></tr></table>";
        //            //studentPay.Texto = string.Empty;
        //            //studentPay.Texto2 = string.Empty;

        //            payload.Datos = new StudentsPayload[] { studentPay };


        //            var jsonPayload = JsonSerializer.Serialize(payload);
        //            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        //            using (var httpClient = new HttpClient())
        //            {
        //                try
        //                {
        //                    HttpResponseMessage httpResponse = httpClient.PostAsync(url, content).Result; // Usar .Result para quitar el async

        //                    if (httpResponse.IsSuccessStatusCode)
        //                    {
        //                        string jsonResponse = httpResponse.Content.ReadAsStringAsync().Result; // Usar .Result

        //                        if (!string.IsNullOrEmpty(jsonResponse))
        //                        {
        //                            try
        //                            {
        //                                PayloadResponse responseDto = JsonSerializer.Deserialize<PayloadResponse>(jsonResponse);
        //                                return responseDto ?? new PayloadResponse(); // Retornar DTO vacío si es nulo
        //                            }
        //                            catch (JsonException jsonEx)
        //                            {
        //                                Console.WriteLine($"Error al deserializar la respuesta JSON: {jsonEx.Message}");
        //                            }
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("La respuesta del servicio está vacía.");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine($"Error al llamar a la API: {httpResponse.StatusCode}");
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    Console.WriteLine($"Error en la llamada HTTP: {ex.Message}");
        //                    return new PayloadResponse(); // Retornar DTO vacío en caso de error
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error procesando la información del estudiante: {ex.Message}");
        //        }
        //    }

        //    return new PayloadResponse(); // Retornar un DTO vacío en caso de error
        //}


        // VERSION ALTERNA A LA APLICACION - NO BORRAR HASTA GENERAR REVISION
        //public PayloadResponse GetGradeCertificatesAsync(string studentId, string codPrograma)
        //{
        //    Payload payload = new Payload();
        //    Students student = new Students();
        //    StudentsPayload studentPay = new StudentsPayload();
        //    Master master = new Master();

        //    string url = "https://digisign-backend.onrender.com/api/workflows/NewIntegration";
        //    string gender = "Masculino";
        //    string tipoIdentificacion = "TI";

        //    try
        //    {
        //        student = GetStudentByParameters(studentId, codPrograma);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return new PayloadResponse(); // Retornar DTO vacío en caso de error
        //    }

        //    if (student != null)
        //    {
        //        try
        //        {
        //            gender = student.GEN_TERCERO.ToUpper() == "F" ? "Femenino" : "Masculino";
        //            tipoIdentificacion = student.TIP_IDENTIFICACION.ToUpper() == "C" ? "CC" : "TI";

        //            Guid guid = new Guid("5c0e5a08-1a5f-4f4b-99c7-c3fc8c57da27");
        //            payload.Guid = guid;

        //            studentPay.Nombres = $"{student.NOM_TERCERO} {student.SEG_NOMBRE}";
        //            studentPay.Apellidos = $"{student.PRI_APELLIDO} {student.SEG_APELLIDO}";
        //            studentPay.NombresYApellidos = $"{student.NOM_TERCERO} {student.SEG_NOMBRE} {student.PRI_APELLIDO} {student.SEG_APELLIDO}";
        //            studentPay.Genero = gender;
        //            studentPay.Email = student.DIR_EMAIL;
        //            studentPay.Identificacion = student.NUM_IDENTIFICACION;
        //            studentPay.FechaCeremonia = DateTime.Now;
        //            studentPay.CodigoPrograma = student.COD_UNIDAD;
        //            studentPay.NombrePrograma = student.NOM_UNIDAD;

        //            master.CodigoUnico = student.COD_PENSUM_LAURA;
        //            master.Escuela = student.NOMBRE_ESCUELA;
        //            master.Nombres = student.NOM_DEPENDENCIA;
        //            master.GenTercero = student.GEN_TERCERO;
        //            master.Email = student.DIR_EMAIL;
        //            master.TipoDeDocumento = tipoIdentificacion;
        //            master.DadoEn = student.MUNICIPIO_SEDE;
        //            master.Snies = "Snies por determinar";
        //            master.CarreraOTitulo = student.NOM_DEPENDENCIA;
        //            master.DiaTexto = DateTime.Now.ToString();
        //            master.DiaNumero = DateTime.Now.Day;
        //            master.MesTexto = DateTime.Now.ToString();
        //            master.MesNumero = DateTime.Now.Month;
        //            master.AgnoNumero = DateTime.Now.Year;
        //            master.AgnoTexto = DateTime.Now.Year.ToString();
        //            master.Clave = student.NIVEL_FORMACION;

        //            studentPay.Master = new Master[] { master };
        //            studentPay.FechaDiploma = DateTime.Now;
        //            studentPay.Tipo = student.MODALIDAD;
        //            studentPay.TipoDocumento = tipoIdentificacion;
        //            studentPay.Tabla = "<table border='1'><tr><th>Columna 1</th><th>Columna 2</th><th>Columna 3</th></tr><tr><td>Fila 1, Columna 1</td><td>Fila 1, Columna 2</td><td>Fila 1, Columna 3</td></tr><tr><td>Fila 2, Columna 1</td><td>Fila 2, Columna 2</td><td>Fila 2, Columna 3</td></tr><tr><td>Fila 3, Columna 1</td><td>Fila 3, Columna 2</td><td>Fila 3, Columna 3</td></tr><tr><td>Fila 4, Columna 1</td><td>Fila 4, Columna 2</td><td>Fila 4, Columna 3</td></tr></table>";
        //            studentPay.Texto = string.Empty;
        //            studentPay.Texto2 = string.Empty;

        //            payload.Datos = new StudentsPayload[] { studentPay };
        //            payload.Emailkey = "email";

        //            var jsonPayload = JsonSerializer.Serialize(payload);
        //            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        //            using (var httpClient = new HttpClient())
        //            {
        //                try
        //                {
        //                    HttpResponseMessage httpResponse = httpClient.PostAsync(url, content).Result; // Usar .Result para quitar el async

        //                    if (httpResponse.IsSuccessStatusCode)
        //                    {
        //                        string jsonResponse = httpResponse.Content.ReadAsStringAsync().Result; // Usar .Result

        //                        if (!string.IsNullOrEmpty(jsonResponse))
        //                        {
        //                            try
        //                            {
        //                                PayloadResponse responseDto = JsonSerializer.Deserialize<PayloadResponse>(jsonResponse);
        //                                return responseDto ?? new PayloadResponse(); // Retornar DTO vacío si es nulo
        //                            }
        //                            catch (JsonException jsonEx)
        //                            {
        //                                Console.WriteLine($"Error al deserializar la respuesta JSON: {jsonEx.Message}");
        //                            }
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("La respuesta del servicio está vacía.");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine($"Error al llamar a la API: {httpResponse.StatusCode}");
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    Console.WriteLine($"Error en la llamada HTTP: {ex.Message}");
        //                    return new PayloadResponse(); // Retornar DTO vacío en caso de error
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error procesando la información del estudiante: {ex.Message}");
        //        }
        //    }

        //    return new PayloadResponse(); // Retornar un DTO vacío en caso de error
        //}
    }
}
