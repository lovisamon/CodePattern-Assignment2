using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer
    {
        internal static void Run()
        {
            Console.WriteLine("Observer");
            Email email = new Email();
            email.RegisterObserver(new EmailWatcher());
            email.UpdateEmail();
            Console.WriteLine();
        }
    }
}
