using StockFeed.Views;
namespace StockFeed
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes() 
        {
            // Routes
            //Routing.RegisterRoute(nameof(MarketQuotesPage), typeof(MarketQuotesPage));
            //Routing.RegisterRoute(nameof(IBMPage), typeof(IBMPage));
        }
    }
}
