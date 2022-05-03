using EasyMektep.Interfaces;
using EasyMektep.Models.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMektep.Controllers
{
    public class SettingController : Controller
    {
        private readonly ISettingInterface _repository;
        public SettingController(ISettingInterface repository)
        {
            this._repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Change(UserModel model)
        {

        }
        [HttpPost]
        public void ChangePassword(string newPass,string repeatPass, string old)
        {
            _repository.ChangePassword(newPass, repeatPass, old);
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        public IActionResult PrivatePolicy()
        {
            return View();
        }
    }
}
