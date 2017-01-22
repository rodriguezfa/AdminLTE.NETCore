using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(3)]
    [DisplayImage("fa fa-pie-chart")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class ChartsController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/ChartJS.js")]
        public IActionResult ChartJS(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/Morris.js")]
        public IActionResult Morris(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/Flot.js")]
        public IActionResult Flot(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/Inline.js")]
        public IActionResult InlineCharts(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
