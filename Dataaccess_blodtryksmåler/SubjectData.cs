using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess_blodtryksmåler
{
    public abstract class SubjectData
    {
        private List<iDataobs> observers;

        protected SubjectData()
        {
            observers = new List<iDataobs>();
        }

        public void Attach(iDataobs observer)
        {
            observers.Add(observer);
        }

        public void Detach(iDataobs observer)
        {
            observers.Remove(observer);
        }

        public void Notify(double[] daDoubles)
        {
            foreach (var observer in observers)
            {
                observer.Update(daDoubles);
            }
        }
    }
}
