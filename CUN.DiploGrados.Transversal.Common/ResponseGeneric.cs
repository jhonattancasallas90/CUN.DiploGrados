using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;

namespace CUN.DiploGrados.Transversal.Common
{
    public class ResponseGeneric<T>
    {
        public T Data { get; set; }             // Entidad a la que vamos a enviar
        public bool IsSuccess { get; set; }     // El envio fue extoso? 
        public string Message { get; set; }     // ¿Consumo correcto o tipo de error controlado?
        public IEnumerable<ValidationFailure> Errors { get; set; }  // Validacion sobre la entidad - Me trae de la clase ApplicationValidator
    }
}
