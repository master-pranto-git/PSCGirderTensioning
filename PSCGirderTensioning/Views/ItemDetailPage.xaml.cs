using PSCGirderTensioning.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PSCGirderTensioning.Views
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