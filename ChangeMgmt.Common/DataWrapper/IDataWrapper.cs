using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DataWrapper
{
    using DTOInterfaces;
    public interface IDataWrapper
    {
        IEnumerable<IUserNameAndPassword> UserNamesAndPasswords { get; }
    }
}
