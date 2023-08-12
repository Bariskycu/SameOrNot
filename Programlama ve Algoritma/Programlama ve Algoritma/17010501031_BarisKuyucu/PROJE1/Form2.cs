using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int sayac = 60;
        public static int S = 0;
        public static int T = 0;
        public static int D = 0;
        public static int Y = 0;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sayac == 0)
            {
                timer1.Stop();
                Form3 form = new PROJE1.Form3();
                this.Hide();
                form.Show();
            }
            else
            {
                sayac--;
                label2.Text = sayac.ToString();
            }
                
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = sayac.ToString();
            label4.Text = 0.ToString();
            label5.Text = 0.ToString();
            this.BackColor = Color.FromArgb(255, 242, 226);
            timer1.Interval = 1000;
            timer1.Start();
            loope();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (S == 0)
            {
                D++;
                label4.Text = D.ToString();
                
            }
            if (S == 1)
            {
                Y++;
                label5.Text = Y.ToString();
               
            }
            loope();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(S == 1)
            {
                D++;
                label4.Text = D.ToString();
                loope();
            }
            if (S == 0)
            {
                Y++;
                label5.Text = Y.ToString();
                
            }
            loope();
        }

        public void loope()
        {
            Random kek = new Random();
            S = kek.Next(2);
            
            if (S == 0)
            {
                T = kek.Next(4);
                switch (T)
                {
                    case 0:
                        pictureBox1.Image = Image.FromFile("1D.png");
                        
                        break;
                    case 1:
                        pictureBox1.Image = Image.FromFile("2D.png");
                        
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("3D.png");
                        
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("4D.png");
                        
                        break;


                }

            }
            else
            {
                T = kek.Next(4);
                switch (T)
                {
                    case 0:
                        pictureBox1.Image = Image.FromFile("1Y.png");
                       
                        break;
                    case 1:
                        pictureBox1.Image = Image.FromFile("2Y.png");
                       
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("3Y.png");
                        
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("4Y.png");
                        
                        break;
                }
            }
            
        }
    }
}
