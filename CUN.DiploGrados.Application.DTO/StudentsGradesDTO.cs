using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class StudentsGradesDTO
    {
        [JsonPropertyName("SEDE_GRADO")]
        public string SEDE_GRADO { get; set; }

        [JsonPropertyName("SNIES")]
        public string SNIES { get; set; }                   //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("TITULACION")]
        public string TITULACION { get; set; }

        [JsonPropertyName("ACTA")]
        public string ACTA { get; set; }                    //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("NRO_REGISTRO")]
        public string NRO_REGISTRO { get; set; }                //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("FOLIO")]
        public string FOLIO { get; set; }                   //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("LIBRO")]
        public string LIBRO { get; set; }
    }
}
