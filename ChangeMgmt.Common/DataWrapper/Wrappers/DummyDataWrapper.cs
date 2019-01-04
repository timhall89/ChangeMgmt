using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DataWrapper.Wrappers
{
    using DTOInterfaces;
    using DTO;
    public class DummyDataWrapper : IDataWrapper
    {
        public IEnumerable<IUserNameAndPassword> UserNamesAndPasswords
            => new List<UserDTO> {
                new UserDTO("Tim", "password1"),
                new UserDTO("Abi", "Password2"),
                new UserDTO("John", "Super")
            };
        
    }
}
