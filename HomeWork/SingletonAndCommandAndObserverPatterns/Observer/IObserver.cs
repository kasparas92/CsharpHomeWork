using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAndCommandAndObserverPatterns.interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
