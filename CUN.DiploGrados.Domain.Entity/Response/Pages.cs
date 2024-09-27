using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity.Response
{
    public class Pages
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
        public bool IsHidden { get; set; }
        public DateTime Value { get; set; }         // Format "12 de Diciembre de 2023" - Formatearla en el controller o donde se tome la consulta  
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }
        public bool FixText { get; set; }
        public bool IsQR { get; set; }
        public string FontWeight { get; set; }
        public string TextAlign { get; set; }
        public string VerticalAlign { get; set; }
        public string Color { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public string TextDecoration { get; set; }
        public string FontStyle { get; set; }
        public string S3ResourcePath { get; set; }
    }
}
