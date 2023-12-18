using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _appDbContext;
        public AccountRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Account> Accounts => _appDbContext.Accounts;

        public Account Login(Account account)
        {
            var acc = _appDbContext.Accounts.Where(u => u.Account_Email == account.Account_Email && u.Account_Password == account.Account_Password).FirstOrDefault();
            if (acc != null)
            {
                return acc;
            }
            else
            {
                return null;
            }
        }

        public Account Register(Account account)
        {
            if (_appDbContext.Accounts.Any(u => u.Account_Email == account.Account_Email))
            {
                return null;
            }
            else
            {
                _appDbContext.Accounts.Add(account);
                _appDbContext.SaveChanges();
                return account;
            }      
        }

        public Account ChangePassword(Account account, int id)
        {
            Account a = _appDbContext.Accounts.Find(id);
            if (a != null)
            {
                a.Account_Password = account.Account_Password;
                _appDbContext.SaveChanges();
            }
            return a;
        }

        public Account GetAccountById(int id)
        {
            return _appDbContext.Accounts.Find(id);
        }

        public Account Block(int id)
        {
            Account a = _appDbContext.Accounts.Find(id);
            if (a != null)
            {
                a.Account_IsBlocked = true;
                _appDbContext.SaveChanges();
            }
            return a;
        }

        public Account Unblock(int id)
        {
            Account a = _appDbContext.Accounts.Find(id);
            if (a != null)
            {
                a.Account_IsBlocked = false;
                _appDbContext.SaveChanges();
            }
            return a;
        }
    }
}
