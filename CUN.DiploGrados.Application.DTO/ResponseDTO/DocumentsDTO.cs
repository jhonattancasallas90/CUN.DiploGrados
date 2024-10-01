using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO.ResponseDTO
{
    public class DocumentsDTO
    {
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("fileName")]
        public string FileName { get; set; }

        [JsonPropertyName("s3Folder")]
        public string S3Folder { get; set; }

        [JsonPropertyName("step")]
        public string Step { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("isDone")]
        public bool IsDone { get; set; }

        [JsonPropertyName("modified")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("documentType")]
        public string? DocumentType { get; set; }

        [JsonPropertyName("schoolGroup")]
        public string? SchoolGroup { get; set; }

        [JsonPropertyName("ceremony")]
        public string? Ceremony { get; set; }

        [JsonPropertyName("participantFlow")]                               // Validar que no presente complicaciones con el archivo JSON
        public ParticipantFlowDTO[] ParticipantFlow { get; set; }

        [JsonPropertyName("documentJsonMetadata")]
        public DocumentJsonMetadataDTO[] DocumentJsonMetadata { get; set; }
    }
}
