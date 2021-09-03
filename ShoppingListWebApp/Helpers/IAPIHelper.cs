﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingListWebApp.Helpers
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        public void InitializeClient();
    }
}