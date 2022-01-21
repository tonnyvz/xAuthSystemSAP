using System.ComponentModel;
using Xamarin.Forms;
using xAuthSystemSAP.ViewModels;

namespace xAuthSystemSAP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}