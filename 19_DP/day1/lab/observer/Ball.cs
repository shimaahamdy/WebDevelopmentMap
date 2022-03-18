using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    internal class Ball 
    {
        
        List<IObserver> listeners = new List<IObserver>();
        
        public void Notify()
        {
            for(int i=0;i<listeners?.Count;++i)
            {
                listeners[i].Update();
            }
        }
        
        public void Attach(IObserver listener)
        {
            listeners.Add(listener);
        }

        public void Detach(IObserver listener)
        {
            listeners.Remove(listener);
        }
    }
}
