using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Data.Repositories
{
    public interface IUserRepository
    {
        public List<User> Get();

        public User Get(string id);

        public User GetByEmail(string email);

        public User Create(User user);

        public void Update(string id, User user);

        public void Remove(User user);

        public void Remove(string id);
    }
}
