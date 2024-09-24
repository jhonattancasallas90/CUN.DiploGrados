using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Application.DTO
{
    public class PayloadDTO
    {
        public Guid Guid { get; set; }
        public StudentsPayloadDTO Student { get; set; }
        public string Emailkey {get; set;}
    }
}
