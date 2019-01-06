using System;
namespace ChangeMgmt.Data.Models
{
    using ChangeMgmt;
    using Microsoft.EntityFrameworkCore;

    public class ChangeMgmtDB : ChangeMgmtContext
    {
        private string connString { get;}

        public ChangeMgmtDB(string connString) =>
            this.connString = connString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer(connString);
        }
    }
}
