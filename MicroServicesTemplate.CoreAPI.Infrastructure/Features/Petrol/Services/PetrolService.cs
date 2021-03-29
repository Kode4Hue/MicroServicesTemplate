using System.Threading.Tasks;
using MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Services;
using MicroServicesTemplate.Domain.Features.Common;
using MicroServicesTemplate.Domain.Features.Petrol;

namespace MicroServicesTemplate.CoreAPI.Infrastructure.Features.Petrol.Services
{
    public class PetrolService : IPetrolService
    {
        public async Task<Result<PetrolPrice>> GetPetrolPrices(int limit)
        {
            return new Result<PetrolPrice>
            {

            };
        }
    }
}
