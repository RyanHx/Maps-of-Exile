using PoEMapsViewModel;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PoEMaps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string selectedAccount = "";

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (PoEMapsViewModel.Helper.MapList.MapListMain.Any(x => x.IsChecked) && LeagueComboBox.SelectedValue != null)
            {
                try
                {
                    string selectedLeague = LeagueComboBox.Text;
                    NoResultsTextBlock.Visibility = Visibility.Hidden;
                    await Task.Run(() => APIViewModel.SearchAsync(selectedLeague));
                    if (APIViewModel.observableResults.Count == 0)
                    {
                        NoResultsTextBlock.Visibility = Visibility.Visible;
                    }
                }
                #region Catch exceptions
                catch (HttpRequestException httpE)
                {
                    PoEMapsViewModel.Helper.UserSettings.Log("HTTP request failed - Exception message: " + httpE.Message);
                    MessageBox.Show("HTTP request failed with following message:\n\n" + httpE.Message + "\n\nIf logging is enabled check " + AppDomain.CurrentDomain.BaseDirectory + @"\Logs.txt" + " for more details.", "HTTP request failed");
                }
                catch (Exception ee)
                {
                    PoEMapsViewModel.Helper.UserSettings.Log("SearchAsync() threw exception: " + ee.Message);
                    MessageBox.Show("Search returned an error.\n\nIf logging is enabled check " + AppDomain.CurrentDomain.BaseDirectory + @"\Logs.txt" + " for more details.", "Search error");
                }
                #endregion

            }
            else
            {
                MessageBox.Show("Please select at least one map/league");
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            #region Create log file
            PoEMapsViewModel.Helper.UserSettings.Log("--Start session--");
            #endregion

            #region Populate map list
            MapListView.ItemsSource = PoEMapsViewModel.Helper.MapList.MapListMain;
            PoEMapsViewModel.Helper.MapList.GetMaps(); // Populates observable collection
            CollectionViewSource.GetDefaultView(MapListView.ItemsSource).Filter = MapFilter; // Set up filter text box
            #endregion

            #region Populate league list
            LeagueComboBox.ItemsSource = APIViewModel.LeagueList;
            try
            {
                await APIViewModel.GetLeaguesAsync(); // Get list of leagues from API
            }
            catch (HttpRequestException httpE)
            {
                PoEMapsViewModel.Helper.UserSettings.Log("League API request failed - Exception message: " + httpE.Message);                
                MessageBox.Show("Request to retrieve list of leagues from API failed with following message:\n\n" + httpE.Message + "\n\nIf logging is enabled check " + AppDomain.CurrentDomain.BaseDirectory + @"\Logs.txt" + " for more details.", "HTTP request failed");
            }

            LeagueComboBox.Items.Refresh();
            #endregion

            #region Set up menus
            LoggingMenuItem.IsChecked = PoEMapsViewModel.Helper.UserSettings.LoggingIsEnabled();
            foreach(MenuItem item in NumOfResultsMenu.Items)
            {
                if (Int32.Parse(item.Name.Replace("_", "")) == PoEMapsViewModel.Helper.UserSettings.GetNumOfResults())
                {
                    item.IsChecked = true;
                }
                else
                {
                    item.IsChecked = false;
                }
            }
            #endregion

            ResultsListView.ItemsSource = APIViewModel.observableResults;
            AccountComboBox.ItemsSource = APIViewModel.accountList;
        }

        private async void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => PoEMapsViewModel.Helper.MapList.Clear());
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(MapListView.ItemsSource).Refresh();
        }

        private bool MapFilter(object item)
        {
            if (String.IsNullOrEmpty(FilterTextBox.Text))
                return true;

            return PoEMapsViewModel.Helper.MapList.Filter(item, FilterTextBox.Text);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PoEMapsViewModel.Helper.UserSettings.SaveSettings();
            PoEMapsViewModel.Helper.UserSettings.Log("--End session--");
        }

        private async void AccountComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AccountComboBox.SelectedValue != null)
            {
                selectedAccount = AccountComboBox.SelectedValue.ToString();
                WhisperTextBox.Text = await Task.Run(() => APIViewModel.GenerateWhisper(selectedAccount));
            }
        }

        private async void QuantSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (AccountComboBox.SelectedValue != null)
            {
                selectedAccount = AccountComboBox.SelectedValue.ToString();
                WhisperTextBox.Text = await Task.Run(() => APIViewModel.GenerateWhisper(selectedAccount));
            }
        }

        private async void MapResultCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (AccountComboBox.SelectedValue != null)
            {
                selectedAccount = AccountComboBox.SelectedValue.ToString();
                WhisperTextBox.Text = await Task.Run(() => APIViewModel.GenerateWhisper(selectedAccount));
            }
        }

        private void ResultsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ResultsListView.SelectedItems.Count > 0)
            {
                APIViewModel item = ResultsListView.SelectedItems[0] as APIViewModel;
                AccountComboBox.SelectedValue = item.AccountName;
            }
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            if (WhisperTextBox.Text.Length > 0)
            {
                Clipboard.SetText(WhisperTextBox.Text);
            }
        }

        private void NumOfResultsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            int resultsNum = Convert.ToInt32(item.Name.Replace("_", ""));
            PoEMapsViewModel.Helper.UserSettings.SetNumOfResults(resultsNum);
            foreach (MenuItem menuItem in NumOfResultsMenu.Items)
            {
                if (menuItem.Name.Equals(item.Name))
                {
                    menuItem.IsChecked = true;
                }
                else
                {
                    menuItem.IsChecked = false;
                }
            }
        }

        private void LoggingMenuItem_Click(object sender, RoutedEventArgs e)
        {
            PoEMapsViewModel.Helper.UserSettings.ToggleLogging();
            LoggingMenuItem.IsChecked = PoEMapsViewModel.Helper.UserSettings.LoggingIsEnabled();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GithubMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RyanHx/Maps-of-Exile");
        }
    }
}