using ShoppingListWebApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListWebApp.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<UserModel>> GetUsers();
        public UserModel GetUserByEmail(string email);
    }
}
