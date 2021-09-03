using Microsoft.AspNetCore.Identity;
using MongoDB.Driver;
using ShoppingList.Models;
using ShoppingListAPI.Data.Mappers;
using ShoppingListAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserManager<ApplicationUser> _userManager;
        private IUserMapping _userMapping;

        public UserRepository(UserManager<ApplicationUser> userManager, IUserMapping userMapping)
        {
            _userMapping = userMapping;
            _userManager = userManager;
        }

        public List<User> Get() => _userMapping.AppUserToUser(_userManager.Users.ToList());

        public async Task<User> Get(string id) => _userMapping.AppUserToUser(await _userManager.FindByIdAsync(id));

        public async Task<User> GetByEmail(string email) => _userMapping.AppUserToUser(await _userManager.FindByEmailAsync(email));

        public async Task<bool> Create(User user)
        {
            ApplicationUser appUser = _userMapping.UserToAppUser(user);

            IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);
            return result.Succeeded;
        }

    }

}
