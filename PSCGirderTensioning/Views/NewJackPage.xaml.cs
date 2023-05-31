using PSCGirderTensioning.Models;
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
    public partial class NewJackPage : ContentPage
    {
        public JackInfo Jack { get; set; }
        public NewJackPage()
        {
            InitializeComponent();
            BindingContext = new NewJackViewModel();
        }
    }
}