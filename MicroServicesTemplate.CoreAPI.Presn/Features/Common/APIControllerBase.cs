using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MicroServicesTemplate.CoreAPI.Presn.Features.Common
{

    [ApiController]
    [Route("api/[controller]")]
    public abstract class APIControllerBase : ControllerBase
    {
        protected readonly ISender Mediator;
       
        public APIControllerBase(ISender sendor)
        {
            Mediator = sendor;
        }
    }
}
