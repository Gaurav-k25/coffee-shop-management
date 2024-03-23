using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class frmLoginPage : Form
    {
        
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text;
            string pass = txtPassoword.Text;


            lblUsername.Text = "";
            lblPassword.Text = "";
            if (uname == "")
            {
                lblUsername.Text = "Enter Your Name";
                lblUsername.ForeColor = Color.Red;
            }
            else
            {
                if (pass == "")
                {
                    lblPassword.Text = "Enter Your Password";
                    lblPassword.ForeColor = Color.Red;
                }


                else if (uname =="1" && pass == "1")
                {
                    Hospital_From frm = new Hospital_From();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    lblLoginSucessfull.Text = "Login Unsuccessful";
                    lblLoginSucessfull.ForeColor = Color.Red;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPassoword.UseSystemPasswordChar = false;
            }else
            {
                txtPassoword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
