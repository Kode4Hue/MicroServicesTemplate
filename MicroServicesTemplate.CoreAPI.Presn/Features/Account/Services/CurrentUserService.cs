using System.Security.Claims;
using MicroServicesTemplate.CoreAPI.Application.Features.Account;
using Microsoft.AspNetCore.Http;

namespace MicroServicesTemplate.CoreAPI.Presn.Features.Account.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
