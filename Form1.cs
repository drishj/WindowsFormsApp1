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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ATOS\Car Showroom Management\WindowsFormsApp1\Login.mdf;Integrated Security=True;Connect Timeout=30");
            //string query = ;
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Login where Username= '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Dashboard objFrmMain = new Dashboard();
                objFrmMain.Show();

            }

            else
            {
                MessageBox.Show("Check your username and password");

            }
            //string USERNAME = "Drishti";
            //string PASSWORD = "123";
            //if ((textBox1.Text == USERNAME) && (textBox2.Text == PASSWORD))
            //    MessageBox.Show("Login success..");
            //else
            //    MessageBox.Show("Enter Valid Username and Password..");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
