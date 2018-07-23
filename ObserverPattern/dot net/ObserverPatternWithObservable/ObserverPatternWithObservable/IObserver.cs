using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IObserver
    {
        void Update(AObservable subject);

        //Push Mechanism
        //void Update(object data)
    }
}
