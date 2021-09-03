using ShoppingList.Models;
using ShoppingListAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListAPI.Data.Mappers
{
    public class UserMapping : IUserMapping
    {
        public User AppUserToUser(ApplicationUser applicationUser)
        {
            var name = applicationUser.UserName.Split('_');
            return new User
            {
                FirstName = name[0],
                LastName = name[1],
                Email = applicationUser.Email
            };

        }
        public List<User> AppUserToUser(List<ApplicationUser> applicationUsers)
        {
            List<User> userModels = new();

            if (applicationUsers is not null)
            {
                foreach (var user in applicationUsers)
                {
                    userModels.Add(AppUserToUser(user));
                }
            }
            return userModels;
        }

        public ApplicationUser UserToAppUser(User user)
        {
            return new ApplicationUser
            {
                UserName = user.FirstName + '_' + user.LastName,
                Email = user.Email
            };
        }


    }
}
