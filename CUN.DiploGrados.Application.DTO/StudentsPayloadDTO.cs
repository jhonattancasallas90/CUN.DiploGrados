using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class StudentsPayloadDTO
    {
        [JsonPropertyName("nombres")]
        public string Nombres {get; set;}

        [JsonPropertyName("apellidos")]
        public string Apellidos {get; set;}

        [JsonPropertyName("nombresyapellidos")]
        public string NombresYApellidos{get; set;}

        [JsonPropertyName("genero")]
        public string Genero{get; set;}

        [JsonPropertyName("serie")]
        public string Serie {get; set;}

        [JsonPropertyName("email")]
        public string Email {get; set;}

        [JsonPropertyName("identificacion")]
        public string Identificacion {get; set;}

        [JsonPropertyName("fechaceremonia")]
        public DateTime FechaCeremonia {get; set;}

        [JsonPropertyName("codigoprograma")]
        public string CodigoPrograma {get; set;}

        [JsonPropertyName("nombreprograma")]
        public string NombrePrograma { get; set; }

        [JsonPropertyName("master")]
        public MasterDTO[] Master { get; set;}

        [JsonPropertyName("fechadiploma")]
        public DateTime FechaDiploma { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo {get; set; }

        [JsonPropertyName("tipo_documento")]
        public string TipoDocumento {get; set; }

        [JsonPropertyName("tabla")]
        public string Tabla {get; set; }

        [JsonPropertyName("texto")]
        public string Texto {get;set;}

        [JsonPropertyName("texto2")]
        public string Texto2{ get;set; }
    }
}
