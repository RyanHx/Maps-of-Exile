using Newtonsoft.Json;
using PoEMapsModel.API;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PoEMapsViewModel.Helper
{
    /// <summary>
    /// Contains method to retrieve download URL of Version.xml from Github releases
    /// </summary>
    public class Updater
    {
        /// <summary>
        /// Retrieves XML download URL via Github API.
        /// </summary>
        /// <returns>XML download URL</returns>
        public static async Task<string> GetXML()
        {
            List<PoEMapsModel.API.GithubReleaseModel> githubModel = new List<PoEMapsModel.API.GithubReleaseModel>();

            APIViewModel.ApiClient.DefaultRequestHeaders.Accept.Clear();
            APIViewModel.ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIViewModel.ApiClient.DefaultRequestHeaders.Add("User-Agent", "Maps-of-Exile");

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await APIViewModel.ApiClient.GetAsync(@"https://api.github.com/repos/RyanHx/Maps-of-Exile/releases");
            if (responseMessage.IsSuccessStatusCode)
            {
                githubModel = JsonConvert.DeserializeObject<List<PoEMapsModel.API.GithubReleaseModel>>(await responseMessage.Content.ReadAsStringAsync());
                foreach(Asset asset in githubModel[0].Assets)
                {
                    if (asset.Name.Contains("Version.xml"))
                    {
                        return asset.BrowserDownloadUrl.ToString();
                    }
                }
            }

            return "Error";
        }
    }
}