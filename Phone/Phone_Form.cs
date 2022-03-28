using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Phone
{
    public partial class Phone_Form : Form

    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Phone_Form;Integrated Security=True");
        public Phone_Form()
        {
            InitializeComponent();
        }

        private void Phone_Form_Load(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmc = new SqlCommand(@"INSERT INTO Table (First,Surname,Mobile,Email,Catagory) Values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "', ", con);

            cmc.ExecuteNonQuery();
            con.Close();
        }
    }
}
