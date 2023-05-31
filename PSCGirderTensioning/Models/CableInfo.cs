using PSCGirderTensioning.AdditionalSupports;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSCGirderTensioning.Models
{
    [Serializable]
    public class CableInfo
    {
        [PrimaryKey] 
        public string cableId { get; set; }
        public string bridgeId { get; set; }
        public string spanId { get; set; }
        public string girderId { get; set; }

        #region General Information
        public int cableNo { get; set; }
        public DateTime tensioningDate { get; set; } = DateTime.Today;
        public int stressingStageOfCable { get; set; } = 1;
        public string jackIDEnd1 { get; set; } = string.Empty;
        public string jackIDEnd2 { get; set; } = string.Empty;

        public string cableNoText { get; set; } = string.Empty;
        public string stressingStageOfCableText { get; set; } = string.Empty;

        #endregion

        #region Design Information

        public double diaOfStrand_mm { get; set; } = 12.70;
        public int nosOfStrandOrCable { get; set; } = 12;
        public string anchorageBrand { get; set; } = string.Empty;
        public double UTSofStrand_Npermm2 { get; set; } = 0;
        public double modulusOfElasticityE_kNpermm2 { get; set; } = 197;
        public double areaOfStrandA_mm2 { get; set; } = 98.70;
        //public double areaOfCable_mm2 { get; set; }
        public double designJackingForceP { get; set; } = 0;
        public string designJackingForceUnit { get; set; } = UnitsEnum.kN.ToString();
        public double designElongation_mm { get; set; } = 0;
        public double designGrippingLength_mm { get; set; } = 0;
        public double actualGrippingLength_mm { get; set; } = 0;
        //public double correctedElongationForGripLength_mm { get; set; }
        public double designCableSlip_mm { get; set; } = 6;
        public double designConcreteStrength_Npermm2 { get; set; } = 0;
        public double actualConcreteStrength_Npermm2 { get; set; } = 0;

        #endregion

        #region Stressing & Jack Information

        public string jackModelNoAndEffi1 { get; set; } = string.Empty;
        public string jackModelNoAndEffi2 { get; set; } = string.Empty;
        public string pressureGaugeModel1 { get; set; } = string.Empty;
        public string pressureGaugeModel2 { get; set; } = string.Empty;
        public string tensioningRamArea1_cm2 { get; set; } = string.Empty;
        public string tensioningRamArea2_cm2 { get; set; } = string.Empty;
        public string blockingRamArea1_cm2 { get; set; } = string.Empty;
        public string blockingRamArea2_cm2 { get; set; } = string.Empty;

        public double actualAreaOfStrandA1_mm2 { get; set; } = 0;
        public double modulusOfElasticityE1_kNpermm2 { get; set; } = 0;
        //public double CorrectedElongationForActualA1E1_mm { get; set; }
        //public double actualCalculatedElongationForGripLength_mm { get; set; }
        //public double grossSlipEnd1_mm { get; set; }
        //public double grossSlipEnd2_mm { get; set; }
        //public double netSlipEnd1_mm { get; set; }
        //public double netSlipEnd2_mm { get; set; }

        public int percentage1 { get; set; } = 20;
        public int percentage2 { get; set; } = 40;
        public int percentage3 { get; set; } = 60;
        public int percentage4 { get; set; } = 80;
        public int percentage5 { get; set; } = 95;
        public int percentage6 { get; set; } = 100;
        public int percentage7 { get; set; } = 103;
        public int percentage8 { get; set; } = 105;

        public double elongationReading11 { get; set; } = 0;
        public double elongationReading12 { get; set; } = 0;
        public double elongationReading13 { get; set; } = 0;
        public double elongationReading14 { get; set; } = 0;
        public double elongationReading15 { get; set; } = 0;
        public double elongationReading16 { get; set; } = 0;
        public double elongationReading17 { get; set; } = 0;
        public double elongationReading18 { get; set; } = 0;

        public double elongationReading21 { get; set; } = 0;
        public double elongationReading22 { get; set; } = 0;
        public double elongationReading23 { get; set; } = 0;
        public double elongationReading24 { get; set; } = 0;
        public double elongationReading25 { get; set; } = 0;
        public double elongationReading26 { get; set; } = 0;
        public double elongationReading27 { get; set; } = 0;
        public double elongationReading28 { get; set; }  = 0;

        public double lockOff1 { get; set; } = 0;
        public double lockOff2 { get; set; } = 0;
        public string remarks { get; set; } = string.Empty;

        #endregion
    }
}
