using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newClass1 = new Class1
            {
                RBattery = double.Parse(textBox1.Text),
                Temperature = double.Parse(textBox2.Text),
                InputPressure = double.Parse(textBox3.Text),
                SVA = double.Parse(textBox4.Text),
                SVF = double.Parse(textBox5.Text),
                GVF = double.Parse(textBox6.Text),
                Vb_Today = double.Parse(textBox7.Text),
                Vm_ToDay = double.Parse(textBox8.Text),
                Vb_Yesterday = double.Parse(textBox9.Text),
                Vm_Yesterday = double.Parse(textBox10.Text),
                GVA = double.Parse(textBox11.Text),
            };
            var newClass2 = new Class2
            {
                Output_Presser = double.Parse(textBox12.Text),
                ZSC = byte.Parse(textBox13.Text),
                MAC_1 = byte.Parse(textBox14.Text),
                UPS_RUNNING = byte.Parse(textBox15.Text),
                CHARGING = byte.Parse(textBox16.Text),
                SD_1 = byte.Parse(textBox17.Text),
                SELECT_SW = byte.Parse(textBox18.Text),
                RESET = byte.Parse(textBox19.Text),
                EMER_NO = byte.Parse(textBox20.Text),
                UPS_STATUS = byte.Parse(textBox21.Text),
                HR_1 = byte.Parse(textBox22.Text),
                BC_1 = byte.Parse(textBox23.Text),
                SV_1 = byte.Parse(textBox24.Text),
            };
            string output1 = JsonConvert.SerializeObject(newClass1);
            string output2 = JsonConvert.SerializeObject(newClass2);

            MessageBox.Show(output1,output2);
        }
    }
}
