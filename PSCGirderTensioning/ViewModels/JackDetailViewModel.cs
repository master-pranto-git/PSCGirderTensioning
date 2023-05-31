using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(JackId), nameof(JackId))]
    public class JackDetailViewModel : BaseViewModel
    {
        private string jackId;
        private string jackingEndRef;
        private string jack_y_text;
        private string jack_y_unit;
        private string jack_x_text;
        private string jack_x_unit;
        private double jack_x_coefficient;
        private double jack_c_coefficient;
        private string jackEquation;


        public string Jack_y_text
        {
            get => jack_y_text;
            set => SetProperty(ref jack_y_text, value);
        }
        public string Jack_y_unit
        {
            get => jack_y_unit;
            set => SetProperty(ref jack_y_unit, value);
        }
        public string Jack_x_text
        {
            get => jack_x_text;
            set => SetProperty(ref jack_x_text, value);
        }
        public string Jack_x_unit
        {
            get => jack_x_unit;
            set => SetProperty(ref jack_x_unit, value);
        }
        public double Jack_x_coefficient
        {
            get => jack_x_coefficient;
            set => SetProperty(ref jack_x_coefficient, value);
        }
        public double Jack_c_coefficient
        {
            get => jack_c_coefficient;
            set => SetProperty(ref jack_c_coefficient, value);
        }
        public string JackEquation
        {
            get => jackEquation;
            set => SetProperty(ref jackEquation, value);
        }

        public string JackingEndRef
        {
            get => jackingEndRef;
            set => SetProperty(ref jackingEndRef, value);
        }

        public string JackId
        {
            get
            {
                return jackId;
            }
            set
            {
                jackId = value;
                LoadJackId(value);
            }
        }

        private async void LoadJackId(string _jackId)
        {
            try
            {
                var jack = await JackDataStore.GetItemAsync(_jackId);
                JackingEndRef = jack.jackingEndRef;
                Jack_x_text = jack.x_text;
                Jack_x_unit = jack.x_unit;
                Jack_y_text = jack.y_text;
                Jack_y_unit = jack.y_unit;
                Jack_x_coefficient = jack.x_coefficient;
                Jack_c_coefficient = jack.c_coefficient;
                JackEquation = jack.jackEquation;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public Command RemoveJackCommand { get; }

        public JackDetailViewModel()
        {
            RemoveJackCommand = new Command(OnRemoveJack);
        }

        private async void OnRemoveJack()
        {
            //await Shell.Current.GoToAsync(nameof(NewItemPage));
            var _jackId = JackId;

            await JackDataStore.DeleteItemAsync(_jackId);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
