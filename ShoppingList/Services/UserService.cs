using ShoppingList.Data.Repositories;
using ShoppingList.Models;
using ShoppingList.Services.Mappers;
using System;
using System.Collections.Generic;

namespace ShoppingList.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserModelMapping _userModelMapping;

        public UserService(IUserRepository userRepository, IUserModelMapping userModelMapping)
        {
            _userRepository = userRepository;
            _userModelMapping = userModelMapping;
        }

        public List<UserModel> GetUsers() => _userModelMapping.UserToUserModel(_userRepository.Get());

        public UserModel GetUserById(string id) => _userModelMapping.UserToUserModel(_userRepository.Get(id).Result);

        public UserModel GetUserByEmail(string email) => _userModelMapping.UserToUserModel(_userRepository.GetByEmail(email).Result);

        public bool CreateUser(UserModel userModel)
        {
            User user = _userModelMapping.UserModelToUser(userModel);

            return _userRepository.Create(user).Result;
        }
    }

}
