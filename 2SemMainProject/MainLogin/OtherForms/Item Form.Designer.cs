namespace _2SemMainProject.OtherForms
{
    partial class Item_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Form));
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Pro_Name_lbl = new System.Windows.Forms.Label();
            this.Qty_lbl = new System.Windows.Forms.Label();
            this.Product_id_lbl = new System.Windows.Forms.Label();
            this.Product_id_txt = new System.Windows.Forms.TextBox();
            this.Product_Name_txt = new System.Windows.Forms.TextBox();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.dataGrid_Item = new System.Windows.Forms.DataGridView();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Category_lbl = new System.Windows.Forms.Label();
            this.Category_txt = new System.Windows.Forms.TextBox();
            this.Unit_Price_txt = new System.Windows.Forms.TextBox();
            this.Unit_price_lbl = new System.Windows.Forms.Label();
            this.ItemDetails_lbl = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset_btn
            // 
            this.Reset_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Reset_btn.Location = new System.Drawing.Point(790, 420);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(137, 55);
            this.Reset_btn.TabIndex = 1;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete_btn.Location = new System.Drawing.Point(935, 420);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(137, 55);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Pro_Name_lbl
            // 
            this.Pro_Name_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pro_Name_lbl.AutoSize = true;
            this.Pro_Name_lbl.Location = new System.Drawing.Point(31, 186);
            this.Pro_Name_lbl.Name = "Pro_Name_lbl";
            this.Pro_Name_lbl.Size = new System.Drawing.Size(93, 16);
            this.Pro_Name_lbl.TabIndex = 3;
            this.Pro_Name_lbl.Text = "Product Name";
            // 
            // Qty_lbl
            // 
            this.Qty_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Qty_lbl.AutoSize = true;
            this.Qty_lbl.Location = new System.Drawing.Point(31, 223);
            this.Qty_lbl.Name = "Qty_lbl";
            this.Qty_lbl.Size = new System.Drawing.Size(55, 16);
            this.Qty_lbl.TabIndex = 4;
            this.Qty_lbl.Text = "Quantity";
            // 
            // Product_id_lbl
            // 
            this.Product_id_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Product_id_lbl.AutoSize = true;
            this.Product_id_lbl.Location = new System.Drawing.Point(31, 143);
            this.Product_id_lbl.Name = "Product_id_lbl";
            this.Product_id_lbl.Size = new System.Drawing.Size(72, 16);
            this.Product_id_lbl.TabIndex = 5;
            this.Product_id_lbl.Text = "Product ID ";
            // 
            // Product_id_txt
            // 
            this.Product_id_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Product_id_txt.Location = new System.Drawing.Point(130, 143);
            this.Product_id_txt.Name = "Product_id_txt";
            this.Product_id_txt.Size = new System.Drawing.Size(300, 22);
            this.Product_id_txt.TabIndex = 6;
            // 
            // Product_Name_txt
            // 
            this.Product_Name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Product_Name_txt.Location = new System.Drawing.Point(130, 180);
            this.Product_Name_txt.Name = "Product_Name_txt";
            this.Product_Name_txt.Size = new System.Drawing.Size(300, 22);
            this.Product_Name_txt.TabIndex = 7;
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Quantity_txt.Location = new System.Drawing.Point(130, 220);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(300, 22);
            this.Quantity_txt.TabIndex = 8;
            // 
            // dataGrid_Item
            // 
            this.dataGrid_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Item.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Item.Location = new System.Drawing.Point(469, 76);
            this.dataGrid_Item.Name = "dataGrid_Item";
            this.dataGrid_Item.RowHeadersWidth = 51;
            this.dataGrid_Item.RowTemplate.Height = 24;
            this.dataGrid_Item.Size = new System.Drawing.Size(637, 310);
            this.dataGrid_Item.TabIndex = 12;
            this.dataGrid_Item.DoubleClick += new System.EventHandler(this.dataGrid_Item_DoubleClick);
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Update_btn.Location = new System.Drawing.Point(504, 420);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(137, 55);
            this.Update_btn.TabIndex = 14;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Category_lbl
            // 
            this.Category_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Category_lbl.AutoSize = true;
            this.Category_lbl.Location = new System.Drawing.Point(31, 259);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.Size = new System.Drawing.Size(62, 16);
            this.Category_lbl.TabIndex = 15;
            this.Category_lbl.Text = "Category";
            // 
            // Category_txt
            // 
            this.Category_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Category_txt.Location = new System.Drawing.Point(130, 259);
            this.Category_txt.Name = "Category_txt";
            this.Category_txt.Size = new System.Drawing.Size(300, 22);
            this.Category_txt.TabIndex = 16;
            // 
            // Unit_Price_txt
            // 
            this.Unit_Price_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Unit_Price_txt.Location = new System.Drawing.Point(130, 293);
            this.Unit_Price_txt.Name = "Unit_Price_txt";
            this.Unit_Price_txt.Size = new System.Drawing.Size(300, 22);
            this.Unit_Price_txt.TabIndex = 18;
            // 
            // Unit_price_lbl
            // 
            this.Unit_price_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Unit_price_lbl.AutoSize = true;
            this.Unit_price_lbl.Location = new System.Drawing.Point(31, 296);
            this.Unit_price_lbl.Name = "Unit_price_lbl";
            this.Unit_price_lbl.Size = new System.Drawing.Size(64, 16);
            this.Unit_price_lbl.TabIndex = 17;
            this.Unit_price_lbl.Text = "Unit Price";
            // 
            // ItemDetails_lbl
            // 
            this.ItemDetails_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDetails_lbl.AutoSize = true;
            this.ItemDetails_lbl.Location = new System.Drawing.Point(466, 38);
            this.ItemDetails_lbl.Name = "ItemDetails_lbl";
            this.ItemDetails_lbl.Size = new System.Drawing.Size(84, 16);
            this.ItemDetails_lbl.TabIndex = 19;
            this.ItemDetails_lbl.Text = "ITEM Details";
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_btn.Location = new System.Drawing.Point(647, 420);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(137, 55);
            this.Add_btn.TabIndex = 20;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 527);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.ItemDetails_lbl);
            this.Controls.Add(this.Unit_Price_txt);
            this.Controls.Add(this.Unit_price_lbl);
            this.Controls.Add(this.Category_txt);
            this.Controls.Add(this.Category_lbl);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.dataGrid_Item);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.Product_Name_txt);
            this.Controls.Add(this.Product_id_txt);
            this.Controls.Add(this.Product_id_lbl);
            this.Controls.Add(this.Qty_lbl);
            this.Controls.Add(this.Pro_Name_lbl);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Reset_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ITEMS";
            this.Load += new System.EventHandler(this.Item_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label Pro_Name_lbl;
        private System.Windows.Forms.Label Qty_lbl;
        private System.Windows.Forms.Label Product_id_lbl;
        private System.Windows.Forms.TextBox Product_id_txt;
        private System.Windows.Forms.TextBox Product_Name_txt;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.DataGridView dataGrid_Item;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label Category_lbl;
        private System.Windows.Forms.TextBox Category_txt;
        private System.Windows.Forms.TextBox Unit_Price_txt;
        private System.Windows.Forms.Label Unit_price_lbl;
        private System.Windows.Forms.Label ItemDetails_lbl;
        private System.Windows.Forms.Button Add_btn;
    }
}