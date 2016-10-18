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
        public int Måling1 { get; set; }
        public  int Måling2 { get; set; }
        public  int Read1 { get; set; }
        public  int Read2 { get; set; }
        public double Factor { get; set; }
    }
}
