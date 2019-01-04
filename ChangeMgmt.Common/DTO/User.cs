using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DTO
{
    using DTOInterfaces;
    public class User : IUserNameAndPassword                
    {
        public User(string UserName, string Password) : this(UserName, Cryptography.GetSHA256(Password))
        {

        }
        
        public User(string UserName, byte[] Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public string UserName { get; }
        public byte[] Password { get; }
    }
}
