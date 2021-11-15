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
    public partial class Form7 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ionut\source\repos\Test\Test\HotelDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            connection.Open();
            string query = "select * from [Reservation]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into [Reservation] values('" + TBCustomerID.Text + "','" + TBCustomerName.Text + "','" + TBCustomerNumber.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation added Successfully!");
            connection.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from [Reservation] where ReservationID=" + TBCustomerID.Text + "";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation deleted Successfully!");
            connection.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select * from [Reservation] where ReservationID like '%" + textBox4.Text + "%';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }
    }
}
