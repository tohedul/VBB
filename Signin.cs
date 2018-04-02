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
    public partial class Signin : Form
    {
        VBBDBDataContext v;
        public Signin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup su = new signup();
            su.Show();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            v = new VBBDBDataContext();

            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username=="")
            {
                MessageBox.Show("Username must be filled!");
            }
            else if(password=="")
            {
                MessageBox.Show("Password must be filled!");
            }
            else
            {
                var getAccount = (
                          from x in v.Users
                          where x.Name==username && x.Password==password
                          select x
                    );

                if (getAccount.Count() != 1)
                {
                    MessageBox.Show("Invalid username & password!");
                }
                else if (getAccount.Count() == 1)
                {
                   // public int i = x;
                    this.Hide();
                    Home h = new Home();
                    h.Show();

                }


            }


            






            
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
