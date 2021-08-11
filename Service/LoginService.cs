using Newtonsoft.Json;
using ParisWinform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.Service
{
    public class LoginService
    {
        public static async Task<Utilisateur> CallLogin(string login, string mdp) {
            using (var httpClient = new HttpClient())
            {
                var inputdata = new Dictionary<string, string> {
                    { "login",login },
                    { "password",mdp }
                };
                using (var content = new FormUrlEncodedContent(inputdata))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = await httpClient.PostAsync(WebService.uri+"api/utilisateur/login", content);
                    using (HttpContent resp = response.Content)
                    {
                        string data = await resp.ReadAsStringAsync();
                        if (data != null){
                            //System.Windows.Forms.MessageBox.Show(data);
                            Utilisateur parsedObject = JsonConvert.DeserializeObject<Utilisateur>(data);
                            return parsedObject;
                        }
                    }
                }
            }
            return null;
        }
    }
}
