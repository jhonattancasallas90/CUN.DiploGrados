using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Students
    {
        //public string COD_PERIODO { get; set; }
        public string NUM_IDENTIFICACION { get; set; }
        public string NOM_TERCERO { get; set; }
        public string SEG_NOMBRE { get; set; }
        public string PRI_APELLIDO { get; set; }
        public string SEG_APELLIDO { get; set; }
        public string GEN_TERCERO { get; set; }
        public string TIP_IDENTIFICACION { get; set; }
        public string DIR_EMAIL { get; set; }
        
        //public string DIR_EMAIL_PER { get; set; }
        
        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string DiaTexto { get; set; }
        public int DiaNumero { get; set; }
        public string MesTexto { get; set; }
        public int MesNumero { get; set; }
        public int AgnoNumero { get; set; }
        public string AgnoTexto { get; set; }

        //    public string TEL_RESIDENCIA { get; set; }
        //    public string TEL_CELULAR { get; set; }
        //    public string COD_UNIDAD { get; set; }
        //    public string NOM_UNIDAD { get; set; }
        //    public string COD_PENSUM { get; set; }
        //    public string COD_PENSUM_LAURA { get; set; }

        //    public string MUNICIPIO_RESIDENCIA { get; set; }
        //    public string DEPARTAMENTO_RESIDENCIA { get; set; }
        //    public string DEPARTAMENTO_SEDE { get; set; }
        //    public string FEC_NACIMIENTO { get; set; }
        //    public int? EDAD { get; set; }
        //    public string MODALIDAD { get; set; }
        //    public string NIVEL_FORMACION { get; set; }
        //    public string NOM_SECCIONAL { get; set; }
        //    public decimal? COD_DPTO { get; set; }
        //    public string CICLO { get; set; }
        //    public string ubicacion { get; set; }
        //    public string CLASE_ACTUAL { get; set; }
        //    public string NUEVO { get; set; }
        //    public string ESTADO_ALUMNO { get; set; }
        //    public string ESTADO_PAGO { get; set; }
        //    public string UNIDADNEGOCIO { get; set; }
        //    public float? SEMESTRE { get; set; }
        //    public string NOM_SEDE { get; set; }
        //    public string ESTADO_MOODLE { get; set; }
        //    public DateTime? ultimo_acceso_moodle { get; set; }
        //    public float? AÑO { get; set; }
        //    public float? SEMESTRE_CALCULADO { get; set; }
        //    public string NOMBRE_ESCUELA { get; set; }
        //    public int? Estrato { get; set; }
        //    public float? promedio { get; set; }
        //    public float? PRO_ACUMULADO { get; set; }
        //    public string ESTADO_CIVIL { get; set; }
        //    public string ESTADO_CIVIL_ACTUAL { get; set; }
        //    public string RANGO_EDAD { get; set; }
        //    public string FECHA_EXP_CEDULA_ACTUALIZADO { get; set; }
        //    public string TELEFONO_ACTUALIZADO { get; set; }
        //    public string TIENE_DISCAPACIDAD { get; set; }
        //    public string DISCAPACIDAD { get; set; }
        //    public string OTRA_DISCAPACIDAD { get; set; }
        //    public string PERTENECE_GRUPO_ETNICO { get; set; }
        //    public string GRUPO_ETNICO { get; set; }
        //    public string LGBTIQ { get; set; }
        //    public string REGIMEN_SISTEMA_SALUD { get; set; }
        //    public string SISTEMA_SALUD { get; set; }
        //    public string ESTRATO_ACTUALIZADO { get; set; }
        //    public string ZONA_RESIDENCIA { get; set; }
        //    public string DEPARTAMENTO_RESIDENCIA_ACTUAL { get; set; }
        //    public string EXPERIENCIA_LABORAL_PREVIA_AREA_ESTUDIO { get; set; }
        //    public string ESTA_TRABAJANDO { get; set; }
        //    public string RANGO_SALARIO { get; set; }
        //    public string RANGO_INGRESO_MENSUAL { get; set; }
        //    public string JORNADA_TRABAJO { get; set; }
        //    public string SECTOR_EMPRESA { get; set; }
        //    public string EMPRESA { get; set; }
        //    public string DESCRIPCION_RELACION_TECNOLOGIA { get; set; }
        //    public string METODO_FINANCIAMIENTO { get; set; }
        //    public string CANAL_INFORMACION_CONOCIO_CUN { get; set; }
        //    public string ULTIMO_NIVEL_EDUCAT_COMPLETADO { get; set; }
        //    public string PRINCIPAL_MOTIVACION_CONTINUAR_ESTUDIOS { get; set; }
        //    public string INST_EDUCATIVA_CONSIDERO_ANTES_QUE_CUN { get; set; }
    }
}
