/*
 * Auteur: Kenley Clermont
 * Date: 26/04/2024
 * Objectif: Fournir une interface pour afficher les dernières informations 
 *           sur les prix et les volumes des actions de IBM.         
 */

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
