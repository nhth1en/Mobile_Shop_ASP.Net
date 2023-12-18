using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> Accounts { get; }
        Account Login(Account account);
        Account Register(Account account);
        Account ChangePassword(Account account, int id);
        Account GetAccountById(int id);

        Account Block(int id);

        Account Unblock(int id);
    }
}
