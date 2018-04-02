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
    public partial class Blood_request : Form
    {
        //public string PostText;
        VBBDBDataContext v = new VBBDBDataContext();
        public Blood_request()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blood_search bs = new Blood_search();
            bs.Show();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin si = new Signin();
            si.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VBBDBDataContext v = new VBBDBDataContext();
       
            Post p = new Post();

            p.PostText= tbpost.Text; 
            v.Posts.InsertOnSubmit(p);
            v.SubmitChanges();


         this.Hide();
         Home h = new Home(); 
         h.Show();
        }
    
    }
}
