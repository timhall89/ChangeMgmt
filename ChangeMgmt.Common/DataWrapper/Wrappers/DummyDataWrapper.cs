using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DataWrapper.Wrappers
{
    using DTOInterfaces;
    using DTO;
    public class DummyDataWrapper : IDataWrapper
    {
        public IEnumerable<IUserNameAndPassword> GetUserNamesAndPasswords()
        {
            return new List<User> { new User("Tim", "password1")}
        }
    }
}
