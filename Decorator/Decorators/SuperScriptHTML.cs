using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class SuperScriptHTML : HTMLDecorator, IHTML
    {
        public SuperScriptHTML(IHTML html) : base(html)
        {
            Tag = "sup";
        }
    }
}
