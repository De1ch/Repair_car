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

        private void AboutAuto()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string path = Application.StartupPath + @"\AboutCars\Audi\Audi.html";
                webBrowser1.Navigate(path);
            }
            else
            {
                string path = Application.StartupPath + @"\AboutCars\Change.html";
                webBrowser1.Navigate(path);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string path = Application.StartupPath + @"\AboutCars\BMW\BMW.html";
                webBrowser1.Navigate(path);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                
            }
            if (comboBox1.SelectedIndex == 3)
            {
                
            }
            if (comboBox1.SelectedIndex == 4)
            {
                
            }
            if (comboBox1.SelectedIndex == 5)
            {
                
            }
            if (comboBox1.SelectedIndex == 6)
            {
                
            }
            if (comboBox1.SelectedIndex == 7)
            {
                
            }
            if (comboBox1.SelectedIndex == 8)
            {

            }
            if (comboBox1.SelectedIndex == 9)
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
            string path = Application.StartupPath + @"\AboutCars\Change.html";
            webBrowser1.Navigate(path);

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
