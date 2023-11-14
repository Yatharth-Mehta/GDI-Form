using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Darkside_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            Pen pen = new Pen(Color.Red, 2);
            var graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.White);

            

            string x = textBox1.Text;
            string[] xyz = new string[5];
            int i = 0;
            x.ToLower();
            foreach (var a in x.Split(' '))
            {
                xyz[i] = a;
                i++;
            }

            string y = textBox2.Text;
            string[] wxy = new string[5];
            int j = 0;
            y.ToLower();
            foreach (var a in y.Split(' '))
            {
                wxy[j] = a;
                j++;
            }

            //Single Line Commands 

            if (xyz[0].Equals("circle")) // CIRCLE
            { 
                if (xyz[1] is null)
                {
                    graphics.DrawEllipse(pen, 0, 0, 50, 50);
                }
                else
                {
                    Circle c = new Circle(int.Parse(xyz[1]));
                    c.draw(graphics, pen);
                }
            }


                else if (xyz[0].Equals("square")) // SQUARE
            {
                    if (xyz[1] is null && xyz[2] is null)
                    {
                        graphics.DrawRectangle(pen, 0, 0, 100, 100);
                    }
                    else
                    {
                        Square sq = new Square(int.Parse(xyz[1]), int.Parse(xyz[2]));
                        sq.draw(graphics, pen);
                    }
                }
                else if (xyz[0].Equals("triangle")) //Triangle
                {
                    Triangle tri = new Triangle(graphics, pen);
                }
                else if (xyz[0].Equals("clear"))
                {
                    graphics.Clear(Color.White);
                }
                else
                {}






            if (wxy[0].Equals("circle")) // CIRCLE
            {
                if (wxy[1] is null)
                {
                    graphics.DrawEllipse(pen, 0, 0, 50, 50);
                }
                else
                {
                    Circle c = new Circle(int.Parse(wxy[1]));
                    c.draw(graphics, pen);
                }
            }


            else if (wxy[0].Equals("square")) // SQUARE
            {
                if (wxy[1] is null && wxy[2] is null)
                {
                    graphics.DrawRectangle(pen, 0, 0, 100, 100);
                }
                else
                {
                    Square sq = new Square(int.Parse(wxy[1]), int.Parse(wxy[2]));
                    sq.draw(graphics, pen);
                }
            }
            else if (wxy[0].Equals("triangle")) //Triangle
            {
                Triangle tri = new Triangle(graphics, pen);
            }
            else if (wxy[0].Equals("clear"))
            {
                graphics.Clear(Color.White);
            }
            else
            { }


            if (xyz[0] == "" && wxy[0] == "")
            {
                textBox3.Text = "Enter a Command";
            }
            pictureBox1.Refresh();
            }
            

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
