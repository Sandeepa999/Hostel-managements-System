using HostelmanegementSystem.studentDBAppRequestTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostelmanegementSystem
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBAppContact.Contact' table. You can move, or remove it, as needed.
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxConName.Text = "";
            textBoxConRegNo.Text = "";
            textBoxRoomNo.Text = "";
            textBoxConMassage.Text = "";
        }

        private void buttonConSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =C:\\Users\\Ashma Sandeepa\\Desktop\\HostalManagementSystem - 1\\HostelmanegementSystem\\HostelmanegementSystem\\studentDB.mdf; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Contact(name,regNo,roomNo,message) values(@name,@regNo,@roomNo,@message)",connection);
            cmd.Parameters.AddWithValue("@name", textBoxConName.Text);
            cmd.Parameters.AddWithValue("@regNo", textBoxConRegNo.Text);
            cmd.Parameters.AddWithValue("@roomNo", textBoxRoomNo.Text);
            cmd.Parameters.AddWithValue("@message", textBoxConMassage.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonVacate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application app=new Application();
            app.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1= new Home();
            h1.Show();
            this.Hide();
        }

        private void textBoxConRegNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
