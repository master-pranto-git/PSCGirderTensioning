using PSCGirderTensioning.Models;
using PSCGirderTensioning.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(GirderId), nameof(GirderId))]
    public class GirderDetailViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string girderId;

        private string spanNoText;
        private string girderNoText;
        private string girderLengthText;
        private string girderCastingDateText;
        private string totalCableNosText;

        private string bridgeName;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public GirderDetailViewModel()
        {
            Cables = new ObservableCollection<CableInfo>();
            LoadCablesCommand = new Command(async () => await ExecuteLoadCablesCommand());
            CableTapped = new Command<CableInfo>(OnCableSelected);

            AddCableCommand = new Command(OnAddCable);
            RemoveGirderCommand = new Command(OnRemoveGirder);
        }

        private async void OnRemoveGirder()
        {
            var girder = await GirderDataStore.GetItemAsync(GirderId);
            //var span = await SpanDataStore.GetItemAsync(girder.spanId);

            //span.GirderList = span.GirderList.Where(g => g.girderId != GirderId).ToList();

            //await SpanDataStore.UpdateItemAsync(span);
            await GirderDataStore.DeleteItemAsync(GirderId);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnAddCable()
        {
            await Shell.Current.GoToAsync($"{nameof(NewCablePage)}?{nameof(NewCableViewModel.GirderID)}={GirderId}");
        }

        private CableInfo _selectedCable;
        public ObservableCollection<CableInfo> Cables { get; }
        public Command LoadCablesCommand { get; }
        public Command RemoveGirderCommand { get; }
        public Command AddCableCommand { get; }
        public Command<CableInfo> CableTapped { get; }

        async Task ExecuteLoadCablesCommand()
        {
            IsBusy = true;
            try
            {
                var _g = await GirderDataStore.GetItemAsync(GirderId);
                var _br = await DataStore.GetItemAsync(_g.bridgeId);
                var _sp = await SpanDataStore.GetItemAsync(_g.spanId);
                Cables.Clear();
                var cablesList = await CableDataStore.GetItemsAsyncForParent(GirderId, true);
                foreach (var _c in cablesList)
                {
                    Cables.Add(_c);
                }
                //var items = await DataStore.GetItemsAsync(true);
                //foreach (var item in items)
                //{
                //    if (_g.bridgeId == item.Id)
                //    {
                //        foreach (var _span in item.SpanList)
                //        {
                //            if (_g.spanId == _span.spanId)
                //            {
                //                foreach (var _girder in _span.GirderList)
                //                {
                //                    if (_g.girderId == _girder.girderId && _girder.cablesList.Count < _girder.totalCableNos)
                //                    {
                //                        for (int i = 1; i <= _girder.totalCableNos; i++)
                //                        {
                //                            CableInfo _cableInfo = new CableInfo() 
                //                            {   bridgeId = _girder.bridgeId, 
                //                                spanId = _girder.spanId, 
                //                                girderId = _girder.girderId, 
                //                                cableNo = i, 
                //                                cableId = Guid.NewGuid().ToString() };
                //                            _girder.cablesList.Add(_cableInfo);
                //                            await CableDataStore.AddItemAsync(_cableInfo);
                //                        }
                //                    }
                //                }
                //            }
                //        }
                //        foreach (var _span in item.SpanList)
                //        {
                //            if (_g.spanId == _span.spanId)
                //            {
                //                foreach (var _girder in _span.GirderList)
                //                {
                //                    if (_g.girderId == _girder.girderId)
                //                    {
                //                        foreach (var _c in _girder.cablesList)
                //                        {
                //                            //_c.CableNoText = $"Girder No: {_g.GirderNo}";
                //                            //_g.GirderLengthText = $"Girder Length: {_g.GirderLength} {_g.GirderLengthUnit}";
                //                            Cables.Add(_c);
                //                        }
                //                    }
                //                }
                //            }
                //        }

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
            SelectedCable = null;
        }

        public CableInfo SelectedCable
        {
            get => _selectedCable;
            set
            {
                SetProperty(ref _selectedCable, value);
                //var _item = GetItemAsync_1(ItemId).Result;
                OnCableSelected(value);
            }
        }

        async void OnCableSelected(CableInfo cable)
        {
            if (cable == null)
                return;
            Debug.WriteLine($"Cable Selected {cable.cableNo}");
            // This will push the ItemDetailPage onto the navigation stack
            //Debug.WriteLine($"Span Id {girder.spanId}");
            await Shell.Current.GoToAsync($"{nameof(CableDetailPage)}?{nameof(CableDetailViewModel.CableId)}={cable.cableId}");
            //await Shell.Current.GoToAsync($"{nameof(SpanDetailPage)}?{nameof(SpanDetailViewModel.SpanId)}={span.spanId}");
        }

        public async void LoadGirderId(string girderId)
        {
            try
            {
                var girder = await GirderDataStore.GetItemAsync(girderId);
                var span = await SpanDataStore.GetItemAsync(girder.spanId);
                var item = await DataStore.GetItemAsync(span.bridgeId);
                //Debug.WriteLine($"Item Id in {nameof(SpanDetailViewModel)}: {item.Id}");
                BridgeName = item.BridgeName;
                SpanNoText = span.SpanNoText;
                GirderNoText = girder.girderNoText;
                GirderLengthText = girder.girderLengthText;
                GirderCastingDateText = $"Girder Casting Date: {girder.girderCastingDate.ToString("dd-MMM-yyyy")}";
                TotalCableNosText = girder.totalCableNosText;
                //SpanId = span.spanId;
                //Spans = item.SpanList;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
            await ExecuteLoadCablesCommand();
        }

        public string TotalCableNosText
        {
            get => $"{totalCableNosText}{Environment.NewLine}";
            set
            {
                SetProperty(ref totalCableNosText, value);
                OnPropertyChanged(nameof(TotalCableNosText));
            }
            //get => totalCableNosText;
            //set => SetProperty(ref totalCableNosText, value);
        }

        public string GirderCastingDateText
        {
            get => $"{girderCastingDateText}{Environment.NewLine}";
            set
            {
                SetProperty(ref girderCastingDateText, value);
                OnPropertyChanged(nameof(GirderCastingDateText));
            }
            //get => girderCastingDateText;
            //set => SetProperty(ref girderCastingDateText, value);
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

        public string GirderNoText
        {
            get => girderNoText;
            set
            {
                SetProperty(ref girderNoText, value);
                OnPropertyChanged(nameof(GirderNoText));
            }
            //set => SetProperty(ref girderNoText, value);
        }
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
        
        public string GirderLengthText
        {
            get => girderLengthText;
            set
            {
                SetProperty(ref girderLengthText, value);
                OnPropertyChanged(nameof(GirderLengthText));
            }
            //set => SetProperty(ref girderLengthText, value);
        }

        public string GirderId
        {
            get
            {
                return girderId;
            }
            set
            {
                girderId = value;
                //Debug.WriteLine($"Span Id in {nameof(SpanDetailViewModel)}: {spanId} and Setting spanId");
                LoadGirderId(value);
            }
        }
    }
}
