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
        private Dataaccess_blodtryksmåler.Login login;
        private DTO_login dtoLogin;

        public DTO_login getLogin(DTO_login log)
        {
            return dtoLogin = login.isUserinDB(log);

        }
    }
}