using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _2SemMainProject.Class1;

namespace _2SemMainProject.OtherForms
{
    public partial class Dash_Board : Form
    {
        public Dash_Board()
        {
            InitializeComponent();
        }

        private void Dash_Board_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }


        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Themecolor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }
            Olinta_lbl.ForeColor = Themecolor.SecondaryColor;

        }

        private void Item_btn_Click(object sender, EventArgs e)
        {
            Item_Form obj = new Item_Form();
            obj.Show();
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            Customer_Form obj = new Customer_Form();
            obj.Show();
        }

        private void Billing_Invoice_btn_Click(object sender, EventArgs e)
        {
            Billing_Form obj = new Billing_Form();
            obj.Show();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            Report_Form obj = new Report_Form();
            obj.Show();
        }
    }
}
