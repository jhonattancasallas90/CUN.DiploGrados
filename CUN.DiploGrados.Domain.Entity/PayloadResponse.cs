using CUN.DiploGrados.Domain.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity
{
    public class PayloadResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string? S3Folder { get; set; }
        public string? Subject { get; set; }
        public DateTime Modified { get; set; }
        public Documents Documents { get; set; }
        public DateTime? DegreeDate { get; set; }
        public Guid Organization { get; set; }
        public bool? SendAttachments { get; set; }
        public ParticipantFlowHeader ParticipantFlow { get; set; }
        public Guid? EmailGroupdId { get; set; }
    }
}
