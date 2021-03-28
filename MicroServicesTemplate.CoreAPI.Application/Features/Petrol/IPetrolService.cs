using System.Threading.Tasks;
using MicroServicesTemplate.Domain.Features.Petrol;
using MicroServicesTemplate.Domain.Features.Common;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Common
{
    public interface IPetrolService
    {
        Task<ResultDTO<PetrolPriceDTO>> GetPetrolPrices(int limit);
    }
}
