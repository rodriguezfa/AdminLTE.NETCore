using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(4)]
    [DisplayImage("fa fa-laptop")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class UIElementsController : Controller
    {
        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult General(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Icons(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Buttons(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Sliders(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Timeline(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("")]
        public IActionResult Modals(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
