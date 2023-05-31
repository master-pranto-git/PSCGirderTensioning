using PSCGirderTensioning.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PSCGirderTensioning.ViewModels
{
    public class NewJackViewModel : BaseViewModel
    {
        private string _jackId;
        private string jackingEndRef;
        private string x_text = "Observed Reading";
        private string y_text = "Actual Reading";
        private string x_unit = "kg/cm2";
        private string y_unit = "Ton";
        private double x_coefficient;
        private double c_coefficient;
        private string jackEquation;

        public NewJackViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(jackingEndRef);
        }

        public string JackingEndRef
        {
            get => jackingEndRef;
            set => SetProperty(ref jackingEndRef, value);
        }

        public string X_unit
        {
            get => x_unit;
            set => SetProperty(ref x_unit, value, "", () => MakeEquationString());
        }
        public string X_text
        {
            get => x_text;
            set => SetProperty(ref x_text, value);
        }
        public string Y_text
        {
            get => y_text;
            set => SetProperty(ref y_text, value);
        }
        public string JackEquation
        {
            get => jackEquation;
            set => SetProperty(ref jackEquation, value);
        }

        public string Y_unit
        {
            get => y_unit;
            set => SetProperty(ref y_unit, value, "", () => MakeEquationString());
        }

        public double X_coefficient
        {
            get => x_coefficient;
            set => SetProperty(ref x_coefficient, value, "", () => MakeEquationString());
        }

        public double C_coefficient
        {
            get => c_coefficient;
            set => SetProperty(ref c_coefficient, value, "", () => MakeEquationString());
        }

        private void MakeEquationString()
        {
            JackEquation = $"y = {X_coefficient.ToString("0.########;-0.########")}x{C_coefficient.ToString("+0.#########;-0.#########;")}; where y = {Y_text} in {Y_unit} and x = {X_text} in {X_unit}.";
            //JackEquation = $"y = {X_coefficient.ToString("R;-R")}x{C_coefficient.ToString("+R;-R;")}; where y = {Y_text} in {Y_unit} and x = {X_text} in {X_unit}.";
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
            _jackId = Guid.NewGuid().ToString();

            JackInfo newJack = new JackInfo()
            {
                jackId = _jackId,
                jackingEndRef = JackingEndRef,
                x_text = X_text,
                y_text = Y_text,
                x_unit = X_unit,
                y_unit = Y_unit,
                x_coefficient = X_coefficient,
                c_coefficient = C_coefficient,
                jackEquation = JackEquation,
            };

            await JackDataStore.AddItemAsync(newJack);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
