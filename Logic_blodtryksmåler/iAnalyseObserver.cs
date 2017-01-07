using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Logic_blodtryksmåler
{
    public interface iAnalyseObserver
    {
        void Update(int val);
    }
}