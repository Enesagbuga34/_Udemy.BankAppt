using System.Collections.Generic;
using System.Linq;
using UdemyBankApp.Web.Data.Context;
using UdemyBankApp.Web.Data.Entities;
using UdemyBankApp.Web.Data.Interfaces;

namespace UdemyBankApp.Web.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
           _context = context;
        }

        //public List<ApplicationUser> GetAll()
        //{
        //    return _context.ApplicationUsers.ToList();
        //}
        public ApplicationUser GetbById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }

        public void Create(ApplicationUser user)
        {
            //_context.ApplicationUsers.Add(user);
            _context.Set<ApplicationUser>().Add(user);
            _context.SaveChanges();
        }
        public void Remove(ApplicationUser user)
        {
            _context.Set<ApplicationUser>().Remove(user);
            _context.SaveChanges();
        }

        public List<ApplicationUser> GetAll()
        {
            return _context.Set<ApplicationUser>().ToList();
        }
    }
}
