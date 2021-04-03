using MediatR;
using MicroServicesTemplate.Shared.DTOs.Features.Common;
using MicroServicesTemplate.Shared.DTOs.Features.Petrol;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Queries.GetPetrolPrices
{
    public class GetPetrolPricesQuery : IRequest<Result<PetrolPrice>>
    {
        public int Limit { get; set; }
    }
}
