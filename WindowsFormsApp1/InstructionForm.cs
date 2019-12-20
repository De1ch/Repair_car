using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InstructionForm : Form
    {
        public InstructionForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form mfrm = Application.OpenForms[0];
            mfrm.StartPosition = FormStartPosition.Manual;
            mfrm.Show();
            this.Hide();
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

        private void AboutAuto()
        {
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex >= 0)
            {
                webBrowser1.Navigate("http://www.cyberforum.ru/windows-forms/thread91197.html"); 
            }
            else
            {
                webBrowser1.DocumentText = "<html><body>ne rabotaet((((</body></html>";
            }
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 2 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 3 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 4 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 5 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 6 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 7 & comboBox2.SelectedIndex >= 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 8 & comboBox2.SelectedIndex >= 0)
            {

            }
            if (comboBox1.SelectedIndex == 9 & comboBox2.SelectedIndex >= 0)
            {

            }
        }

        private void InstructionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            toolStripButton2.Available = false;
            toolStripButton5.Available = true;
        }

        private void InstructionForm_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            toolStripButton5.Available = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }


        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            toolStripButton2.Available = true;
            toolStripButton5.Available = false;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectModel();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AboutAuto();
            groupBox1.Hide();
            toolStripButton2.Available = true;
            toolStripButton5.Available = false;
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
