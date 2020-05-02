using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CSharpHomework
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        String[] arr = { "广医附院", "东华医院", "东莞市中医院", "湛江市人民医院", "虎门中医院", "广东省人民医院", "东莞市人民医院", "深圳市人民医院", "深圳市第二人民医院" };
        String[] brr = new String[3];

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[0];
            textBox1.Text = brr[0];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[1];
            textBox1.Text = brr[0];
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[2];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[3];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[4];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[5];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox1.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[6];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox1.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[7];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox1.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            brr[0] = arr[8];
            textBox1.Text = brr[0];
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[0];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[1];
            textBox2.Text = brr[1];
            checkBox10.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[2];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox10.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[3];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox10.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[4];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox10.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[5];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox10.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[6];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox10.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[7];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox10.Checked = false;
            checkBox18.Checked = false;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            brr[1] = arr[8];
            textBox2.Text = brr[1];
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox10.Checked = false;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[0];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[1];
            textBox3.Text = brr[2];
            checkBox19.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[2];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox19.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[3];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox19.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[4];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox19.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[5];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox19.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[6];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox19.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[7];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox19.Checked = false;
            checkBox27.Checked = false;
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            brr[2] = arr[8];
            textBox3.Text = brr[2];
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox19.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("提交成功");
            string strtx1=textBox1.Text;
            string strtx2= textBox2.Text;
            string strtx3= textBox3.Text;
            string sql = "update 表1 set 第一志愿='"+strtx1+"',第二志愿='"+strtx2+"',第三志愿= '"+strtx3+"' where 学号='17209120369'";
           
            OleDbConnection oleDb = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database11.mdb");
            oleDb.Open();
            OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
                int i = oleDbCommand.ExecuteNonQuery();
                oleDb.Close();
            
        }









    }


}