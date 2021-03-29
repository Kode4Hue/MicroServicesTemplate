using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Services;
using MicroServicesTemplate.Domain.Features.Common;
using MicroServicesTemplate.Domain.Features.Petrol;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Queries.GetPetrolPrices
{
    public class GetPetrolPricesQueryHandler : IRequestHandler<GetPetrolPricesQuery, Result<PetrolPrice>>
    {

        private IPetrolService _petrolService;

        public GetPetrolPricesQueryHandler(IPetrolService petrolService)
        {
            _petrolService = petrolService;
        }

        public async Task<Result<PetrolPrice>> Handle(GetPetrolPricesQuery request, CancellationToken cancellationToken)
        {
            return await _petrolService.GetPetrolPrices(request.Limit);
        }
    }
}
