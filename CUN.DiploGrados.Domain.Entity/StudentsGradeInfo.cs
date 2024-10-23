using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class StudentsGradeInfo
    {
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

        [JsonPropertyName("GRADO_FECHA")]                             //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string GRADO_FECHA { get; set; }
    }
}
