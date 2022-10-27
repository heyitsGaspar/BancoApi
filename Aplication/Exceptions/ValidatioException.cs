using FluentValidation.Results;

namespace Aplication.Exceptions
{
    public class ValidatioException : Exception
    {
        public ValidatioException() : base("Se han producido uno o mas errores de validacion")
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get;} 
        
        public ValidatioException(IEnumerable<ValidationFailure> failures): this ()
        {
            foreach(var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
