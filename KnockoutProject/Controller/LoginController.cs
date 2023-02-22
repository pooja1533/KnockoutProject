using Core.Constants;
using Microsoft.AspNetCore.Mvc;
using ServiceInterfaces;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace KnockoutProject
{
    public class LoginController : Controller
    {
        private IUserService UserServiceInterface { get; set; }
        public LoginController(IUserService userService)
        {
            this.UserServiceInterface = userService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserViewModel userViewModel)
        {
            BaseModel baseModel = new BaseModel();
            LoginDO login = new LoginDO();
            login.Email = userViewModel.Email;
            login.Password = userViewModel.Password;
            bool result=UserServiceInterface.Login(login);
            if (result)
            {
                baseModel.IsError = false;
                baseModel.RedirectUrl = Url.Action(ActionNames.Index,ControllerNames.Hotel);
            }
            else
            {
                baseModel.IsError = true;
                baseModel.ErrorMessage = "UserName or Password wrong";
            }
            return Json(baseModel);

        }
    }
}
