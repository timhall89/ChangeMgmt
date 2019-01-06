using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DTOInterfaces
{
    public interface IEmailAndPassword
    {
        string Email { get; }
        byte[] Password { get; }
    }
}
