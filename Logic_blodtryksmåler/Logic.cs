using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Logic :iStrategy
    {
        private int value;
        private Dataaccess_blodtryksmåler.GetData DAL;

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public DTO_data formVtommHg()
        {
            throw new NotImplementedException();
        }

        public bool ZeroAdjust()
        {
            throw new NotImplementedException();
        }

    }
}
