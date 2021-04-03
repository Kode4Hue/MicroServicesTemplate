using System.Threading.Tasks;
using MicroServicesTemplate.Shared.DTOs.Features.Common;
using MicroServicesTemplate.Shared.DTOs.Features.Petrol;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Services
{
    public interface IPetrolService
    {
        Task<Result<PetrolPrice>> GetPetrolPrices(int limit);
    }
}
