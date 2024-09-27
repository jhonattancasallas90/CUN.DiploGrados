using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity.Response
{
    public class Documents
    {
        public Guid? Id { get; set; }
        public string FileName { get; set; }
        public string S3Folder { get; set; }
        public string Step { get; set; }
        public string Hash { get; set; }
        public bool IsDone { get; set; }
        public DateTime Modified { get; set; }
        public string? DocumentType { get; set; }
        public string? SchoolGroup { get; set; }
        public string? Ceremony { get; set; }
        public ParticipantFlow ParticipantFlow { get; set; }
        public DocumentJsonMetadata DocumentJsonMetadata { get; set; }
    }
}
