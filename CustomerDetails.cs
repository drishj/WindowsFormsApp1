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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ATOS\Car Showroom Management\WindowsFormsApp1\CarStock.mdf;Integrated Security=True;Connect Timeout=30");
        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            
        }


        //private void populate()
        //{
        //    Con.Open();
        //    string query = "select * from Customer";
        //    SqlDataAdapter da = new SqlDataAdapter(query, Con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    CustomerDGV.DataSource = ds.Tables[0];
        //    Con.Close();
        //    }

        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ATOS\Car Showroom Management\WindowsFormsApp1\CarStock.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
            {
            if (Custid.Text == "" || Custname.Text == "" || Custaddr.Text == "" || Contactno.Text == "")
            {
                MessageBox.Show("Information Missing ");

            }
            else
            {
                //try
                //{
                    //Con.Open();
                    //string query = "insert into Customer values( " + Custid.Text + ",'" + Custname.Text + "','" + Custaddr.Text + "' , '" + Contactno.Text + "')";
                    SqlCommand cmd = new SqlCommand("insert into Customer values( " + Custid.Text + ",'" + Custname.Text + "','" + Custaddr.Text + "' , '" + Contactno.Text + "')", Con);

                    //MessageBox.Show("Details added successfully");
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    //populate();

                    //    catch (Exception Myex)
                    //    {
                    //        MessageBox.Show(Myex.Message);
                    //    }
                    //finally
                    //{
                    //    Con.Close();
                    //}
                    MessageBox.Show("Details added successfully");
                }
                }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard objFrmMain = new Dashboard();
            objFrmMain.Show();
        }
    }

    //private void CustomerDetails_Load(object sender, EventArgs e)
    //{
    //    // TODO: This line of code loads data into the 'carStockDataSet.Customer' table. You can move, or remove it, as needed.
    //    //this.customerTableAdapter.Fill(this.carStockDataSet.Customer);

        

    //}
}
    
