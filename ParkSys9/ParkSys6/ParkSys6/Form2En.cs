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
            //Car[0] = Form1.Car[1];
            // List < string > Mylist = new List<string>();
            //Mylist.Add("Hello");
            //listBox1.DataSource = Mylist;
           

            // loadList();
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked " + listBox1.SelectedItems[0]);
            //listBox1.Items.Add(listBox1.SelectedItems[0]);
            //listBox1.Items.Add(new ListBoxItem("name", "value"));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Car[1]);
        }

        private void loadList()
        {
            int i = 0;

            foreach (string g in Car)
            {
                listBox1.Items.Add(Car[i]);

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
