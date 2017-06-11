using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormLoc : Form
    {
       // public string[] Car = Form1En.Car;

        public FormLoc()
        {

            InitializeComponent();

            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Form1En.Car[1]);

            Reserve r1 = new Reserve("Reserve", "Ground", "A4");

            

            Location L1 = new Location(r1);

         L1.Cetak1();

     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1En.Car[2]);

            Disabled d1 = new Disabled("Disabled", "Ground", "B1");

            Location L1 = new Location(d1);

            L1.Cetak2();
        }
    }
}
