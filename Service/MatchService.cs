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
        public static async Task<List<model.Match>> GetMatches()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var request = await httpClient.GetAsync("http://localhost:3000/api/match");
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
    }
}
