﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Payload
    {
            public Guid Guid { get; set; }
            public Students Student { get; set; }
            public string Emailkey { get; set; }
    }
}
