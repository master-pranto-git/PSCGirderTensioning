using PSCGirderTensioning.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PSCGirderTensioning.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JacksPage : ContentPage
    {
        JacksViewModel _viewModel;

        public JacksPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new JacksViewModel();
        
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}