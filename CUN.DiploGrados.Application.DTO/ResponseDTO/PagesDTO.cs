using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO.ResponseDTO
{
    public class PagesDTO
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("isHidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }         // Format "12 de Diciembre de 2023" - Formatearla en el controller o donde se tome la consulta  

        [JsonPropertyName("x1")]
        public int X1 { get; set;}

        [JsonPropertyName("x2")]
        public int X2 { get; set;}

        [JsonPropertyName("y1")]
        public int Y1 { get; set;}

        [JsonPropertyName("y2")]
        public int Y2 { get; set; }

        [JsonPropertyName("fontName")]
        public string FontName { get; set; }

        [JsonPropertyName("fontSize")]
        public int FontSize { get; set; }

        [JsonPropertyName("fixText")]
        public bool FixText { get; set; }

        [JsonPropertyName("isQR")]
        public bool IsQR { get; set; }

        [JsonPropertyName("fontWeight")]
        public string FontWeight { get; set; }

        [JsonPropertyName("textAlign")]
        public string TextAlign { get; set; }

        [JsonPropertyName("verticalAlign")]
        public string VerticalAlign { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonPropertyName("borderColor")]
        public string BorderColor { get; set; }

        [JsonPropertyName("textDecoration")]
        public string TextDecoration { get; set; }

        [JsonPropertyName("fontStyle")]
        public string FontStyle { get; set; }

        [JsonPropertyName("s3ResourcePath")]
        public string S3ResourcePath { get; set; }
    }
}
