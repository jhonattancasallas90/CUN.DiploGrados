using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity.Response
{
    public class DocumentJsonMetadata
    {
        public string DocumentName { get; set; }
        public int PagesNumber { get; set; }
        public string BackgroundFile { get; set; }
        public string Content { get; set; }
        public Pages Pages { get; set; }
        public string Tipologia { get; set; }
        public string Modalidad { get; set; }
        public string IdUnidad { get; set; }
        public string CodigoPrograma { get; set; }
        public string Ceremony { get; set; }
        public string DocumentType { get; set; }
        public string SchoolGroup { get; set; }
        public string IdentificationNumber { get; set; }
    }
}
