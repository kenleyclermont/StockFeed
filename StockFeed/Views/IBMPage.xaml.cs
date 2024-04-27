using StockFeed.ViewModels;
namespace StockFeed.Views;
public partial class IBMPage : ContentPage
{
    public IBMPage(IBMPageViewModel ibmPageViewModel)
    {
        InitializeComponent();
        BindingContext = ibmPageViewModel;
    }
}
