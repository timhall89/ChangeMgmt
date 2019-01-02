using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeMgmt.Data.DataInterface.SqlServer
{
    using Microsoft.EntityFrameworkCore;
    using Models.SqlServerDB.Entities;
    using Common;

    public class SqlServerWrapper : ChangeMgmtContext, IDataWrapper
    {
        private string connString { get;}

        public SqlServerWrapper(string connString) =>
            this.connString = connString;
       
        public bool IsPasswordValid(string email, string password)
        {
            return true;
        }

        public bool IsPasswordValid(string email, byte[] password)
        {
            List<User> list = User.Where(u => u.Email == email).ToList();
            if (!list.Any()) throw new KeyNotFoundException($"No user exists with email {email}");

            return list.Any(u => u.Password == password);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer(connString);
        }

        public void AddUser(string Email, string FirstName, string LastName, string Password) =>
            AddUser(Email, FirstName, LastName, Cryptography.GetSHA256(Password));

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
    }
}
