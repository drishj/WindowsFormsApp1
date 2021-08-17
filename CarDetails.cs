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
    public partial class CarDetails : Form
    {
        public CarDetails()
        {
            InitializeComponent();
        }

       
        private void CarDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        //private void populate()
        //{
        //    Con.Open();
        //    string query = "select * from Carstock";
        //    SqlDataAdapter da = new SqlDataAdapter(query, Con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    //CarDetailsDGV.DataSource = ds.Tables[0];
        //    Con.Close();
        //    Con.Close();

        //}

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ATOS\Car Showroom Management\WindowsFormsApp1\CarStock.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            //if (Carname.Text == "" || Brandname.Text == "" || Carprice.Text == "" || No_Of_Car_In_Stock.Text == "" || Modelno.Text == "")
            //{
            //    MessageBox.Show("Information Missing ");

            //}
            //else
            //{
                try
                {
                    //    Con.Open();
                    //string query = "insert into CarStock values( " + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand("insert into CarStock values( '" + Carname.Text + "','" + Brandname.Text + "','" + Carprice.Text + "' , '" + No_Of_Car_In_Stock.Text + "','" + Modelno.Text + "')", Con);
                    
                //MessageBox.Show("Details added successfully");
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Details added successfully");
            }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                Con.Close();
                }

            }


        }
    }

