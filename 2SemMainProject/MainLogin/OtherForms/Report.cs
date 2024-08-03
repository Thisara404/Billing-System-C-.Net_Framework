using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _2SemMainProject.Class1;

namespace _2SemMainProject.OtherForms
{
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }
        readonly SqlConnection conn = new SqlConnection(connectionString: "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\VISUAL STUDIO\\2SemMainProject\\2SemMainProject\\DataBase\\Form_InvoiceT.mdf\";Integrated Security=True;Connect Timeout=30");
        private void DisplayInvoice()
        {
            try
            {
                conn.Open();
                string Query = "SELECT [Customer ID], [Customer Name], [Customer Phone], [Customer Email], [Customer Address] FROM [table]";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                var ds = new DataSet();
                adapter.Fill(ds);
                ReportDGV.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Category_Form_Load(object sender, EventArgs e)
        
            {
                LoadTheme();
                DisplayInvoice();

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
                Report_lbl.ForeColor = Themecolor.SecondaryColor;

            }

        private void Report_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Billing_Form obj = new Billing_Form();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
