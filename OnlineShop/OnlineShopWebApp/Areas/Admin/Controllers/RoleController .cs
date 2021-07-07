using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Areas.Admin.Models;
using System.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {       
        private readonly RoleManager<IdentityRole> rolesStorage;
        public RoleController(RoleManager<IdentityRole> rolesStorage)
        {            
            this.rolesStorage = rolesStorage;
        }
       
        public IActionResult Index()
        {
            var roles = rolesStorage.Roles.ToList();
            return View(roles.Select(x => new RoleViewModel { Name = x.Name }).ToList());//Здесь должен быть список доступных ролей
        }
        public IActionResult Remove(string roleName)
        {
            var role = rolesStorage.FindByNameAsync(roleName).Result;
            if(role != null)
            {
                rolesStorage.DeleteAsync(role).Wait();
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IdentityRole role)
        {

            var result = rolesStorage.CreateAsync(new IdentityRole(role.Name)).Result;
            if(result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(role);

            //if(rolesStorage.TryGetByName(role.Name)!=null)
            //{
            //    ModelState.AddModelError("", "Такая роль уже существует");
            //}
            //if(ModelState.IsValid)
            //{
            //    rolesStorage.Add(role);
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(role);
        }        
    }
}
