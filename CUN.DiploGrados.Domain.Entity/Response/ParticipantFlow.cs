using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity.Response
{
    public class ParticipantFlow
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Role { get; set; }
        public bool IsVariable { get; set; }
        public string IpAddress { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsCompleted { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
    }
    public class ParticipantFlowHeader : ParticipantFlow
    {
    }
}
