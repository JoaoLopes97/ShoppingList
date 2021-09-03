using ShoppingListWebApp.Helpers;
using ShoppingListWebApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingListWebApp.Services
{
    public class UserService : IUserService
    {
        public IAPIHelper _apiHelper { get; set; }

        public UserService(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public UserModel GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            using HttpResponseMessage responseMessage = await _apiHelper.ApiClient.GetAsync("/user");
            return await responseMessage.Content.ReadAsAsync<IEnumerable<UserModel>>();

        }

        
    }
}
