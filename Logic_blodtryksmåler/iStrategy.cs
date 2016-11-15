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
        DTO_data DatatoPresentation(int i);//skal denne have en parameter med?? 
    }
}
