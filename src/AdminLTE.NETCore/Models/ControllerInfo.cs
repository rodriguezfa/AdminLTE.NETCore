using AdminLTE.NETCore.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.Models
{
    public class ControllerInfo
    {
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string DisplayImage { get; set; }
        public string ControllerName { get; set; }
        public List<ActionInfo> ControllerActions { get; set; }
        public TreeViewAttribute TreeViewSettings { get; set; }
    }

}
