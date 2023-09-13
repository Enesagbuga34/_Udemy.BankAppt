using UdemyBankApp.Web.Data.Entities;
using UdemyBankApp.Web.Models;

namespace UdemyBankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        Account Map(AccountCreateModel model);
    }
}
