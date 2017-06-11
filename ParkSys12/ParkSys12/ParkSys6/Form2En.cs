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
    public partial class Form2En : Form
    {
        public string[] Car = Form1En.Car;

      
        public Form2En()
        {
           // listBox1.Items.Add("A1");
           // listBox1.Items.Add("A2");

            //Car[0] = Form1.Car[1];
            // List < string > Mylist = new List<string>();
            //Mylist.Add("Hello");
            //listBox1.DataSource = Mylist;
           

            //loadList();
            InitializeComponent();
            loadList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // MessageBox.Show("You clicked " + listBox1.SelectedItems[0]);
           // listBox1.Items.Add(listBox1.SelectedItems[0]);
            //listBox1.Items.Add(new ListBoxItem("name", "value"));
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // listBox1.Items.Add("A1");
          //listBox1.Items.Add("A2");
        }

        private void loadList()
        {

            for (int i = 0; i < 10;i++ )
            {
                listBox1.Items.Add("Hello");
            }
         
           /*
            for (int i = 0;i<=10 ;i++)
            {
               
                listBox1.Items.Add(Car[i]);
            }

            */
        }

        private void Form2En_Load(object sender, EventArgs e)
        {

        }
    }
}
