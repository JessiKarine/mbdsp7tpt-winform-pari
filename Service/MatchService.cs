using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.Service
{
    public class MatchService
    {
        public static async Task<List<model.Match>> GetMatches(String suite)
        {
            if (WebService.ApiClient == null) {
                WebService.InitializeClient();
            }
            using (var httpClient = WebService.ApiClient)
            {
                var request = await httpClient.GetAsync(WebService.uri+ "api/match"+ suite);
                if (request.IsSuccessStatusCode)
                {
                    var resultArray = await request.Content.ReadAsStringAsync();
                    System.Windows.Forms.MessageBox.Show(resultArray);
                    var final = JsonConvert.DeserializeObject<List<model.Match>>(resultArray);
                    return final;
                }
                else {
                    System.Windows.Forms.MessageBox.Show("Fail");
                }
                
            }
            return null;
        }
        public static async Task<List<model.Match>> GetMatchesByCategorie(String categorie)
        {
            return await GetMatches("nomcategorie/"+categorie);
        }
    }
}
