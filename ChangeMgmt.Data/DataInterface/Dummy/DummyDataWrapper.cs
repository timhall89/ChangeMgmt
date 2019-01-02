using System;
namespace ChangeMgmt.Data.DataInterface.Dummy
{
    public class DummyDataWrapper : IDataWrapper
    {
        public DummyDataWrapper()
        {
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
