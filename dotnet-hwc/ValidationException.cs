using System;

namespace HwcBootstrapper
{
    public class ValidationException : Exception
    {
        
        public ValidationException(string message) : base(message)
        {
        }
        
    }
}
