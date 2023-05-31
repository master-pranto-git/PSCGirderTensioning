using PSCGirderTensioning.Services;
using PSCGirderTensioning.Views;
using System;
using Xamarin.Forms;

namespace PSCGirderTensioning
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<SpanDataStore>();
            DependencyService.Register<GirderDataStore>();
            DependencyService.Register<CableDataStore>();
            DependencyService.Register<JackDataStore>();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSn5adkFiUXpfdXNdRA==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdUVqWXtfeHFUQ2lfUw==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZjUH9acXxQR2ZdU0Y=;MTI4Njk3MUAzMjMwMmUzNDJlMzBaMzhqM1E3bHRVY1R4N1ZJR0s1QW42ZzJtT09SN05vWkxNVjZ0N2lscStZPQ==;MTI4Njk3MkAzMjMwMmUzNDJlMzBYNWh4YTFrZkV6VlBYdVcrUUMrcmhER05qTURyVVNLMlh2NkpwempWa1pnPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVgWXZedHVdQ2FaWEB0;MTI4Njk3NEAzMjMwMmUzNDJlMzBIYXE0dDBhR1pzR0k1ZlRNUlBhczF6cG9NdVFXY1E0d2hKaS9DTUNVNXp3PQ==;MTI4Njk3NUAzMjMwMmUzNDJlMzBkbjFPZ3hKeGpsQmgzN2xmcnZlQzlYemVScm5CTmY4TTljYWlUanpicUlVPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZjUH9acXxQR2hUVkY=;MTI4Njk3N0AzMjMwMmUzNDJlMzBMN0hTZHhkeW9uUmZObnpqSEpBdHNKQ3NhVkpjczNWVW8zZ3dnb0x6OW1BPQ==;MTI4Njk3OEAzMjMwMmUzNDJlMzBLNUxxZXFpQ2NEU0xpWkZuOEwxYVM5MEVTSFhITzg4WHJ3Z1VOMWw1clQwPQ==;MTI4Njk3OUAzMjMwMmUzNDJlMzBIYXE0dDBhR1pzR0k1ZlRNUlBhczF6cG9NdVFXY1E0d2hKaS9DTUNVNXp3PQ==");
            //PlotViewRenderer.Init();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
