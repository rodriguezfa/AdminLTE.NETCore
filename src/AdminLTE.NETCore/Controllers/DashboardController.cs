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
        public IActionResult DashboardV1(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        public IActionResult DashboardV2(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
