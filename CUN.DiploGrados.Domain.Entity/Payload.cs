using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Payload
    {
        [JsonPropertyName("u")]
        public Guid Guid { get; set; }

        [JsonPropertyName("masterendata")]
        public string MasterEndata { get; set; } = "true"; // O el valor que necesites

        [JsonPropertyName("emailkey")]
        public string Emailkey { get; set; }

        [JsonPropertyName("datos")]
        public StudentsPayload[] Datos { get; set; }
    }
}

