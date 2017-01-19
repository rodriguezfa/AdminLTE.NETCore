using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrderAttribute(0)]
    [DisplayImageAttribute("fa fa-dashboard")]
    public class DashboardController : Controller
    {
        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("/lib/AdminLTE-2.3.11/dist/js/pages/dashboard.js")]
        public IActionResult DashboardV1(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("/lib/AdminLTE-2.3.11/dist/js/pages/dashboard2.js")]
        public IActionResult DashboardV2(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }    
    }
}
