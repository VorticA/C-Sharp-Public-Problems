using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Layouts
{
    using Interfaces;
    class SimpleLayout : ILayout
    {
        public string Format { get => "{0} - {1} - {2} \n"; }
    }
}
