namespace _2SemMainProject
{
    partial class POS_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_Form));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.Olinta_lbl = new System.Windows.Forms.Label();
            this.btnClose_ChildForm = new System.Windows.Forms.Button();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Report_btn = new System.Windows.Forms.Button();
            this.Item_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.Billing_Invoice_btn = new System.Windows.Forms.Button();
            this.Customer_btn = new System.Windows.Forms.Button();
            this.panelTitleBarBody = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.panelTitleBar.Controls.Add(this.Olinta_lbl);
            this.panelTitleBar.Controls.Add(this.btnClose_ChildForm);
            this.panelTitleBar.Controls.Add(this.lblHomeTitle);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // Olinta_lbl
            // 
            this.Olinta_lbl.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.Olinta_lbl, "Olinta_lbl");
            this.Olinta_lbl.Name = "Olinta_lbl";
            // 
            // btnClose_ChildForm
            // 
            resources.ApplyResources(this.btnClose_ChildForm, "btnClose_ChildForm");
            this.btnClose_ChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnClose_ChildForm.BackgroundImage = global::_2SemMainProject.Properties.Resources.icons8_cancel_48;
            this.btnClose_ChildForm.FlatAppearance.BorderSize = 0;
            this.btnClose_ChildForm.Name = "btnClose_ChildForm";
            this.btnClose_ChildForm.UseVisualStyleBackColor = false;
            this.btnClose_ChildForm.Click += new System.EventHandler(this.btnClose_ChildForm_Click);
            // 
            // lblHomeTitle
            // 
            resources.ApplyResources(this.lblHomeTitle, "lblHomeTitle");
            this.lblHomeTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHomeTitle.Name = "lblHomeTitle";
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panelMenu.Controls.Add(this.Report_btn);
            this.panelMenu.Controls.Add(this.Item_btn);
            this.panelMenu.Controls.Add(this.Logout_btn);
            this.panelMenu.Controls.Add(this.Dashboard_btn);
            this.panelMenu.Controls.Add(this.Billing_Invoice_btn);
            this.panelMenu.Controls.Add(this.Customer_btn);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // Report_btn
            // 
            this.Report_btn.Image = global::_2SemMainProject.Properties.Resources.icons8_order_501;
            resources.ApplyResources(this.Report_btn, "Report_btn");
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.UseVisualStyleBackColor = true;
            this.Report_btn.Click += new System.EventHandler(this.Category_btn_Click);
            // 
            // Item_btn
            // 
            resources.ApplyResources(this.Item_btn, "Item_btn");
            this.Item_btn.Image = global::_2SemMainProject.Properties.Resources.icons8_shop_32;
            this.Item_btn.Name = "Item_btn";
            this.Item_btn.UseVisualStyleBackColor = true;
            this.Item_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Logout_btn, "Logout_btn");
            this.Logout_btn.Image = global::_2SemMainProject.Properties.Resources.icons8_log_out_50;
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Image = global::_2SemMainProject.Properties.Resources.icons8_website_analytics_641;
            resources.ApplyResources(this.Dashboard_btn, "Dashboard_btn");
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // Billing_Invoice_btn
            // 
            this.Billing_Invoice_btn.Image = global::_2SemMainProject.Properties.Resources.icons8_billing_50;
            resources.ApplyResources(this.Billing_Invoice_btn, "Billing_Invoice_btn");
            this.Billing_Invoice_btn.Name = "Billing_Invoice_btn";
            this.Billing_Invoice_btn.UseVisualStyleBackColor = true;
            this.Billing_Invoice_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customer_btn
            // 
            this.Customer_btn.Image = global::_2SemMainProject.Properties.Resources.icons8_customer_501;
            resources.ApplyResources(this.Customer_btn, "Customer_btn");
            this.Customer_btn.Name = "Customer_btn";
            this.Customer_btn.UseVisualStyleBackColor = true;
            this.Customer_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelTitleBarBody
            // 
            resources.ApplyResources(this.panelTitleBarBody, "panelTitleBarBody");
            this.panelTitleBarBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.panelTitleBarBody.Name = "panelTitleBarBody";
            this.panelTitleBarBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBarBody_Paint);
            // 
            // POS_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelTitleBarBody);
            this.IsMdiContainer = true;
            this.Name = "POS_Form";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnClose_ChildForm;
        private System.Windows.Forms.Label Olinta_lbl;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Report_btn;
        private System.Windows.Forms.Button Item_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Button Billing_Invoice_btn;
        private System.Windows.Forms.Button Customer_btn;
        private System.Windows.Forms.Panel panelTitleBarBody;
    }
}

