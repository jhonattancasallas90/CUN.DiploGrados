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

        [JsonPropertyName("datos")]
        public StudentsPayloadDTO[] Student { get; set; }

        [JsonPropertyName("emailKey")]
        public string Emailkey {get; set;}
    }
}
