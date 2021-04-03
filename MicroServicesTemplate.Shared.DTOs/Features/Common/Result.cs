using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServicesTemplate.Shared.DTOs.Features.Common
{
    public class Result<T>
    {
        public List<string> ResourceId { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public List<T> Records { get; set; }
    }
}
