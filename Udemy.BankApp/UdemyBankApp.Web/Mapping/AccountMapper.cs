using System.Collections.Generic;
using UdemyBankApp.Web.Data.Entities;
using UdemyBankApp.Web.Models;

namespace UdemyBankApp.Web.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance,
            };
        }
    }
}
