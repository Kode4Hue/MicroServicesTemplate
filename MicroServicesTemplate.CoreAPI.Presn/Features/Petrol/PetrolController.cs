using System.Threading.Tasks;
using MediatR;
using MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Queries.GetPetrolPrices;
using MicroServicesTemplate.CoreAPI.Presn.Features.Common;
using MicroServicesTemplate.Shared.DTOs.Features.Common;
using MicroServicesTemplate.Shared.DTOs.Features.Petrol;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroServicesTemplate.CoreAPI.Presn.Features.Petrol
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetrolController : APIControllerBase
    {

        private readonly ILogger<PetrolController> _logger;

        public PetrolController(ISender mediator, ILogger<PetrolController> logger):base(mediator)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<Result<PetrolPrice>> Get()
        {
            var query = new GetPetrolPricesQuery
            {
                Limit = 10
            };

            var result = await Mediator.Send(query);
            return result;
        }
    }
}
