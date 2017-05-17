using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(6)]
    [DisplayImage("fa fa-table")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class TablesController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("")]
        public IActionResult SimpleTables(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/Tables/datatables.min.js")]
        public IActionResult DataTables(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
