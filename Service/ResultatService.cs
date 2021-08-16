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
    class ResultatService
    {
        public static async Task<model.DocsResultat> GetResultatsDocs()
        {
            if (WebService.ApiClient == null)
            {
                WebService.InitializeClient();
            }
            using (var httpClient = new HttpClient())
            {
                var request = await httpClient.GetAsync(WebService.uri + "api/resultat/getResultat");
                if (request.IsSuccessStatusCode)
                {
                    var resultArray = await request.Content.ReadAsStringAsync();
                    var final = JsonConvert.DeserializeObject<model.DocsResultat>(resultArray);
                    return final;
                }
                else {
                    System.Windows.Forms.MessageBox.Show(""+request.ReasonPhrase);
                }

            }
            return null;
        }
        public static async void deleteResultat(string id)
        {
            if (WebService.ApiClient == null)
            {
                WebService.InitializeClient();
            }
            using (var httpClient = new HttpClient())
            {
                var request = await httpClient.DeleteAsync(WebService.uri + "api/resultat/"+id);
                if (request.IsSuccessStatusCode)
                {
                    var resultArray = await request.Content.ReadAsStringAsync();
                    Message final = JsonConvert.DeserializeObject<Message>(resultArray);
                    System.Windows.Forms.MessageBox.Show("" + final.message);

                }else
                {
                    System.Windows.Forms.MessageBox.Show("" + request.ReasonPhrase);
                }

            }
        }
        public static async Task<string> createResultat(string date, string heure, string idmatch, string pointeq1, string pointeq2)
        {
            using (var httpClient = new HttpClient())
            {
                var inputdata = new Dictionary<string, string> {
                    { "date",date },
                    { "heure",heure },
                    { "idmatch",idmatch },
                    { "pointequipe1",pointeq1 },
                    { "pointequipe2",pointeq2 }
                };
                using (var content = new FormUrlEncodedContent(inputdata))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = await httpClient.PostAsync(WebService.uri + "api/resultat", content);
                    using (HttpContent resp = response.Content)
                    {
                        var data = await resp.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return null;
        }
    }
}
