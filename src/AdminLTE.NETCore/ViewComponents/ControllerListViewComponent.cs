using AdminLTE.NETCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.ViewComponents
{
    public class ControllerListViewComponent : ViewComponent
    {
        private readonly IControllerInformationRepository _controllerList;
        public ControllerListViewComponent(IControllerInformationRepository controllerList)
        {
            _controllerList = controllerList;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Todo: Return allowed queues and counters.
            var items = await Task.Run(() => _controllerList.GetAll());
            return View(items);
        }
    }
}
