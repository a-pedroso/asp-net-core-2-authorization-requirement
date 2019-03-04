using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Threading.Tasks;

namespace AuthorizationWithRequirement.AuthorizationPolicies
{
    public class ADGroupsHandler<T> : AuthorizationHandler<T> where T : ADGroupsRequirement
    {
        public ILogger<T> Logger { get; set; }

        public ADGroupsHandler() 
        {
            Logger = NullLogger<T>.Instance;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, T requirement)
        {
            foreach (var g in requirement.Groups)
            {
                try
                {
                    if (context.User.IsInRole(g))
                    {
                        context.Succeed(requirement);
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Logger.LogError(ex, "Error on IsInRole validation");
                    throw;
                }
            }

            return Task.CompletedTask;
        }
    }
}
