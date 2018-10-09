using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalcDemo
{
    public partial class Calc : Form
    {
        private readonly HiddenForm _settingsForm = new HiddenForm();
        private readonly Dog _tuantuan = new Dog();
        
        public Calc()
        {
            InitializeComponent();
        }

        public string T1;
        public string T2;
       
        private void textBox1_TextChanged(object sender, EventArgs e) => T1 = textBox1.Text;

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
            if (_tuantuan != null) textBox4.Text = (_tuantuan.total_eyes(2, 3)).ToString(CultureInfo.InvariantCulture);
            var  sToN1 = Convert.ToDouble(T1);
            var  sToN2 = Convert.ToDouble(T2);


            if (radioButton1.Checked)
                textBox3.Text = (sToN1 + sToN2).ToString(CultureInfo.InvariantCulture);
            else if (radioButton2.Checked)
                textBox3.Text = (sToN1 - sToN2).ToString(CultureInfo.InvariantCulture);
            else if (radioButton3.Checked)
                textBox3.Text = (sToN1 * sToN2).ToString(CultureInfo.InvariantCulture);
            else if (radioButton4.Checked)
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
            if (_settingsForm.Visible)
                _settingsForm.Hide();
            else 
                _settingsForm.Show();
            


        }



        private void NumValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = (numericUpDown1.Value * 5).ToString(CultureInfo.InvariantCulture);
        }
    }
}
