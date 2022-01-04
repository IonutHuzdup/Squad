using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Visible==true)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
