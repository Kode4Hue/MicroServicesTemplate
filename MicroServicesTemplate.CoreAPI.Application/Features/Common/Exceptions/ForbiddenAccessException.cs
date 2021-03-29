using System;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Common.Exceptions
{
    public class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException() : base() { }
    }
}
