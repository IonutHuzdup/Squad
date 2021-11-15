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
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ionut\source\repos\Test\Test\HotelDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            connection.Open();
            string query = "select * from [Customer]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into [Customer] values('" + TBCustomerID.Text + "','" + TBCustomerName.Text + "','" + TBCustomerNumber.Text + "')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer added Successfully!");
            connection.Close();
            populate();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "delete from [Customer] where CustomerID="+TBCustomerID.Text+"";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer deleted Successfully!");
            connection.Close();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "UPDATE [Customer] set CustomerName='" + TBCustomerName.Text + "', CustomerNumber='" + TBCustomerNumber.Text + "' where ClientID = "+TBCustomerID.Text+";";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer edited Successfully!");
            connection.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select * from [Customer] where CustomerName like '%"+textBox4.Text+"%';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }
    }
}
