using Newtonsoft.Json;
using ParisWinform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.Service
{
    class UtilisateurService
    {
        public static async Task<List<Utilisateur>> GetUtilisateurs()
        {

            if (WebService.ApiClient == null)
            {
                WebService.InitializeClient();
            }
            using (var httpClient = new HttpClient())
            {
                var request = await httpClient.GetAsync(WebService.uri + "api/utilisateur");
                if (request.IsSuccessStatusCode)
                {
                    var resultArray = await request.Content.ReadAsStringAsync();
                    var final = JsonConvert.DeserializeObject<List<Utilisateur>>(resultArray);
                    return final;
                }

            }
            return null;
        }
    }
}
