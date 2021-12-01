using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    interface ISubject
    {
        public List<IObserver> Observers { get; set; }
        public void RegisterObserver(IObserver observer);
        public void UnRegisterObserver(IObserver observer);
        public void NotifyObserver();
    }
}
