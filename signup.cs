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
    public partial class signup : Form
    {
        VBBDBDataContext v; 
        public signup()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {

            if (tbname.Text == "")
            {
                MessageBox.Show("Name must be filled");
            }
            else if (tbpassword.Text == "")
            {
                MessageBox.Show("Password must be filled");
            }
            else if (tbdateofbirth.Text == "")
            {
                MessageBox.Show("Date of birth  must be filled");
            }
            else if (tbbloodgroup.Text == "")
            {
                MessageBox.Show("Blood group must be filled");
            }
            else if (tblastdonationdate.Text == "")
            {
                MessageBox.Show("Last donation date must be filled");
            }
            else if (tbmobilenumber.Text == "")
            {
                MessageBox.Show("Mobile number must be filled");
            }
            else if (tbaddress.Text == "")
            {
                MessageBox.Show("Adress must be filled");
            }
            else
            {
                
                    v = new VBBDBDataContext();
                    User u = new User();
                    u.Name = tbname.Text;
                    u.Password = tbpassword.Text;
                    u.DateOfBirth = Convert.ToDateTime(tbdateofbirth.Text);//dob
                    u.BloodGroup = tbbloodgroup.Text;

                /* try
                 {

                     u.LastDonationDate = Convert.ToDateTime(tblastdonationdate.Text);
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Enter date in right format(ex:mm/dd/yyyy)");*/

                    u.LastDonationDate = Convert.ToDateTime(tblastdonationdate.Text);// last donation d
                    u.MobileNumber = Convert.ToInt32(tbmobilenumber.Text);
                    u.Address = tbaddress.Text;

                    v.Users.InsertOnSubmit(u);

                
                    try
                    {
                        v.SubmitChanges();
                        MessageBox.Show("Successfully registered!");
                        Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong, Try again!");
                    }

                this.Hide();
                Signin si = new Signin();
                si.Show();
                
            
            }
        }
    }
}
