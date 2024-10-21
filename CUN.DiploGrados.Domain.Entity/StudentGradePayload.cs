using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class StudentGradePayload
    {
        [JsonPropertyName("SEDE_GRADO")]
        public string SedeGrado { get; set; }          // Verificar que estos datos sean los correctos -   // Por validar para su integración

        [JsonPropertyName("SNIES")]
        public string SNIES { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("TITULACION")]
        public string Titulacion { get; set; }          //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("ACTA")]
        public string Acta { get; set; }                //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("NRO_REGISTRO")]
        public string NroRegistro { get; set; }        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("FOLIO")]
        public string Folio { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("LIBRO")]
        public string Libro { get; set; }
    }
}
