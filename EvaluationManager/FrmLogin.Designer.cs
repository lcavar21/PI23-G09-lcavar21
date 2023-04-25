namespace EvaluationManager
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.Form = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.Form.Location = new System.Drawing.Point(231, 92);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(250, 20);
            this.Form.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(320, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(75, 13);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Korisnicko ime";
            this.txtUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(335, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(44, 13);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Lozinka";
            this.txtPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(320, 222);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 371);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Form;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLogin;
    }
}

