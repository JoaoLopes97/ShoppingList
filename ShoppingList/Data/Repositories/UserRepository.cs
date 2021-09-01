using MongoDB.Driver;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository()
        {
            MongoDBContext mongoDBContext = new();

            _users = mongoDBContext._database.GetCollection<User>("Users");
        }

        public List<User> Get() =>
           _users.Find(user => true).ToList();

        public User Get(Guid id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();

        public User Get(string email) =>
            _users.Find<User>(user => user.Email == email).FirstOrDefault();

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(Guid id, User user) =>
            _users.ReplaceOne(user => user.Id == id, user);

        public void Remove(User user) =>
            _users.DeleteOne(u => u.Id == user.Id);

        public void Remove(Guid id) =>
            _users.DeleteOne(user => user.Id == id);
    }

}
