using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(1)]
    [DisplayImage("fa fa-files-o")]
    [TreeView("span", "label label-primary pull-right", "4")]
    public class LayoutOptionsController : Controller
    {
        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult TopNavigation(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Boxed(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Fixed(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult CollapsedSidebar(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
