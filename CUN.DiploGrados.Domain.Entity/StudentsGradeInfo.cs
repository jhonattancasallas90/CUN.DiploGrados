using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity
{
    public class StudentsGradeInfo
    {
        public string SEDE_GRADO { get; set; }          // Verificar que estos datos sean los correctos -   // Por validar para su integración
        public string SNIES { get; set; }                   //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string TITULACION { get; set; }          //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string ACTA { get; set; }                    //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string NRO_REGISTRO { get; set; }                //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string FOLIO { get; set; }                   //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados
        public string LIBRO { get; set; }
    }
}
