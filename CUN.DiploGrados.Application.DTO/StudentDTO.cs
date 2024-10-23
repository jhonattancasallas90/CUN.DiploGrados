using CUN.DiploGrados.Domain.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace CUN.DiploGrados.Application.DTO
{
    public class StudentDTO
    {
        [JsonPropertyName("MASTER")]
        public Master Master { get; set; }

        [JsonPropertyName("NUM_IDENTIFICACION")]
        public string NUM_IDENTIFICACION { get; set; }

        [JsonPropertyName("NOMBRE_ESCUELA")]
        public string NOMBRE_ESCUELA { get; set; }

        [JsonIgnore]
        public string NOM_TERCERO { get; set; }

        [JsonIgnore]
        public string SEG_NOMBRE { get; set; }

        [JsonIgnore]
        public string PRI_APELLIDO { get; set; }

        [JsonIgnore]
        public string SEG_APELLIDO { get; set; }

        [JsonPropertyName("GEN_TERCERO")]
        public string GEN_TERCERO { get; set; }

        [JsonPropertyName("DIR_EMAIL")]
        public string DIR_EMAIL { get; set; }

        [JsonPropertyName("TIP_IDENTIFICACION")]
        public string TIP_IDENTIFICACION { get; set; }
        //public StudentsGradeInfo StudentGrade { get; set; }         // Acceso a la data complementaria de ORACLE

        [JsonPropertyName("SEDE_GRADO")]
        public string SEDE_GRADO { get; set; }          // Verificar que estos datos sean los correctos -   // Por validar para su integración

        [JsonPropertyName("SNIES")]
        public string SNIES { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("TITULACION")]
        public string TITULACION { get; set; }          //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("ACTA")]
        public string ACTA { get; set; }                //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("NRO_REGISTRO")]
        public string NRO_REGISTRO { get; set; }        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("FOLIO")]
        public string FOLIO { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("LIBRO")]
        public string LIBRO { get; set; }

        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonIgnore]    // No eliminar esta instancia
        public string GradoFecha { get; set; }    // Acceso a la data complementaria de ORACLE

        [JsonPropertyName("DiaTexto")]
        public string DiaTexto { get; set; }

        [JsonPropertyName("DiaNumero")]
        public int DiaNumero { get; set; }

        [JsonPropertyName("MesTexto")]
        public string MesTexto { get; set; }

        [JsonPropertyName("MesNumero")]
        public int MesNumero { get; set; }

        [JsonPropertyName("AgnoNumero")]
        public int AgnoNumero { get; set; }

        [JsonPropertyName("AgnoTexto")]
        public string AgnoTexto { get; set; }
    }
}
