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
    public class GetAsyncDatalist : iDataobs
    {
        List<double> daDoubles=new List<double>();
        DTO_blodtryksmåler.DTO_data datadto = new DTO_data();
        public void Update(double[] data)
        {
            for (int i = 0; i < data.Length;i=i+10)
            {
                List<double> av=new List<double>();
                for (int j = i; j < i+10 ; j++)
                {
                    av.Add(data[j]);

                }
                datadto.datalist.Add(av.Average());
            }
           

        }
    }
}
