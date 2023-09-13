using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UdemyBankApp.Web.Data.Context;
using UdemyBankApp.Web.Data.Interfaces;
using UdemyBankApp.Web.Data.Repositories;
using UdemyBankApp.Web.Mapping;
using UdemyBankApp.Web.Models;

namespace UdemyBankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        //private readonly BankContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository; 
        private readonly IUserMapper _userMapper;
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountMapper _accountMapper;
        
        public AccountController(/*BankContext context,*/ IApplicationUserRepository applicationUserRepository,
            IUserMapper userMapper , IAccountRepository accountRepository, IAccountMapper accountMapper )
        {
            //_context = context;
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            _accountRepository = accountRepository;
            _accountMapper = accountMapper;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _userMapper.MapToUserList( _applicationUserRepository.GetbById(id));
            return View(userInfo);
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model) 
        {


            _accountRepository.Create(_accountMapper.Map(model));
            //_context.Accounts.Add(new Data.Entities.Account
            //{
            //    AccountNumber = model.AccountNumber,
            //    ApplicationUserId = model.ApplicationUserId,
            //    Balance = model.Balance
            //});
            //_context.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}
