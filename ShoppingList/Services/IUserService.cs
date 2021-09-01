using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    public interface IUserService
    {
        public List<UserModel> GetUsers();

        public UserModel GetUserById(string id);

        public UserModel GetUserByEmail(string email);

        public bool CreateUser(UserModel userModel);

        public void UpdateUser(string id, UserModel userModel);
        public void RemoveUser(UserModel userModel);

        public void RemoveUser(string id);
    }
}
