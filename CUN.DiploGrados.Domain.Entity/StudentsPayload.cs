using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class StudentsPayload
    {
        [JsonPropertyName("identificacion")]
        public string Identificacion { get; set; }

        [JsonPropertyName("nombres")]
        public string Nombres { get; set; }

        [JsonPropertyName("apellidos")]
        public string Apellidos { get; set; }

        [JsonPropertyName("nombresyapellidos")]
        public string NombresYApellidos { get; set; }

        [JsonPropertyName("genero")]
        public string Genero { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("DiaTexto")]
        public string DiaTexto { get; set; }

        [JsonPropertyName("DiaNumero")]
        public int DiaNumero {get; set; }

        [JsonPropertyName("MesTexto")]
        public string MesTexto { get; set; }

        [JsonPropertyName("MesNumero")]
        public int MesNumero { get; set; }

        [JsonPropertyName("AgnoNumero")]
        public int AgnoNumero { get; set; }

        [JsonPropertyName("AgnoTexto")]
        public string AgnoTexto { get; set; } 


        //[JsonPropertyName("serie")]
        //public string Serie { get; set; }

        //[JsonPropertyName("fechaceremonia")]
        //public DateTime FechaCeremonia { get; set; }

        //[JsonPropertyName("codigoprograma")]
        //public string CodigoPrograma { get; set; }

        //[JsonPropertyName("nombreprograma")]
        //public string NombrePrograma { get; set; }

        //[JsonPropertyName("master")]
        //public Master[] Master { get; set; }

        //[JsonPropertyName("fechadiploma")]
        //public DateTime FechaDiploma { get; set; }

        //[JsonPropertyName("tipo")]
        //public string Tipo { get; set; }

        //[JsonPropertyName("tipodocumento")]
        //public string TipoDocumento { get; set; }

        //[JsonPropertyName("tabla")]
        //public string Tabla { get; set; }

        //[JsonPropertyName("texto")]
        //public string Texto { get; set; }

        //[JsonPropertyName("texto2")]
        //public string Texto2 { get; set; }
    }
}
