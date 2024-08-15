using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.R
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(comboBox1.SelectedItem);
            double text2 = Convert.ToDouble(textBox2.Text);
            double product = text1 * text2;
            //Now to display the product in textbox3.
            //but we will convert this value to string
            //because textbox only recognizes string.
            textBox3.Text = product.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
 }
