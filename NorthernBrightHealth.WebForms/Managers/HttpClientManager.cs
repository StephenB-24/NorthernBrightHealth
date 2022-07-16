using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace NorthernBrightHealth.WebForms.Managers
{
    public static class HttpClientManager
    {
        private const string NBH_BaseAddress = "https://localhost:44356/";

        // Return an HttpClient instance for the NortherBrightHealth API.
        public static HttpClient GetHttpClient(string query = "")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(NBH_BaseAddress + query);
            return client;
        }
    }
}