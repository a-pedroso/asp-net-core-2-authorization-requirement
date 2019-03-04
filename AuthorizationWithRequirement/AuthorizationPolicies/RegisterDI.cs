using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace AuthorizationWithRequirement.AuthorizationPolicies
{
    public static class RegisterDI
    {
        public static void AddAuthorizationPolicies(this IServiceCollection services, IConfiguration configuration)
        {
            // Get Configuration
            var adGroupsConfiguration = new ADGroupsConfiguration();
            configuration.GetSection("ADGroupsConfiguration").Bind(adGroupsConfiguration);


            // MyFeature
            IEnumerable<string> myFeatureRoles = adGroupsConfiguration.MyFeature;
            services.AddAuthorization(options =>
            {
                options.AddPolicy(AuthorizationPolicyNames.MyFeature, policy => policy.Requirements.Add(new MyFeature.Requirement(myFeatureRoles)));
            });
            services.AddSingleton<IAuthorizationHandler, MyFeature.Handler>();


            // Others Features Requirements...
        }
    }
}
