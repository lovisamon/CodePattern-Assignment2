using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class SubScriptHTML : HTMLDecorator, IHTML
    {
        public SubScriptHTML(IHTML html) : base(html)
        {
            Tag = "sub";
        }
    }
}
