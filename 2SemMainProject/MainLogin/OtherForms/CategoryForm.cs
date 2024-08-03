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
    public partial class Category_Form : Form
    {
        public Category_Form()
        {
            InitializeComponent();
        }

        private void Category_Form_Load(object sender, EventArgs e)
        
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
                CategoryDetails_lbl.ForeColor = Themecolor.SecondaryColor;

            }
        
    }
}
