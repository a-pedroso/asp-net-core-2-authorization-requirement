using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationWithRequirement.AuthorizationPolicies.MyFeature;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationWithRequirement.Controllers
{
    [AuthorizeMyFeature]
    public class MyFeatureController : Controller
    {
        // GET: MyFeature
        public ActionResult Index()
        {
            return View();
        }
    }
}