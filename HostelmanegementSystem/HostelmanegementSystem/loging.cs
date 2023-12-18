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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostelmanegementSystem
{
    public partial class loging : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.studentDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public loging()
        {
            InitializeComponent();
        }
       



        private void loging_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginRegistrationbutton_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.Show();
            this.Hide();

        }
       

        private void LoginContactbutton_Click(object sender, EventArgs e)
        {
            Contact con1 = new Contact();
            con1.Show();
            this.Hide();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM StudentDetailTable WHERE regNo='"+ LoginRegiNotextBox.Text+"' and password='"+ LoginPWtextBox.Text+"'",con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                Application app = new Application();
                app.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Registration Number or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
