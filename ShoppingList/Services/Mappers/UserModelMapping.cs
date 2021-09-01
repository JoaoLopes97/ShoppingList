using ShoppingList.Models;
using System.Collections.Generic;
//using BCryptNet = BCrypt.Net.BCrypt;

namespace ShoppingList.Services.Mappers
{
    public class UserModelMapping: IUserModelMapping
    {
        public List<UserModel> UserToUserModel(List<User> users)
        {
            List<UserModel> userModels = new();

            if(users is not null)
            {
                foreach (var user in users)
                {
                    userModels.Add(UserToUserModel(user));
                }
            }
            return userModels;
        }

        public UserModel UserToUserModel(User user) => new()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = user.Password
        };

        public User UserModelToUser(UserModel userModel) => new()
        {
            FirstName = userModel.FirstName,
            LastName = userModel.LastName,
            Email = userModel.Email,
            Password = userModel.Password
        };
        
    }
}
