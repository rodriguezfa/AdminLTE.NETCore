using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(8)]
    [DisplayImage("fa fa-envelope")]
    [TreeViewSettings("small|label pull-right bg-yellow|12", "small|label pull-right bg-green|16", "small|label pull-right bg-red|5")]
    public class MailBoxController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("")]
        [TreeView("", "label pull-right bg-red", "3")]
        public IActionResult InBox(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("")]
        [TreeView("", "label pull-right bg-red", "3")]
        public IActionResult Compose(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("")]
        [TreeView("", "label pull-right bg-red", "3")]
        public IActionResult Read(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
