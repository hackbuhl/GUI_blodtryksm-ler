using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_blodtryksmåler
{
    public interface IObserverLogic
    {
        void Update(ref DTO_blodtryksmåler.DTO_data dto);
    }
}
