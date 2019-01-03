using System;

namespace ChangeMgmt.Data.DataInterface
{
    public interface IDataWrapper
    {
        bool IsPasswordValid(string email, string password);
        bool IsPasswordValid(string email, byte[] password);

        void AddUser(string Email, string FirstName, string LastName, string Password);
        void AddUser(string Email, string FirstName, string LastName, byte[] Password);
    }
}
