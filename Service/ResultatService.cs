using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.Service
{
    class ResultatService
    {
        public static async Task<model.DocsResultat> GetResultatsDocs()
        {
            if (WebService.ApiClient == null)
            {
                WebService.InitializeClient();
            }
            using (var httpClient = WebService.ApiClient)
            {
                var request = await httpClient.GetAsync(WebService.uri + "api/resultat/getResultat");
                if (request.IsSuccessStatusCode)
                {
                    var resultArray = await request.Content.ReadAsStringAsync();
                    System.Windows.Forms.MessageBox.Show("" + resultArray);
                    var final = JsonConvert.DeserializeObject<model.DocsResultat>(resultArray);
                    return final;
                }
                else {
                    System.Windows.Forms.MessageBox.Show(""+request.ReasonPhrase);
                }

            }
            return null;
        }
    }
}
