using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_blodtryksmåler
{
    public abstract class AbAnalyse
    {

        private List<iAnalyseObserver> observers = new List<iAnalyseObserver>();
        private int CalVariabel;

        public Filter Filter
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public iAnalyseObserver iAnalyseObserver
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Attach(iAnalyseObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(iAnalyseObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(int val)
        {
            foreach (var observer in observers)
            {
                observer.Update(val);
            }
        }
    }
}
