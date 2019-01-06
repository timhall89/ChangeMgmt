using System;
namespace ChangeMgmt.Data.DataWrapper.Dummy
{
    public class DummyDataWrapper : IDataWrapper
    {
        public DummyDataWrapper()
        {
        }

        public void AddUser(string Email, string FirstName, string LastName, string Password)
        {
            throw new NotImplementedException();
        }

        public void AddUser(string Email, string FirstName, string LastName, byte[] Password)
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordValid(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordValid(string email, byte[] password)
        {
            throw new NotImplementedException();
        }
    }
}
