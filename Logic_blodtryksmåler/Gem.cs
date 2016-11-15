using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dataaccess_blodtryksmåler;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Gem
    {
        private Dataaccess_blodtryksmåler.GemPatient GemPatient= new GemPatient();
        private int[] weightCPR = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

        private bool ValidateCPR(String cpr)
        {
            int sum = 0;
            if (cpr.Length == 10)
            {
                for (int i = 0; i < cpr.Length; i++)
                {
                    char[] chars = cpr.ToCharArray();
                    sum += (chars[i] - 48) * weightCPR[i]; //de 48 trækkes fra for at lave char om til int-værdier
                }

                int res = sum % 11;
                if (res == 0)
                    return true;
            }
            return false;
        }

        public int SaveBT(DTO_login login, DTO_data data)
        {
            if (ValidateCPR(data.CPR) == true)
            {
                return GemPatient.SaveBT(data, login);

            }
            else
                return 3;
            
        }
    }
}