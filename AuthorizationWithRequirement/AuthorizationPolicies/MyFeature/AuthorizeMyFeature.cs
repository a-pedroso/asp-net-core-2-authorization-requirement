using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationWithRequirement.AuthorizationPolicies.MyFeature
{
    public class AuthorizeMyFeature : AuthorizeAttribute
    {
        public AuthorizeMyFeature() : base(AuthorizationPolicyNames.MyFeature)
        {
        }
    }
}
