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
        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("/lib/AdminLTE-2.3.11/plugins/chartjs/Chart.js,/js/ChartJS.js")]
        public IActionResult ChartJS(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("/js/Morris.js,/lib/AdminLTE-2.3.11/plugins/morris/morris.min.js,https://cdnjs.cloudflare.com/ajax/libs/raphael/2.1.0/raphael-min.js")]
        public IActionResult Morris(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("/lib/AdminLTE-2.3.11/plugins/flot/jquery.flot.min.js,/lib/AdminLTE-2.3.11/plugins/flot/jquery.flot.resize.min.js,/lib/AdminLTE-2.3.11/plugins/flot/jquery.flot.pie.min.js,/lib/AdminLTE-2.3.11/plugins/flot/jquery.flot.categories.min.js,/js/Flot.js")]
        public IActionResult Flot(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenuAttribute]
        [DisplayImageAttribute("fa fa-circle-o")]
        [ScriptAfterPartialViewAttribute("/lib/AdminLTE-2.3.11/plugins/knob/jquery.knob.js,/lib/AdminLTE-2.3.11/plugins/sparkline/jquery.sparkline.min.js,/js/Inline.js")]
        public IActionResult InlineCharts(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
