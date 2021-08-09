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
            var utilisateur = new Utilisateur(login, mdp) ;
            string uri = WebService.uri + "api/utilisateur/login";
            Console.WriteLine(uri);
            using (HttpResponseMessage response = await WebService.ApiClient.PostAsJsonAsync(uri, utilisateur)) {
                if (response.IsSuccessStatusCode){
                    Utilisateur utilisateurRecu = await response.Content.ReadAsAsync<Utilisateur>();
                    System.Windows.Forms.MessageBox.Show("" + utilisateurRecu.Login);
                    return utilisateurRecu;
                }
                else {
                    if (response.StatusCode == HttpStatusCode.Unauthorized) {
                        System.Windows.Forms.MessageBox.Show("tena izy");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(response.ReasonPhrase);
                    }
                    return null;
                }

            }
        }
    }
}
