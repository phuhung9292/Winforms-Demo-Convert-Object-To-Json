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
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Timers;

namespace GasApp
{
    public partial class Form1 : Form
    {
        static dynamic mqttFactory = new MqttFactory();
        IMqttClient client = mqttFactory.CreateMqttClient();
        System.Timers.Timer timer;
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
            PublicMessageAsync(client, output1);


            //MessageBox.Show(output1);
        }
        private async Task mq()
        {

            var options = new MqttClientOptionsBuilder().
                 WithClientId(Guid.NewGuid().ToString())
                 .WithCredentials(textBox26.Text, textBox27.Text)
                 .WithTcpServer(ip.Text, int.Parse(port.Text))

                 .WithCleanSession()
                .Build();
            client.UseConnectedHandler(e =>
            {
                Console.WriteLine("connected");
            });
            client.UseDisconnectedHandler(e =>
            {
                Console.WriteLine("Disconnect");
            });
            await client.ConnectAsync(options);

            //await 



        }

        private async Task PublicMessageAsync(IMqttClient client, string output1)
        {
            string messagePayLoad = output1;
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(textBox28.Text).
                WithPayload(messagePayLoad)
                .WithAtLeastOnceQoS()
                .Build();
            if (client.IsConnected)
            {
                await client.PublishAsync(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mq();
            MessageBox.Show("connect success");
        }




        private void textBox29_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox29.Text)) {
               
                timer = new System.Timers.Timer();
                timer.Interval = int.Parse(textBox29.Text)*1000;
                timer.Elapsed += OnTimeEvent;
                
            }
           
            }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (textBox29.Text != null)
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
                    PublicMessageAsync(client, output1);
                }
            }));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Interval =
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            textBox29.Text = null;
        }
    }
        
    }

