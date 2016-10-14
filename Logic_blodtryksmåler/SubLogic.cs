using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class SubLogic : Logic
    {
        private int value;
        private Dataaccess_blodtryksmåler.GetData DAL;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    Notify(this.value);
                }
            }
        }
    }
}
