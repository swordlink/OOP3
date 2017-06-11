using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form1En : Form
    {
        private SerialPort myData;
        public static int i = 0;
        public static string[] Car = new string[10];
        public Form1En()
        {
            InitializeComponent();
           // Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Gate Open";
            pictureBox1.Image=WindowsFormsApplication1.Properties.Resources.Open;
            //myData.Write("N");
            Car[i] = textBox3.Text;
            

           
           // CarPark.SavePlate((textBox3.Text));
           //string txt = CarPark.Car[i];
            MessageBox.Show(Car[i], "System");
            i++;
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2En q = new Form2En();
            q.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Gate Close";
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Close;
            int no = i - 1;
            MessageBox.Show(CarPark.Car[no]);
            //myData.Write("F");
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Init()
        {
            /*
            myData = new SerialPort();
            myData.BaudRate = 9600;
            myData.PortName = "COM4";
            myData.Open();
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
