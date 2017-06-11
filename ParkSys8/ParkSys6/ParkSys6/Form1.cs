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
    public partial class Form1 : Form
    {
        public Form1()
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


            Reserve r1 = new Reserve("Reserve", "Ground", "A4");

            Disabled d1 = new Disabled("-", "-", "-");

            Location L1 = new Location(r1,d1);

         L1.Print();

     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reserve r1 = new Reserve("-", "-", "-");

            Disabled d1 = new Disabled("Disabled", "Ground", "B1");

            Location L2 = new Location(r1,d1);

            L2.Print();
        }
    }
}
