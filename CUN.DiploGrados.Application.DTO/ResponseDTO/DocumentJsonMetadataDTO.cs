using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO.ResponseDTO
{
    public class DocumentJsonMetadataDTO
    {
        [JsonPropertyName("documentName")]
        public string DocumentName { get; set; }

        [JsonPropertyName("pagesNumber")]
        public int PagesNumber { get; set; }

        [JsonPropertyName("backgroundFile")]
        public string BackgroundFile { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("pages")]
        public PagesDTO Pages { get; set; }

        [JsonPropertyName("tipologia")]
        public string Tipologia {get; set; }

        [JsonPropertyName("modalidad")]
        public string Modalidad {get; set; }

        [JsonPropertyName("idUnidad")]
        public string IdUnidad {get; set; }

        [JsonPropertyName("codigoPrograma")]
        public string CodigoPrograma {get; set; }

        [JsonPropertyName("ceremony")]
        public string Ceremony {get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType {get; set; }

        [JsonPropertyName("schoolGroup")]
        public string SchoolGroup {get; set; }

        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber {get; set; }
    }
}
