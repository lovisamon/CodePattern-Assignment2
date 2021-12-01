using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class BoldHTML : HTMLDecorator, IHTML
    {
        public BoldHTML(IHTML html) : base(html)
        {
            Tag = "b";
        }
    }
}
