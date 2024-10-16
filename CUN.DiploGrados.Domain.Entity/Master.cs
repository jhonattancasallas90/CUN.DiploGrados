using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class Master
    {
        [JsonPropertyName("codigounico")]
        public string TipoPlantilla { get; set; }       //"tipoplantilla": "grados, duplicados, honoresCausa"

        //[JsonPropertyName("codigounico")]
        //public string CodigoUnico { get; set; }

        //[JsonPropertyName("escuela")]
        //public string Escuela { get; set; }

        //[JsonPropertyName("nombres")]
        //public string Nombres { get; set; }

        //[JsonPropertyName("gentercero")]
        //public string GenTercero { get; set; }

        //[JsonPropertyName("email")]
        //public string Email { get; set; }

        //[JsonPropertyName("tipodedocumento")]
        //public string TipoDeDocumento { get; set; }

        //[JsonPropertyName("tipodedocumentoacta")]
        //public string TipoDeDocumentoActa { get; set; }

        //[JsonPropertyName("dadoen")]
        //public string DadoEn { get; set; }

        //[JsonPropertyName("snies")]
        //public string Snies { get; set; }

        //[JsonPropertyName("carreraotitulo")]
        //public string CarreraOTitulo { get; set; }

        //[JsonPropertyName("acta")]
        //public string Acta { get; set; }

        //[JsonPropertyName("registro")]
        //public string Registro { get; set; }

        //[JsonPropertyName("folio")]
        //public string Folio { get; set; }

        //[JsonPropertyName("libro")]
        //public string Libro { get; set; }

        //[JsonPropertyName("diatexto")]
        //public string DiaTexto { get; set; }

        //[JsonPropertyName("dianumero")]
        //public int DiaNumero { get; set; }

        //[JsonPropertyName("mestexto")]
        //public string MesTexto { get; set; }

        //[JsonPropertyName("mesnumero")]
        //public int MesNumero { get; set; }

        //[JsonPropertyName("agnonumero")]
        //public int AgnoNumero { get; set; }

        //[JsonPropertyName("agnotexto")]
        //public string AgnoTexto { get; set; }

        //[JsonPropertyName("clave")]
        //public string Clave { get; set; }
    }
}
