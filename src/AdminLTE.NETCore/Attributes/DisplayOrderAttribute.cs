using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DisplayOrderAttribute : Attribute
    {
        public readonly int DisplayOrder;
        public DisplayOrderAttribute(int order)  // order is a positional parameter
        {
            this.DisplayOrder = order;
        }
    }
}
