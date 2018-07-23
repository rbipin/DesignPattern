using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class AObservable
    {
        List<IObserver> Observers = new List<IObserver>();
        bool state = false;
        public virtual void AddObserver(IObserver obs)
        {
            Observers.Add(obs);
        }
        
        public virtual void RemoveObserver(IObserver obs)
        {           
             Observers.Remove(obs);
        }

        //This is using PUll mechanism, the observer the pull the data as required from the subject
        public virtual void NotifyObserver()
        {
            if (state)
            {
                foreach (IObserver obs in Observers)
                {
                    obs.Update(this);
                }
                state = false;
            }
        }

        //Used in Push Mechanism
        //public virtual void NotifyObserver(Object data)
        //{
        //    if (state)
        //    {
        //        foreach (IObserver obs in Observers)
        //        {
        //            obs.Update(this, data);
        //        }
        //        state = false;
        //    }
        //}

        protected void StateChanged()
        {
            state = true;
        }


    }
}
