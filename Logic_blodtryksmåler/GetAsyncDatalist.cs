using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Dataaccess_blodtryksmåler;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class GetAsyncDatalist : Dataaccess_blodtryksmåler.iDataobs
    {
        List<double> daDoubles=new List<double>();

        private Logic log; // her skal findes det oprindelige logic objekt og putte det ind i?? 

        public GetAsyncDatalist(DAQmxAsyncRead daqRead, Logic logic)
        {
            log = logic;
            daqRead.Attach(this);
        }
        public void Update(double[] data)
        {
            
            for (int i = 0; i < data.Length;i=i+20)
            {
                
                List<double> av=new List<double>();
                for (int j = i; j < i+20 ; j++)
                {
                    av.Add(data[j]);

                }
                
                log.dtoData.datalist.Add(av.Average());
            }
           log.sema1.Release();
        }

        public Logic GetLogic()
        {
            return log;
        }

    }
}
