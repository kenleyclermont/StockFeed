using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using StockFeed.Models;
using StockFeed.Services;
namespace StockFeed.ViewModels
{
    public partial class IBMPageViewModel : ObservableObject
    {
        private readonly IBMService _ibmService;
        public ObservableCollection<IBMData> modelViewIBMData { get; } = new();
        public IBMPageViewModel(IBMService ibmService)
        {
            _ibmService = ibmService;

            InitializeModelViewIBMData();
        }

        private async void InitializeModelViewIBMData()
        {
            modelViewIBMData.Clear();
            var ibmInfoOnline = await _ibmService.GetIBMInformationOnline();
            foreach (var info in ibmInfoOnline)
            {
                    modelViewIBMData.Add(info);
            }
        }
           
        
    }
}