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
    public partial class Profile : Form
    {
        VBBDBDataContext v = new VBBDBDataContext();

        List<User> Emps;
        int rno = 0;

        public Profile()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            User u = new User();
           

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

        private void tname_TextChanged(object sender, EventArgs e)
        {
            User u = new User();
            tn.Text = u.Name;

        }

        private void tbg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           v = new VBBDBDataContext();
            Emps = v.Users.ToList();
            ShowData();
        }
        private void ShowData()
        {
            tn.Text = Emps[rno].Name;
            tbg.Text = Emps[rno].BloodGroup;
            tdob.Text = Emps[rno].DateOfBirth.ToString();
            tldd.Text = Emps[rno].LastDonationDate.ToString();
            tm.Text = Emps[rno].MobileNumber.ToString();
            ta.Text = Emps[rno].Address;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VBBDBDataContext v = new VBBDBDataContext();
            User u = new User();
            //string username=t
            var getAccount = (
                          from x in v.Users
                          where x.Name ==tn.Text
                          
                          select x
                          
                    );

            foreach (User x in getAccount)
            {


                try
                {
                    x.MobileNumber = int.Parse(tm.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Enter valid mobile no.");
                }
                //v.Users.InsertOnSubmit(u);

                v.SubmitChanges();
            }
            
        }
    }
}
