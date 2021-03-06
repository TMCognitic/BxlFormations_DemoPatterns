using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.ObserverPattern
{
    public abstract class Subject : ISubject
    {
        private Action<ISubject> _notifyHandler;

        public void Attach(IObserver observer)
        {
            _notifyHandler += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            _notifyHandler -= observer.Update;
        }

        protected void Notify()
        {
            _notifyHandler?.Invoke(this);
        }
    }
}
