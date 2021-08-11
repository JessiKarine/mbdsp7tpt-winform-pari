using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.Service
{
    public class MouvementService
    {
        public static async Task<String> debiterJoueur(string idPari, string idUser, String date, String montant)
        {
            using (var httpClient = new HttpClient())
            {
                var inputdata = new Dictionary<string, string> {
                    { "date",date },
                    { "idUser",idUser },
                    { "idPari",idPari },
                    { "montantDebit",montant },
                    { "montantCredit","0" }
                };
                using (var content = new FormUrlEncodedContent(inputdata))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = await httpClient.PostAsync(WebService.uri + "api/mvtJoueur", content);
                    using (HttpContent resp = response.Content)
                    {
                        string data = await resp.ReadAsStringAsync();
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
