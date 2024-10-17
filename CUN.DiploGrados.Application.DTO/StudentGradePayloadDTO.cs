using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class StudentGradePayloadDTO
    {
        [JsonPropertyName("SEDE_GRADO")]
        public string SEDE_GRADO { get; set; }                  //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("SNIES")]
        public string SNIES { get; set; }                       //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("TITULACION")]                        // Carrera o titulo
        public string TITULACION { get; set; }                  //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("ACTA")]                              //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string ACTA { get; set; }

        [JsonPropertyName("NRO_REGISTRO")]                      //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string NRO_REGISTRO { get; set; }

        [JsonPropertyName("FOLIO")]                             //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string FOLIO { get; set; }

        [JsonPropertyName("LIBRO")]                             //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string LIBRO { get; set; }
    }
}
