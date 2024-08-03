using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2SemMainProject
{
    
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pwdTxt.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UnTxt.Text == "" && pwdTxt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                } else if (UnTxt.Text == "Olinta" && pwdTxt.Text == "Admin2024")
                {
                    MessageBox.Show("Login Sucessfull");
                    POS_Form obj = new POS_Form();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            UnTxt.Text = "";
            pwdTxt.Text = "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pwdTxt.UseSystemPasswordChar = !checkBox1.Checked;
        }

       
        
    }
}
