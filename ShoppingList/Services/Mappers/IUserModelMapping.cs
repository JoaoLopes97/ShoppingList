using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Services.Mappers
{
   public interface IUserModelMapping
    {
        public UserModel UserToUserModel(User user);
        public List<UserModel> UserToUserModel(List<User> users);


        public User UserModelToUser(UserModel userModel);
    }
}
