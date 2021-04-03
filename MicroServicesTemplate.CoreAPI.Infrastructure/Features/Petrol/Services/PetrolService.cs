using System.Threading.Tasks;
using MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Services;
using MicroServicesTemplate.Shared.DTOs.Features.Common;
using MicroServicesTemplate.Shared.DTOs.Features.Petrol;

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
