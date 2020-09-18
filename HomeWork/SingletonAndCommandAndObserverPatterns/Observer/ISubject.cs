using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAndCommandAndObserverPatterns.interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
