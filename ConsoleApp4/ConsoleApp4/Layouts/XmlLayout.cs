using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Layouts
{
    using Interfaces;
    class XmlLayout : ILayout
    {
        public string Format => 
            "<log>\n" +
            "   <date>{0}</date>\n" +
            "   <level>{1}</level>\n" +
            "   <message>{2}</message>\n" +
            "<log>\n";
    }
}
