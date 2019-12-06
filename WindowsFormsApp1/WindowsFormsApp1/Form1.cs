using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string[,] elements = { {"Голова", "Глаза", "Нос", "Рот", "Волосы"},
                               {"1", "2", "3", "4", "5"}};
        Image[,] images;
        Image[,] images1;
        int CurrentIndex = 0;
        int CurrentIndex1 = 0;
        public Form1()
        {
            InitializeComponent();
            images = new Image[elements.GetLength(0), elements.GetLength(1)];
            images[0, 0] = new Bitmap("D:1.png");
            images[0, 1] = new Bitmap("D:2.png");
            images[0, 2] = new Bitmap("D:3.png");
            images[0, 3] = new Bitmap("D:4.png");
            images[0, 4] = new Bitmap("D:5.png");
            images1 = new Image[elements.GetLength(0), elements.GetLength(1)];
            images1[1, 0] = new Bitmap("D:g1.png");
            images1[1, 1] = new Bitmap("D:g2.png");
            images1[1, 2] = new Bitmap("D:g3.png");
            images1[1, 3] = new Bitmap("D:g4.png");
            images1[1, 4] = new Bitmap("D:g5.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void UpdateListBox(int ItemsIndex)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < elements.GetLength(1); i++)
                listBox1.Items.Add(elements[0, ItemsIndex] + " " + elements[1, i]);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CurrentIndex = 0;
            UpdateListBox(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CurrentIndex1 = 1;
            UpdateListBox(1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CurrentIndex = 2;
            UpdateListBox(2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CurrentIndex = 3;
            UpdateListBox(3);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CurrentIndex = 4;
            UpdateListBox(4);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;


            (this.Controls["pictureBox" + (CurrentIndex + 1).ToString()] as PictureBox).Image = images[CurrentIndex][listBox1.SelectedIndex];




        }
    }
}

