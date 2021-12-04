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
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            Email email = new Email();
            email.RegisterObserver(new EmailWatcher());
            email.UpdateEmail();
            Console.WriteLine();
        }
    }
}
