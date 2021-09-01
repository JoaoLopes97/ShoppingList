using ShoppingList.Data.Repositories;
using ShoppingList.Models;
using ShoppingList.Services.Mappers;
using System;
using System.Collections.Generic;

namespace ShoppingList.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserModelMapping userModelMapping;

        public UserService(IUserRepository userRepository, IUserModelMapping userModelMapping)
        {
            this.userRepository = userRepository;
            this.userModelMapping = userModelMapping;
        }

        public List<UserModel> GetUsers() => userModelMapping.UserToUserModel(userRepository.Get());


        public UserModel GetUserById(Guid id) => userModelMapping.UserToUserModel(userRepository.Get(id));

        public UserModel GetUserById(string email) => userModelMapping.UserToUserModel(userRepository.Get(email));

        public bool CreateUser(UserModel userModel)
        {
            User user = userModelMapping.UserModelToUser(userModel);

            return userRepository.Create(user) is not null;
        }

        public void UpdateUser(Guid id, UserModel userModel)
        {
            User user = userModelMapping.UserModelToUser(userModel);

            userRepository.Update(id,user);
        }

        public void RemoveUser(UserModel userModel) => userRepository.Remove(userModelMapping.UserModelToUser(userModel));

        public void RemoveUser(Guid id) => userRepository.Remove(id);
    }

}
