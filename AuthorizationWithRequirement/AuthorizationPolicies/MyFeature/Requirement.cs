using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationWithRequirement.AuthorizationPolicies.MyFeature
{
    public class Requirement : ADGroupsRequirement
    {
        public Requirement(IEnumerable<string> groups) : base(groups)
        {

        }
    }
}
