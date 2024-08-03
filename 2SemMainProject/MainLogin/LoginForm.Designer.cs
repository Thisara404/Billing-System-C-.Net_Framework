namespace _2SemMainProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.UnTxt = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNamelbl
            // 
            resources.ApplyResources(this.UserNamelbl, "UserNamelbl");
            this.UserNamelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.UserNamelbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.UserNamelbl.Name = "UserNamelbl";
            // 
            // Passwordlbl
            // 
            resources.ApplyResources(this.Passwordlbl, "Passwordlbl");
            this.Passwordlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.Passwordlbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Passwordlbl.Name = "Passwordlbl";
            // 
            // UnTxt
            // 
            resources.ApplyResources(this.UnTxt, "UnTxt");
            this.UnTxt.Name = "UnTxt";
            this.UnTxt.TextChanged += new System.EventHandler(this.UnTxt_TextChanged);
            // 
            // pwdTxt
            // 
            resources.ApplyResources(this.pwdTxt, "pwdTxt");
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Login_btn, "Login_btn");
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Resetbtn, "Resetbtn");
            this.Resetbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Controls.Add(this.Resetbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pwdTxt);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.UserNamelbl);
            this.panel1.Controls.Add(this.Passwordlbl);
            this.panel1.Controls.Add(this.UnTxt);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox UnTxt;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}