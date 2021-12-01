using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class MarkedHTML : HTMLDecorator, IHTML
    {
        public MarkedHTML(IHTML html) : base(html)
        {
            Tag = "mark";
        }
    }
}
