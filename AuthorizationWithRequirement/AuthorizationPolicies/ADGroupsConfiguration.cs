using System.Collections.Generic;

namespace AuthorizationWithRequirement.AuthorizationPolicies
{
    /// <summary>
    /// represents ADGroupsConfiguration from appsettings.json
    /// </summary>
    public class ADGroupsConfiguration
    {
        public IEnumerable<string> MyFeature { get; set; }
    }
}
