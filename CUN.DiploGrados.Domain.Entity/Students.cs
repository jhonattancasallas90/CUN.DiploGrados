using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Students
    {
        [JsonPropertyName("MASTER")]
        public Master Master { get; set; }

        [JsonPropertyName("NUM_IDENTIFICACION")]
        public string NUM_IDENTIFICACION { get; set; }

        [JsonPropertyName("NOMBRE_ESCUELA")]
        public string NOMBRE_ESCUELA { get; set; }

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

        [JsonPropertyName("DIR_EMAIL")]
        public string DIR_EMAIL { get; set; }

        [JsonPropertyName("TIP_IDENTIFICACION")]
        public string TIP_IDENTIFICACION { get; set; }

        public StudentsGradeInfo StudentGrade { get; set; }

        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

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
