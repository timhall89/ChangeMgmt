using System;

namespace ChangeMgmt.Data.DataWrapper
{
    using System.Collections.Generic;
    using System.Linq;
    using ChangeMgmt.Common.DTOInterfaces;
    using Models;
    using Models.ChangeMgmt;

    public class ChangeMgmtDBWrapper : ChangeMgmtDB, IDataWrapper
    {
        public ChangeMgmtDBWrapper(string connString) : base(connString)
        {
        }

        public bool IsPasswordValid(string email, byte[] password)
        {
            List<User> list = User.Where(u => u.Email == email).ToList();
            if (!list.Any()) throw new ArgumentException($"No user exists with email {email}");

            return list.Any(u => u.Password == password);
        }

        public void AddUser(string Email, string FirstName, string LastName, byte[] Password)
        {
            User.Add(new User()
            {
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                Password = Password
            });

            SaveChanges();
        }

        public bool IsPasswordValid(IEmailAndPassword User)
        {
            List<User> list = this.User.Where(u => u.Email == User.Email).ToList();
            if (!list.Any()) throw new ArgumentException($"No user exists with email {User.Email}");

            return list.Any(u => u.Password == User.Password);
        }
    }
}
