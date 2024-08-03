using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static _2SemMainProject.Class1;

namespace _2SemMainProject.OtherForms
{
    public partial class Item_Form : Form
    {
        public Item_Form()
        {
            InitializeComponent();
            LoadTheme();
            DisplayItem();
        }

        readonly SqlConnection conn = new SqlConnection(connectionString: "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\VISUAL STUDIO\\2SemMainProject\\2SemMainProject\\DataBase\\Form_InvoiceT.mdf\";Integrated Security=True;Connect Timeout=30");

        private void DisplayItem()
        {
            try
            {
                conn.Open();
                string Query = "SELECT * FROM Item";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                var ds = new DataSet();
                adapter.Fill(ds);
                dataGrid_Item.DataSource = ds.Tables[0];
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
            ItemDetails_lbl.ForeColor = Themecolor.SecondaryColor;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product_id_txt.Text = "";
            Product_Name_txt.Text = "";
            Quantity_txt.Text = "";
            Unit_Price_txt.Text = "";
            Category_txt.Text = "";
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_id_txt.Text == "" || Product_Name_txt.Text == "" || Quantity_txt.Text == "" || Category_txt.Text == "" || Unit_Price_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "UPDATE Item SET [Product Name] = @Name, [Product Quantity] = @Quantity, [Product Category] = @Category, [Product Unit Price] = @UnitPrice WHERE [Product ID] = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", Product_id_txt.Text);
                    cmd.Parameters.AddWithValue("@Name", Product_Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity_txt.Text);
                    cmd.Parameters.AddWithValue("@Category", Category_txt.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", Unit_Price_txt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Updated Successfully");
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

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_id_txt.Text == "" || Product_Name_txt.Text == "" || Quantity_txt.Text == "" || Category_txt.Text == "" || Unit_Price_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Item ([Product ID], [Product Name], [Product Quantity], [Product Category], [Product Unit Price]) VALUES (@ID, @Name, @Quantity, @Category, @UnitPrice)", conn);
                    cmd.Parameters.AddWithValue("@ID", Product_id_txt.Text);
                    cmd.Parameters.AddWithValue("@Name", Product_Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity_txt.Text);
                    cmd.Parameters.AddWithValue("@Category", Category_txt.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", Unit_Price_txt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Added Successfully");
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_id_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "DELETE FROM Item WHERE [Product ID] = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", Product_id_txt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully");
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

        private void dataGrid_Item_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Product_id_txt.Text = dataGrid_Item.SelectedRows[0].Cells[0].Value.ToString();
                Product_Name_txt.Text = dataGrid_Item.SelectedRows[0].Cells[1].Value.ToString();
                Quantity_txt.Text = dataGrid_Item.SelectedRows[0].Cells[2].Value.ToString();
                Category_txt.Text = dataGrid_Item.SelectedRows[0].Cells[3].Value.ToString();
                Unit_Price_txt.Text = dataGrid_Item.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Item_Form_Load(object sender, EventArgs e)
        {
            // Optional: Any logic needed during form load
        }

        private void dataGrid_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Any logic needed for cell content click
        }
    }
}
