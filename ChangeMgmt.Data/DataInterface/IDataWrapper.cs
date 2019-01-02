using System;
namespace ChangeMgmt.Data.DataInterface
{
    public interface IDataWrapper
    {
        bool IsPasswordValid(string email, string password);
        bool IsPasswordValid(string email, byte[] password);
    }
}
