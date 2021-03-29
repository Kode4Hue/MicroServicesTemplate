using MediatR;
using MicroServicesTemplate.Domain.Features.Common;
using MicroServicesTemplate.Domain.Features.Petrol;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Queries.GetPetrolPrices
{
    public class GetPetrolPricesQuery : IRequest<Result<PetrolPrice>>
    {
        public int Limit { get; set; }
    }
}
