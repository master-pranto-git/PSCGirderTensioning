using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(GirderID), nameof(GirderID))]
    public class NewCableViewModel : BaseViewModel
    {
        private string girderID;
        public string GirderID
        {
            get => girderID;
            set => SetProperty(ref girderID, value);
        }

        public NewCableViewModel()
        {

        }
    }
}
