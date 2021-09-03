using ShoppingList.Models;
using ShoppingListAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Data.Repositories
{
    public interface IUserRepository
    {
        public List<User> Get();

        public Task<User> Get(string id);

        public Task<User> GetByEmail(string email);

        public Task<bool> Create(User user);
    }
}
