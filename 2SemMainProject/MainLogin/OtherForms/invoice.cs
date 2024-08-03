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
    public partial class Billing_Form : Form
    {
        private DataTable table;
        public Billing_Form()
        {
            InitializeComponent();
        }
        
        readonly SqlConnection conn = new SqlConnection(connectionString: "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\VISUAL STUDIO\\2SemMainProject\\2SemMainProject\\DataBase\\Form_InvoiceT.mdf\";Integrated Security=True;Connect Timeout=30");

        private void DisplayCustomer()
        {
            try
            {
                conn.Open();
                string Query = "SELECT [Customer ID], [Customer Name], [Customer Phone], [Customer Email], [Customer Address] FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                var ds = new DataSet();
                adapter.Fill(ds);
                CustomerGridview.DataSource = ds.Tables[0];
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

        private void DisplayItem()
        {
            try
            {
                conn.Open();
                string Query = "SELECT * FROM Item";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                var ds = new DataSet();
                adapter.Fill(ds);
                ProductGridView.DataSource = ds.Tables[0];
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
        int ProductNo = 0;
        int Quantity, UnitPrice, Total; // what's this
            string Product;
        private void Billing_Form_Load(object sender, EventArgs e)
        {
            LoadTheme();
            DisplayItem();
            DisplayCustomer();
            table = new DataTable();
            table.Columns.Add("ProductNo", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));


        }
        int sum = 0;
        private void Quantity_Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Quantity_txt.Text))
                {
                    MessageBox.Show("Enter The Quantity of Product");
                } else if (flag==0)
                {
                    MessageBox.Show("Enter the Product");
                } else if (Convert.ToInt32(Quantity_txt.Text)>stock)
                {
                    MessageBox.Show("Not Enough Stock available");
                } else
                {
                    ProductNo += ProductNo + 1;
                    Quantity = Convert.ToInt32(Quantity_txt.Text);
                    Total=Quantity * UnitPrice;
                    table.Rows.Add(ProductNo,Product,Quantity,UnitPrice,Total);
                    InvoicesDGV.DataSource=table;
                    flag = 0;
                    sum+=Total;
                    TotalAmount_txt.Text = "Rs" + sum.ToString();
                    UpdateProduct();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally 
            {
                conn.Close();
            }
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
                Quantity_lbl.ForeColor = Themecolor.SecondaryColor;
                Address_lbl.ForeColor = Themecolor.SecondaryColor;
                Customers_lbl.ForeColor = Themecolor.SecondaryColor;
                Email_lbl.ForeColor = Themecolor.SecondaryColor;
                ID_lbl.ForeColor = Themecolor.SecondaryColor;
                Invoice_No_lbl.ForeColor = Themecolor.SecondaryColor;
                Name_lbl.ForeColor = Themecolor.SecondaryColor;
                Phone_lbl.ForeColor = Themecolor.SecondaryColor;
                Product_lbl.ForeColor = Themecolor.SecondaryColor;
                Rs_lbl.ForeColor = Themecolor.SecondaryColor;
                Tot_amo_lbl.ForeColor = Themecolor.SecondaryColor;
                Unit_price_lbl.ForeColor = Themecolor.SecondaryColor;
                Pro_lbl.ForeColor = Themecolor.SecondaryColor;
                Qty_lbl.ForeColor = Themecolor.SecondaryColor;
            }
        int flag = 0;
        int stock;
        private void InvoicesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Product = InvoicesDGV.SelectedRows[0].Cells[1].ToString();
                Quantity = Convert.ToInt32(InvoicesDGV.SelectedRows[0].Cells[3].ToString());
                UnitPrice = Convert.ToInt32(InvoicesDGV.SelectedRows[0].Cells[5].ToString());
                flag = 1;
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

        private void Quantity_lbl_Click(object sender, EventArgs e)
        {

        }

        public void View_Invoice_btn_Click(object sender, EventArgs e)
        {
            
            Report_Form obj = new Report_Form();
        }

        private void InvoicesDGV_DoubleClick(object sender, EventArgs e)
        {
            Product_Name_txt.Text= InvoicesDGV.SelectedRows[0].Cells[1].Value.ToString();
            QtyTb.Text = InvoicesDGV.SelectedRows[0].Cells[2].Value.ToString();
            Unit_Price_txt.Text = InvoicesDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Add_invoice_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Invoice_no_txt.Text) || string.IsNullOrEmpty(Invoice_no_txt.Text) || string.IsNullOrEmpty(id_txt.Text) || string.IsNullOrEmpty(Name_txt.Text) || string.IsNullOrEmpty(Phone_txt.Text) || string.IsNullOrEmpty(Email_txt.Text) || string.IsNullOrEmpty(Address_txt.Text) || string.IsNullOrEmpty(QtyTb.Text) || string.IsNullOrEmpty(Unit_Price_txt.Text) || string.IsNullOrEmpty(Product_Name_txt.Text) || string.IsNullOrEmpty(TotalAmount_txt.Text)) 
                {
                    MessageBox.Show("Fill the Data Correctly");
                }
                
                   
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into [Table]values ('"+Invoice_no_txt.Text +"','" + id_txt.Text+"','" + Name_txt.Text+ "','" + Phone_txt.Text+ "','" + Email_txt.Text+"','" + Address_txt.Text+"','" + QtyTb.Text+"','" + Unit_Price_txt.Text+ "','" + Product_Name_txt.Text+ "','" + TotalAmount_txt.Text+"')",conn);
                    conn.Close();
                    MessageBox.Show("Data Entered Succesfully");
                    conn.Close();
                }
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

        private void InvoicesDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerGridview_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id_txt.Text = CustomerGridview.SelectedRows[0].Cells[0].Value.ToString();
                Name_txt.Text = CustomerGridview.SelectedRows[0].Cells[1].Value.ToString();
                Phone_txt.Text = CustomerGridview.SelectedRows[0].Cells[2].Value.ToString();
                Email_txt.Text = CustomerGridview.SelectedRows[0].Cells[3].Value.ToString();
                Address_txt.Text = CustomerGridview.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }
        }
            void UpdateProduct()
            {
                try
                {
                    int id = Convert.ToInt32(ProductGridView.SelectedRows[0].Cells[0].Value.ToString());
                    int newQty = stock - Convert.ToInt32(Rs_lbl.Text);
                    if (newQty < 0)
                    {
                        MessageBox.Show("Operation Failed");
                    } else
                    {
                        conn.Open();
                        string query = "Update Product Set Quantity=" + newQty + "Where Product Id=" + id + ";";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        DisplayItem();
                    }
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
        
    }
}
