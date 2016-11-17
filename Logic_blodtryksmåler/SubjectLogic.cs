using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_blodtryksmåler
{
    public abstract class SubjectLogic
    {
        private List<IObserverLogic> observers;

        public SubjectLogic()
        {
            observers = new List<IObserverLogic>(); 
        }

        public void Attach(IObserverLogic observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserverLogic observer)
        {
            observers.Remove(observer);
        }

        public void Notify(ref DTO_blodtryksmåler.DTO_data dto)
        {
            foreach (var observer in observers)
            {
                observer.Update(ref dto);
            }
        }

    }
}
