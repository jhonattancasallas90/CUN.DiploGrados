using CUN.DiploGrados.Application.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class PayloadResponseDTO
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("s3Folder")]
        public string? S3Folder { get; set; }

        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        [JsonPropertyName("modified")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("documents")]
        public DocumentsDTO[] Documents { get; set; }

        [JsonPropertyName("degreeDate")]
        public DateTime? DegreeDate { get; set; }

        [JsonPropertyName("organization")]
        public Guid Organization { get; set; }

        [JsonPropertyName("sendAttachments")]
        public bool? SendAttachments { get; set; }

        [JsonPropertyName("participantFlowHeader")]
        public ParticipantFlowHeaderDTO[] ParticipantFlow { get; set; }

        [JsonPropertyName("emailGroupId")]
        public Guid? EmailGroupdId { get; set; }
    }
}
