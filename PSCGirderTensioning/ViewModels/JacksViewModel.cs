using PSCGirderTensioning.Models;
using PSCGirderTensioning.Services;
using PSCGirderTensioning.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    public class JacksViewModel : BaseViewModel
    {
        private JackInfo _selectedJack;
        public ObservableCollection<JackInfo> Jacks { get; }
        public Command LoadJacksCommand { get; }
        public Command AddJackCommand { get; }
        public Command<JackInfo> JackTapped { get; }
        
        public JacksViewModel()
        {
            //if (JackDataStore is JackDataStore store)
            //{
            //    store.DatabasePath = dbPath;
            //}
            Title = "Jack Info";
            Jacks = new ObservableCollection<JackInfo>();
            LoadJacksCommand = new Command(async () => await ExecuteLoadJacksCommand());
            JackTapped = new Command<JackInfo>(OnJackSelected);
            AddJackCommand = new Command(OnAddJack);
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedJack = null;
        }

        public JackInfo SelectedJack
        {
            get => _selectedJack;
            set
            {
                SetProperty(ref _selectedJack, value);
                OnJackSelected(value);
            }
        }

        private async void OnAddJack(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewJackPage));
        }

        private async void OnJackSelected(JackInfo jack)
        {
            if (jack == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(JackDetailPage)}?{nameof(JackDetailViewModel.JackId)}={jack.jackId}");
        }

        private async Task ExecuteLoadJacksCommand()
        {
            IsBusy = true;
            try
            {
                Jacks.Clear();
                var items = await JackDataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Jacks.Add(item);
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
    }
}
