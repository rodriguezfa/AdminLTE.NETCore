using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(5)]
    [DisplayImage("fa fa-edit")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class FormsController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("")]
        public IActionResult GeneralElements(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        //[ScriptAfterPartialView("/lib/AdminLTE-2.3.11/plugins/select2/select2.full.min.js,/lib/AdminLTE-2.3.11/plugins/input-mask/jquery.inputmask.js,/lib/AdminLTE-2.3.11/plugins/input-mask/jquery.inputmask.date.extensions.js,/lib/AdminLTE-2.3.11/plugins/input-mask/jquery.inputmask.date.extensions.js,https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.11.2/moment.min.js,/lib/AdminLTE-2.3.11/plugins/daterangepicker/daterangepicker.js,/lib/AdminLTE-2.3.11/plugins/datepicker/bootstrap-datepicker.js,/lib/AdminLTE-2.3.11/plugins/colorpicker/bootstrap-colorpicker.min.js,/lib/AdminLTE-2.3.11/plugins/timepicker/bootstrap-timepicker.min.js,/lib/AdminLTE-2.3.11/plugins/iCheck/icheck.min.js,/js/Forms/Advanced.js")]
        [ScriptAfterPartialView("/js/Forms/advanced.min.js")]

        public IActionResult AdvancedElements(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        //[ScriptAfterPartialView("https://cdn.ckeditor.com/4.5.7/standard/ckeditor.js,/lib/AdminLTE-2.3.11/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js,/js/Forms/Editors.js")]
        [ScriptAfterPartialView("/js/Forms/editors.min.js")]
        public IActionResult Editors(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}
