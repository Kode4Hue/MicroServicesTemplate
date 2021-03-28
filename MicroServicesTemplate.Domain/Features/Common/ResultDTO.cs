using System.Collections.Generic;

namespace MicroServicesTemplate.Domain.Features.Common
{
    public class ResultDTO<T>
    {
        public List<string> ResourceId { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public List<T> Records { get; set; }
    }
}
