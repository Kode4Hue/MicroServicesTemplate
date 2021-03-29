using System.Threading.Tasks;
using MicroServicesTemplate.Domain.Features.Petrol;
using MicroServicesTemplate.Domain.Features.Common;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Services
{
    public interface IPetrolService
    {
        Task<Result<PetrolPrice>> GetPetrolPrices(int limit);
    }
}
