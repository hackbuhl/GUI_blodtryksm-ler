using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_blodtryksmåler
{
    [Serializable]
    public class DTO_data
    {
        public List<double> datalist { get; set; }
        public List<double> FilterList { get; set; }
        public DateTime datoogtid { get; set; }
        public int Systole { get; set; }
        public int Diastole { get; set; }
        public  string kommentar { get; set; }
        public string CPR { get; set; }




        public DTO_data()
        {

        }

        public DTO_data(List<double> currentVoltageSeq)
        {
            this.datalist = currentVoltageSeq; 
        }

}
}