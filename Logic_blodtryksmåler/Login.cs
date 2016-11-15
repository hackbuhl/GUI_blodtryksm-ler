using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dataaccess_blodtryksmåler;
using DTO_blodtryksmåler;

namespace Logic_blodtryksmåler
{
    public class Login
    {
        private Dataaccess_blodtryksmåler.Login login = new Dataaccess_blodtryksmåler.Login();

        public DTO_login getLogin(DTO_login log)
        {
           return login.isUserinDB(log);
        }
    }
}