using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
        }

        private async  void button5_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            int y=pictureBox1.Location.Y;
            int x = pictureBox1.Location.X;
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            while (pictureBox1.Location.Y - 5> 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-5);
                await Task.Delay(1);
            }
            while (pictureBox1.Location.X - 5 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            while (pictureBox1.Location.Y + 5 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
                await Task.Delay(1);
            }
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            while (pictureBox1.Location.Y - 5 > y)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
                await Task.Delay(1);
            }
            while (pictureBox1.Location.X - 5 > x)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            int x = ClientRectangle.Width / 2 - pictureBox1.Width / 2;
            int y = ClientRectangle.Height / 2 - pictureBox1.Height / 2;
            if (x> pictureBox1.Location.X)
            {
                while (pictureBox1.Location.X + 5 < x)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X+5, pictureBox1.Location.Y);
                    await Task.Delay(1);
                }
            }
            else
            {
                while (pictureBox1.Location.X - 5 > x)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                    await Task.Delay(1);
                }
            }
            if (y > pictureBox1.Location.Y)
            {
                while (pictureBox1.Location.Y + 5 < y)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+5);
                    await Task.Delay(1);
                }
            }
            else
            {
                while (pictureBox1.Location.Y - 5 > y)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-5);
                    await Task.Delay(1);
                }
            }
        }
    }
}
