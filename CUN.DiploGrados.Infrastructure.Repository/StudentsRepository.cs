using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Infrastructure.Data;
using CUN.DiploGrados.Infrastructure.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace CUN.DiploGrados.Infrastructure.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly DapperContext _context;

        public StudentsRepository(DapperContext context)
        {
            _context = context;
        }

        public IEnumerable<Students> GetStudentById(string studentId)
        {
            using (var connection = _context.CreateConnection())
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
            using (var connection = _context.CreateConnection())
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

        public Payload GetGradeCertificates(string studentId, string codPrograma)
        {
            Payload payload = new Payload();
            Students student = new Students();
            string url = "https://digisign-backend.onrender.com/api/workflows/NewIntegration";
            string gender = "Masculino";
            string tipoIdentificacion = "TI";

            try
            {
                student = GetStudentByParameters(studentId, codPrograma);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (student != null)
            {
                try
                {
                    if (student.GEN_TERCERO.ToUpper() == "F")
                    {
                        gender = "Femenino";
                    }

                    if (student.TIP_IDENTIFICACION.ToUpper() == "C")
                    {
                        tipoIdentificacion = "CC";
                    }
                    Guid guid = new Guid("5c0e5a08-1a5f-4f4b-99c7-c3fc8c57da27");
                    payload.Guid = guid;
                    payload.Student.Nombres = student.NOM_TERCERO + " " + student.SEG_NOMBRE;
                    payload.Student.Apellidos = student.PRI_APELLIDO + " " + student.SEG_APELLIDO;
                    payload.Student.NombresYApellidos = student.NOM_TERCERO + " " + student.SEG_NOMBRE + " " + student.PRI_APELLIDO + " " + student.SEG_APELLIDO;
                    payload.Student.Genero = gender;
                    payload.Student.Serie = string.Empty;
                    payload.Student.Email = student.DIR_EMAIL;
                    payload.Student.Identificacion = student.NUM_IDENTIFICACION;
                    payload.Student.FechaCeremonia = DateTime.Now;                      // Parametrizar de acuerdo a la fecha de ceremonia estipulada
                    payload.Student.CodigoPrograma = student.COD_UNIDAD;
                    payload.Student.NombrePrograma = student.NOM_UNIDAD;
                    payload.Student.Master.CodigoUnico = student.COD_PENSUM_LAURA;      // POR VALIDAR
                    payload.Student.Master.Escuela = student.NOMBRE_ESCUELA;
                    payload.Student.Master.Nombres = student.NOM_DEPENDENCIA;           // POR VALIDAR
                    payload.Student.Master.GenTercero = student.GEN_TERCERO;
                    payload.Student.Master.Email = student.DIR_EMAIL;
                    payload.Student.Master.TipoDeDocumento = tipoIdentificacion;
                    payload.Student.Master.TipoDeDocumentoActa = student.TIP_IDENTIFICACION;
                    payload.Student.Master.DadoEn = student.MUNICIPIO_SEDE;
                    payload.Student.Master.Snies = "Snies por determinar";              // Por validar
                    payload.Student.Master.CarreraOTitulo = student.NOM_DEPENDENCIA;    // Por validar
                    payload.Student.Master.Acta = "No existe columna";                  // No hay columna
                    payload.Student.Master.Registro = "No existe columna";              // No hay columna
                    payload.Student.Master.Folio = "No existe columna";                 // No hay columna
                    payload.Student.Master.Libro = "No existe columna";                 // No hay columna
                    payload.Student.Master.DiaTexto = DateTime.Now.ToString();          // Construir Helper para dia en texto
                    payload.Student.Master.DiaNumero = DateTime.Now.Day;               
                    payload.Student.Master.MesTexto = DateTime.Now.ToString();           // Construir Helper para dia en texto
                    payload.Student.Master.MesNumero = DateTime.Now.Month;
                    payload.Student.Master.AgnoNumero = DateTime.Now.Year;
                    payload.Student.Master.AgnoTexto = DateTime.Now.Year.ToString();     // Construir Helper para dia en texto
                    payload.Student.Master.Clave = student.NIVEL_FORMACION;             // Por validar porque aparece como comentario, se deja mostrando carrera
                   
                    payload.Student.FechaDiploma = DateTime.Now;                        // Parametrizar de acuerdo a la fecha de entrega diploma estipulada
                    payload.Student.Tipo = student.MODALIDAD;                           // Por validar
                    payload.Student.TipoDocumento = tipoIdentificacion;                 // Parametrizar de acuerdo a la fecha de ceremonia estipulada
                    payload.Student.Tabla = "<table border='1'><tr><th>Columna 1</th><th>Columna 2</th><th>Columna 3</th></tr><tr><td>Fila 1, Columna 1</td><td>Fila 1, Columna 2</td><td>Fila 1, Columna 3</td></tr><tr><td>Fila 2, Columna 1</td><td>Fila 2, Columna 2</td><td>Fila 2, Columna 3</td></tr><tr><td>Fila 3, Columna 1</td><td>Fila 3, Columna 2</td><td>Fila 3, Columna 3</td></tr><tr><td>Fila 4, Columna 1</td><td>Fila 4, Columna 2</td><td>Fila 4, Columna 3</td></tr></table>";
                    payload.Student.Texto = string.Empty;
                    payload.Student.Texto2 = string.Empty;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }




            return payload;
        }
    }
}
