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
                new UserDTO() {UserName = "Tim", Password = Cryptography.GetSHA256("password1") },
                new UserDTO() {UserName="Abi",Password = Cryptography.GetSHA256( "Password2") },
                new UserDTO() {UserName = "John",Password = Cryptography.GetSHA256("Super") }
            };
        
    }
}
