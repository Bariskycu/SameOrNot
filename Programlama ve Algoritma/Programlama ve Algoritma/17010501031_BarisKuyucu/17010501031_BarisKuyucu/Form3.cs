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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = Form2.D.ToString();
            label5.Text = Form2.Y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.sayac = 60;
            Form2.S = 0;
            Form2.T = 0;
            Form2.D = 0;
            Form2.Y = 0;
        Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
