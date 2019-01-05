using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DTO
{
    using DTOInterfaces;
    public class UserDTO : IUserNameAndPassword                
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastnName { get; set; }
        public byte[] Password { get; set; }
    }
}
