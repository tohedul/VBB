using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBB
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            
        }
        private void Home_Load(object sender,EventArgs e)
        {
            
        }


        private void btnprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.Show();

        }

        private void pnlprofile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin si = new Signin();
            si.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blood_search bs = new Blood_search();
            bs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blood_request br = new Blood_request();
            br.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              

        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            VBBDBDataContext v = new VBBDBDataContext();
            dataGridView1.DataSource = v.Posts;
        }
    }
}
