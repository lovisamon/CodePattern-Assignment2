using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class DeletedHTML : HTMLDecorator, IHTML
    {
        public DeletedHTML(IHTML html) : base(html)
        {
            Tag = "del";
        }
    }
}
