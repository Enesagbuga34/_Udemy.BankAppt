using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyBankApp.Web.Data.Context;
using UdemyBankApp.Web.Data.Interfaces;
using UdemyBankApp.Web.Data.Repositories;
using UdemyBankApp.Web.Mapping;
using UdemyBankApp.Web.Models;

namespace UdemyBankApp.Web.Controllers
{
    public class HomeController : Controller
    {

        //private readonly BankContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;

    
        public HomeController(/*BankContext context ,*/IApplicationUserRepository applicationUserRepository, IUserMapper userMapper)
        {
            //_context = context;
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;

        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList( _applicationUserRepository.GetAll()));
            //return View(_applicationUserRepository.GetAll());
        }
    }
}
