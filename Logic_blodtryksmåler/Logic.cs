using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic_blodtryksmåler
{
    public abstract class Logic
    {
        private List<iDataObserver> observers = new List<iDataObserver>();
        private int CalVariabel;

        public void Attach(iDataObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(iDataObserver observer)
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

        public DTO_blodtryksmåler.DTO_data fromVtommHg()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeCalibration()
        {
            throw new System.NotImplementedException();
        }

        public bool ZeroAdjust()
        {
            throw new System.NotImplementedException();
        }
    }
}