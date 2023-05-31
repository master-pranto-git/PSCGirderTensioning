using PSCGirderTensioning.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string bridgeName;
        private string packageNo;
        private string district;
        private string upazilla;
        private int spanNos;
        private string itemId;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(bridgeName)
                && !String.IsNullOrWhiteSpace(district)
                && (spanNos > 0);
        }

        public string BridgeName
        {
            get => bridgeName;
            set => SetProperty(ref bridgeName, value);
        }

        public string PackageNo
        {
            get => packageNo;
            set => SetProperty(ref packageNo, value);
        }

        public string District
        {
            get => district;
            set => SetProperty(ref district, value);
        }

        public string Upazilla
        {
            get => upazilla;
            set => SetProperty(ref upazilla, value);
        }

        public int SpanNos
        {
            get => spanNos;
            set => SetProperty(ref spanNos, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            itemId = Guid.NewGuid().ToString();
            List<SpanInfoDataModel> _SpanList = new List<SpanInfoDataModel>();
            for (int i = 1; i <= spanNos; i++)
            {
                SpanInfoDataModel _spanInfo = new SpanInfoDataModel() { bridgeId = itemId, SpanNo = i, SpanNoText = $"Span No: {i}", spanId = Guid.NewGuid().ToString() };
                _SpanList.Add(_spanInfo);
                await SpanDataStore.AddItemAsync(_spanInfo);
            }

            Item newItem = new Item()
            {
                Id = itemId,
                BridgeName = BridgeName,
                PackageNo = PackageNo,
                District = District,
                Upazilla = Upazilla,
                SpanNos = SpanNos,
                //SpanList = _SpanList
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
