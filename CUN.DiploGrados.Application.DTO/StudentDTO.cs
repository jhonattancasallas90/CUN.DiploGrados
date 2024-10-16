using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class StudentDTO
    {
        //[JsonPropertyName("COD_PERIODO")]
        //public string COD_PERIODO { get; set; }
        [JsonPropertyName("NUM_IDENTIFICACION")]
        public string NUM_IDENTIFICACION { get; set; }

        [JsonPropertyName("NOM_TERCERO")]
        public string NOM_TERCERO { get; set; }

        [JsonPropertyName("SEG_NOMBRE")]
        public string SEG_NOMBRE { get; set; }

        [JsonPropertyName("PRI_APELLIDO")]
        public string PRI_APELLIDO { get; set; }

        [JsonPropertyName("SEG_APELLIDO")]
        public string SEG_APELLIDO { get; set; }

        [JsonPropertyName("GEN_TERCERO")]
        public string GEN_TERCERO { get; set; }

        [JsonPropertyName("TIP_IDENTIFICACION")]
        public string TIP_IDENTIFICACION { get; set; }

        [JsonPropertyName("DIR_EMAIL")]
        public string DIR_EMAIL { get; set; }

        //[JsonPropertyName("DIR_EMAIL_PER")]
        //public string DIR_EMAIL_PER { get; set; }


        //[JsonPropertyName("TEL_RESIDENCIA")]
        //public string TEL_RESIDENCIA { get; set; }

        //[JsonPropertyName("TEL_CELULAR")]
        //public string TEL_CELULAR { get; set; }

        //[JsonPropertyName("COD_UNIDAD")]
        //public string COD_UNIDAD { get; set; }

        //[JsonPropertyName("NOM_UNIDAD")]
        //public string NOM_UNIDAD { get; set; }

        //[JsonPropertyName("COD_PENSUM")]
        //public string COD_PENSUM { get; set; }

        //[JsonPropertyName("COD_PENSUM_LAURA")]
        //public string COD_PENSUM_LAURA { get; set; }



        //[JsonPropertyName("MUNICIPIO_RESIDENCIA")]
        //public string MUNICIPIO_RESIDENCIA { get; set; }

        //[JsonPropertyName("DEPARTAMENTO_RESIDENCIA")]
        //public string DEPARTAMENTO_RESIDENCIA { get; set; }

        //[JsonPropertyName("DEPARTAMENTO_SEDE")]
        //public string DEPARTAMENTO_SEDE { get; set; }

        //[JsonPropertyName("FEC_NACIMIENTO")]
        //public string FEC_NACIMIENTO { get; set; }

        //[JsonPropertyName("EDAD")]
        //public int? EDAD { get; set; }

        //[JsonPropertyName("MODALIDAD")]
        //public string MODALIDAD { get; set; }

        //[JsonPropertyName("NIVEL_FORMACION")]
        //public string NIVEL_FORMACION { get; set; }

        //[JsonPropertyName("NOM_SECCIONAL")]
        //public string NOM_SECCIONAL { get; set; }

        //[JsonPropertyName("COD_DPTO")]
        //public decimal? COD_DPTO { get; set; }

        //[JsonPropertyName("CICLO")]
        //public string CICLO { get; set; }

        //[JsonPropertyName("ubicacion")]
        //public string ubicacion { get; set; }

        //[JsonPropertyName("CLASE_ACTUAL")]
        //public string CLASE_ACTUAL { get; set; }

        //[JsonPropertyName("NUEVO")]
        //public string NUEVO { get; set; }

        //[JsonPropertyName("ESTADO_ALUMNO")]
        //public string ESTADO_ALUMNO { get; set; }

        //[JsonPropertyName("ESTADO_PAGO")]
        //public string ESTADO_PAGO { get; set; }

        //[JsonPropertyName("UNIDADNEGOCIO")]
        //public string UNIDADNEGOCIO { get; set; }

        //[JsonPropertyName("SEMESTRE")]
        //public float? SEMESTRE { get; set; }

        //[JsonPropertyName("NOM_SEDE")]
        //public string NOM_SEDE { get; set; }

        //[JsonPropertyName("ESTADO_MOODLE")]
        //public string ESTADO_MOODLE { get; set; }

        //[JsonPropertyName("ultimo_acceso_moodle")]
        //public DateTime? ultimo_acceso_moodle { get; set; }

        //[JsonPropertyName("AÑO")]
        //public float? AÑO { get; set; }

        //[JsonPropertyName("SEMESTRE_CALCULADO")]
        //public float? SEMESTRE_CALCULADO { get; set; }

        //[JsonPropertyName("NOMBRE_ESCUELA")]
        //public string NOMBRE_ESCUELA { get; set; }

        //[JsonPropertyName("Estrato")]
        //public int? Estrato { get; set; }

        //[JsonPropertyName("promedio")]
        //public float? promedio { get; set; }

        //[JsonPropertyName("PRO_ACUMULADO")]
        //public float? PRO_ACUMULADO { get; set; }

        //[JsonPropertyName("ESTADO_CIVIL")]
        //public string ESTADO_CIVIL { get; set; }

        //[JsonPropertyName("ESTADO_CIVIL_ACTUAL")]
        //public string ESTADO_CIVIL_ACTUAL { get; set; }

        //[JsonPropertyName("RANGO_EDAD")]
        //public string RANGO_EDAD { get; set; }

        //[JsonPropertyName("FECHA_EXP_CEDULA_ACTUALIZADO")]
        //public string FECHA_EXP_CEDULA_ACTUALIZADO { get; set; }

        //[JsonPropertyName("TELEFONO_ACTUALIZADO")]
        //public string TELEFONO_ACTUALIZADO { get; set; }

        //[JsonPropertyName("TIENE_DISCAPACIDAD")]
        //public string TIENE_DISCAPACIDAD { get; set; }

        //[JsonPropertyName("DISCAPACIDAD")]
        //public string DISCAPACIDAD { get; set; }

        //[JsonPropertyName("OTRA_DISCAPACIDAD")]
        //public string OTRA_DISCAPACIDAD { get; set; }

        //[JsonPropertyName("PERTENECE_GRUPO_ETNICO")]
        //public string PERTENECE_GRUPO_ETNICO { get; set; }

        //[JsonPropertyName("GRUPO_ETNICO")]
        //public string GRUPO_ETNICO { get; set; }

        //[JsonPropertyName("LGBTIQ")]
        //public string LGBTIQ { get; set; }

        //[JsonPropertyName("REGIMEN_SISTEMA_SALUD")]
        //public string REGIMEN_SISTEMA_SALUD { get; set; }

        //[JsonPropertyName("SISTEMA_SALUD")]
        //public string SISTEMA_SALUD { get; set; }

        //[JsonPropertyName("ESTRATO_ACTUALIZADO")]
        //public string ESTRATO_ACTUALIZADO { get; set; }

        //[JsonPropertyName("ZONA_RESIDENCIA")]
        //public string ZONA_RESIDENCIA { get; set; }

        //[JsonPropertyName("DEPARTAMENTO_RESIDENCIA_ACTUAL")]
        //public string DEPARTAMENTO_RESIDENCIA_ACTUAL { get; set; }

        //[JsonPropertyName("EXPERIENCIA_LABORAL_PREVIA_AREA_ESTUDIO")]
        //public string EXPERIENCIA_LABORAL_PREVIA_AREA_ESTUDIO { get; set; }

        //[JsonPropertyName("ESTA_TRABAJANDO")]
        //public string ESTA_TRABAJANDO { get; set; }

        //[JsonPropertyName("RANGO_SALARIO")]
        //public string RANGO_SALARIO { get; set; }

        //[JsonPropertyName("RANGO_INGRESO_MENSUAL")]
        //public string RANGO_INGRESO_MENSUAL { get; set; }

        //[JsonPropertyName("JORNADA_TRABAJO")]
        //public string JORNADA_TRABAJO { get; set; }

        //[JsonPropertyName("SECTOR_EMPRESA")]
        //public string SECTOR_EMPRESA { get; set; }

        //[JsonPropertyName("EMPRESA")]
        //public string EMPRESA { get; set; }

        //[JsonPropertyName("DESCRIPCION_RELACION_TECNOLOGIA")]
        //public string DESCRIPCION_RELACION_TECNOLOGIA { get; set; }

        //[JsonPropertyName("METODO_FINANCIAMIENTO")]
        //public string METODO_FINANCIAMIENTO { get; set; }

        //[JsonPropertyName("CANAL_INFORMACION_CONOCIO_CUN")]
        //public string CANAL_INFORMACION_CONOCIO_CUN { get; set; }

        //[JsonPropertyName("ULTIMO_NIVEL_EDUCAT_COMPLETADO")]
        //public string ULTIMO_NIVEL_EDUCAT_COMPLETADO { get; set; }

        //[JsonPropertyName("PRINCIPAL_MOTIVACION_CONTINUAR_ESTUDIOS")]
        //public string PRINCIPAL_MOTIVACION_CONTINUAR_ESTUDIOS { get; set; }

        //[JsonPropertyName("INST_EDUCATIVA_CONSIDERO_ANTES_QUE_CUN")]
        //public string InstEducativaConsideroAntesQueCUN { get; set; }
    }
}
