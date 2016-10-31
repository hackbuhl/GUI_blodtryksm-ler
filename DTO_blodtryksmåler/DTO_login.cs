using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_blodtryksmåler
{
    [Serializable]
    public class DTO_login
    {
        public int id { get; set; }
        public string pass { get; set; }
        public string type { get; set; }
    }
}
