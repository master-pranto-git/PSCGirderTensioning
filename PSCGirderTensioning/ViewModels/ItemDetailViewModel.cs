using PSCGirderTensioning.Models;
using PSCGirderTensioning.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string itemId;
        private string bridgeName;
        private string district;
        private string upazilla;
        private string packageNo;
        private int spanNos;
        public string Id { get; set; }
        //public Command RemoveItemCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public ItemDetailViewModel()
        {
            Spans = new ObservableCollection<SpanInfoDataModel>();
            SpanTapped = new Command<SpanInfoDataModel>(OnSpanSelected);

            RemoveItemCommand = new Command(OnRemoveItem);
            LoadSpansCommand = new Command(async () => await ExecuteLoadSpansCommand());
        }

        public string BridgeName
        {
            get => bridgeName;
            set {
                SetProperty(ref bridgeName, value);
                OnPropertyChanged(nameof(BridgeName));
            }
        }

        public string PackageNo
        {
            get => packageNo;
            set
            {
                SetProperty(ref packageNo, value);
                OnPropertyChanged(nameof(PackageNo));
            }
            //set => SetProperty(ref packageNo, value);
        }

        public string District
        {
            get => district;
            set
            {
                SetProperty(ref district, value);
                OnPropertyChanged(nameof(District));
            }
            //set => SetProperty(ref district, value);
        }

        public string Upazilla
        {
            get => upazilla;
            set
            {
                SetProperty(ref upazilla, value);
                OnPropertyChanged(nameof(Upazilla));
            }
            //set => SetProperty(ref upazilla, value);
        }

        public int SpanNos
        {
            get => spanNos;
            set
            {
                SetProperty(ref spanNos, value);
                OnPropertyChanged(nameof(SpanNos));
            }
            //set => SetProperty(ref spanNos, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public Command RemoveItemCommand { get; }
        private async void OnRemoveItem()
        {
            //await Shell.Current.GoToAsync(nameof(NewItemPage));
            var _ItemId = ItemId;

            await DataStore.DeleteItemAsync(_ItemId);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");

        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                BridgeName = item.BridgeName;
                District = item.District;
                Upazilla = item.Upazilla;
                PackageNo = item.PackageNo;
                SpanNos = item.SpanNos;
                //Spans = item.SpanList;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
            await ExecuteLoadSpansCommand();
        }

        private SpanInfoDataModel _selectedSpan;
        //public ObservableCollection<SpanInfoDataModel> Spans { get; private set; }
        private ObservableCollection<SpanInfoDataModel> _spans;

        public ObservableCollection<SpanInfoDataModel> Spans
        {
            get { return _spans; }
            set
            {
                SetProperty(ref _spans, value);
                OnPropertyChanged(nameof(Spans));
            }
        }

        public Command LoadSpansCommand { get; }
        //public Command AddSpanCommand { get; }
        public Command<SpanInfoDataModel> SpanTapped { get; }

        async Task ExecuteLoadSpansCommand()
        {
            IsBusy = true;
            Spans.Clear();

            try
            {
                //Spans = new ObservableCollection<SpanInfoDataModel>();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    if (ItemId == item.Id)
                    {
                        //if (item.SpanList.Count < item.SpanNos)
                        //{
                        //    for (int i = 1; i <= item.SpanNos; i++)
                        //    {
                        //        SpanInfoDataModel _spanInfo = new SpanInfoDataModel() { bridgeId = itemId, SpanNo = i, spanId = Guid.NewGuid().ToString() };
                        //        item.SpanList.Add(_spanInfo);
                        //        await SpanDataStore.AddItemAsync(_spanInfo);
                        //    }
                        //}
                        var spanList = await SpanDataStore.GetItemsAsyncForParent(ItemId, true);

                        foreach (var _s in spanList)
                        {
                            //_s.SpanNoText = $"Span No: {_s.SpanNo}";
                            //_s.TotalGirderNosText = $"Total Girder Nos: {_s.TotalGirderNos}";
                            //_s.SpanLengthText = $"Span Length: {_s.SpanLength} {_s.SpanLengthUnit}";
                            Spans.Add(_s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedSpan = null;
        }

        public SpanInfoDataModel SelectedSpan
        {
            get => _selectedSpan;
            set
            {
                SetProperty(ref _selectedSpan, value);
                //var _item = GetItemAsync_1(ItemId).Result;
                OnSpanSelected(value);
            }
        }

        async void OnSpanSelected(SpanInfoDataModel span)
        {
            if (span == null)
                return;
            Debug.WriteLine($"Span Selected {span.SpanNo}");
            // This will push the ItemDetailPage onto the navigation stack
            //Debug.WriteLine($"Span Id {span.spanId}");
            await Shell.Current.GoToAsync($"{nameof(SpanDetailPage)}?{nameof(SpanDetailViewModel.SpanId)}={span.spanId}");
        }
    }
}
