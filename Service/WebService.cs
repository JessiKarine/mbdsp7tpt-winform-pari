using ParisWinform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.Service
{
    public static class WebService
    {
        public static System.Net.Http.HttpClient ApiClient { get; set; }
        //public static string uri = "http://localhost:3000/"; 
        public static string uri = "https://mbdsp7-node-tpt-pari.herokuapp.com/";

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri(uri);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }
    }
}
