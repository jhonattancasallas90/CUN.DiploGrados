using CUN.DiploGrados.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class PayloadDTO
    {
        [JsonPropertyName("u")]
        public Guid Guid { get; set; }

        [JsonPropertyName("masterendata")]
        public string MasterEndata { get; set; }

        [JsonPropertyName("emailKey")]
        public string Emailkey {get; set;}

        [JsonPropertyName("datos")]
        public StudentDTO[] Datos { get; set; }
    }
}
