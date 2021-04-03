using System.Threading.Tasks;
using MicroServicesTemplate.Shared.DTOs.Features.Common;

namespace MicroServicesTemplate.CoreAPI.Application.Features.Account
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<bool> AuthorizeAsync(string userId, string policyName);

        Task<(ResponseStatusResult Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<ResponseStatusResult> DeleteUserAsync(string userId);
    }
}
