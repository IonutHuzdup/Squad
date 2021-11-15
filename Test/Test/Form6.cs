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
    public partial class Form6 : Form
    {
    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ionut\source\repos\Test\Test\HotelDataBase.mdf;Integrated Security=True;Connect Timeout=30");
    public void populate()
    {
        connection.Open();
        string query = "select * from [Room]";
        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        var dataSet = new DataSet();
        dataAdapter.Fill(dataSet);
        dataGridView1.DataSource = dataSet.Tables[0];
        connection.Close();
    }
    public Form6()
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string free;
            if (radioButton2.Checked == true)
                free = "Free";
            else
                free = "Occupied";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into [Room] values('" + TBCustomerID.Text + "','" + TBCustomerName.Text + "','"+free+"')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Room added Successfully!");
            connection.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from [Room] where RoomID=" + TBCustomerID.Text + "";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Room deleted Successfully!");
            connection.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select * from [Room] where RoomID like '%" + textBox4.Text + "%';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //populate();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string free;
            if (radioButton2.Checked == true)
                free = "Free";
            else
                free = "Occupied";
            connection.Open();
            string query = "UPDATE [Room] set RoomFree='" + free + "'where RoomID = " + TBCustomerID.Text + ";";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Room edited Successfully!");
            connection.Close();
            populate();
        }
    }
}
