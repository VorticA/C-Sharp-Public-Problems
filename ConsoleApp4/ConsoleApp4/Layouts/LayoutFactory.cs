using Loggers.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Layouts
{
    class LayoutFactory : ILayoutFactory
    {
        public ILayout GetLayout(string name)
        {
            if (name.ToLower() == "simplelayout") return new SimpleLayout();
            else if (name.ToLower() == "xmllayout") return new XmlLayout();
            else throw new ArgumentException("Invalid layout type.");
        }
    }
}
