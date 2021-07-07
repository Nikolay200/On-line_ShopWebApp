using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Db;
using OnlineShop.Db.BDModels;
using OnlineShopWebApp.Areas.Account.Models;
using OnlineShopWebApp.Controllers;
using OnlineShopWebApp.Models;
using System;
using Register = OnlineShopWebApp.Models.Register;

namespace OnlineShopWebApp.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountController : Controller
    {   
        
        private readonly UserManager<User> userManager;//Пользователь, который ещё не авторизовался
        private readonly SignInManager<User> signInManager; //Пользователь, который уже авторизовался
        private readonly ILogger<AccountController> logger;
        private readonly EmailService service;
        private string emailAdress;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ILogger<AccountController> logger, EmailService service)
        {           
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
            this.service = service;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new Login() {ReturnUrl = returnUrl});
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            
            if(ModelState.IsValid)
            {
                var result = signInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false).Result;
                if(result.Succeeded)
                 {
                        return Redirect(login.ReturnUrl ?? "/Home");                                      
                 }
                else
                {
                    ModelState.AddModelError("", "Неправильный пароль");
                }
                return View(login);
            }
            var userAccount = userManager.FindByNameAsync(login.UserName);
            if (userAccount == null)
            {
                ModelState.AddModelError("", "Такого пользователя не существует");
            }

            if (userAccount.Equals(login.Password))
            {
                ModelState.AddModelError("", "Пароль неправильный");
                return RedirectToAction(nameof(Login));
            }

            return View(login);                       
        }

        
        public IActionResult Register()//(string returnUrl)
        {
                      
            return View(new Register());//new Register() {ReturnUrl = returnUrl}
        }

        [HttpPost]
        [Obsolete]
        public IActionResult Register(Register register, string emailAdress)
        {
            if (register.UserName == register.Password)
            {
                ModelState.AddModelError("", "Имя и пароль не должны совпадать");
            }
            
            if (ModelState.IsValid)
            {
                service.SendMailToRegister(emailAdress);
                User user = new User { Email = register.Email, UserName = register.UserName, PhoneNumber = register.Phone };
                var result = userManager.CreateAsync(user, register.Password).Result;
                if (result.Succeeded)
                {
                    //добавление Cookies
                    signInManager.SignInAsync(user, false).Wait();
                    TryAssignUserRole(user);
                    
                    //return Redirect();//register.ReturnUrl ?? "/Home"
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }               
            }
            return View(register);
        }

        public IActionResult SendMailToChangePassword(string accountEmail)
        {            
            return View(new ChangePassword() { Email = accountEmail });
        }

        [HttpPost]              
        public IActionResult SendMailToChangePassword(ChangePassword changePassword)
        {   
            service.Se
            return View("NameUserAccount");
        }

        private void TryAssignUserRole(User user)
        {
            try
            {
                userManager.AddToRoleAsync(user, Constants.UserRoleName).Wait();
            }
            catch (Exception)
            {

                throw;//Сделать логирование данных
            }
        }


    }
}
