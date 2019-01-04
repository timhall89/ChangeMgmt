using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DTOInterfaces
{
    public interface IUserNameAndPassword
    {
        string UserName { get; }
        byte[] Password { get; }
    }
}
