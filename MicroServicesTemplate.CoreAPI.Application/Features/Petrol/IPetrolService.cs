using System.Threading.Tasks;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Common
{
    public interface IPetrolService
    {
        Task<ResultDTO<PetrolPriceDTO>> GetPetrolPrices(int limit);
    }
}
