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
    public partial class CableDetailPage : ContentPage
    {
        CableDetailViewModel _viewModel;

        public CableDetailPage()
        {
            InitializeComponent();
            _viewModel = new CableDetailViewModel();
            _viewModel.MyChart = theChart;

            BindingContext = _viewModel;

        }

        //private void OnOptionSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _viewModel.OnOptionSelectedIndexChanged(sender, e);
        //    // Event handling code here
        //}
    }
}