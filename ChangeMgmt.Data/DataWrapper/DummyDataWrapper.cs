using System;
using ChangeMgmt.Common.DTOInterfaces;

namespace ChangeMgmt.Data.DataWrapper
{
    public class DummyDataWrapper : IDataWrapper
    {
        public DummyDataWrapper()
        {
        }

        public bool IsPasswordValid(IUserNameAndPassword User)
        {
            throw new NotImplementedException();
        }
    }
}
