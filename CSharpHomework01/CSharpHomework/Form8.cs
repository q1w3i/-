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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            OleDbConnection oleDb = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database11.mdb");
            string sql = "select * from 表1";
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb);
            DataTable dt = new DataTable();
            dbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
