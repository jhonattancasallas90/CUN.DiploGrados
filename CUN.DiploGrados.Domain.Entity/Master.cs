using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Master
    {
        [JsonPropertyName("TipoPlantilla")]
        public string TipoPlantilla { get; set; }       //"tipoplantilla": "grados, duplicados, honoresCausa"
    }
}
