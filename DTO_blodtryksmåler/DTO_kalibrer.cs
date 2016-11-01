using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_blodtryksmåler
{
    [Serializable]
    public class DTO_kalibrer
    {
        public double   Måling1 { get; set; }
        public  double Måling2 { get; set; }
        public  double Read { get; set; }
        public  double Read2 { get; set; }
        public double Factor { get; set; }
    }
}
