using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Infrastructure.Data;
using CUN.DiploGrados.Infrastructure.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
