using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Registration.Domain
{
    public interface IAccount 
    {
        bool PasswordChecker();
    }

    public interface IUserInfo
    {
        string UserInfo();
    }
}


