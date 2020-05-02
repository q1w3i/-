using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teacher_side
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == button2.Text)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            if (textBox3.Text == button8.Text)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
