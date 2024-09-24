using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity
{
    public  class StudentsPayload
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresYApellidos { get; set; }
        public string Genero { get; set; }
        public string Serie { get; set; }
        public string Email { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaCeremonia { get; set; }
        public string CodigoPrograma { get; set; }
        public string NombrePrograma { get; set; }
        public Master Master { get; set; }
        public DateTime FechaDiploma { get; set; }
        public string Tipo { get; set; }
        public string TipoDocumento { get; set; }
        public string Tabla { get; set; }
        public string Texto { get; set; }
        public string Texto2 { get; set; }
    }
}
