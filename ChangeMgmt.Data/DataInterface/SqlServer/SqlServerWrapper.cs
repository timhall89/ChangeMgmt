using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeMgmt.Data.DataInterface.SqlServer
{
    using Microsoft.EntityFrameworkCore;
    using Models.SqlServerDB.Entities;

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
    }
}
