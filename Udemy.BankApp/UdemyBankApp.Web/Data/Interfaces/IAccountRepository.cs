using UdemyBankApp.Web.Data.Entities;

namespace UdemyBankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
       void Create(Account account);
        public void Remove(Account account);

    }
}
