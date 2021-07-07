using OnlineShopWebApp.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp
{
    public interface IRolesStorage
    {
        List<RoleViewModel> GetAll();
        RoleViewModel TryGetByName(string name);
        void Add(RoleViewModel role);
        void Remove(string name);
    }
}