using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class MasterDTO
    {
        [JsonPropertyName("TipoPlantilla")]
        public string TipoPlantilla { get; set; }        //"tipoplantilla": "grados, duplicados, honoresCausa"
    }
}
