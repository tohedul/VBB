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
    public partial class Blood_search : Form
    {
        public Blood_search()
        {
            InitializeComponent();

            comboBox1.Items.Add("A+");
            comboBox1.Items.Add("A-");
            comboBox1.Items.Add("B+");
            comboBox1.Items.Add("B-");
            comboBox1.Items.Add("AB+");
            comboBox1.Items.Add("AB-");
            comboBox1.Items.Add("O+");
            comboBox1.Items.Add("O-");
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

        private void btnprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VBBDBDataContext v = new VBBDBDataContext();
            User u = new User();

            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if(item=="A+")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,x.BloodGroup,x.LastDonationDate,x.MobileNumber,x.Address
                                            }
                                            
                                            );


            }
            else if(item=="A-")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }
            else if (item == "B+")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }
            else if (item == "B-")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }
            else if (item == "AB+")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }
            else if (item == "AB-")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }
            else if (item == "O+")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }
            else if (item == "O-")
            {
                dataGridView1.DataSource = (from x in v.Users
                                            where x.BloodGroup == item
                                            select new
                                            {
                                                x.Name,
                                                x.BloodGroup,
                                                x.LastDonationDate,
                                                x.MobileNumber,
                                                x.Address
                                            }

                                            );
            }



        }
    }
}
