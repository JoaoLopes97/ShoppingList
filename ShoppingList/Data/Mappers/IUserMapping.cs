using ShoppingList.Models;
using ShoppingListAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListAPI.Data.Mappers
{
    public interface IUserMapping
    {
        public User AppUserToUser(ApplicationUser applicationUser);
        public List<User> AppUserToUser(List<ApplicationUser> applicationUsers);
        public ApplicationUser UserToAppUser(User user);

    }
}
