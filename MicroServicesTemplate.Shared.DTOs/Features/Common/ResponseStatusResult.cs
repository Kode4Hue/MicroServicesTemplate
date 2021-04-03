using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServicesTemplate.Shared.DTOs.Features.Common
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
