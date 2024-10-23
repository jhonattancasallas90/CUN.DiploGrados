using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Master
    {
        [JsonPropertyName("tipoplantilla")]             // CLASE 100% FUNCIONAL para nombrar los campos del Body JSON
        public List<string> TipoPlantilla { get; set; }       //"tipoplantilla": "grados, duplicados, honoresCausa"

        public Master()
        {
            // Inicializa la lista con los valores predeterminados
            TipoPlantilla = new List<string>
            {
                "grados",
                "duplicados",
                "honores",
                "Causa",
                "Opción inválida"
            };
        }
    }
}
