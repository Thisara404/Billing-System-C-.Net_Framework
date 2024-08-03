namespace _2SemMainProject.OtherForms
{
    partial class Billing_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.InvoicesDGV = new System.Windows.Forms.DataGridView();
            this.Customers_lbl = new System.Windows.Forms.Label();
            this.CustomerGridview = new System.Windows.Forms.DataGridView();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.Product_lbl = new System.Windows.Forms.Label();
            this.Quantity_Add_btn = new System.Windows.Forms.Button();
            this.Invoice_Date_View = new MetroFramework.Controls.MetroDateTime();
            this.Invoice_DT = new System.Windows.Forms.Label();
            this.Invoice_No_lbl = new System.Windows.Forms.Label();
            this.Invoice_no_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.Phone_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Add_invoice_btn = new System.Windows.Forms.Button();
            this.View_Invoice_btn = new System.Windows.Forms.Button();
            this.Tot_amo_lbl = new System.Windows.Forms.Label();
            this.Rs_lbl = new System.Windows.Forms.Label();
            this.TotalAmount_txt = new MetroFramework.Controls.MetroTextBox();
            this.Qty_lbl = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.Unit_Price_txt = new System.Windows.Forms.TextBox();
            this.Unit_price_lbl = new System.Windows.Forms.Label();
            this.Product_Name_txt = new System.Windows.Forms.TextBox();
            this.Pro_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(141, 54);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(156, 22);
            this.Quantity_txt.TabIndex = 40;
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(68, 60);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(55, 16);
            this.Quantity_lbl.TabIndex = 39;
            this.Quantity_lbl.Text = "Quantity";
            // 
            // InvoicesDGV
            // 
            this.InvoicesDGV.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.InvoicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicesDGV.Location = new System.Drawing.Point(71, 106);
            this.InvoicesDGV.Name = "InvoicesDGV";
            this.InvoicesDGV.RowHeadersWidth = 51;
            this.InvoicesDGV.RowTemplate.Height = 24;
            this.InvoicesDGV.Size = new System.Drawing.Size(435, 135);
            this.InvoicesDGV.TabIndex = 52;
            this.InvoicesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoicesDGV_CellContentClick_1);
            this.InvoicesDGV.DoubleClick += new System.EventHandler(this.InvoicesDGV_DoubleClick);
            // 
            // Customers_lbl
            // 
            this.Customers_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Customers_lbl.AutoSize = true;
            this.Customers_lbl.Location = new System.Drawing.Point(633, 57);
            this.Customers_lbl.Name = "Customers_lbl";
            this.Customers_lbl.Size = new System.Drawing.Size(71, 16);
            this.Customers_lbl.TabIndex = 57;
            this.Customers_lbl.Text = "Customers";
            // 
            // CustomerGridview
            // 
            this.CustomerGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerGridview.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.CustomerGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridview.Location = new System.Drawing.Point(638, 90);
            this.CustomerGridview.Name = "CustomerGridview";
            this.CustomerGridview.RowHeadersWidth = 51;
            this.CustomerGridview.RowTemplate.Height = 24;
            this.CustomerGridview.Size = new System.Drawing.Size(435, 135);
            this.CustomerGridview.TabIndex = 59;
            this.CustomerGridview.DoubleClick += new System.EventHandler(this.CustomerGridview_DoubleClick);
            // 
            // ProductGridView
            // 
            this.ProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductGridView.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(71, 322);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowTemplate.Height = 24;
            this.ProductGridView.Size = new System.Drawing.Size(435, 135);
            this.ProductGridView.TabIndex = 62;
            // 
            // Product_lbl
            // 
            this.Product_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Product_lbl.AutoSize = true;
            this.Product_lbl.Location = new System.Drawing.Point(68, 283);
            this.Product_lbl.Name = "Product_lbl";
            this.Product_lbl.Size = new System.Drawing.Size(53, 16);
            this.Product_lbl.TabIndex = 60;
            this.Product_lbl.Text = "Product";
            // 
            // Quantity_Add_btn
            // 
            this.Quantity_Add_btn.Location = new System.Drawing.Point(303, 46);
            this.Quantity_Add_btn.Name = "Quantity_Add_btn";
            this.Quantity_Add_btn.Size = new System.Drawing.Size(79, 38);
            this.Quantity_Add_btn.TabIndex = 64;
            this.Quantity_Add_btn.Text = "Add";
            this.Quantity_Add_btn.UseVisualStyleBackColor = true;
            this.Quantity_Add_btn.Click += new System.EventHandler(this.Quantity_Add_btn_Click);
            // 
            // Invoice_Date_View
            // 
            this.Invoice_Date_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoice_Date_View.Location = new System.Drawing.Point(874, 264);
            this.Invoice_Date_View.MinimumSize = new System.Drawing.Size(0, 30);
            this.Invoice_Date_View.Name = "Invoice_Date_View";
            this.Invoice_Date_View.Size = new System.Drawing.Size(200, 30);
            this.Invoice_Date_View.TabIndex = 65;
            // 
            // Invoice_DT
            // 
            this.Invoice_DT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoice_DT.AutoSize = true;
            this.Invoice_DT.Location = new System.Drawing.Point(871, 240);
            this.Invoice_DT.Name = "Invoice_DT";
            this.Invoice_DT.Size = new System.Drawing.Size(82, 16);
            this.Invoice_DT.TabIndex = 66;
            this.Invoice_DT.Text = "Invoice Date";
            // 
            // Invoice_No_lbl
            // 
            this.Invoice_No_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoice_No_lbl.AutoSize = true;
            this.Invoice_No_lbl.Location = new System.Drawing.Point(637, 240);
            this.Invoice_No_lbl.Name = "Invoice_No_lbl";
            this.Invoice_No_lbl.Size = new System.Drawing.Size(71, 16);
            this.Invoice_No_lbl.TabIndex = 67;
            this.Invoice_No_lbl.Text = "Invoice No";
            // 
            // Invoice_no_txt
            // 
            this.Invoice_no_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoice_no_txt.Location = new System.Drawing.Point(714, 240);
            this.Invoice_no_txt.Name = "Invoice_no_txt";
            this.Invoice_no_txt.Size = new System.Drawing.Size(123, 22);
            this.Invoice_no_txt.TabIndex = 68;
            // 
            // Address_txt
            // 
            this.Address_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_txt.Location = new System.Drawing.Point(714, 420);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(123, 22);
            this.Address_txt.TabIndex = 78;
            // 
            // Address_lbl
            // 
            this.Address_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Location = new System.Drawing.Point(635, 423);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(58, 16);
            this.Address_lbl.TabIndex = 77;
            this.Address_lbl.Text = "Address";
            // 
            // Email_txt
            // 
            this.Email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_txt.Location = new System.Drawing.Point(714, 386);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(123, 22);
            this.Email_txt.TabIndex = 76;
            // 
            // Email_lbl
            // 
            this.Email_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(635, 386);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(41, 16);
            this.Email_lbl.TabIndex = 75;
            this.Email_lbl.Text = "Email";
            // 
            // Phone_txt
            // 
            this.Phone_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone_txt.Location = new System.Drawing.Point(714, 347);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(123, 22);
            this.Phone_txt.TabIndex = 74;
            // 
            // Name_txt
            // 
            this.Name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_txt.Location = new System.Drawing.Point(714, 307);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(123, 22);
            this.Name_txt.TabIndex = 73;
            // 
            // id_txt
            // 
            this.id_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.id_txt.Location = new System.Drawing.Point(714, 270);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(123, 22);
            this.id_txt.TabIndex = 72;
            // 
            // ID_lbl
            // 
            this.ID_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(637, 273);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(20, 16);
            this.ID_lbl.TabIndex = 71;
            this.ID_lbl.Text = "ID";
            // 
            // Phone_lbl
            // 
            this.Phone_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone_lbl.AutoSize = true;
            this.Phone_lbl.Location = new System.Drawing.Point(635, 350);
            this.Phone_lbl.Name = "Phone_lbl";
            this.Phone_lbl.Size = new System.Drawing.Size(46, 16);
            this.Phone_lbl.TabIndex = 70;
            this.Phone_lbl.Text = "Phone";
            // 
            // Name_lbl
            // 
            this.Name_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(635, 313);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(44, 16);
            this.Name_lbl.TabIndex = 69;
            this.Name_lbl.Text = "Name";
            // 
            // Add_invoice_btn
            // 
            this.Add_invoice_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_invoice_btn.Location = new System.Drawing.Point(935, 379);
            this.Add_invoice_btn.Name = "Add_invoice_btn";
            this.Add_invoice_btn.Size = new System.Drawing.Size(138, 38);
            this.Add_invoice_btn.TabIndex = 79;
            this.Add_invoice_btn.Text = "Add Invoice";
            this.Add_invoice_btn.UseVisualStyleBackColor = true;
            this.Add_invoice_btn.Click += new System.EventHandler(this.Add_invoice_btn_Click);
            // 
            // View_Invoice_btn
            // 
            this.View_Invoice_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.View_Invoice_btn.Location = new System.Drawing.Point(935, 433);
            this.View_Invoice_btn.Name = "View_Invoice_btn";
            this.View_Invoice_btn.Size = new System.Drawing.Size(138, 38);
            this.View_Invoice_btn.TabIndex = 80;
            this.View_Invoice_btn.Text = "View Invoice";
            this.View_Invoice_btn.UseVisualStyleBackColor = true;
            this.View_Invoice_btn.Click += new System.EventHandler(this.View_Invoice_btn_Click);
            // 
            // Tot_amo_lbl
            // 
            this.Tot_amo_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Tot_amo_lbl.AutoSize = true;
            this.Tot_amo_lbl.Location = new System.Drawing.Point(68, 476);
            this.Tot_amo_lbl.Name = "Tot_amo_lbl";
            this.Tot_amo_lbl.Size = new System.Drawing.Size(92, 16);
            this.Tot_amo_lbl.TabIndex = 81;
            this.Tot_amo_lbl.Text = "Total Amount :";
            // 
            // Rs_lbl
            // 
            this.Rs_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rs_lbl.AutoSize = true;
            this.Rs_lbl.Location = new System.Drawing.Point(197, 475);
            this.Rs_lbl.Name = "Rs_lbl";
            this.Rs_lbl.Size = new System.Drawing.Size(27, 16);
            this.Rs_lbl.TabIndex = 82;
            this.Rs_lbl.Text = "Rs.";
            // 
            // TotalAmount_txt
            // 
            this.TotalAmount_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TotalAmount_txt.CustomButton.Image = null;
            this.TotalAmount_txt.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.TotalAmount_txt.CustomButton.Name = "";
            this.TotalAmount_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalAmount_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalAmount_txt.CustomButton.TabIndex = 1;
            this.TotalAmount_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalAmount_txt.CustomButton.UseSelectable = true;
            this.TotalAmount_txt.CustomButton.Visible = false;
            this.TotalAmount_txt.Lines = new string[] {
        "0.00"};
            this.TotalAmount_txt.Location = new System.Drawing.Point(254, 471);
            this.TotalAmount_txt.MaxLength = 32767;
            this.TotalAmount_txt.Name = "TotalAmount_txt";
            this.TotalAmount_txt.PasswordChar = '\0';
            this.TotalAmount_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalAmount_txt.SelectedText = "";
            this.TotalAmount_txt.SelectionLength = 0;
            this.TotalAmount_txt.SelectionStart = 0;
            this.TotalAmount_txt.ShortcutsEnabled = true;
            this.TotalAmount_txt.Size = new System.Drawing.Size(128, 23);
            this.TotalAmount_txt.TabIndex = 83;
            this.TotalAmount_txt.Text = "0.00";
            this.TotalAmount_txt.UseSelectable = true;
            this.TotalAmount_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalAmount_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Qty_lbl
            // 
            this.Qty_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Qty_lbl.AutoSize = true;
            this.Qty_lbl.Location = new System.Drawing.Point(635, 458);
            this.Qty_lbl.Name = "Qty_lbl";
            this.Qty_lbl.Size = new System.Drawing.Size(55, 16);
            this.Qty_lbl.TabIndex = 84;
            this.Qty_lbl.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QtyTb.Location = new System.Drawing.Point(714, 455);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(123, 22);
            this.QtyTb.TabIndex = 85;
            // 
            // Unit_Price_txt
            // 
            this.Unit_Price_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Unit_Price_txt.Location = new System.Drawing.Point(714, 490);
            this.Unit_Price_txt.Name = "Unit_Price_txt";
            this.Unit_Price_txt.Size = new System.Drawing.Size(123, 22);
            this.Unit_Price_txt.TabIndex = 87;
            // 
            // Unit_price_lbl
            // 
            this.Unit_price_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Unit_price_lbl.AutoSize = true;
            this.Unit_price_lbl.Location = new System.Drawing.Point(635, 490);
            this.Unit_price_lbl.Name = "Unit_price_lbl";
            this.Unit_price_lbl.Size = new System.Drawing.Size(64, 16);
            this.Unit_price_lbl.TabIndex = 86;
            this.Unit_price_lbl.Text = "Unit Price";
            // 
            // Product_Name_txt
            // 
            this.Product_Name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Product_Name_txt.Location = new System.Drawing.Point(951, 307);
            this.Product_Name_txt.Name = "Product_Name_txt";
            this.Product_Name_txt.Size = new System.Drawing.Size(123, 22);
            this.Product_Name_txt.TabIndex = 89;
            // 
            // Pro_lbl
            // 
            this.Pro_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pro_lbl.AutoSize = true;
            this.Pro_lbl.Location = new System.Drawing.Point(871, 313);
            this.Pro_lbl.Name = "Pro_lbl";
            this.Pro_lbl.Size = new System.Drawing.Size(53, 16);
            this.Pro_lbl.TabIndex = 88;
            this.Pro_lbl.Text = "Product";
            // 
            // Billing_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 527);
            this.Controls.Add(this.Product_Name_txt);
            this.Controls.Add(this.Pro_lbl);
            this.Controls.Add(this.Unit_Price_txt);
            this.Controls.Add(this.Unit_price_lbl);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.Qty_lbl);
            this.Controls.Add(this.TotalAmount_txt);
            this.Controls.Add(this.Rs_lbl);
            this.Controls.Add(this.Tot_amo_lbl);
            this.Controls.Add(this.View_Invoice_btn);
            this.Controls.Add(this.Add_invoice_btn);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.Phone_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Invoice_no_txt);
            this.Controls.Add(this.Invoice_No_lbl);
            this.Controls.Add(this.Invoice_DT);
            this.Controls.Add(this.Invoice_Date_View);
            this.Controls.Add(this.Quantity_Add_btn);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.Product_lbl);
            this.Controls.Add(this.CustomerGridview);
            this.Controls.Add(this.Customers_lbl);
            this.Controls.Add(this.InvoicesDGV);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.Quantity_lbl);
            this.Name = "Billing_Form";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.DataGridView InvoicesDGV;
        private System.Windows.Forms.Label Customers_lbl;
        private System.Windows.Forms.DataGridView CustomerGridview;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Label Product_lbl;
        private System.Windows.Forms.Button Quantity_Add_btn;
        private MetroFramework.Controls.MetroDateTime Invoice_Date_View;
        private System.Windows.Forms.Label Invoice_DT;
        private System.Windows.Forms.Label Invoice_No_lbl;
        private System.Windows.Forms.TextBox Invoice_no_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label Phone_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Button Add_invoice_btn;
        private System.Windows.Forms.Button View_Invoice_btn;
        private System.Windows.Forms.Label Tot_amo_lbl;
        private System.Windows.Forms.Label Rs_lbl;
        private MetroFramework.Controls.MetroTextBox TotalAmount_txt;
        private System.Windows.Forms.Label Qty_lbl;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.TextBox Unit_Price_txt;
        private System.Windows.Forms.Label Unit_price_lbl;
        private System.Windows.Forms.TextBox Product_Name_txt;
        private System.Windows.Forms.Label Pro_lbl;
    }
}