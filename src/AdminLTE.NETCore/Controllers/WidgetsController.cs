using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(2)]
    [DisplayImage("")]
    public class WidgetsController : Controller
    {
        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-th")]
        [ScriptAfterPartialViewAttribute("")]
        [TreeView("", "label pull-right bg-green", "new")]
        public IActionResult Widgets(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
