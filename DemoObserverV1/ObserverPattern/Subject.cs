using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.ObserverPattern
{
    public abstract class Subject : ISubject
    {
        private List<IObserver> _observers;

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(this);
            }
        }
    }
}
