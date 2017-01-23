using AdminLTE.NETCore.Attributes;
using AdminLTE.NETCore.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.Models
{
    /// <summary>
    /// Dynamically get a list of the controllers and actions for the AdminLTE demo
    /// </summary>
    public class ControllerInformationRepository : IControllerInformationRepository
    {
        private List<ControllerInfo> _controllerInfo = new List<ControllerInfo>();

        public ControllerInformationRepository()
        {
            //TODO: Refactor to make more readable
            _controllerInfo = Assembly.GetEntryAssembly()
                .GetTypes()
                .AsEnumerable()
                .Where(type => typeof(Controller).IsAssignableFrom(type)) //&& Can add a filter here to not include some controllers.
                .ToList()
                .OrderBy(t =>
                {
                    var orderby = (DisplayOrderAttribute)t.GetTypeInfo().GetCustomAttribute<DisplayOrderAttribute>();
                    if (orderby != null)
                        return orderby.DisplayOrder;
                    else
                        return 0;
                }
                )
            .Select(
            d => new
            {
                fullname = d.FullName,
                controllerName = CleanupControllerName(d.Name),
                displayImage = d.GetTypeInfo().GetCustomAttribute<DisplayImageAttribute>(),
                action_list = d.GetMethods().Where(method => method.IsPublic && method.IsDefined(typeof(DisplayActionMenuAttribute))),
                treeview = d.GetTypeInfo().GetCustomAttribute<TreeViewAttribute>(),
                treeviewsettings = d.GetTypeInfo().GetCustomAttribute<TreeViewSettingsAttribute>()
            }
            )
                .ToList()
                .Select(
                   a =>
                    new ControllerInfo()
                    {
                        ControllerName = a.controllerName,
                        FullName = a.fullname,
                        DisplayName = a.controllerName.SeparatePascalCase(),
                        DisplayImage = a.displayImage.DisplayImage,
                        TreeViewSettings = a.treeview,
                        TreeViewSettings2 = a.treeviewsettings,
                        //Actions
                        ControllerActions = a.action_list.Select(act => new Models.ActionInfo()
                        {
                            ActionName = act.Name,
                            DisplayName = act.Name.SeparatePascalCase(),
                            DisplayImage = act.GetCustomAttributes<DisplayImageAttribute>().FirstOrDefault().DisplayImage, //Will generate an exception if the attribute is not defined.
                            ScriptAfterPartialView = act.GetCustomAttributes<ScriptAfterPartialViewAttribute>().FirstOrDefault().ScriptToRun, //Will generate an exception if the attribute is not defined.
                            TreeViewSettings = act.GetCustomAttributes<TreeViewAttribute>().FirstOrDefault(),
                            TreeViewSettings2 = act.GetCustomAttributes<TreeViewSettingsAttribute>().FirstOrDefault()
                        }).ToList()
                    }
            ).ToList();

        }

        private string CleanupControllerName(string controllerName)
        {
            return controllerName.Replace("Controller", "");
        }

        public List<ControllerInfo> GetAll()
        {
            return _controllerInfo;
        }
    }
}
