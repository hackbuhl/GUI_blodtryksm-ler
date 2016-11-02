using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_blodtryksmåler
{
    [Serializable]
     public class DTO_alarm
    {
        public int ØvSys { get; set; }
        public int NedSys { get; set; }
        public int ØvDia { get; set; }
        public int NedDia { get; set; }
        public bool State { get; set; }

    }
}
