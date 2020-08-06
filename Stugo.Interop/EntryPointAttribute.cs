using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stugo.Interop
{
    /// <summary>
    /// Allows the specification of the unmanaged entry point.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EntryPointAttribute : Attribute
    {
        public EntryPointAttribute(string entryPoint)
        {
            EntryPoint = entryPoint;
        }

        public string EntryPoint { get; set; }
    }
}
