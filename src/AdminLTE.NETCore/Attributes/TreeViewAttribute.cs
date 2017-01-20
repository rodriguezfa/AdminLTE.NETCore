using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.NETCore.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class TreeViewAttribute : Attribute
    {
        public readonly string ElementType;
        public readonly string ElementClass;
        public readonly string ElementValue;

        public TreeViewAttribute(string elementType, string elementClass, string elementValue) 
        {
            this.ElementType = elementType;
            this.ElementClass = elementClass;
            this.ElementValue = elementValue;
        }
    }
}
