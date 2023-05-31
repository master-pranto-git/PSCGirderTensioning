//using OxyPlot;
using OxyPlot.Series;
using PSCGirderTensioning.Models;
using PSCGirderTensioning.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using PSCGirderTensioning.AdditionalSupports;
using Syncfusion.SfChart.XForms;
//using Syncfusion.SfChart.XForms;


namespace PSCGirderTensioning.ViewModels
{
    [QueryProperty(nameof(CableId), nameof(CableId))]
    public class CableDetailViewModel : BaseViewModel
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        #region Measured Elongation

        private double measuredElongation12;
        private double measuredElongation13;
        private double measuredElongation14;
        private double measuredElongation15;
        private double measuredElongation16;
        private double measuredElongation17;
        private double measuredElongation18;

        private double measuredElongation22;
        private double measuredElongation23;
        private double measuredElongation24;
        private double measuredElongation25;
        private double measuredElongation26;
        private double measuredElongation27;
        private double measuredElongation28;

        private double measuredElongation32;
        private double measuredElongation33;
        private double measuredElongation34;
        private double measuredElongation35;
        private double measuredElongation36;
        private double measuredElongation37;
        private double measuredElongation38;

        #region Measured Elongation Public Properties

        public double MeasuredElongation12
        {
            get => measuredElongation12;
            //set
            //{
            //    SetProperty(ref measuredElongation12, value);
            //    OnPropertyChanged(nameof(MeasuredElongation12));
            //}
            set => SetProperty(ref measuredElongation12, value);

        }

    public double MeasuredElongation13
        {
            get => measuredElongation13;
            //set
            //{
            //    SetProperty(ref measuredElongation13, value);
            //    OnPropertyChanged(nameof(MeasuredElongation13));
            //}
            set => SetProperty(ref measuredElongation13, value);
        }

        public double MeasuredElongation14
        {
            get => measuredElongation14;
            //set
            //{
            //    SetProperty(ref measuredElongation14, value);
            //    OnPropertyChanged(nameof(MeasuredElongation14));
            //}
            set => SetProperty(ref measuredElongation14, value);
        }

        public double MeasuredElongation15
        {
            get => measuredElongation15;
            //set
            //{
            //    SetProperty(ref measuredElongation15, value);
            //    OnPropertyChanged(nameof(MeasuredElongation15));
            //}
            set => SetProperty(ref measuredElongation15, value);
        }

        public double MeasuredElongation16
        {
            get => measuredElongation16;
            //set
            //{
            //    SetProperty(ref measuredElongation15, value);
            //    OnPropertyChanged(nameof(MeasuredElongation15));
            //}
            set => SetProperty(ref measuredElongation16, value);
        }

        public double MeasuredElongation17
        {
            get => measuredElongation17;
            set => SetProperty(ref measuredElongation17, value);
        }

        public double MeasuredElongation18
        {
            get => measuredElongation18;
            set => SetProperty(ref measuredElongation18, value);
        }

        public double MeasuredElongation22
        {
            get => measuredElongation22;
            set => SetProperty(ref measuredElongation22, value);
        }

        public double MeasuredElongation23
        {
            get => measuredElongation23;
            set => SetProperty(ref measuredElongation23, value);
        }

        public double MeasuredElongation24
        {
            get => measuredElongation24;
            set => SetProperty(ref measuredElongation24, value);
        }

        public double MeasuredElongation25
        {
            get => measuredElongation25;
            set => SetProperty(ref measuredElongation25, value);
        }

        public double MeasuredElongation26
        {
            get => measuredElongation26;
            set => SetProperty(ref measuredElongation26, value);
        }

        public double MeasuredElongation27
        {
            get => measuredElongation27;
            set => SetProperty(ref measuredElongation27, value);
        }

        public double MeasuredElongation28
        {
            get => measuredElongation28;
            set => SetProperty(ref measuredElongation28, value);
        }

        public double MeasuredElongation32
        {
            get => measuredElongation32;
            set => SetProperty(ref measuredElongation32, value);
        }

        public double MeasuredElongation33
        {
            get => measuredElongation33;
            set => SetProperty(ref measuredElongation33, value);
        }

        public double MeasuredElongation34
        {
            get => measuredElongation34;
            set => SetProperty(ref measuredElongation34, value);
        }

        public double MeasuredElongation35
        {
            get => measuredElongation35;
            set => SetProperty(ref measuredElongation35, value);
        }

        public double MeasuredElongation36
        {
            get => measuredElongation36;
            set => SetProperty(ref measuredElongation36, value);
        }

        public double MeasuredElongation37
        {
            get => measuredElongation37;
            set => SetProperty(ref measuredElongation37, value);
        }

        public double MeasuredElongation38
        {
            get => measuredElongation38;
            set => SetProperty(ref measuredElongation38, value);
        }

        #endregion


        #endregion

        #region Reading for Elongation
        private double elongationReading11;
        private double elongationReading12;
        private double elongationReading13;
        private double elongationReading14;
        private double elongationReading15;
        private double elongationReading16;
        private double elongationReading17;
        private double elongationReading18;

        private double elongationReading21;
        private double elongationReading22;
        private double elongationReading23;
        private double elongationReading24;
        private double elongationReading25;
        private double elongationReading26;
        private double elongationReading27;
        private double elongationReading28;

        private double lockOff1;
        private double lockOff2;

        //private double elongationReading11 = 42;
        //private double elongationReading12 = 75;
        //private double elongationReading13 = 105;
        //private double elongationReading14 = 140;
        //private double elongationReading15 = 162;
        //private double elongationReading16 = 175;
        //private double elongationReading17 = 182;
        //private double elongationReading18 = 0;
        //private double elongationReading21 = 40;
        //private double elongationReading22 = 70;
        //private double elongationReading23 = 100;
        //private double elongationReading24 = 130;
        //private double elongationReading25 = 155;
        //private double elongationReading26 = 165;
        //private double elongationReading27 = 170;
        //private double elongationReading28 = 0;

        //private double lockOff1 = 175;
        //private double lockOff2 = 162;

        #region Elongation Reading Public Properties
        public double ElongationReading11
        {
            get => elongationReading11;
            set => SetProperty(ref elongationReading11, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading12
        {
            get => elongationReading12;
            set => SetProperty(ref elongationReading12, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading13
        {
            get => elongationReading13;
            set => SetProperty(ref elongationReading13, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading14
        {
            get => elongationReading14;
            set => SetProperty(ref elongationReading14, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading15
        {
            get => elongationReading15;
            set => SetProperty(ref elongationReading15, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading16
        {
            get => elongationReading16;
            set => SetProperty(ref elongationReading16, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading17
        {
            get => elongationReading17;
            set => SetProperty(ref elongationReading17, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading18
        {
            get => elongationReading18;
            set => SetProperty(ref elongationReading18, value, "", () => CalculateMeasuredElongation());
        }

        public double ElongationReading21
        {
            get => elongationReading21;
            set => SetProperty(ref elongationReading21, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading22
        {
            get => elongationReading22;
            set => SetProperty(ref elongationReading22, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading23
        {
            get => elongationReading23;
            set => SetProperty(ref elongationReading23, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading24
        {
            get => elongationReading24;
            set => SetProperty(ref elongationReading24, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading25
        {
            get => elongationReading25;
            set => SetProperty(ref elongationReading25, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading26
        {
            get => elongationReading26;
            set => SetProperty(ref elongationReading26, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading27
        {
            get => elongationReading27;
            set => SetProperty(ref elongationReading27, value, "", () => CalculateMeasuredElongation());
        }
        public double ElongationReading28
        {
            get => elongationReading28;
            set => SetProperty(ref elongationReading28, value, "", () => CalculateMeasuredElongation());
        }
        #endregion

        #region LockOff Public Properties
        public double LockOff1
        {
            get => lockOff1;
            set => SetProperty(ref lockOff1, value, "", () => { CalculateResult(); ScatterChartViewModel(); });
        }

        public double LockOff2
        {
            get => lockOff2;

            set => SetProperty(ref lockOff2, value, "", () => { CalculateResult(); ScatterChartViewModel(); });
        }
        #endregion


        #endregion

        #region Calculate Methods

        private void CalculateMeasuredElongation()
        {
            MeasuredElongation12 = ElongationReading12 - ElongationReading11 + 0;
            MeasuredElongation22 = ElongationReading22 - ElongationReading21 + 0;
            MeasuredElongation32 = (MeasuredElongation12 + MeasuredElongation22) / 2;

            MeasuredElongation13 = ElongationReading13 - ElongationReading12 + MeasuredElongation32;
            MeasuredElongation23 = ElongationReading23 - ElongationReading22 + MeasuredElongation32;
            MeasuredElongation33 = (MeasuredElongation13 + MeasuredElongation23) / 2;

            MeasuredElongation14 = ElongationReading14 - ElongationReading13 + MeasuredElongation33;
            MeasuredElongation24 = ElongationReading24 - ElongationReading23 + MeasuredElongation33;
            MeasuredElongation34 = (MeasuredElongation14 + MeasuredElongation24) / 2;

            MeasuredElongation15 = ElongationReading15 - ElongationReading14 + MeasuredElongation34;
            MeasuredElongation25 = ElongationReading25 - ElongationReading24 + MeasuredElongation34;
            MeasuredElongation35 = (MeasuredElongation15 + MeasuredElongation25) / 2;

            MeasuredElongation16 = ElongationReading16 - ElongationReading15 + MeasuredElongation35;
            MeasuredElongation26 = ElongationReading26 - ElongationReading25 + MeasuredElongation35;
            MeasuredElongation36 = (MeasuredElongation16 + MeasuredElongation26) / 2;

            MeasuredElongation17 = ElongationReading17 - ElongationReading16 + MeasuredElongation36;
            MeasuredElongation27 = ElongationReading27 - ElongationReading26 + MeasuredElongation36;
            MeasuredElongation37 = (MeasuredElongation17 + MeasuredElongation27) / 2;

            MeasuredElongation18 = ElongationReading18 - ElongationReading17 + MeasuredElongation37;
            MeasuredElongation28 = ElongationReading28 - ElongationReading27 + MeasuredElongation37;
            MeasuredElongation38 = (MeasuredElongation18 + MeasuredElongation28) / 2;
        }

        private void CalculateCalibreateGaugePressre()
        {
            double calibratedForce1 = 0;
            double calibratedForce2 = 0;
            if (selectedJackEnd1 != null)
            {
                double _convertedDesignForce1 = ConvertDesignForceToDesiredUnit(DesignJackingForce, SelectedDesignForceUnit, SelectedJackEnd1.y_unit);
                calibratedForce1 = (_convertedDesignForce1 - selectedJackEnd1.c_coefficient) / selectedJackEnd1.x_coefficient;
            }
            if (selectedJackEnd2 != null)
            {
                double _convertedDesignForce2 = ConvertDesignForceToDesiredUnit(DesignJackingForce, SelectedDesignForceUnit, SelectedJackEnd2.y_unit);
                calibratedForce2 = (_convertedDesignForce2 - selectedJackEnd2.c_coefficient) / selectedJackEnd2.x_coefficient;
            }

            CalibratedPressure11 = Math.Round(calibratedForce1 * ((double)Percentage1 / 100.0), 0);
            CalibratedPressure12 = Math.Round(calibratedForce1 * ((double)Percentage2 / 100.0), 0);
            CalibratedPressure13 = Math.Round(calibratedForce1 * ((double)Percentage3 / 100.0), 0);
            CalibratedPressure14 = Math.Round(calibratedForce1 * ((double)Percentage4 / 100.0), 0);
            CalibratedPressure15 = Math.Round(calibratedForce1 * ((double)Percentage5 / 100.0), 0);
            CalibratedPressure16 = Math.Round(calibratedForce1 * ((double)Percentage6 / 100.0), 0);
            CalibratedPressure17 = Math.Round(calibratedForce1 * ((double)Percentage7 / 100.0), 0);
            CalibratedPressure18 = Math.Round(calibratedForce1 * ((double)Percentage8 / 100.0), 0);

            CalibratedPressure21 = Math.Round(calibratedForce2 * ((double)Percentage1 / 100.0), 0);
            CalibratedPressure22 = Math.Round(calibratedForce2 * ((double)Percentage2 / 100.0), 0);
            CalibratedPressure23 = Math.Round(calibratedForce2 * ((double)Percentage3 / 100.0), 0);
            CalibratedPressure24 = Math.Round(calibratedForce2 * ((double)Percentage4 / 100.0), 0);
            CalibratedPressure25 = Math.Round(calibratedForce2 * ((double)Percentage5 / 100.0), 0);
            CalibratedPressure26 = Math.Round(calibratedForce2 * ((double)Percentage6 / 100.0), 0);
            CalibratedPressure27 = Math.Round(calibratedForce2 * ((double)Percentage7 / 100.0), 0);
            CalibratedPressure28 = Math.Round(calibratedForce2 * ((double)Percentage8 / 100.0), 0);
        }

        private double ConvertDesignForceToDesiredUnit(double _designJackingForce, string _selectedDesignForceUnit, string _y_unit)
        {
            double convertedForce = 0;

            switch (_y_unit)
            {
                case "Ton":
                    if (_selectedDesignForceUnit == UnitsEnum.kG.ToString())
                    {
                        convertedForce = _designJackingForce / 1000;
                    }
                    else if (_selectedDesignForceUnit == UnitsEnum.kN.ToString())
                    {
                        convertedForce = _designJackingForce / 9.81;
                    }
                    break;
                default:
                    convertedForce = _designJackingForce;
                    break;
            }

            return convertedForce;
        }

        private void MultiplyWithPercentage()
        {
            ActualPressure11 = Math.Round(DesignJackingForce * ((double)Percentage1 / 100.0), 0);
            ActualPressure12 = Math.Round(DesignJackingForce * ((double)Percentage2 / 100.0), 0);
            ActualPressure13 = Math.Round(DesignJackingForce * ((double)Percentage3 / 100.0), 0);
            ActualPressure14 = Math.Round(DesignJackingForce * ((double)Percentage4 / 100.0), 0);
            ActualPressure15 = Math.Round(DesignJackingForce * ((double)Percentage5 / 100.0), 0);
            ActualPressure16 = Math.Round(DesignJackingForce * ((double)Percentage6 / 100.0), 0);
            ActualPressure17 = Math.Round(DesignJackingForce * ((double)Percentage7 / 100.0), 0);
            ActualPressure18 = Math.Round(DesignJackingForce * ((double)Percentage8 / 100.0), 0);

            ActualPressure21 = Math.Round(DesignJackingForce * ((double)Percentage1 / 100.0), 0);
            ActualPressure22 = Math.Round(DesignJackingForce * ((double)Percentage2 / 100.0), 0);
            ActualPressure23 = Math.Round(DesignJackingForce * ((double)Percentage3 / 100.0), 0);
            ActualPressure24 = Math.Round(DesignJackingForce * ((double)Percentage4 / 100.0), 0);
            ActualPressure25 = Math.Round(DesignJackingForce * ((double)Percentage5 / 100.0), 0);
            ActualPressure26 = Math.Round(DesignJackingForce * ((double)Percentage6 / 100.0), 0);
            ActualPressure27 = Math.Round(DesignJackingForce * ((double)Percentage7 / 100.0), 0);
            ActualPressure28 = Math.Round(DesignJackingForce * ((double)Percentage8 / 100.0), 0);

            CalculateCalibreateGaugePressre();
        }

        private double GetMaxValueFromList(List<double> _doubleList)
        {
            double maxValue = _doubleList.Max();
            return maxValue;
        }

        private void CalculateResult()
        {
            AreaOfCable_mm2 = Math.Round(NosOfStrand * AreaOfStrand_mm2, 2);
            CorrectedElongation = Math.Round(DesignElongation + (DesignJackingForce * (ActualGrippingLength - DesignGrippingLength) / (AreaOfCable_mm2 * ModulusOfElasticity_E)), 2);
            ActualAreaOfCable_mm2 = Math.Round(NosOfStrand * ActualAreaOfStrand_mm2, 2);

            CorrectedElongation1 = Math.Round(CorrectedElongation * ((AreaOfCable_mm2 * ModulusOfElasticity_E) / (ActualAreaOfCable_mm2 * ModulusOfElasticity_E1)), 2);
            ActualCalculatedElongation = Math.Round(DesignJackingForce * ((ActualGrippingLength - DesignGrippingLength) / (ActualAreaOfCable_mm2 * ModulusOfElasticity_E1)), 2);


            List<double> _dL1 = new List<double>() {
                ElongationReading11, ElongationReading12, ElongationReading13, ElongationReading14,
                ElongationReading15, ElongationReading16, ElongationReading17, ElongationReading18,
            };

            List<double> _dL2 = new List<double>() {
                ElongationReading21, ElongationReading22, ElongationReading23, ElongationReading24,
                ElongationReading25, ElongationReading26, ElongationReading27, ElongationReading28,
            };

            GrossSlipAtEnd1 = _dL1.Max() - LockOff1;
            GrossSlipAtEnd2 = _dL2.Max() - LockOff2;
            NetSlipAtEnd1 = GrossSlipAtEnd1 - ActualCalculatedElongation;
            NetSlipAtEnd2 = GrossSlipAtEnd2 - ActualCalculatedElongation;

            MultiplyWithPercentage();
        }

        #endregion

        #region Calibrated Pressure DataBinder
        private double calibratedPressure11;
        private double calibratedPressure12;
        private double calibratedPressure13;
        private double calibratedPressure14;
        private double calibratedPressure15;
        private double calibratedPressure16;
        private double calibratedPressure17;
        private double calibratedPressure18;

        private double calibratedPressure21;
        private double calibratedPressure22;
        private double calibratedPressure23;
        private double calibratedPressure24;
        private double calibratedPressure25;
        private double calibratedPressure26;
        private double calibratedPressure27;
        private double calibratedPressure28;

        #region Public Calibrated Pressure

        public double CalibratedPressure11
        {
            get => calibratedPressure11;
            set => SetProperty(ref calibratedPressure11, value);
        }
        public double CalibratedPressure12
        {
            get => calibratedPressure12;
            set => SetProperty(ref calibratedPressure12, value);
        }
        public double CalibratedPressure13
        {
            get => calibratedPressure13;
            set => SetProperty(ref calibratedPressure13, value);
        }
        public double CalibratedPressure14
        {
            get => calibratedPressure14;
            set => SetProperty(ref calibratedPressure14, value);
        }
        public double CalibratedPressure15
        {
            get => calibratedPressure15;
            set => SetProperty(ref calibratedPressure15, value);
        }
        public double CalibratedPressure16
        {
            get => calibratedPressure16;
            set => SetProperty(ref calibratedPressure16, value);
        }
        public double CalibratedPressure17
        {
            get => calibratedPressure17;
            set => SetProperty(ref calibratedPressure17, value);
        }
        public double CalibratedPressure18
        {
            get => calibratedPressure18;
            set => SetProperty(ref calibratedPressure18, value);
        }

        public double CalibratedPressure21
        {
            get => calibratedPressure21;
            set => SetProperty(ref calibratedPressure21, value);
        }
        public double CalibratedPressure22
        {
            get => calibratedPressure22;
            set => SetProperty(ref calibratedPressure22, value);
        }
        public double CalibratedPressure23
        {
            get => calibratedPressure13;
            set => SetProperty(ref calibratedPressure23, value);
        }
        public double CalibratedPressure24
        {
            get => calibratedPressure24;
            set => SetProperty(ref calibratedPressure24, value);
        }
        public double CalibratedPressure25
        {
            get => calibratedPressure25;
            set => SetProperty(ref calibratedPressure25, value);
        }
        public double CalibratedPressure26
        {
            get => calibratedPressure26;
            set => SetProperty(ref calibratedPressure26, value);
        }
        public double CalibratedPressure27
        {
            get => calibratedPressure27;
            set => SetProperty(ref calibratedPressure27, value);
        }
        public double CalibratedPressure28
        {
            get => calibratedPressure28;
            set => SetProperty(ref calibratedPressure28, value);
        }

        #endregion



        #endregion

        #region Actual Pressure DataBinder
        private double actualPressure11;
        private double actualPressure12;
        private double actualPressure13;
        private double actualPressure14;
        private double actualPressure15;
        private double actualPressure16;
        private double actualPressure17;
        private double actualPressure18;

        private double actualPressure21;
        private double actualPressure22;
        private double actualPressure23;
        private double actualPressure24;
        private double actualPressure25;
        private double actualPressure26;
        private double actualPressure27;
        private double actualPressure28;

        #region Actual Pressure Public Properties
        public double ActualPressure11
        {
            get => actualPressure11;
            set => SetProperty(ref actualPressure11, value);
        }
        public double ActualPressure12
        {
            get => actualPressure12;
            set => SetProperty(ref actualPressure12, value);
        }
        public double ActualPressure13
        {
            get => actualPressure13;
            set => SetProperty(ref actualPressure13, value);
        }
        public double ActualPressure14
        {
            get => actualPressure14;
            set => SetProperty(ref actualPressure14, value);
        }
        public double ActualPressure15
        {
            get => actualPressure15;
            set => SetProperty(ref actualPressure15, value);
        }
        public double ActualPressure16
        {
            get => actualPressure16;
            set => SetProperty(ref actualPressure16, value);
        }
        public double ActualPressure17
        {
            get => actualPressure17;
            set => SetProperty(ref actualPressure17, value);
        }
        public double ActualPressure18
        {
            get => actualPressure18;
            set => SetProperty(ref actualPressure18, value);
        }

        public double ActualPressure21
        {
            get => actualPressure21;
            set => SetProperty(ref actualPressure21, value);
        }
        public double ActualPressure22
        {
            get => actualPressure22;
            set => SetProperty(ref actualPressure22, value);
        }
        public double ActualPressure23
        {
            get => actualPressure13;
            set => SetProperty(ref actualPressure23, value);
        }
        public double ActualPressure24
        {
            get => actualPressure24;
            set => SetProperty(ref actualPressure24, value);
        }
        public double ActualPressure25
        {
            get => actualPressure25;
            set => SetProperty(ref actualPressure25, value);
        }
        public double ActualPressure26
        {
            get => actualPressure26;
            set => SetProperty(ref actualPressure26, value);
        }
        public double ActualPressure27
        {
            get => actualPressure27;
            set => SetProperty(ref actualPressure27, value);
        }
        public double ActualPressure28
        {
            get => actualPressure28;
            set => SetProperty(ref actualPressure28, value);
        }
        #endregion

        #endregion

        #region Percentage DataBinder

        private int percentage1 = 20;
        private int percentage2 = 40;
        private int percentage3 = 60;
        private int percentage4 = 80;
        private int percentage5 = 95;
        private int percentage6 = 100;
        private int percentage7 = 103;
        private int percentage8 = 105;

        #region Percentage Public Properties
        public int Percentage1
        {
            get => percentage1;
            set => SetProperty(ref percentage1, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage2
        {
            get => percentage2;
            set => SetProperty(ref percentage2, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage3
        {
            get => percentage3;
            set => SetProperty(ref percentage3, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage4
        {
            get => percentage4;
            set => SetProperty(ref percentage4, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage5
        {
            get => percentage5;
            set => SetProperty(ref percentage5, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage6
        {
            get => percentage6;
            set => SetProperty(ref percentage6, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage7
        {
            get => percentage7;
            set => SetProperty(ref percentage7, value, "", () => MultiplyWithPercentage());
        }

        public int Percentage8
        {
            get => percentage8;
            set => SetProperty(ref percentage8, value, "", () => MultiplyWithPercentage());
        }
        #endregion

        #endregion

        #region Calculated Values Public and Private Properties

        private double correcFactorForICJ;
        public double CorrectionFactorForICJ
        {
            get => correcFactorForICJ;
            set => SetProperty(ref correcFactorForICJ, value);
        }

        private double averageElongation;
        public double AverageElongation
        {
            get => averageElongation;
            set => SetProperty(ref averageElongation, value);
        }

        private string averageElongationText;
        public string AverageElongationText
        {
            get => averageElongationText;
            set => SetProperty(ref averageElongationText, value);
        }

        private double averageSlip;
        public double AverageSlip
        {
            get => averageSlip;
            set => SetProperty(ref averageSlip, value);
        }

        private string averageSlipText;
        public string AverageSlipText
        {
            get => averageSlipText;
            set => SetProperty(ref averageSlipText, value);
        }

        #region Design Related Calculated Properties

        private double areaOfCable_mm2;
        public double AreaOfCable_mm2
        {
            get => areaOfCable_mm2;
            set => SetProperty(ref areaOfCable_mm2, value);
        }

        private double correctedElongation;
        public double CorrectedElongation
        {
            get => correctedElongation;
            set => SetProperty(ref correctedElongation, value);
        }

        private double actualAreaOfCable_mm2;
        public double ActualAreaOfCable_mm2
        {
            get => actualAreaOfCable_mm2;
            set => SetProperty(ref actualAreaOfCable_mm2, value);
        }

        private double correctedElongation1;
        public double CorrectedElongation1
        {
            get => correctedElongation1;
            set => SetProperty(ref correctedElongation1, value);
        }

        private double actualCalculatedElongation;
        public double ActualCalculatedElongation
        {
            get => actualCalculatedElongation;
            set => SetProperty(ref actualCalculatedElongation, value);
        }

        private double grossSlipAtEnd1;
        public double GrossSlipAtEnd1
        {
            get => grossSlipAtEnd1;
            set => SetProperty(ref grossSlipAtEnd1, value);
        }

        private double grossSlipAtEnd2;
        public double GrossSlipAtEnd2
        {
            get => grossSlipAtEnd2;
            set => SetProperty(ref grossSlipAtEnd2, value);
        }

        private double netSlipAtEnd1;
        public double NetSlipAtEnd1
        {
            get => netSlipAtEnd1;
            set => SetProperty(ref netSlipAtEnd1, value);
        }

        private double netSlipAtEnd2;
        public double NetSlipAtEnd2
        {
            get => netSlipAtEnd2;
            set => SetProperty(ref netSlipAtEnd2, value);
        }

        #endregion


        #endregion

        #region Design Data and Calculation Binder before table

        //Design Information
        private double diaOfStrand_mm = 12.70;
        private int nosOfStrand = 12;
        private double areaOfStrand_mm2 = 98.70;
        private double modulusOfElasticity_E = 197;
        //private double designElongation = 157.90; // Added Data
        //private double designJackingForce = 1680; // Added
        private double designElongation;
        private double designJackingForce;
        private double designGrippingLength = 0;
        private double designCableSlip = 6;
        private double actualGrippingLength;
        //private double actualGrippingLength = 580; //Added
        private double designConcreteStrength;
        private double actualConcreteStrength;

        //private double actualAreaOfStrand_mm2 = 99.40; //Added
        private double actualAreaOfStrand_mm2;
        //private double modulusOfElasticity_E1 = 194.9; //added
        private double modulusOfElasticity_E1;


        #region Design Public Properties

        public double ActualAreaOfStrand_mm2
        {
            get => actualAreaOfStrand_mm2;
            set => SetProperty(ref actualAreaOfStrand_mm2, value, "", () => CalculateResult());
        }

        public double ModulusOfElasticity_E1
        {
            get => modulusOfElasticity_E1;
            set => SetProperty(ref modulusOfElasticity_E1, value, "", () => CalculateResult());
        }

        public double DesignConcreteStrength
        {
            get => designConcreteStrength;
            set => SetProperty(ref designConcreteStrength, value);
        }

        public double ActualConcreteStrength
        {
            get => actualConcreteStrength;
            set => SetProperty(ref actualConcreteStrength, value);
        }

        public double DiaOfStrand_mm
        {
            get => diaOfStrand_mm;
            set => SetProperty(ref diaOfStrand_mm, value);
        }

        public double DesignJackingForce
        {
            get => designJackingForce;
            set => SetProperty(ref designJackingForce, value, "", () => CalculateResult());
        }

        public double DesignCableSlip
        {
            get => designCableSlip;
            set => SetProperty(ref designCableSlip, value);
        }

        public double ModulusOfElasticity_E
        {
            get => modulusOfElasticity_E;
            set => SetProperty(ref modulusOfElasticity_E, value, "", () => CalculateResult());
        }

        public double DesignElongation
        {
            get => designElongation;
            set => SetProperty(ref designElongation, value, "", () => CalculateResult());
        }

        public double DesignGrippingLength
        {
            get => designGrippingLength;
            set => SetProperty(ref designGrippingLength, value, "", () => CalculateResult());
        }

        public double ActualGrippingLength
        {
            get => actualGrippingLength;
            set => SetProperty(ref actualGrippingLength, value, "", () => CalculateResult());
        }

        public int NosOfStrand
        {
            get => nosOfStrand;
            set => SetProperty(ref nosOfStrand, value, "", () => CalculateResult());
        }

        public double AreaOfStrand_mm2
        {
            get => areaOfStrand_mm2;
            set => SetProperty(ref areaOfStrand_mm2, value, "", () => CalculateResult());
        }


        #endregion


        #endregion

        #region Bridge General Information

        private string bridgeId;
        private string spanId;
        private string girderId;
        private string cableId;
        private int spanNo;
        private int girderNo;
        private int girderLength;
        private string girderLengthUnit;
        private int totalCableNos;

        private string girderNoText;
        private string girderLengthText;
        private string totalCableNosText;

        private string bridgeName;
        private string district;
        private string upazilla;

        public string BridgeName
        {
            get => bridgeName;
            set => SetProperty(ref bridgeName, value);
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
        public string BridgeId
        {
            get => bridgeId;
            set => SetProperty(ref bridgeId, value);
        }
        public int SpanNo
        {
            get => spanNo;
            set => SetProperty(ref spanNo, value);
        }

        private string stressingStage;
        public string StressingStage
        {
            get => stressingStage;
            set => SetProperty(ref stressingStage, value);
        }

        public string CableId
        {
            get
            {
                return cableId;
            }
            set
            {
                cableId = value;
                LoadCableId(value);
            }
        }

        private string spanGirderRef;
        private string cableRefToBeStressedText;
        public string SpanGirderRef
        {
            get => spanGirderRef;
            set => SetProperty(ref spanGirderRef, value);
        }
        public string GirderLengthText
        {
            get => girderLengthText;
            set => SetProperty(ref girderLengthText, value);
        }
        public string CableRefToBeStressedText
        {
            get => cableRefToBeStressedText;
            set => SetProperty(ref cableRefToBeStressedText, value);
        }

        private string girderCastingDateText;
        public string GirderCastingDateText
        {
            get => girderCastingDateText;
            set => SetProperty(ref girderCastingDateText, value);
        }

        private string remarks;
        public string Remarks
        {
            get => remarks;
            set => SetProperty(ref remarks, value);
        }
        private DateTime tensioningDate;
        public DateTime TensioningDate
        {
            get => tensioningDate;
            set => SetProperty(ref tensioningDate, value);
        }


        #endregion


        private string selectedDesignForceUnit;
        private JackInfo selectedJackEnd1;
        private JackInfo selectedJackEnd2;

        public ObservableCollection<string> DesignForceUnits { get; set; }
        public ObservableCollection<JackInfo> Jacks { get; set; }

        public string SelectedDesignForceUnit
        {
            get { return selectedDesignForceUnit; }
            set
            {
                if (selectedDesignForceUnit != value)
                {
                    selectedDesignForceUnit = value;
                    OnDesignForceUnitPropertyChanged(nameof(SelectedDesignForceUnit));
                }
            }
        }

        public JackInfo SelectedJackEnd1
        {
            get { return selectedJackEnd1; }
            set
            {
                if (selectedJackEnd1 != value)
                {
                    selectedJackEnd1 = value;
                    OnSelectedJackPropertyChanged(nameof(SelectedJackEnd1));
                    CalculateCalibreateGaugePressre();
                }
            }
        }

        public JackInfo SelectedJackEnd2
        {
            get { return selectedJackEnd2; }
            set
            {
                if (selectedJackEnd2 != value)
                {
                    selectedJackEnd2 = value;
                    OnSelectedJackPropertyChanged(nameof(SelectedJackEnd2));
                    CalculateCalibreateGaugePressre();
                }
            }
        }

        public event PropertyChangedEventHandler SelectedJackPropertyChanged;

        protected virtual void OnSelectedJackPropertyChanged(string propertyName)
        {
            SelectedJackPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void LoadJacks()
        {
            Jacks = new ObservableCollection<JackInfo>();
            Jacks.Clear();
            var _jacks = await JackDataStore.GetItemsAsync(true);
            foreach (var _jack in _jacks)
            {
                Jacks.Add(_jack);
            }
        }

        public CableDetailViewModel()
        {
            DesignForceUnits = new ObservableCollection<string>
            {
            UnitsEnum.kG.ToString(),
            UnitsEnum.kN.ToString(),
            };
            SelectedDesignForceUnit = DesignForceUnits[1]; // set default selection

            LoadJacks();

            CalculateResult();
            
            ScatterData = scatterData;

            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            //PlotViewCommand = new Command(OnPlotView);
            CalculateCorrecFactorCommand = new Command(OnCalculateCorrecFactorCommand);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private void OnCalculateCorrecFactorCommand()
        {
            ScatterChartViewModel();
        }

        //private async void OnPlotView()
        //{
        //    //await Shell.Current.GoToAsync($"{nameof(PlotViewPage)}");
        //    //await Shell.Current.GoToAsync($"{nameof(PlotViewPage)}?{nameof(PlotViewViewModel.ScatterData)}={ScatterData}");
        //}

        //public void OnOptionSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var picker = (Picker)sender;
        //    var selectedOption = (string)picker.SelectedItem;

        //    // Perform action when option is selected
        //    // e.g. display a message or update a property in your ViewModel
        //    Debug.WriteLine($"Selected option: {selectedOption}");
        //}

        public event PropertyChangedEventHandler DesignForceUnitPropertyChanged;

        protected virtual void OnDesignForceUnitPropertyChanged(string propertyName)
        {
            DesignForceUnitPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Saving Data

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }
        //public Command PlotViewCommand { get; }
        public Command CalculateCorrecFactorCommand { get; private set; }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(bridgeName)
                && !String.IsNullOrWhiteSpace(district);
        }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        //private async string GetJackId(JackInfo jackInfo)
        //{

        //}

        private async void OnSave()
        {
            var _c = await CableDataStore.GetItemAsync(CableId);

            CableInfo newCable = new CableInfo()
            {
                bridgeId = _c.bridgeId,
                spanId = _c.spanId,
                girderId = _c.girderId,
                cableId = CableId,

                cableNo = _c.cableNo,
                tensioningDate = TensioningDate,
                stressingStageOfCable = int.Parse(StressingStage),
                jackIDEnd1 = SelectedJackEnd1.jackId,
                jackIDEnd2 = SelectedJackEnd2.jackId,

                cableNoText = _c.cableNoText,
                stressingStageOfCableText = _c.stressingStageOfCableText,

                diaOfStrand_mm = DiaOfStrand_mm,
                nosOfStrandOrCable = NosOfStrand,
                modulusOfElasticityE_kNpermm2 = ModulusOfElasticity_E,
                areaOfStrandA_mm2 = AreaOfStrand_mm2,
                designJackingForceP = DesignJackingForce,
                designJackingForceUnit = SelectedDesignForceUnit,
                designElongation_mm = DesignElongation,
                designGrippingLength_mm = DesignGrippingLength,
                actualGrippingLength_mm = ActualGrippingLength,
                designCableSlip_mm = DesignCableSlip,
                designConcreteStrength_Npermm2 = DesignConcreteStrength,
                actualConcreteStrength_Npermm2 = ActualConcreteStrength,

                actualAreaOfStrandA1_mm2 = ActualAreaOfStrand_mm2,
                modulusOfElasticityE1_kNpermm2 = ModulusOfElasticity_E1,

                percentage1 = Percentage1,
                percentage2 = Percentage2,
                percentage3 = Percentage3,
                percentage4 = Percentage4,
                percentage5 = Percentage5,
                percentage6 = Percentage6,
                percentage7 = Percentage7,
                percentage8 = Percentage8,

                elongationReading11 = ElongationReading11,
                elongationReading12 = ElongationReading12,
                elongationReading13 = ElongationReading13,
                elongationReading14 = ElongationReading14,
                elongationReading15 = ElongationReading15,
                elongationReading16 = ElongationReading16,
                elongationReading17 = ElongationReading17,
                elongationReading18 = ElongationReading18,

                elongationReading21 = ElongationReading21,
                elongationReading22 = ElongationReading22,
                elongationReading23 = ElongationReading23,
                elongationReading24 = ElongationReading24,
                elongationReading25 = ElongationReading25,
                elongationReading26 = ElongationReading26,
                elongationReading27 = ElongationReading27,
                elongationReading28 = ElongationReading28,

                lockOff1 = LockOff1,
                lockOff2 = LockOff2,
                remarks = Remarks,

            };

            //await CableDataStore.AddItemAsync(newCable);
            await CableDataStore.UpdateItemAsync(newCable);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        #endregion


        private async void LoadCableId(string _cableId)
        {
            try
            {
                var cable = await CableDataStore.GetItemAsync(_cableId);
                var girder = await GirderDataStore.GetItemAsync(cable.girderId);
                var span = await SpanDataStore.GetItemAsync(girder.spanId);
                var bridge = await DataStore.GetItemAsync(span.bridgeId);
                //Debug.WriteLine($"Item Id in {nameof(SpanDetailViewModel)}: {item.Id}");
                BridgeName = bridge.BridgeName;
                District = bridge.District;
                Upazilla = bridge.Upazilla;
                SpanGirderRef = $"Span-{span.SpanNo}, Girder-{girder.girderNo}";
                GirderLengthText = girder.girderLengthText;
                CableRefToBeStressedText = $"{cable.cableNo.ToString("00")} of {girder.totalCableNos.ToString("00")}";
                GirderCastingDateText = girder.girderCastingDate.ToString("dd-MMM-yyyy");
                TensioningDate = cable.tensioningDate;
                StressingStage = cable.stressingStageOfCable.ToString("00");
                //SelectedJackEnd1 = await JackDataStore.GetItemAsync(cable.jackIDEnd1);
                //SelectedJackEnd2 = await JackDataStore.GetItemAsync(cable.jackIDEnd2);
                SelectedJackEnd1 = Jacks?.FirstOrDefault(c => c.jackId == cable.jackIDEnd1);
                SelectedJackEnd2 = Jacks?.FirstOrDefault(c => c.jackId == cable.jackIDEnd2);
                //SelectedJackEnd2 = await JackDataStore.GetItemAsync(cable.jackIDEnd2);
                //SelectedJackEnd2 = cable.jackInfoEnd2;

                DiaOfStrand_mm = cable.diaOfStrand_mm;
                NosOfStrand = cable.nosOfStrandOrCable;
                //AnchorageBrand = cable.anchorageBrand;
                //UTSofStrand = cable.UTSofStrand_Npermm2;
                ModulusOfElasticity_E = cable.modulusOfElasticityE_kNpermm2;
                AreaOfStrand_mm2 = cable.areaOfStrandA_mm2;
                DesignJackingForce = cable.designJackingForceP;
                SelectedDesignForceUnit = cable.designJackingForceUnit;
                DesignElongation = cable.designElongation_mm;
                DesignGrippingLength = cable.designGrippingLength_mm;
                ActualGrippingLength = cable.actualGrippingLength_mm;
                DesignCableSlip = cable.designCableSlip_mm;
                DesignConcreteStrength = cable.designConcreteStrength_Npermm2;
                ActualConcreteStrength = cable.actualConcreteStrength_Npermm2;

                ActualAreaOfStrand_mm2 = cable.actualAreaOfStrandA1_mm2;
                ModulusOfElasticity_E1 = cable.modulusOfElasticityE1_kNpermm2;

                Percentage1 = cable.percentage1;
                Percentage2 = cable.percentage2;
                Percentage3 = cable.percentage3;
                Percentage4 = cable.percentage4;
                Percentage5 = cable.percentage5;
                Percentage6 = cable.percentage6;
                Percentage7 = cable.percentage7;
                Percentage8 = cable.percentage8;

                ElongationReading11 = cable.elongationReading11;
                ElongationReading12 = cable.elongationReading12;
                ElongationReading13 = cable.elongationReading13;
                ElongationReading14 = cable.elongationReading14;
                ElongationReading15 = cable.elongationReading15;
                ElongationReading16 = cable.elongationReading16;
                ElongationReading17 = cable.elongationReading17;
                ElongationReading18 = cable.elongationReading18;

                ElongationReading21 = cable.elongationReading21;
                ElongationReading22 = cable.elongationReading22;
                ElongationReading23 = cable.elongationReading23;
                ElongationReading24 = cable.elongationReading24;
                ElongationReading25 = cable.elongationReading25;
                ElongationReading26 = cable.elongationReading26;
                ElongationReading27 = cable.elongationReading27;
                ElongationReading28 = cable.elongationReading28;

                LockOff1 = cable.lockOff1;
                LockOff2 = cable.lockOff2;

                Remarks = cable.remarks;

                GirderLengthText = girder.girderLengthText;


            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        #region Plotting

        private ObservableCollection<ScatterDataPoint> scatterData = new ObservableCollection<ScatterDataPoint>() 
        { 
            new ScatterDataPoint() { XValue = 0, YValue = 0 },
            new ScatterDataPoint() { XValue = 10, YValue = 10 },
            new ScatterDataPoint() { XValue = 20, YValue = 20 },
        };

        public ObservableCollection<ScatterDataPoint> ScatterData
        {
            get => scatterData;
            set
            {
                SetProperty(ref scatterData, value);
                //OnPropertyChanged(nameof(ScatterData));
            }
            //get;
            //set;
        }

        private void MyCHart()
        {
            scatterData = new ObservableCollection<ScatterDataPoint>()
            {
                new ScatterDataPoint() { XValue = 0, YValue = Percentage1 },
            };
        }

        //public PlotModel ScatterChartModel { get; set; }
        public string TrendlineEquation { get; set; }

        public void ScatterChartViewModel()
        {
            //double[] x_values = Array.Empty<double>();
            //double[] y_values = Array.Empty<double>();
            //MyCHart();
            scatterData = new ObservableCollection<ScatterDataPoint>()
            {
                new ScatterDataPoint() { XValue = 0, YValue = Percentage1 },
            };
            //ScatterChartModel = new PlotModel { Title = "Scatter Chart" };

            var series = new OxyPlot.Series.ScatterSeries();

            series.Points.Add(new ScatterPoint(0, Percentage1));
            if (ElongationReading12 > 0 && ElongationReading22 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation32, Percentage2));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation32, YValue = Percentage2 });
            }
            if (ElongationReading13 > 0 && ElongationReading23 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation33, Percentage3));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation33, YValue = Percentage3 });
            }
            if (ElongationReading14 > 0 && ElongationReading24 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation34, Percentage4));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation34, YValue = Percentage4 });
            }
            if (ElongationReading15 > 0 && ElongationReading25 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation35, Percentage5));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation35, YValue = Percentage5 });
            }
            if (ElongationReading16 > 0 && ElongationReading26 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation36, Percentage6));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation36, YValue = Percentage6 });
            }
            if (ElongationReading17 > 0 && ElongationReading27 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation37, Percentage7));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation37, YValue = Percentage7 });
            }
            if (ElongationReading18 > 0 && ElongationReading28 > 0)
            {
                series.Points.Add(new ScatterPoint(MeasuredElongation38, Percentage8));
                scatterData.Add(new ScatterDataPoint() { XValue = MeasuredElongation38, YValue = Percentage8 });
            }

            //ScatterChartModel.Series.Add(series);

            double[] x_values = series.Points.Select(point1 => point1.X).ToArray();
            double[] y_Values = series.Points.Select(point2 => point2.Y).ToArray();

            //double[] x_values = { per };
            //double[] y_Values = series.Points.Select(point2 => point2.Y).ToArray();
            //double[] x_values = scatterData.Select(point1 => point1.XValue).ToArray();
            //double[] y_Values = scatterData.Select(point2 => point2.YValue).ToArray();
            double slope, intercept;
            LinearRegression(x_values, y_Values, out slope, out intercept);

            //var trendline = new FunctionSeries(z => slope * z + intercept, 0, 2, 0.1);
            //trendline.Color = OxyColors.Red;
            //ScatterChartModel.Series.Add(trendline);

            TrendlineEquation = $"Trendline Equation: y = {slope:F2}x + {intercept:F2}";

            double xValue = (0 - intercept) / slope;
            double yValue = 0;
            CorrectionFactorForICJ = Math.Round(Math.Abs(xValue), 1);

            //scatterData.Add(new ScatterDataPoint() { XValue = xValue, YValue = yValue });

            CalculateAvgElongationAndSlip();
            ScatterData = scatterData;
            //var pointAnnotation = new PointAnnotation
            //{
            //    X = xValue,
            //    Y = yValue,
            //    Text = $"({xValue:F2}, {yValue:F2})"
            //};
            //ScatterChartModel.Annotations.Add(pointAnnotation);
        }

        private void CalculateAvgElongationAndSlip()
        {
            double _avgMeasuredElongation = 0;
            if (MeasuredElongation38 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation38;
            }
            else if (MeasuredElongation37 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation37;

            }
            else if (MeasuredElongation36 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation36;

            }
            else if (MeasuredElongation35 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation35;

            }
            else if (MeasuredElongation34 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation34;

            }
            else if (MeasuredElongation33 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation33;

            }
            else if (MeasuredElongation32 > 0)
            {
                _avgMeasuredElongation = MeasuredElongation32;
            }
            AverageElongation = _avgMeasuredElongation + CorrectionFactorForICJ;
            AverageSlip = (NetSlipAtEnd1 + NetSlipAtEnd2) / 2;

            string checkElongation = $"{Environment.NewLine}{Environment.NewLine}({AverageElongation} < {DesignElongation}){Environment.NewLine}Not Ok";
            string checkSlip = $"{Environment.NewLine}{Environment.NewLine}({AverageSlip} > {DesignCableSlip}){Environment.NewLine}Not Ok";

            if (AverageElongation > DesignElongation)
            {
                checkElongation = $"{Environment.NewLine}{Environment.NewLine}({AverageElongation} > {DesignElongation}){Environment.NewLine}Ok";
            }
            if (AverageSlip < DesignCableSlip)
                checkSlip = $"{Environment.NewLine}{Environment.NewLine}({AverageSlip} < {DesignCableSlip}){Environment.NewLine}Ok";

            

            AverageElongationText = $"{AverageElongation}{checkElongation}";
            AverageSlipText = $"{AverageSlip}{checkSlip}";
        }

        private static void LinearRegression(double[] xVals, double[] yVals, out double slope, out double intercept)
        {
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
            int n = xVals.Length;

            for (int i = 0; i < n; i++)
            {
                sumX += xVals[i];
                sumY += yVals[i];
                sumXY += xVals[i] * yVals[i];
                sumX2 += xVals[i] * xVals[i];
            }

            double det = n * sumX2 - sumX * sumX;

            slope = (n * sumXY - sumX * sumY) / det;
            intercept = (sumY * sumX2 - sumX * sumXY) / det;
        }


        #endregion

        #region Exporting to Pdf

        private SfChart myChart;

        public SfChart MyChart {
            get => myChart;
            set => SetProperty(ref myChart, value); 
        }

        #endregion
    }

    public class ScatterDataPoint
    {
        public double XValue { get; set; }
        public double YValue { get; set; }
    }

}
