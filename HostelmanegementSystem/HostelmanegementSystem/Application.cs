using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelmanegementSystem
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
           
        }
       

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =C:\\Users\\Ashma Sandeepa\\Desktop\\HostalManagementSystem - 1\\HostelmanegementSystem\\HostelmanegementSystem\\studentDB.mdf; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Request(name,regNo,year,phone,address) values(@name,@regNo,@year,@phone,@address)", connection);
            cmd.Parameters.AddWithValue("@name", textBoxReqName.Text);
            cmd.Parameters.AddWithValue("@regNo", textBoxreqRegNo.Text);
            cmd.Parameters.AddWithValue("@year", Convert.ToInt16(textBox5.Text));
            cmd.Parameters.AddWithValue("@phone", textBoxReqTel.Text);
            cmd.Parameters.AddWithValue("@address", textBoxReqAddress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Request has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonVacate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =C:\\Users\\Ashma Sandeepa\\Desktop\\HostalManagementSystem - 1\\HostelmanegementSystem\\HostelmanegementSystem\\studentDB.mdf; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Vacate(name,regNo,phone,roomNo) values(@name,@regNo,@phone,@roomNo)", connection);
            cmd.Parameters.AddWithValue("@name", textBoxVacName.Text);
            cmd.Parameters.AddWithValue("@regNo", textBoxVacRegNo.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxVacTel.Text);
            cmd.Parameters.AddWithValue("@roomNo", textBoxVacRoomNo.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Request is sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact c1 = new Contact();
            c1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1=new Home();
            h1.Show();  
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contact c2 = new Contact();
            c2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            h2.Show();
            this.Hide();
        }
    }
}
