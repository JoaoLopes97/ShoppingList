using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingListWebApp.Helpers
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient APIClient;
        public IConfiguration Configuration { get; }

        public HttpClient ApiClient
        {
            get
            {
                return APIClient;
            }
        }

        public APIHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            InitializeClient();
        }

        public void InitializeClient()
        {
            APIClient = new HttpClient
            {
                BaseAddress = new Uri(Configuration.GetValue<string>("ApiUrl"))
            };
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
