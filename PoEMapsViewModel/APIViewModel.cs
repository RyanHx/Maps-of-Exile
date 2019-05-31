using Newtonsoft.Json;
using PoEMapsModel.API;
using PoEMapsModel.Maps;
using PoEMapsViewModel.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PoEMapsViewModel
{
    public class APIViewModel : INotifyPropertyChanged
    {
        #region members
        private string _accountName;
        private ObservableCollection<MapViewModel> _maps;
        #endregion

        #region properties
        public string AccountName
        {
            get { return _accountName; }
            set
            {
                if (value != _accountName)
                {
                    _accountName = value;
                }
            }
        }
        public ObservableCollection<MapViewModel> Maps
        {
            get { return _maps; }
            set
            {
                _maps = value;
            }
        }
        #endregion

        public APIViewModel()
        {
            Maps = new ObservableCollection<MapViewModel>();
        }

        #region HttpClient
        private static HttpClientHandler ClientHandler = new HttpClientHandler();
        private static HttpClient ApiClient = new HttpClient(ClientHandler, false);
        #endregion

        public static ObservableCollection<string> LeagueList = new ObservableCollection<string>();
        public static ObservableCollection<APIViewModel> observableResults = new ObservableCollection<APIViewModel>();
        public static ObservableCollection<string> accountList = new ObservableCollection<string>();

        public static async Task SearchAsync(string selectedLeague)
        {
            List<ResultModel> resultModels = new List<ResultModel>();
            List<FetchModel> fetchModels = new List<FetchModel>();
            List<APIViewModel> finalAPIResults = new List<APIViewModel>();
            List<MapViewModel> selectedMaps = new List<MapViewModel>();

            Application.Current.Dispatcher.Invoke(delegate
            {
                observableResults.Clear();
                accountList.Clear();
            });

            foreach (MapViewModel map in Helper.MapList.MapListMain)
            {
                if (map.IsChecked)
                {
                    selectedMaps.Add(map);
                }
            }

            string LogFile = AppDomain.CurrentDomain.BaseDirectory + @"\Logs\Log.txt";

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            #region Trade/Search request
            #region Log search start
            PoEMapsViewModel.Helper.UserSettings.Log("Sending Trade/Search requests");
            #endregion
            foreach (MapViewModel map in selectedMaps) // For all maps that are ticked
            {
                SearchModel search = new SearchModel();
                ResultModel result = new ResultModel();
                if (map.Map.Name.Contains("Map"))
                {
                    search.Query.Type.Option = map.Map.Name;
                }
                else
                {
                    search.Query.Name.Option = map.Map.Name;
                }
                search.Query.Filters.MapFilters.Filters.MapTier.Max = map.Map.Tier; // Set maximum tier option to current map's tier (avoids receiving shaped on non-shaped searches)

                string jsonQuery = JsonConvert.SerializeObject(search, Formatting.None); // Serialize search model into JSON

                string searchUrl = @"https://www.pathofexile.com/api/trade/search/" + selectedLeague + "?source=" + jsonQuery; // Set final trade/search URL

                searchUrl = searchUrl.Replace(@"""type"":{""option"":null,""discriminator"":""warfortheatlas""},", ""); // replace "null" values as they break request to API
                searchUrl = searchUrl.Replace(@"""name"":{""option"":null,""discriminator"":""warfortheatlas""},", "");

                HttpResponseMessage responseMessage = new HttpResponseMessage();
                responseMessage.Headers.Add("Accept", "application/json");
                responseMessage = await ApiClient.GetAsync(searchUrl); // Send request to GGG API using current search URL and place response into 'responseMessage'
                responseMessage.EnsureSuccessStatusCode(); // Throw HttpResponseException if search request fails
                resultModels.Add(JsonConvert.DeserializeObject<ResultModel>(await responseMessage.Content.ReadAsStringAsync())); // Add result to list
            }
            #region Log search success
            PoEMapsViewModel.Helper.UserSettings.Log("Trade/Search requests successful");
            #endregion
            #endregion

            #region Trade/Fetch request
            #region Log fetch start
            PoEMapsViewModel.Helper.UserSettings.Log("Sending Trade/Fetch requests");
            #endregion
            foreach (ResultModel results in resultModels) // Iterate through results to make trade/fetch requests on each
            {
                string fetchUrl = "";
                List<string> fetchUrlCollection = new List<string>();
                if (results.result.Length > 0)
                {
                    #region Sort URLs into groups of 10 fetches (limit of API)
                    PoEMapsViewModel.Helper.UserSettings.Log("-- Sorting fetch URLs into fetchUrlCollection");
                    for (int i = 0; i < results.result.Length; i++) //Trade API limits returned server error if too many fetch queries were in a single URL; limit seems to be ~10
                    {
                        if (!(i > Settings.Default.NumOfResults - 1))
                        {
                            if (results.result[i] != null) // as long as result[] has another element
                            {
                                if (i == 0) // if first result 
                                {
                                    fetchUrl = @"https://www.pathofexile.com/api/trade/fetch/" + results.result[i]; // start fresh url
                                }
                                else if (i % 10 == 0) // if multiple of 10 (limit of requests per URL)
                                {
                                    fetchUrl = fetchUrl + "?query=" + results.id; // append query id
                                    fetchUrlCollection.Add(fetchUrl); // add to list of fetch urls
                                    fetchUrl = @"https://www.pathofexile.com/api/trade/fetch/" + results.result[i]; // start fresh url
                                }
                                else
                                {
                                    fetchUrl = fetchUrl + "," + results.result[i]; // append result id with comma divider
                                }
                            }
                            else
                            {
                                if (!fetchUrl.EndsWith("?query=" + results.id))
                                {
                                    fetchUrl = fetchUrl + "?query=" + results.id; // append query id for final fetchUrl
                                    fetchUrlCollection.Add(fetchUrl);
                                }
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (!fetchUrl.EndsWith("?query=" + results.id))
                    {
                        fetchUrl = fetchUrl + "?query=" + results.id; // append query id for final fetchUrl
                        fetchUrlCollection.Add(fetchUrl);
                    }

                    PoEMapsViewModel.Helper.UserSettings.Log("-- Sorting fetch URLs success");

                    #endregion
                    PoEMapsViewModel.Helper.UserSettings.Log("-- Begin fetches from fetchUrlCollection");
                }
                if (fetchUrlCollection.Count > 0)
                {
                    foreach (string pendingFetchUrl in fetchUrlCollection)
                    {
                        HttpResponseMessage responseMessage = new HttpResponseMessage();
                        responseMessage = await ApiClient.GetAsync(pendingFetchUrl); // Send request to GGG API using current fetch URL and place response into 'responseMessage'
                        responseMessage.EnsureSuccessStatusCode(); // Throws HttpResponseException if fetch fails
                        fetchModels.Add(JsonConvert.DeserializeObject<FetchModel>(await responseMessage.Content.ReadAsStringAsync()));
                    }
                    PoEMapsViewModel.Helper.UserSettings.Log("-- Fetches from fetchUrlCollection success");
                }
            }
            #region Log fetch success
            PoEMapsViewModel.Helper.UserSettings.Log("Trade/Fetch requests successful");
            #endregion
            #endregion

            #region Sort fetch results
            #region Log sort start
            PoEMapsViewModel.Helper.UserSettings.Log("Sorting fetch results");
            #endregion
            foreach (FetchModel fetchModel in fetchModels)
            {
                for (int i = 0; i < fetchModel.result.Length; i++)
                {
                    if (finalAPIResults.Any(x => x.AccountName.Equals(fetchModel.result[i].listing.account.lastCharacterName))) // If finalAPIResults contains an entry for this account
                    {
                        List<MapViewModel> temp = new List<MapViewModel>();
                        foreach (MapViewModel map in finalAPIResults[finalAPIResults.FindIndex(x => x.AccountName.Equals(fetchModel.result[i].listing.account.lastCharacterName))].Maps) // Retreieve account's list of maps
                        {
                            temp.Add(map);
                        }

                        if (temp.Any(x => x.Map.Name.Equals(CheckIfUnique(fetchModel.result[i])))) // If account's map list contains an entry for this map
                        {
                            temp[temp.FindIndex(x => x.Map.Name.Equals(CheckIfUnique(fetchModel.result[i])))].Quantity++;
                        }
                        else
                        {
                            temp.Add(new MapViewModel
                            {
                                Map = new Map
                                {
                                    Name = CheckIfUnique(fetchModel.result[i])
                                },
                                Quantity = 1,
                                Price = fetchModel.result[i].listing.price
                            });
                        }

                        finalAPIResults[finalAPIResults.FindIndex(x => x.AccountName.Equals(fetchModel.result[i].listing.account.lastCharacterName))].Maps.Clear(); // Send results back
                        foreach (MapViewModel map in temp)
                        {
                            finalAPIResults[finalAPIResults.FindIndex(x => x.AccountName.Equals(fetchModel.result[i].listing.account.lastCharacterName))].Maps.Add(map);
                        }
                    }
                    else
                    {
                        finalAPIResults.Add(new APIViewModel
                        {
                            AccountName = fetchModel.result[i].listing.account.lastCharacterName,
                            Maps = new ObservableCollection<MapViewModel>{new MapViewModel
                                {
                                    Map = new Map
                                     {
                                        Name = CheckIfUnique(fetchModel.result[i])
                                     },
                                     Quantity = 1,
                                     Price = fetchModel.result[i].listing.price
                                }
                            }
                        });
                    }
                }
            }

            Application.Current.Dispatcher.Invoke(delegate
            {
                observableResults.Clear();
                foreach (APIViewModel finalResult in finalAPIResults)
                {
                    foreach (MapViewModel map in finalResult.Maps)
                    {
                        map.IsChecked = true;
                    }
                    observableResults.Add(finalResult);
                }

                accountList.Clear();
                if (observableResults.Count > 0)
                {
                    foreach (APIViewModel obsResult in observableResults)
                    {
                        accountList.Add(obsResult.AccountName);
                    }
                }
            });
            #region Log sorting end
            PoEMapsViewModel.Helper.UserSettings.Log("Sorting results successful");
            #endregion
            #endregion
        }

        public static async Task GetLeaguesAsync()
        {
            List<LeagueModel> leagues = new List<LeagueModel>();
            string leagueUrl = @"http://api.pathofexile.com/leagues?realm=pc";
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            #region Log start of league request
            PoEMapsViewModel.Helper.UserSettings.Log("Start league API request");
            #endregion
            responseMessage = await ApiClient.GetAsync(leagueUrl);
            responseMessage.EnsureSuccessStatusCode();
            #region Log league request success
            PoEMapsViewModel.Helper.UserSettings.Log("League API request success");
            #endregion
            leagues = JsonConvert.DeserializeObject<List<LeagueModel>>(await responseMessage.Content.ReadAsStringAsync());
            foreach (LeagueModel league in leagues)
            {
                if (!league.Id.Contains("SSF"))
                {
                    LeagueList.Add(league.Id);
                }
            }
        }

        public static string GenerateWhisper(string selectedAccount)
        {
            ObservableCollection<MapViewModel> accountMapList = observableResults.FirstOrDefault(x => x.AccountName.Equals(selectedAccount)).Maps;
            Dictionary<string, double> cost = new Dictionary<string, double>();
            string whisperMessage;

            StringBuilder sb = new StringBuilder();
            sb.Append("@").Append(selectedAccount).Append(" Hi, I'd like to buy ");

            foreach (MapViewModel map in accountMapList)
            {
                if (map.IsChecked)
                {
                    if (accountMapList.IndexOf(map) != accountList.Count - 1)
                    {
                        sb.Append(map.NumSelected).Append(" ").Append(map.Map.Name).Append(", ");
                    }
                    else
                    {
                        sb.Append(map.NumSelected).Append(" ").Append(map.Map.Name).Append(" ");
                    }
                    if (map.Price != null)
                    {
                        if (!cost.ContainsKey(map.Price.currency))
                        {
                            cost.Add(map.Price.currency, map.Price.amount * map.NumSelected);
                        }
                        else
                        {
                            cost[map.Price.currency] += map.Price.amount * map.NumSelected;
                        }
                    }

                }
            }

            sb.Append("for ");

            //sb.Remove(sb.Length - 2, 1);
            int costCount = cost.Count;
            bool isLastCurr = false;
            foreach (string currency in cost.Keys)
            {
                costCount--;
                isLastCurr = costCount == 0;

                if (!isLastCurr)
                {
                    sb.Append(cost[currency]).Append(" ").Append(currency).Append(", ");
                }
                else
                {
                    sb.Append(cost[currency]).Append(" ").Append(currency);
                }
            }

            sb.Replace(", for", " for");
            whisperMessage = sb.ToString();

            return whisperMessage;
        }

        public static string CheckIfUnique(Result result)
        {
            StringBuilder sb = new StringBuilder(result.item.typeLine);
            sb.Replace("Superior ", "");
            foreach (MapViewModel map in Helper.MapList.MapListMain)
            {
                if (!map.Map.Name.Contains("Map")) // if map name doesn't contain "map" - must be unique name
                {
                    if (result.listing.whisper.Contains(map.Map.Name))
                    {
                        sb.Insert(0, "Unique ");
                        break;
                    }
                }
            }

            return sb.ToString();
        }

        #region INotifyPropertyChanged
        // Declare the PropertyChanged event
        public event PropertyChangedEventHandler PropertyChanged;

        // OnPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        private void OnPropertyChanged(object sender, string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(sender, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}