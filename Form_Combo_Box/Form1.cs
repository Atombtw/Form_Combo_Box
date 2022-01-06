using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Logitech");
            comboBox2.Items.Add("Razer");
            comboBox2.Items.Add("Rampage");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Logitech" )
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1");
                comboBox3.Items.Add("2");
            }
            else if (comboBox2.Text == "Razer")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("4");
            }
            else if (comboBox2.Text == "Rampage")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("5");
                comboBox3.Items.Add("6");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "1")
            {
                comboBox1.Items.Clear();
                string[] i1 = { "a", "b", "c" };
                comboBox1.Items.AddRange(i1);
            }
            else if (comboBox3.Text == "2")
            {
                comboBox1.Items.Clear();
                string[] i2 = { "d", "e", "f" };
                comboBox1.Items.AddRange(i2);
            }
            else if (comboBox3.Text == "3")
            {
                comboBox1.Items.Clear();
                string[] i3 = { "g", "l", "m" };
                comboBox1.Items.AddRange(i3);
            }
            else if (comboBox3.Text == "4")
            {
                comboBox1.Items.Clear();
                string[] i4 = { "n", "o", "ö" };
                comboBox1.Items.AddRange(i4);
            }
            else if (comboBox3.Text == "5")
            {
                comboBox1.Items.Clear();
                string[] i5 = { "p", "r", "s" };
                comboBox1.Items.AddRange(i5);
            }
            else if (comboBox3.Text == "6")
            {
                comboBox1.Items.Clear();
                string[] i6 = { "ş", "t", "u" };
                comboBox1.Items.AddRange(i6);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Model: " + comboBox2.Text);
            listBox1.Items.Add("Marka: " + comboBox3.Text);
            listBox1.Items.Add("Version: " + comboBox1.Text);
        }
    }
}
