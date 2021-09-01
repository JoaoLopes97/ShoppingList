using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    public interface IUserService
    {
        public List<UserModel> GetUsers();

        public UserModel GetUserById(Guid id);

        public UserModel GetUserById(string email);

        public bool CreateUser(UserModel userModel);

        public void UpdateUser(Guid id, UserModel userModel);
        public void RemoveUser(UserModel userModel);

        public void RemoveUser(Guid id);
    }
}
