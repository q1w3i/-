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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("123") && textBox2.Text.Equals("123"))
            {
                this.DialogResult = DialogResult.OK; ;
                this.Hide();
            }
            else
            {
                MessageBox.Show("请输入正确的账号密码");
            }

        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }







    }
}
