using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RepairForm : Form
    {

        public RepairForm()
        {
            InitializeComponent();

            comboBox1.Validated += comboBox1_Validated;
            errorProvider1.SetIconAlignment(comboBox1, ErrorIconAlignment.MiddleRight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void SelectModel()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A3");
                comboBox2.Items.Add("A4");
                comboBox2.Items.Add("A8");
                comboBox2.Items.Add("RS6");
                comboBox2.Items.Add("RS7");
                comboBox2.Items.Add("S4");
                comboBox2.Items.Add("S7");
                comboBox2.Items.Add("SQ2");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("1 series");
                comboBox2.Items.Add("3 series");
                comboBox2.Items.Add("5 series GT");
                comboBox2.Items.Add("i3");
                comboBox2.Items.Add("i8");
                comboBox2.Items.Add("M4");
                comboBox2.Items.Add("M5");
                comboBox2.Items.Add("M6");
                comboBox2.Items.Add("X7");
                comboBox2.Items.Add("Z4");
                comboBox2.Items.Add("X2");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Alero");
                comboBox2.Items.Add("Aveo");
                comboBox2.Items.Add("Blazer");
                comboBox2.Items.Add("Camaro");
                comboBox2.Items.Add("Cobalt");
                comboBox2.Items.Add("Cruze");
                comboBox2.Items.Add("Evanda");
                comboBox2.Items.Add("Impala");
                comboBox2.Items.Add("Lanos");
                comboBox2.Items.Add("Orlando");
                comboBox2.Items.Add("Tahoe");
                comboBox2.Items.Add("Volt");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Crown Victoria");
                comboBox2.Items.Add("Edge");
                comboBox2.Items.Add("Escort");
                comboBox2.Items.Add("Explorer");
                comboBox2.Items.Add("F-150");
                comboBox2.Items.Add("Focus");
                comboBox2.Items.Add("Ranger");
                comboBox2.Items.Add("Taurus");
                comboBox2.Items.Add("Transit Connect");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Accord");
                comboBox2.Items.Add("Civic Type R");
                comboBox2.Items.Add("Civic");
                comboBox2.Items.Add("CR-V");
                comboBox2.Items.Add("Fit");
                comboBox2.Items.Add("FR-V");
                comboBox2.Items.Add("Jazz");
                comboBox2.Items.Add("Legend");
                comboBox2.Items.Add("Passport");
                comboBox2.Items.Add("Pilot");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CX-3");
                comboBox2.Items.Add("CX-4");
                comboBox2.Items.Add("CX-30");
                comboBox2.Items.Add("CX-9");
                comboBox2.Items.Add("MPV");
                comboBox2.Items.Add("MX-30");
            }
            if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AMG GT");
                comboBox2.Items.Add("AMG GT C");
                comboBox2.Items.Add("B-Class Electric Drive");
                comboBox2.Items.Add("C-Class");
                comboBox2.Items.Add("SLS AMG");
                comboBox2.Items.Add("C-Class AMG");
                comboBox2.Items.Add("SLC");
                comboBox2.Items.Add("S-Class");
                comboBox2.Items.Add("M-Class");
                comboBox2.Items.Add("Vito");
                comboBox2.Items.Add("Viano");
                comboBox2.Items.Add("X-Class");
            }
            if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("350Z");
                comboBox2.Items.Add("Almera");
                comboBox2.Items.Add("370Z");
                comboBox2.Items.Add("Cube");
                comboBox2.Items.Add("Fuga");
                comboBox2.Items.Add("GT-R");
                comboBox2.Items.Add("Juke");
                comboBox2.Items.Add("Juke Nismo RS");
                comboBox2.Items.Add("Maxima");
                comboBox2.Items.Add("Pathfinder");
                comboBox2.Items.Add("Primera");
                comboBox2.Items.Add("Qashqai");
            }
            if (comboBox1.SelectedIndex == 8)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Alphard");
                comboBox2.Items.Add("Avalon");
                comboBox2.Items.Add("Celica");
                comboBox2.Items.Add("C-HR");
                comboBox2.Items.Add("Crown");
                comboBox2.Items.Add("Land Cruiser");
                comboBox2.Items.Add("Corolla");
                comboBox2.Items.Add("RAV4");
                comboBox2.Items.Add("Prius");
                comboBox2.Items.Add("Supra");
                comboBox2.Items.Add("4Runner");
                comboBox2.Items.Add("Venza");
                comboBox2.Items.Add("Verso");
            }
            if (comboBox1.SelectedIndex == 9)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Jetta");
                comboBox2.Items.Add("Golf Plus");
                comboBox2.Items.Add("Golf GTI");
                comboBox2.Items.Add("Golf");
                comboBox2.Items.Add("Cross Polo");
                comboBox2.Items.Add("Scirocco");
                comboBox2.Items.Add("Sharan");
                comboBox2.Items.Add("Tarek");
                comboBox2.Items.Add("T-Cross");
                comboBox2.Items.Add("Teramont");
                comboBox2.Items.Add("Tiguan");
                comboBox2.Items.Add("Touareg");
                comboBox2.Items.Add("Touran");
                comboBox2.Items.Add("Transporter");
                comboBox2.Items.Add("XL1");
            }
        }

        private void EngineRepair()
        { 
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
               // richTextBox1.Hide();
                pictureBox1.Hide();
               // webBrowser1.Refresh();
               // webBrowser1.Show();

               // webBrowser1.Url = new Uri("https://www.bmwstyle.ru/8-bmw-world/12-bmw-engine-motors/2291-bmw-engine-repair/");

                StreamReader sr = new StreamReader("Engine/BMW.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            else
            {
                richTextBox1.Clear();
                pictureBox1.Show();
                richTextBox1.Text = "Укажите марку и модель автомобиля!";

            }
            if (comboBox1.SelectedIndex == 2 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Chevrolet.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 3 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Ford.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 4 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Honda.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 5 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Mazda.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 6 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Mercedes-Benz.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 7 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Nissan.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 8 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Toyota.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 9 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Engine/Volkswagen.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
        }

        private void EngineRepairAudi()
        {
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 0)
            {
                richTextBox1.Clear();
                // richTextBox1.Hide();
                pictureBox1.Hide();
                // webBrowser1.Show();
                // webBrowser1.Refresh();

                // webBrowser1.Url = new Uri ("https://www.mehanika.ru/informatory/publications/kolonka-mastera/remont-dvigatelya-audi/");

                StreamReader sr = new StreamReader("Engine/Audi/A1.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/A3.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 2)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/A4.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 3)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/A8.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 4)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/RS6.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 5)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/RS7.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 6)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/S4.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 7)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/S7.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 8)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/SQ2.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
        }

        private void TransmissionRepair()
        {
            if (comboBox1.SelectedIndex == 2 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Chevrolet.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            else
            {
                richTextBox1.Clear();
                pictureBox1.Show();
                richTextBox1.Text = "Укажите марку и модель автомобиля!";

            }
            if (comboBox1.SelectedIndex == 3 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Ford.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 4 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Honda.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 5 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Mazda.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 6 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Mercedes-Benz.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 7 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Nissan.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 8 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Toyota.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 9 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Transmission/Volkswagen.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
        }

        private void TransmissionRepairAudi()
        {
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 0)
            {
                richTextBox1.Clear();
                // richTextBox1.Hide();
                pictureBox1.Hide();
                // webBrowser1.Show();
                // webBrowser1.Refresh();

                // webBrowser1.Url = new Uri ("https://www.mehanika.ru/informatory/publications/kolonka-mastera/remont-dvigatelya-audi/");

                StreamReader sr = new StreamReader("Transmission/Audi/A1.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Transmission/Audi/A3.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 2)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Transmission/Audi/A4.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 3)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Transmission/Audi/A8.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 4)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Transmission/Audi/RS6.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 5)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Transmission/Audi/RS7.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 6)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Transmission/Audi/S4.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 7)
            {
                richTextBox1.Clear();

                pictureBox1.Hide(); 

                StreamReader sr = new StreamReader("Transmission/Audi/S7.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 8)
            {
                richTextBox1.Clear();
               
                pictureBox1.Hide();      

                StreamReader sr = new StreamReader("Transmission/Audi/SQ2.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
        }

        private void SuspensionRepair()
        {
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/BMW.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            else
            {
                richTextBox1.Clear();
                pictureBox1.Show();
                richTextBox1.Text = "Укажите марку и модель автомобиля!";

            }
            if (comboBox1.SelectedIndex == 2 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Chevrolet.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 3 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Ford.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 4 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Honda.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 5 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Mazda.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 6 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Mercedes-Benz.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 7 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Nissan.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 8 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Toyota.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 9 & comboBox2.SelectedIndex >= 0)
            {
                richTextBox1.Clear();
                pictureBox1.Hide();
                StreamReader sr = new StreamReader("Suspension/Volkswagen.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
        }

        private void SuspensionRepairAudi()
        {
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 0)
            {
                richTextBox1.Clear();
                // richTextBox1.Hide();
                pictureBox1.Hide();
                // webBrowser1.Show();
                // webBrowser1.Refresh();

                // webBrowser1.Url = new Uri ("https://www.mehanika.ru/informatory/publications/kolonka-mastera/remont-dvigatelya-audi/");

                StreamReader sr = new StreamReader("Suspension/Audi/A1.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Suspension/Audi/A3.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 2)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Suspension/Audi/A4.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 3)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Suspension/Audi/A8.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 4)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/RS6.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 5)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Engine/Audi/RS7.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 6)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Suspension/Audi/S4.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 7)
            {
                richTextBox1.Clear();

                pictureBox1.Hide();

                StreamReader sr = new StreamReader("Suspension/Audi/S7.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 8)
            {
                richTextBox1.Clear();
                // richTextBox1.Hide();
                pictureBox1.Hide();
                // webBrowser1.Show();
                // webBrowser1.Refresh();

                // webBrowser1.Url = new Uri ("https://www.mehanika.ru/informatory/publications/kolonka-mastera/remont-dvigatelya-audi/");

                StreamReader sr = new StreamReader("Suspension/Audi/SQ2.txt", System.Text.Encoding.Unicode);

                while (!sr.EndOfStream)
                    richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form mfrm = Application.OpenForms[0];
            mfrm.StartPosition = FormStartPosition.Manual;
            mfrm.Show();
            this.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void comboBox1_Validated(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == -1)
                errorProvider1.SetError(comboBox1, "Выберите марку автомобиля");
            else
                errorProvider1.SetError(comboBox1, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EngineRepair();
            EngineRepairAudi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             TransmissionRepair();
             TransmissionRepairAudi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             SuspensionRepair();
             SuspensionRepairAudi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // unactive 
            TransmissionRepair();
            TransmissionRepairAudi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // unactive 
            EngineRepair();
            EngineRepairAudi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectModel();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }


        private void RepairForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pictureBox1.BackColor = Color.Transparent;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
} 