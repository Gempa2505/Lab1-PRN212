using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountById(string accountID);
    }
}
