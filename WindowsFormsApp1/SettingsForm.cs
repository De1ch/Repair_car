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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Language.ExitRequest, Language.ExitTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new System.Globalization.CultureInfo[]{
        System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
        System.Globalization.CultureInfo.GetCultureInfo("en-US")
            };

            comboBox1.DisplayMember = "NativeName"; 
            comboBox1.ValueMember = "Name";

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBox1.SelectedValue = Properties.Settings.Default.Language;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
