using System.Collections.Generic;
using System.Linq;

namespace MicroServicesTemplate.Domain.Features.Common
{
    public class ResponseStatusResult
    {
        internal ResponseStatusResult(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static ResponseStatusResult Success()
        {
            return new ResponseStatusResult(true, new string[] { });
        }

        public static ResponseStatusResult Failure(IEnumerable<string> errors)
        {
            return new ResponseStatusResult(false, errors);
        }
    }
}
