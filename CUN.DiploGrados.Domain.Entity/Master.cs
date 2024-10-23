using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Master
    {
        [JsonPropertyName("tipoplantilla")]
        public string TipoPlantilla { get; set; }

        // Lista privada con valores predeterminados
        private static readonly List<string> ValoresPredeterminados = new List<string>
        {
            "grados",
            "duplicados",
            "honores Causa",
            "Opción inválida"
        };

        // Método para obtener los valores predeterminados
        public static List<string> ObtenerValoresPredeterminados()
        {
            return new List<string>(ValoresPredeterminados);
        }

        public Master() { }
    }
}
