using LoginMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVCApplication.Services
{
    public class UsersRepo : Repo<Users>
    {
        private readonly LoginContext _loginContext;
        public UsersRepo(LoginContext loginContext)
        {
            _loginContext = loginContext;
        }
        public bool Validate(Users users)
        {
            if (_loginContext.Users.Where(e => e.EmailID == users.EmailID &&
            e.Password == users.Password).Any())
                return true;
            else
                return false;
        }
    }
}

