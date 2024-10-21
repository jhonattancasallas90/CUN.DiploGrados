using CUN.DiploGrados.Domain.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class PayloadResponse
    {
        [JsonPropertyName("Id")]
        public Guid Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("S3Folder")]
        public string? S3Folder { get; set; }

        [JsonPropertyName("Subject")]
        public string? Subject { get; set; }

        [JsonPropertyName("Modified")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("Documents")]
        public Documents Documents { get; set; }

        [JsonPropertyName("DegreeDate")]
        public DateTime? DegreeDate { get; set; }

        [JsonPropertyName("Organization")]
        public Guid Organization { get; set; }

        [JsonPropertyName("SendAttachments")]
        public bool? SendAttachments { get; set; }

        [JsonPropertyName("ParticipantFlow")]
        public ParticipantFlowHeader ParticipantFlow { get; set; }

        [JsonPropertyName("EmailGroupdId")]
        public Guid? EmailGroupdId { get; set; }
    }
}
