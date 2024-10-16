using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Application.DTO
{
    public class MasterDTO
    {
        [JsonPropertyName("TipoPlantilla")]
        public string TipoPlantilla { get; set; }       //"tipoplantilla": "grados, duplicados, honoresCausa"

        //[JsonPropertyName("codigo unico")]
        //public string CodigoUnico {get; set;}

        //[JsonPropertyName("escuela")]
        //public string Escuela { get; set;}

        //[JsonPropertyName("nombres")]
        //public string Nombres { get; set;}

        //[JsonPropertyName("gen_tercero")]
        //public string GenTercero { get; set;}

        //[JsonPropertyName("email")]
        //public string Email { get; set;}

        //[JsonPropertyName("tipo de documento")]
        //public string TipoDeDocumento {get; set;}

        //[JsonPropertyName("tipo de documento(acta)")]
        //public string TipoDeDocumentoActa { get; set;}

        //[JsonPropertyName("dado en")]
        //public string DadoEn {get; set;}

        //[JsonPropertyName("snies")]
        //public string Snies { get; set;}

        //[JsonPropertyName("carrera o titulo")]
        //public string CarreraOTitulo { get; set;}

        //[JsonPropertyName("acta")]
        //public string Acta {get; set;}

        //[JsonPropertyName("registro")]
        //public string Registro { get; set;}

        //[JsonPropertyName("folio")]
        //public string Folio { get; set;}

        //[JsonPropertyName("libro")]
        //public string Libro { get; set;}

        //[JsonPropertyName("dia (texto)")]
        //public string DiaTexto {get; set;}

        //[JsonPropertyName("dia (numero)")]
        //public int DiaNumero {get; set;}

        //[JsonPropertyName("mes (texto)")]
        //public string MesTexto {get; set;}

        //[JsonPropertyName("mes (numero)")]
        //public string MesNumero {get; set;}

        //[JsonPropertyName("año (numero)")]
        //public string AgnoNumero {get; set;}

        //[JsonPropertyName("año (texto)")]
        //public string AgnoTexto { get; set; }

        //[JsonPropertyName("clave")]
        //public string Clave { get; set; }
    }
}
