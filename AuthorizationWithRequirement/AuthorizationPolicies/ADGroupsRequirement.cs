using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace AuthorizationWithRequirement.AuthorizationPolicies
{
    public class ADGroupsRequirement : IAuthorizationRequirement
    {
        public IEnumerable<string> Groups { get; private set; }

        public ADGroupsRequirement(IEnumerable<string> groups)
        {
            Groups = groups;
        }
    }
}
