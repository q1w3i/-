using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Teacher_side
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(pictureBox1.ClientRectangle);

            gp.AddEllipse(pictureBox2.ClientRectangle);

            gp.AddEllipse(pictureBox3.ClientRectangle);

            Region region = new Region(gp);

            pictureBox1.Region = region;
            pictureBox2.Region = region;
            pictureBox3.Region = region;

            gp.Dispose();

            region.Dispose();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void Form7_Shown_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 lg = new Form1();
            if (lg.ShowDialog() == DialogResult.OK)
                this.Visible = true;
            else
                this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
    }
}

