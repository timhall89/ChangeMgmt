using System;

namespace ChangeMgmt.Data.DataWrapper
{
    using Common.DTOInterfaces;
    public interface IDataWrapper
    {
        bool IsPasswordValid(IEmailAndPassword User);
    }
}
