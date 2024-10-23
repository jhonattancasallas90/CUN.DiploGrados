﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CUN.DiploGrados.Domain.Entity
{
    public class StudentsPayload                // CLASE 100% FUNCIONAL para nombrar los campos del Body JSON
    {
        [JsonPropertyName("master")]
        public List<Master> Master { get; set; }

        [JsonPropertyName("identificacion")]
        public string Identificacion { get; set; }

        [JsonPropertyName("escuela")]
        public string NombreEscuela { get; set; }

        [JsonIgnore]
        public string Nombres { get; set; }

        [JsonIgnore]
        public string Apellidos { get; set; }

        [JsonPropertyName("nombres")]
        public string NombresYApellidos {  get; set; }

        [JsonPropertyName("gen_tercero")]
        public string Genero { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("tipo_documento")]
        public string TipoDocumento { get; set; }

        [JsonPropertyName("tipo_documento_acta")]
        public string TipoDocumentoActa { get; set; }

        //[JsonIgnore]
        //public StudentsGradeInfo StudentGrade { get; set; }    // Acceso a la data complementaria de ORACLE

        [JsonPropertyName("dado_en")]
        public string SEDE_GRADO { get; set; }          // Verificar que estos datos sean los correctos -   // Por validar para su integración

        [JsonPropertyName("snies")]
        public string SNIES { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("carrera_o_titulo")]
        public string TITULACION { get; set; }          //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("acta")]
        public string ACTA { get; set; }                //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("registro")]
        public string NRO_REGISTRO { get; set; }        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("folio")]
        public string FOLIO { get; set; }               //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        [JsonPropertyName("libro")]
        public string LIBRO { get; set; }

        //Nuevos campos integrados de acuerdo a reunión con Lorena Diplogrados

        //[JsonIgnore]
        //public string GRADO_FECHA { get; set; }    // Acceso a la data complementaria de ORACLE

        [JsonPropertyName("dia_texto")]
        public string DiaTexto { get; set; }

        [JsonPropertyName("dia_numero")]
        public string DiaNumero { get; set; }
        //public int DiaNumero { get; set; }

        [JsonPropertyName("mes_texto")]
        public string MesTexto { get; set; }

        [JsonPropertyName("mes_numero")]
        public string MesNumero { get; set; }
        //public int MesNumero { get; set; }

        [JsonPropertyName("anio_numero")]
        public string AgnoNumero { get; set; }
        //public int AgnoNumero { get; set; }

        [JsonPropertyName("anio_texto")]
        public string AgnoTexto { get; set; }

    }
}
