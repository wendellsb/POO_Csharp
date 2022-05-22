using System;

namespace POO_Tratamentos_Exceções._152_Exceções_Personalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
