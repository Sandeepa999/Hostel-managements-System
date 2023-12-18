using HostelmanegementSystem.studentDBAppDataTableAdapters;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBAppData.StudentDetailTable' table. You can move, or remove it, as needed.
            

        }
        private void Edit(bool value)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =C:\\Users\\Ashma Sandeepa\\Desktop\\HostalManagementSystem - 1\\HostelmanegementSystem\\HostelmanegementSystem\\studentDB.mdf; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.StudentDetailTable(regNo,firstName,midName,lastName,gender,phone,email,password) values(@regNo,@firstName,@midName,@lastName,@gender,@phone,@email,@password)", connection);
            cmd.Parameters.AddWithValue("@regNo", textBox3.Text);
            cmd.Parameters.AddWithValue("@firstName", textBox4.Text);
            cmd.Parameters.AddWithValue("@midName", textBox5.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox6.Text);
            cmd.Parameters.AddWithValue("@gender", textBoxGender.Text);
            cmd.Parameters.AddWithValue("@phone", textBox7.Text);
            cmd.Parameters.AddWithValue("@email", textBox8.Text);
            cmd.Parameters.AddWithValue("@password", textBox9.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application a1=new Application();
            a1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show(); 
            this.Hide();


        }

       
    }
}
