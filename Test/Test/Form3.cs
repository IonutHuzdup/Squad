using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ionut\source\repos\Test\Test\HotelDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into [Employee] values('" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Registration Successfull!");
            connection.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
