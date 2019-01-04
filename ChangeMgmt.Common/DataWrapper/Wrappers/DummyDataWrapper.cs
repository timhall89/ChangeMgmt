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
            => new List<User> {
                new User("Tim", "password1"),
                new User("Abi", "Password2"),
                new User("John", "Super")
            };
        
    }
}
