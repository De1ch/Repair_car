using MySql.Data.MySqlClient;
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
    public partial class HelpForm : Form
    {
        public HelpForm()
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

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `problems` (`mail`, `problem`, `problem_info`) VALUES (NULL, @mail, @problem, @problem_info);", db.getConnection());

            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = TextBox1.Text;
            command.Parameters.Add("@problem", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@problem_info", MySqlDbType.VarChar).Value = richTextBox1.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("ne ok");

            db.closeConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
