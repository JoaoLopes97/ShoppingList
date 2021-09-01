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


        public UserModel GetUserById(string id) => _userModelMapping.UserToUserModel(_userRepository.Get(id));

        public UserModel GetUserByEmail(string email) => _userModelMapping.UserToUserModel(_userRepository.GetByEmail(email));

        public bool CreateUser(UserModel userModel)
        {
            User user = _userModelMapping.UserModelToUser(userModel);

            return _userRepository.Create(user) is not null;
        }

        public void UpdateUser(string id, UserModel userModel)
        {
            User user = _userModelMapping.UserModelToUser(userModel);

            _userRepository.Update(id,user);
        }

        public void RemoveUser(UserModel userModel) => _userRepository.Remove(_userModelMapping.UserModelToUser(userModel));

        public void RemoveUser(string id) => _userRepository.Remove(id);
    }

}
