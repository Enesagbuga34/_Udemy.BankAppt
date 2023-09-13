using System.Collections.Generic;
using UdemyBankApp.Web.Data.Entities;

namespace UdemyBankApp.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();

        ApplicationUser GetbById(int id);

        void Create(ApplicationUser user);
    }
}
