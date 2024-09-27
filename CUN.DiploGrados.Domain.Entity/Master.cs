using System;
using System.Collections.Generic;
using System.Text;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Master
    {
        public string CodigoUnico { get; set; }
        public string Escuela { get; set; }
        public string Nombres { get; set; }
        public string GenTercero { get; set; }
        public string Email { get; set; }
        public string TipoDeDocumento { get; set; }
        public string TipoDeDocumentoActa { get; set; }
        public string DadoEn { get; set; }
        public string Snies { get; set; }
        public string CarreraOTitulo { get; set; }
        public string Acta { get; set; }
        public string Registro { get; set; }
        public string Folio { get; set; }
        public string Libro { get; set; }
        public string DiaTexto { get; set; }
        public int DiaNumero { get; set; }
        public string MesTexto { get; set; }
        public int MesNumero { get; set; }
        public int AgnoNumero { get; set; }
        public string AgnoTexto { get; set; }
        public string Clave { get; set; }
    }
}
