using System.Collections.Generic;
using UdemyBankApp.Web.Data.Entities;
using UdemyBankApp.Web.Models;

namespace UdemyBankApp.Web.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);

        UserListModel MapToUserList(ApplicationUser user);
    }
}
