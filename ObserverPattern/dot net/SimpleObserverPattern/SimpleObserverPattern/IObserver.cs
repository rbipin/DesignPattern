using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{
    interface IObserver
    {
        void Update(Object data);
    }
}
