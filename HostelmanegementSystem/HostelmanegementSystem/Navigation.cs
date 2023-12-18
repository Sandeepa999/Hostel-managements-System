using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelmanegementSystem
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message me = new Message();
            me.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewRegistration newreg = new NewRegistration();
            newreg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Request req = new Request();
            req.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vacate va = new Vacate();
            va.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
