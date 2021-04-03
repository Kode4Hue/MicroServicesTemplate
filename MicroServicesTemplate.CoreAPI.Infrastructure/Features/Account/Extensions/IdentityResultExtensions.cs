using MicroServicesTemplate.Shared.DTOs.Features.Common;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace MicroServicesTemplate.CoreAPI.Infrastructure.Features.Account.Extensions
{
    public static class IdentityResultExtensions
    {
        public static ResponseStatusResult ToApplicationResult(this IdentityResult result)
        {
            return result.Succeeded
                ? ResponseStatusResult.Success()
                : ResponseStatusResult.Failure(result.Errors.Select(e => e.Description));
        }
    }
}
