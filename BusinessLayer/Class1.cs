using System;

namespace BusinessLayer
{
    public class Class1
    {
        public double RBattery { get; set; }
        public double Temperature { get; set; }

        public double InputPressure { get; set; }
        public double SVA { get; set; }
        public double SVF { get; set; }
        public double GVF { get; set; }
        public double Vb_Today { get; set; }
        public double Vm_ToDay { get; set; }
        public double Vb_Yesterday { get; set; }
        public double Vm_Yesterday { get; set; }
        public double GVA { get; set; }

        public double Output_Presser { get; set; }
        public byte ZSC { get; set; }
        public byte MAC_1 { get; set; }
        public byte UPS_RUNNING { get; set; }
        public byte CHARGING { get; set; }
        public byte SD_1 { get; set; }
        public byte SELECT_SW { get; set; }
        public byte RESET { get; set; }
        public byte EMER_NO { get; set; }
        public byte UPS_STATUS { get; set; }
        public byte HR_1 { get; set; }
        public byte BC_1 { get; set; }
        public byte SV_1 { get; set; }
    }
}
