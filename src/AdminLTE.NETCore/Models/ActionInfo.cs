using AdminLTE.NETCore.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.Models
{
    public class ActionInfo
    {
        public string ActionName { get; set; }
        public string DisplayName { get; set; }
        public string DisplayImage { get; set; }
        public string ScriptAfterPartialView { get; set; }
        public TreeViewAttribute TreeViewSettings{ get; set; }
    }
}
