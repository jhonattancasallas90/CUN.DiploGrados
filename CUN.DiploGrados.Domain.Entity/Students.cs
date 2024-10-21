using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Students : StudentsGradeInfo
    {
        [JsonPropertyName("master")]
        public Master Master { get; set; }

        [JsonPropertyName("identificacion")]
        public string NUM_IDENTIFICACION { get; set; }

        [JsonPropertyName("escuela")]
        public string NOMBRE_ESCUELA { get; set; }

        [JsonIgnore]    // No eliminar esta instancia
        public string NOM_TERCERO { get; set; }

        [JsonIgnore]    // No eliminar esta instancia
        public string SEG_NOMBRE { get; set; }

        [JsonIgnore]    // No eliminar esta instancia
        public string PRI_APELLIDO { get; set; }

        [JsonIgnore]    // No eliminar esta instancia
        public string SEG_APELLIDO { get; set; }

        [JsonPropertyName("gen_tercero")]
        public string GEN_TERCERO { get; set; }

        [JsonPropertyName("email")]
        public string DIR_EMAIL { get; set; }

        [JsonPropertyName("tipo_documento")]
        public string TIP_IDENTIFICACION { get; set; }

        //public StudentsGradeInfo StudentGrade { get; set; }

        [JsonPropertyName("dado_en")]
        public string SEDE_GRADO { get; set; }          // Verificar que estos datos sean los correctos -   // Por validar para su integración

        [JsonPropertyName("snies")]
        public string SNIES { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("carrera_o_titulo")]
        public string TITULACION { get; set; }          //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("acta")]
        public string ACTA { get; set; }                //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("registro")]
        public string NRO_REGISTRO { get; set; }        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("folio")]
        public string FOLIO { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("libro")]
        public string LIBRO { get; set; }

        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("dia_texto")]
        public string DiaTexto { get; set; }

        [JsonPropertyName("dia_numero")]
        public int DiaNumero { get; set; }

        [JsonPropertyName("mes_texto")]
        public string MesTexto { get; set; }

        [JsonPropertyName("mes_numero")]
        public int MesNumero { get; set; }

        [JsonPropertyName("anio_numero")]
        public int AgnoNumero { get; set; }

        [JsonPropertyName("anio_texto")]
        public string AgnoTexto { get; set; }
    }
}
