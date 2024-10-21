﻿using CUN.DiploGrados.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class StudentsPayloadDTO
    {
        [JsonPropertyName("MASTER")]
        public Master Master { get; set; }

        [JsonPropertyName("identificacion")]
        public string identificacion { get; set; }

        [JsonPropertyName("nombreEscuela")]
        public string NOMBRE_ESCUELA { get; set; }

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

        [JsonPropertyName("TipoDocumento")]
        public string TipoDocumento { get; set; }

        [JsonPropertyName("TipoDocumentoActa")]
        public string TipoDocumentoActa { get; set; }

        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        [JsonPropertyName("DiaTexto")]
        public string DiaTexto { get; set; }

        [JsonPropertyName("DiaNumero")]
        public int DiaNumero { get; set; }

        [JsonPropertyName("MesTexto")]
        public string MesTexto { get; set; }

        [JsonPropertyName("MesNumero")]
        public int MesNumero { get; set; }

        [JsonPropertyName("AgnoNumero")]
        public int AgnoNumero { get; set; }

        [JsonPropertyName("AgnoTexto")]
        public string AgnoTexto { get; set; }
    }
}
