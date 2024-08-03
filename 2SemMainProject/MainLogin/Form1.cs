using _2SemMainProject.OtherForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static _2SemMainProject.Class1;


namespace _2SemMainProject
{
    public partial class POS_Form : MetroFramework.Forms.MetroForm

    { //-------------------Colors Changes & Child form ---------------------

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public POS_Form()
        {
            InitializeComponent();
            random = new Random();
            btnClose_ChildForm.Visible = false;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == index)
            {
               index=random.Next(Themecolor.ColorList.Count);
            }
            tempIndex = index;
            string Color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(Color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender is Button)
            {
                Button clickedButton = (Button)btnSender; 
                if (currentButton != clickedButton)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = Font;
                    panelTitleBar.BackColor = color;
                    Olinta_lbl.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);

                    Themecolor.PrimaryColor = color;
                    Themecolor.SecondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    btnClose_ChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
          foreach (Control previousBtn in panelMenu.Controls)
            {
            if(previousBtn.GetType()==typeof(Button))
                {
                previousBtn.BackColor = Color.White;
                previousBtn.ForeColor = Color.Black;
                previousBtn.Font = Font;    
                }
          }
        }

        // -------------------------Child Form-------------------------------
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Set the child form's size to match the size of the panelTitleBarBody
            childForm.Size = panelTitleBarBody.Size;

            // Enable auto-scrolling for the child form
            childForm.AutoScroll = true;

            // Dock the child form to fill the panelTitleBarBody
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the panelTitleBarBody
            this.panelTitleBarBody.Controls.Add(childForm);

            // Bring the child form to the front
            childForm.BringToFront();

            // Show the child form
            childForm.Show();

            // Set the label text to match the child form's text
            lblHomeTitle.Text = childForm.Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           ActivateButton(sender);
        }

        //----------------------Button------------------------
       
        // Invoice Button
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OtherForms.Billing_Form(), sender);
            lblHomeTitle.Text = "Invoice";
            Billing_Form obj = new Billing_Form();
            
           
        }
        //Customer Button
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OtherForms.Customer_Form(), sender);
            lblHomeTitle.Text = "Customers";
            Customer_Form obj = new Customer_Form();
           

        }
        //Dashboard Button
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OtherForms.Dash_Board(), sender);
            lblHomeTitle.Text = "DashBoard";
            Dash_Board obj = new Dash_Board();
           
        }
        //LogOut Button
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOG OUT || confirm?", "log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                POS_Form lg = new POS_Form();
                lg.Show();

            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
        //Item Form Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new OtherForms.Item_Form(), sender);
            lblHomeTitle.Text = "Items";
            Item_Form obj = new Item_Form();
        }
        //Report Button
        public void Category_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OtherForms.Report_Form(), sender);
            lblHomeTitle.Text = "Category";
            Report_Form obj = new Report_Form();
        }

        private void btnClose_ChildForm_Click(object sender, EventArgs e)
        {
            activeForm?.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblHomeTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(87, 79, 120);
            Olinta_lbl.BackColor = Color.FromArgb(234, 212, 250);

            currentButton = null;
            btnClose_ChildForm.Visible = false;
        }

        private void panelTitleBarBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
