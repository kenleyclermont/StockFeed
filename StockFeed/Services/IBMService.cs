using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using StockFeed.Models;
using Newtonsoft.Json;

namespace StockFeed.Services
{
    public class IBMService : ObservableObject
    {

        private ObservableCollection<IBMData> ibmInformation = new ObservableCollection<IBMData>();
        private const string IBM_URL = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=IBM&apikey=7MOV1V3G1529YV1T";
        public IBMService()
        {
        }
        private async Task<List<IBMData>> FetchIBMData(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var ibmInfo = JsonConvert.DeserializeObject<IBMQuoteResponse>(jsonResponse);
                    return new List<IBMData> { ibmInfo.GlobalQuote };
                }
                else
                {
                    throw new Exception("Failed to fetch IBM data.");
                }
            }
        }
        public async Task LoadIBMData()
        {
            try
            {
                var ibmInfo = await FetchIBMData(IBM_URL);
                ibmInformation.Clear();
                foreach (var info in ibmInfo)
                {
                    ibmInformation.Add(info);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task<ObservableCollection<IBMData>> GetIBMInformationOnline()
        {
            await LoadIBMData();
            return ibmInformation;
        }
    }
}

