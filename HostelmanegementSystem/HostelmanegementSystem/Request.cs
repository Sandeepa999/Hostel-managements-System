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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBAppRequest.Request' table. You can move, or remove it, as needed.
            // this.requestTableAdapter.Fill(this.studentDBAppRequest.Request);
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =C:\\Users\\Ashma Sandeepa\\Desktop\\HostalManagementSystem - 1\\HostelmanegementSystem\\HostelmanegementSystem\\studentDB.mdf; Integrated Security = True");
            SqlCommand message = new SqlCommand("select * from dbo.Request", connection);
            SqlDataAdapter myadapter = new SqlDataAdapter(message);
            DataTable request = new DataTable();
            myadapter.Fill(request);
            dataGridView1.DataSource = request;
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigation n1 = new Navigation();
            n1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
