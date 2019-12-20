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
    public partial class Form1 : Form
    {
        private int rj, rz;
        private PictureBox fruit;
        private PictureBox[] Snake = new PictureBox[400];
        private Label labelscore;
        private int dirx, diry;
        private int _width = 900;
        private int _height = 800;
        private int _sizeofsides = 40;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "snake";
            this.Width = _width;
            this.Height = _height;
            dirx = 1;
            diry = 0;
            labelscore = new Label();
            labelscore.Text = "Score:0";
            labelscore.Location = new Point(810, 10);
            this.Controls.Add(labelscore);
            Snake[0] = new PictureBox();
            Snake[0].Location = new Point(201, 201);
            Snake[0].Size = new Size(_sizeofsides - 1, _sizeofsides - 1);
            Snake[0].BackColor = Color.Red;
            this.Controls.Add(Snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Green;
            fruit.Size = new Size(_sizeofsides, _sizeofsides);
            _generateMap();
            _generatefruit();
            timer.Tick += new EventHandler(_update);
            timer.Interval = 200;
            timer.Start();
            this.KeyDown += new KeyEventHandler(OKP);
            if (dirx != 1 && diry != 0)
            {
                dirx = -1; diry = 0;

            }
        }
        private void _generatefruit()
        {
            Random r = new Random();
            rj = r.Next(0, _height - _sizeofsides);
            int tempj = rj % _sizeofsides;
            rj -= tempj;
            rz = r.Next(0, _height - _sizeofsides);
            int tempz = rz % _sizeofsides;
            rz -= tempz;
            rj++;
            rz++;
            fruit.Location = new Point(rj, rz);
            this.Controls.Add(fruit);
        }
        private void _checkborders()
        {
            if (Snake[0].Location.X < 0)
            {
                for (int _j = 1; _j <= score; _j++)
                {
                    this.Controls.Remove(Snake[_j]);
                }
                score = 0;
                labelscore.Text = "Score: " + score;
                dirx = 1;
            }
            if (Snake[0].Location.X > _height)
            {
                for (int _j = 1; _j <= score; _j++)
                {
                    this.Controls.Remove(Snake[_j]);
                }
                score = 0;
                labelscore.Text = "Score: " + score;
                dirx = -1;
            }
            if (Snake[0].Location.Y < 0)
            {
                for (int _j = 1; _j <= score; _j++)
                {
                    this.Controls.Remove(Snake[_j]);
                }
                score = 0;
                labelscore.Text = "Score: " + score;
                diry = 1;
            }
            if (Snake[0].Location.Y > _height)
            {
                for (int _j = 1; _j <= score; _j++)
                {
                    this.Controls.Remove(Snake[_j]);
                }
                score = 0;
                labelscore.Text = "Score: " + score;
                diry = -1;
            }
        }
        private void _eatself()
        {
            for (int _j = 1; _j < score; _j++)
            {
                if (Snake[0].Location == Snake[_j].Location)
                {
                    for (int _z = _j; _z <= score; _z++)
                        this.Controls.Remove(Snake[_z]);
                    score = score - (score - _j + 1);
                    labelscore.Text = "Score: " + score;
                }
            }
        }
        private void _eatfruit()
        {
            if (Snake[0].Location.X == rj && Snake[0].Location.Y == rz)
            {
                labelscore.Text = "Score: " + ++score;
                Snake[score] = new PictureBox();
                Snake[score].Location = new Point(Snake[score - 1].Location.X + 40 * dirx, Snake[score - 1].Location.Y - 40 * diry);
                Snake[score].Size = new Size(_sizeofsides - 5, _sizeofsides - 5);
                Snake[score].BackColor = Color.Blue;
                this.Controls.Add(Snake[score]);
                _generatefruit();
            }
        }

        private void _generateMap()
        {
            for (int i = 0; i < _width / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeofsides * i);
                pic.Size = new Size(_width - 100, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i < _height / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeofsides * i, 0);
                pic.Size = new Size(1, _width);
                this.Controls.Add(pic);
            }
        }
        private void _moveshake()
        {
            for (int i = score; i >= 1; i--)
            {
                Snake[i].Location = Snake[i - 1].Location;
            }
            Snake[0].Location = new Point(Snake[0].Location.X + dirx * (_sizeofsides), Snake[0].Location.Y + diry * (_sizeofsides));
            _eatself();
        }

     
        private void _update(object myobject, EventArgs eventargs)
        {
            _checkborders();
            _eatfruit();
            _moveshake();
            // cube.Location = new Point(cube.Location.X + dirx * _sizeofsides, cube.Location.Y + diry * _sizeofsides);
        }
        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":

                    dirx = 1;
                    diry = 0;
                                        break;                                      
                case "Left":
                    dirx = -1;
                    diry = 0;
                    break;
                case "Up":
                    diry = -1;
                    dirx = 0;
                    break;
                case "Down":
                    diry = 1;
                    dirx = 0;
                    break;
                    
            }       
        } 

       
    }
}
