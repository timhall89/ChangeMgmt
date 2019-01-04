using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ChangeMgmt.BusinessLogic.Helpers
{
    using Common.DTO;
    public class LoginHelper
    {
        public bool IsUserPasswordCorrect(IEnumerable<UserNamePasswordPair> DataSet, UserNamePasswordPair User)
        {
            List<string> PasswordsForUserName = DataSet.Where(DataSetUser => DataSetUser.UserName == User.UserName)
                .Select(DataSetUser => DataSetUser.Password)
                .ToList();

            if (!PasswordsForUserName.Any()) throw new ArgumentException($"No user exists with user name {User.UserName}");

            return PasswordsForUserName.Any(pw => pw == User.Password);
        }
    }
}
