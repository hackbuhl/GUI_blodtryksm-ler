using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public interface iStrategy
    {
        void Execute(bool cal);
        DTO_data formVtommHg();
        bool ZeroAdjust();
    }
}
