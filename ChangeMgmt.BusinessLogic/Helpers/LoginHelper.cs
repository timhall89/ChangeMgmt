using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ChangeMgmt.BusinessLogic.Helpers
{
    using Common.DTOInterfaces;
    public class LoginHelper
    {
        public static bool IsUserPasswordCorrect(IEnumerable<IEmailAndPassword> DataSet, IEmailAndPassword User)
        {
            List<byte[]> PasswordsForUserName = DataSet.Where(DataSetUser => DataSetUser.Email == User.Email)
                .Select(DataSetUser => DataSetUser.Password)
                .ToList();

            if (!PasswordsForUserName.Any()) throw new ArgumentException($"No user exists with user name {User.Email}");

            return PasswordsForUserName.Any(pw => pw.SequenceEqual(User.Password));
        }
    }
}
