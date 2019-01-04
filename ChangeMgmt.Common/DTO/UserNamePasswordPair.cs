using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMgmt.Common.DTO
{
    public class PasswordValidationData
    { 
        public PasswordValidationData(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public string UserName { get; }
        public string Password { get; }
    }
}
