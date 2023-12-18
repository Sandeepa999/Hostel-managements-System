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


namespace HostelmanegementSystem
{
    public partial class WardenLogin : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.studentDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public WardenLogin()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM WardenLogin WHERE username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                Navigation nev = new Navigation();
                nev.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Registration Number or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WardenLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBAppWarden.WardenLogin' table. You can move, or remove it, as needed.
            this.wardenLoginTableAdapter.Fill(this.studentDBAppWarden.WardenLogin);

        }
    }
}
