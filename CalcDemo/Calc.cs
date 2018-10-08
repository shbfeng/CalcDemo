using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcDemo
{
    public partial class Calc : Form
    {
        private readonly HiddenForm _settingsForm = new HiddenForm();
        public Calc()
        {
            InitializeComponent();
        }

        public string T1;
        public string T2;
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           T1 = textBox1.Text;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            T2 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   textBox2.Text = T1;
         //   var selectedIndex = comboBox1.SelectedIndex;
         //   var selectedItem = comboBox1.SelectedItem;
       
            var  sToN1 = Convert.ToDouble(T1);
            var  sToN2 = Convert.ToDouble(T2);


            if (radioButton1.Checked == true)
                textBox3.Text = (sToN1 + sToN2).ToString(CultureInfo.InvariantCulture);
            else if (radioButton2.Checked == true)
                textBox3.Text = (sToN1 - sToN2).ToString(CultureInfo.InvariantCulture);
            else if (radioButton3.Checked == true)
                textBox3.Text = (sToN1 * sToN2).ToString(CultureInfo.InvariantCulture);
            else if (radioButton4.Checked == true)
            {

                try
                {
                    textBox3.Text = (sToN1 / sToN2).ToString(CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Error");
                }
            }
            //  MessageBox.Show(@"Selected Item Text: " + selectedItem.ToString() + "\n" +"Index: " + selectedIndex.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        // Show the settings form
            if (_settingsForm.Visible == true)
                _settingsForm.Hide();
            else 
                _settingsForm.Show();
        }
    }
}
