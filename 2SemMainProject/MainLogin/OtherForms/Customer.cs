using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static _2SemMainProject.Class1;

namespace _2SemMainProject.OtherForms
{
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
            DisplayCustomer();
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
                dataGrid_Customer.DataSource = ds.Tables[0];
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

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ID_txt.Text = "";
            Name_txt.Text = "";
            Phone_txt.Text = "";
            Email_txt.Text = "";
            Address_txt.Text = "";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_txt.Text == "" || Address_txt.Text == "" || Name_txt.Text == "" || Phone_txt.Text == "" || Email_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customer ([Customer ID], [Customer Name], [Customer Phone], [Customer Email], [Customer Address]) VALUES (@ID, @Name, @Phone, @Email, @Address)", conn);
                    cmd.Parameters.AddWithValue("@ID", ID_txt.Text);
                    cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone_txt.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_txt.Text);
                    cmd.Parameters.AddWithValue("@Address", Address_txt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Added Successfully");
                    DisplayCustomer();
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

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Address_txt.Text == "" || ID_txt.Text == "" || Name_txt.Text == "" || Phone_txt.Text == "" || Email_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "UPDATE Customer SET [Customer Name] = @Name, [Customer Phone] = @Phone, [Customer Email] = @Email, [Customer Address] = @Address WHERE [Customer ID] = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", ID_txt.Text);
                    cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone_txt.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_txt.Text);
                    cmd.Parameters.AddWithValue("@Address", Address_txt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Updated Successfully");
                    DisplayCustomer();
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
                if (ID_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "DELETE FROM Customer WHERE [Customer ID] = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", ID_txt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayCustomer();
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

        private void dataGrid_Customer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ID_txt.Text = dataGrid_Customer.SelectedRows[0].Cells[0].Value.ToString();
                Name_txt.Text = dataGrid_Customer.SelectedRows[0].Cells[1].Value.ToString();
                Phone_txt.Text = dataGrid_Customer.SelectedRows[0].Cells[2].Value.ToString();
                Email_txt.Text = dataGrid_Customer.SelectedRows[0].Cells[3].Value.ToString();
                Address_txt.Text = dataGrid_Customer.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Customer_Form_Load(object sender, EventArgs e)
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
            CustomerDetails_lbl.ForeColor = Themecolor.SecondaryColor;
        }

        private void dataGrid_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement any necessary code here
        }
    }
}
