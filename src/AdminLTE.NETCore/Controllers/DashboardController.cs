using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(0)]
    [DisplayImage("fa fa-dashboard")]
    [TreeView("i", "fa fa-angle-left pull-right", "" )]
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
        [ScriptAfterPartialViewAttribute("/lib/AdminLTE-2.3.11/plugins/chartjs/Chart.min.js,/lib/AdminLTE-2.3.11/dist/js/pages/dashboard2.js")]
        public IActionResult DashboardV2(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }    
    }
}
