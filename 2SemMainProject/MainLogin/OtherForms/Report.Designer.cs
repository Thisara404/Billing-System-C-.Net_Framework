namespace _2SemMainProject.OtherForms
{
    partial class Report_Form
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
            this.Back_btn = new System.Windows.Forms.Button();
            this.ReportDGV = new System.Windows.Forms.DataGridView();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Report_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Back_btn.Location = new System.Drawing.Point(362, 407);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(137, 55);
            this.Back_btn.TabIndex = 53;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ReportDGV
            // 
            this.ReportDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportDGV.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDGV.Location = new System.Drawing.Point(108, 62);
            this.ReportDGV.Name = "ReportDGV";
            this.ReportDGV.RowHeadersWidth = 51;
            this.ReportDGV.RowTemplate.Height = 24;
            this.ReportDGV.Size = new System.Drawing.Size(927, 310);
            this.ReportDGV.TabIndex = 52;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_btn.Location = new System.Drawing.Point(656, 407);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(137, 55);
            this.Add_btn.TabIndex = 49;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Report_lbl
            // 
            this.Report_lbl.AutoSize = true;
            this.Report_lbl.Location = new System.Drawing.Point(105, 25);
            this.Report_lbl.Name = "Report_lbl";
            this.Report_lbl.Size = new System.Drawing.Size(48, 16);
            this.Report_lbl.TabIndex = 54;
            this.Report_lbl.Text = "Report";
            this.Report_lbl.Click += new System.EventHandler(this.Report_lbl_Click);
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 527);
            this.Controls.Add(this.Report_lbl);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.ReportDGV);
            this.Controls.Add(this.Add_btn);
            this.Name = "Report_Form";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.Category_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.DataGridView ReportDGV;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label Report_lbl;
    }
}