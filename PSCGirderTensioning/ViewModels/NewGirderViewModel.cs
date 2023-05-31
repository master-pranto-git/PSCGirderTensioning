using PSCGirderTensioning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(SpanId), nameof(SpanId))]
    [QueryProperty(nameof(BridgeId), nameof(BridgeId))]
    public class NewGirderViewModel : BaseViewModel
    {
        private string spanId;
        private string bridgeId;

        private string girderId;
        private int girderNo;
        private DateTime girderCastingDate = DateTime.Today;
        private int totalCableNos;
        private double girderLength;

        public string BridgeId
        {
            get => bridgeId;
            set => SetProperty(ref bridgeId, value);
        }

        public string SpanId
        {
            get => spanId;
            set 
            {
                SetProperty(ref spanId, value, "",
                    async () => { _Span = await SpanDataStore.GetItemAsync(SpanId); });
            }
        }

        public int GirderNo
        {
            get => girderNo;
            set => SetProperty(ref girderNo, value);
        }

        public DateTime GirderCastingDate
        {
            get => girderCastingDate;
            set => SetProperty(ref girderCastingDate, value);
        }

        public int TotalCableNos
        {
            get => totalCableNos;
            set => SetProperty(ref totalCableNos, value);
        }

        public double GirderLength
        {
            get => girderLength;
            set => SetProperty(ref girderLength, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        public NewGirderViewModel()
        {
            GetExistingGirderLength();
            //GetSpan();
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private async void GetExistingGirderLength()
        {
            var girdersInSameSpan = await GirderDataStore.GetItemsAsyncForParent(SpanId);
            var _g = girdersInSameSpan.ToList();
            
            if (_g.Count > 0)
            {
                GirderLength = _g[0].girderLength;
            }
        }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            girderId = Guid.NewGuid().ToString();
            List<CableInfo> _cablesList = new List<CableInfo>();
            for (int i = 1; i <= TotalCableNos; i++)
            {
                CableInfo cableInfo = new CableInfo()
                {
                    bridgeId = BridgeId,
                    spanId = SpanId,
                    girderId = girderId,
                    cableId = Guid.NewGuid().ToString(),
                    cableNo = i,
                    stressingStageOfCable = 1,
                    cableNoText = $"Cable No: {i}",
                    stressingStageOfCableText = $"Stressing Stage: {1}",
                };
                await CableDataStore.AddItemAsync(cableInfo);
                _cablesList.Add(cableInfo);
            }
            //for (int i = 1; i <= spanNos; i++)
            //{
            //    SpanInfoDataModel _spanInfo = new SpanInfoDataModel() { bridgeId = itemId, SpanNo = i, spanId = Guid.NewGuid().ToString() };
            //    _SpanList.Add(_spanInfo);
            //    await SpanDataStore.AddItemAsync(_spanInfo);
            //}

            GirderInfo newGirder = new GirderInfo()
            {
                girderId = girderId,
                spanId = SpanId,
                bridgeId = BridgeId,
                girderNo = GirderNo,
                girderNoText = $"Girder No: {GirderNo}",
                girderCastingDate = GirderCastingDate,
                totalCableNos = TotalCableNos,
                totalCableNosText = $"Total Cable Nos: {TotalCableNos}",
                girderLength = GirderLength,
                girderLengthUnit = "meter",
                girderLengthText = $"Girder Length: {GirderLength:F2} meter",
                //cablesList = _cablesList,
            };
            await GirderDataStore.AddItemAsync(newGirder);

            //var _span = await SpanDataStore.GetItemAsync(SpanId);
            //_span.GirderList.Add(newGirder);
            //await SpanDataStore.UpdateItemAsync(_span);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        SpanInfoDataModel _Span;

        private bool ValidateSave()
        {
            return (totalCableNos > 0)
                && (girderCastingDate < DateTime.Today)
                && (_Span != null)
                //&& (_Span.GirderList.Where(g => g.girderNo == girderNo).ToList().Count == 0)
                && (girderNo > 0);
        }
    }
}
