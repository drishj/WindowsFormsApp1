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
    public partial class SaleDetails : Form
    {
        public SaleDetails()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ATOS\Car Showroom Management\WindowsFormsApp1\CarStock.mdf;Integrated Security=True;Connect Timeout=30");

        private void SaleDetails_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //{
        //    //    if (Saleid.Text == "" || Carname.Text == "" || Custid.Text == "" || Saledate.Text == "")
        //    //    {
        //    //        MessageBox.Show("Information Missing ");

        //    //    }
        //    //    else
        //    //    {
        //    try
        //    {
        //        //Con.Open();
        //        //string query = "insert into Customer values( " + Custid.Text + ",'" + Custname.Text + "','" + Custaddr.Text + "' , '" + Contactno.Text + "')";
        //        //SET IDENTITY_INSERT Sales ON;
        //        SqlCommand cmd = new SqlCommand("insert into Sales values('" + Carname.Text + "','" + Custid.Text + "' , '" + Saledate.Text + "')", Con);

        //        //MessageBox.Show("Details added successfully");
        //        Con.Open();
        //        cmd.ExecuteNonQuery();
        //        Con.Close();
        //        //populate();
        //    }
        //    catch (Exception Myex)
        //    {
        //        MessageBox.Show(Myex.Message);
        //    }
        //    finally
        //    {
        //        Con.Close();
        //    }

        //    MessageBox.Show("Details added successfully");
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "insert into Sales values('" + Carname.Text + "','" + Custid.Text + "' , '" + Saledate.Text + "')";
            cmd.ExecuteNonQuery();
            Con.Close();
            disp_data();
            MessageBox.Show("Details added successfully");
        }
        public void disp_data()
        {
        Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Sales";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SaleDGV.DataSource = dt;
            
            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard objFrmMain = new Dashboard();
            objFrmMain.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Sales where Custid='" + Custid.Text + "'";
            cmd.ExecuteNonQuery();
            Con.Close();
            disp_data();
            MessageBox.Show("Record deleted successfully");
        }
    }
        }
    //}
//}
