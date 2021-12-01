using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class SmallerHTML : HTMLDecorator, IHTML
    {
        public SmallerHTML(IHTML html) : base(html)
        {
            Tag = "small";
        }
    }
}
