using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
//using System.Windows.Controls.listboxitem;

namespace WindowsFormsApplication1
{
  struct Park
    {
        public int index;
        public string noPlate;
        public string lot;
        public string level;
        public bool vacancy;  // parking kosng ke tak
        public string code;

    }
    
 
    public partial class Form1En : Form
    {
        Park[] myPark = new Park[10];
        
        public string[] normalLot = new string[5] {"C1","C2","C3","C4","C5"};

        private SerialPort myData;
        public static int i = 0;
        public static string[] Car = new string[10];
        List<string> items = new List<string>();
        public string plate;
        private string choosen;
        private int size;
        public Form1En()
        {
           
            InitializeComponent();
            loadArray();
           // loadParkToList();
           // loadCode();
           // listBox1.DataSource = items;
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
            // Init();
           

        }

        private void button1_Click(object sender, EventArgs e)  //niii button save
        {
            label1.Text = "Gate Open";
            pictureBox1.Image=WindowsFormsApplication1.Properties.Resources.Open;
            //myData.Write("N");
            //listBox1.DataSource = null;
            //listBox1.DataSource = items;
            plate = textBox3.Text;
            
            loadParkToList();
          //  loadCode();



            // CarPark.SavePlate((textBox3.Text));
            //string txt = CarPark.Car[i];
            // MessageBox.Show(Car[i], "System");
            //i++;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string[] b = new string[2];
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
                myPark[i].vacancy = false;
                j++;

            }

            for (int i = 0; i < Reserve.lot.Length; i++)
            {
                myPark[j].index = j + 1;
                myPark[j].lot = Reserve.lot[i];
                myPark[j].level = "G";
                myPark[j].vacancy = false;
                j++;
            }

            for (int i = 0; i < Disabled.lot.Length;i++ )
            {
                myPark[j].index = j + 1;
                myPark[j].lot = Disabled.lot[i];
                myPark[j].level = "G";
                myPark[j].vacancy = false;
                j++;

            }
        }

        private  void loadParkToList ()
        {
            //listBox1.ClearSelected();
            listBox1.Items.Clear();
            size = 0;
            for (int i = 0; i < 10; i++)
            {
                // Car[i] = myPark[i].lot;
                //  items.Add(myPark[i].lot);
                // listBox1.Items.Add(Car[i]);
                if (myPark[i].vacancy==false)
                {
                    listBox1.Items.Add(myPark[i].lot);
                    Car[size] = myPark[i].lot;
                    size++;
                }
                else 
                {
                   // MessageBox.Show(myPark[i].lot);
                }

            }
             

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

       /* void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString());
            }
        }
        */

        private void listBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                // MessageBox.Show(listBox1.SelectedItem.ToString());
                string selected = listBox1.GetItemText(listBox1.SelectedItem);
                // MessageBox.Show(myPark[3].code);
               // string cuba = "C1";
               
                // int h =0;
                string[] cod = new string[10];
                cod[1] = selected;

                int j = 0;
               for (int i = 0;i<Car.Length;i++)
                {
                    
                    if (myPark[i].lot == cod[1])
                    {
                         myPark[i].vacancy = true;
                         myPark[i].noPlate = plate;
                        
                        MessageBox.Show("Congratulation !!");
                        j = i;

                    }
                }
                

                 label4.Text ="PLATE: " + plate;
                 label5.Text ="LOT: "+ myPark[j].lot;
                Refresh();


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /*
        private void loadCode()
        {
               for (int i = 0;i<Car.Length;i++)
               {
                string selected = listBox1.GetItemText(listBox1.Items[i]);
                myPark[i].code = selected;
               }


        }
        */
    }
}
