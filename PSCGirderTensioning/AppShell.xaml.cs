using PSCGirderTensioning.ViewModels;
using PSCGirderTensioning.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PSCGirderTensioning
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(SpanDetailPage), typeof(SpanDetailPage));
            Routing.RegisterRoute(nameof(GirderDetailPage), typeof(GirderDetailPage));
            Routing.RegisterRoute(nameof(CableDetailPage), typeof(CableDetailPage));
            Routing.RegisterRoute(nameof(JackDetailPage), typeof(JackDetailPage));
            Routing.RegisterRoute(nameof(NewJackPage), typeof(NewJackPage));
            //Routing.RegisterRoute(nameof(PlotViewPage), typeof(PlotViewPage));
            Routing.RegisterRoute(nameof(NewGirderPage), typeof(NewGirderPage));
            Routing.RegisterRoute(nameof(NewCablePage), typeof(NewCablePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
