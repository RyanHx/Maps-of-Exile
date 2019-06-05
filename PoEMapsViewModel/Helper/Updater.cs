using Newtonsoft.Json;
using Squirrel;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PoEMapsViewModel.Helper
{
    public class Updater
    {
        private static async Task Update()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/RyanHx/Maps-of-Exile", null, null, null, true))
            {
                await mgr.Result.UpdateApp();
            }
        }

        public static async Task CheckForUpdate(string ver)
        {
            List<PoEMapsModel.API.GithubModel> githubModel = new List<PoEMapsModel.API.GithubModel>();

            APIViewModel.ApiClient.DefaultRequestHeaders.Accept.Clear();
            APIViewModel.ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIViewModel.ApiClient.DefaultRequestHeaders.Add("User-Agent", "Maps-of-Exile");

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await APIViewModel.ApiClient.GetAsync("https://api.github.com/repos/RyanHx/Maps-of-Exile/releases");
            if (responseMessage.IsSuccessStatusCode)
            {
                githubModel = JsonConvert.DeserializeObject<List<PoEMapsModel.API.GithubModel>>(await responseMessage.Content.ReadAsStringAsync());
                StringBuilder CurrentVersion = new StringBuilder(ver);
                CurrentVersion.Remove(5, 2);
                if (!CurrentVersion.ToString().Equals(githubModel[0].TagName.Replace("v", "")))
                {
                    await Update();
                    MessageBox.Show("A new version of the application has been found and installed. Restart to load new version.", "Update found");
                }
            }
            else
            {
                MessageBox.Show("Error when checking for update:\n\n" + responseMessage.ReasonPhrase, "Update failed");
            }
        }
    }
}