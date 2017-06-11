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
  struct Park
    {
        public int index;
        public string noPlate;
        public string lot;
        public string level;
        public bool vacancy;  // parkig kosng ke tak
    }
    
 
    public partial class Form1En : Form
    {
       Park[] myPark = new Park[10];
        public string[] normalLot = new string[5] {"C1","C2","C3","C4","C5"};

        private SerialPort myData;
        public static int i = 0;
        public static string[] Car = new string[10];
        public string plate;
        public Form1En()
        {
            loadArray();
            loadParkToList();
            InitializeComponent();
           // Init();
            
        }

        private void button1_Click(object sender, EventArgs e)  //niii button save
        {
            label1.Text = "Gate Open";
            pictureBox1.Image=WindowsFormsApplication1.Properties.Resources.Open;
            //myData.Write("N");
            plate = textBox3.Text;
            

           
           // CarPark.SavePlate((textBox3.Text));
           //string txt = CarPark.Car[i];
           // MessageBox.Show(Car[i], "System");
            //i++;
           


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
           // MessageBox.Show(CarPark.Car[no]);
            //myData.Write("F");

            Form2En q = new Form2En();
            q.Show();
           
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

        private void loadArray() 
        {
            int j = 0;
            for (int i=0; i< normalLot.Length; i++)
            {
                myPark[i].index = i;
                myPark[i].lot = normalLot[i];
                myPark[i].level = "G";
                j++;

            }

            for (int i = 0; i < Reserve.lot.Length; i++)
            {
                myPark[j].index = j + 1;
                myPark[j].lot = Reserve.lot[i];
                myPark[j].level = "G";
                j++;
            }

            for (int i = 0; i < Disabled.lot.Length;i++ )
            {
                myPark[j].index = j + 1;
                myPark[j].lot = Disabled.lot[i];
                myPark[j].level = "G";
                j++;

            }
        }

        private void loadParkToList ()
        {
            for (int i = 0; i < 10; i++)
            {
                Car[i] = myPark[i].lot;
               
            }
        
        
        
        
        }
    }
}
