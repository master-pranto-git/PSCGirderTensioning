using PSCGirderTensioning.Models;
using PSCGirderTensioning.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(SpanId), nameof(SpanId))]
    public class SpanDetailViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string spanId;
        private string bridgeId;
        private int spanNo;
        //private int totalGirderNos;
        //private double spanLength;
        //private string spanLengthUnit;

        private string spanNoText;
        //private string spanLengthText;
        //private string totalGirderNosText;


        private string bridgeName;
        private string district;
        private string upazilla;
        //private int spanNos;

        private string itemId;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public Command RemoveSpanCommand { get; }
        public Command AddGirderCommand { get; }

        public SpanDetailViewModel()
        {
            Girders = new ObservableCollection<GirderInfo>();
            LoadGirdersCommand = new Command(async () => await ExecuteLoadGirdersCommand());
            GirderTapped = new Command<GirderInfo>(OnGirderSelected);

            //RemoveSpanCommand = new Command(OnRemoveSpan);
            AddGirderCommand = new Command(OnAddGirder);
        }

        private async void OnAddGirder()
        {
            await Shell.Current.GoToAsync($"{nameof(NewGirderPage)}?{nameof(NewGirderViewModel.SpanId)}={SpanId}&{nameof(NewGirderViewModel.BridgeId)}={BridgeId}");
        }

        private GirderInfo _selectedGirder;
        public ObservableCollection<GirderInfo> Girders { get; }
        public Command LoadGirdersCommand { get; }
        //public Command AddSpanCommand { get; }
        public Command<GirderInfo> GirderTapped { get; }

        //public string ItemId
        //{
        //    get
        //    {
        //        return itemId;
        //    }
        //    set
        //    {
        //        itemId = value;
        //        //LoadSpanId(value);
        //    }
        //}

        async Task ExecuteLoadGirdersCommand()
        {
            IsBusy = true;
            //BridgeId = _sp.bridgeId;
            try
            {
                var _sp = await SpanDataStore.GetItemAsync(SpanId);
                //var _bridge = await DataStore.GetItemAsync(BridgeId);

                Girders.Clear();
                var girderList = await GirderDataStore.GetItemsAsyncForParent(SpanId, true);
                foreach (var _g in girderList)
                {
                    Girders.Add(_g);
                }

                //var items = await DataStore.GetItemsAsync(true);
                //foreach (var item in items)
                //{
                //    if (BridgeId == item.Id)
                //    {
                //        // Create New Girders
                //        //foreach (var _span in item.SpanList)
                //        //{
                //        //    if (_span.spanId == spanId)
                //        //    {
                //        //        if (_span.GirderList.Count < _span.TotalGirderNos)
                //        //        {
                //        //            for (int i = 1; i <= _span.TotalGirderNos; i++)
                //        //            {
                //        //                GirderInfo _girderInfo = new GirderInfo() { bridgeId = itemId, spanId = _span.spanId, GirderNo = i, girderId = Guid.NewGuid().ToString() };
                //        //                _span.GirderList.Add(_girderInfo);
                //        //                await GirderDataStore.AddItemAsync(_girderInfo);
                //        //            }
                //        //        }
                //        //    }
                //        //}

                //        // Add Existing Girders To List
                //        foreach (var _s in item.SpanList)
                //        {
                //            if (_s.spanId == spanId)
                //            {
                //                foreach (var _g in _s.GirderList)
                //                {
                //                    //_g.GirderNoText = $"Girder No: {_g.GirderNo}";
                //                    //_g.GirderLengthText = $"Girder Length: {_g.GirderLength} {_g.GirderLengthUnit}";
                //                    //_g.TotalCableNosText = $"Total Cable Nos: {_g.TotalCableNos}";
                //                    Girders.Add(_g);
                //                }
                //            }
                //            else
                //            {
                //                Debug.WriteLine("SpanID not Matched.");
                //            }
                //        }
                //    }
                //    else
                //    {
                //        Debug.WriteLine("BridgeID not Matched.");
                //    }
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine("I've No idea!!!");
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
            SelectedGirder = null;
        }

        public GirderInfo SelectedGirder
        {
            get => _selectedGirder;
            set
            {
                SetProperty(ref _selectedGirder, value);
                //var _item = GetItemAsync_1(ItemId).Result;
                OnGirderSelected(value);
            }
        }

        async void OnGirderSelected(GirderInfo girder)
        {
            if (girder == null)
                return;
            Debug.WriteLine($"Girder Selected {girder.girderNo}");
            // This will push the ItemDetailPage onto the navigation stack
            //Debug.WriteLine($"Span Id {girder.spanId}");
            await Shell.Current.GoToAsync($"{nameof(GirderDetailPage)}?{nameof(GirderDetailViewModel.GirderId)}={girder.girderId}");
        }

        //private async void OnRemoveSpan()
        //{
        //    //await Shell.Current.GoToAsync(nameof(NewItemPage));

        //    await SpanDataStore.DeleteItemAsync(spanId);

        //    // This will pop the current page off the navigation stack
        //    await Shell.Current.GoToAsync("..");

        //}

        public async void LoadSpanId(string spanId)
        {
            try
            {
                var span = await SpanDataStore.GetItemAsync(spanId);
                var item = await DataStore.GetItemAsync(span.bridgeId);
                //Debug.WriteLine($"Item Id in {nameof(SpanDetailViewModel)}: {item.Id}");
                BridgeId = item.Id;
                BridgeName = item.BridgeName;
                District = item.District;
                Upazilla = item.Upazilla;
                //SpanNos = item.SpanNos;
                SpanNo = span.SpanNo;
                //SpanLength = span.SpanLength;
                //SpanLengthUnit = span.SpanLengthUnit;
                SpanNoText = span.SpanNoText;
                //SpanLengthText = span.SpanLengthText;
                //TotalGirderNosText = span.TotalGirderNosText;
                //SpanId = span.spanId;
                //Spans = item.SpanList;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
            await ExecuteLoadGirdersCommand();
        }
        public string SpanId
        {
            get
            {
                return spanId;
            }
            set
            {
                spanId = value;
                LoadSpanId(value);
            }
        }

        #region Bridge Properties

        public string BridgeName
        {
            get => $"Bridge Name: {bridgeName}{Environment.NewLine}";
            set
            {
                SetProperty(ref bridgeName, value);
                OnPropertyChanged(nameof(BridgeName));
            }
            //set => SetProperty(ref bridgeName, value);
        }

        public string SpanNoText
        {
            get => spanNoText;
            set
            {
                SetProperty(ref spanNoText, value);
                OnPropertyChanged(nameof(SpanNoText));
            }
            //set => SetProperty(ref spanNoText, value);
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
        }

        public string BridgeId
        {
            get => bridgeId;
            set
            {
                SetProperty(ref bridgeId, value);
                OnPropertyChanged(nameof(BridgeId));
            }
            //set => SetProperty(ref bridgeId, value);
        }

        public int SpanNo
        {
            get => spanNo;
            set
            {
                SetProperty(ref spanNo, value);
                OnPropertyChanged(nameof(SpanNo));
            }
            //set => SetProperty(ref spanNo, value);
        }

        #endregion

        
    }
}
